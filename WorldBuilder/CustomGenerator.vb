Public Class CustomGenerator
    Private Seed As Integer
    Private Width As Integer, Height As Integer
    Private Min As Double, Max As Double
    Private InitSquareCount As Integer, Layers As Integer
    Private rnd As Random

    Private Matrix As Double(,)

    Public Sub New(Seed As Integer, Width As Integer, Height As Integer, Min As Double, Max As Double, InitSquareCount As Integer, Layers As Integer)
        'CHECK FOR INVALID PARAMETER INPUTS
        If Width < 32 Or Height < 32 Then
            Throw New System.ArgumentException("Both Width and Height values must be greater than 16")
        End If
        If Width <> Height Or Math.Log(Width, 2) <> Math.Floor(Math.Log(Width, 2)) Then
            Throw New System.ArgumentException("Both Width and Height must be a power of 2 and equal to each other")
        End If
        If Max <= Min Then
            Throw New System.ArgumentException("Max cannot be less than or qual to Min")
        End If
        If InitSquareCount < 1 Then
            Throw New System.ArgumentException("StartingSquareCount Must be greater than 0")
        End If
        If Layers < 1 Then
            Throw New System.ArgumentException("Depth must be greater than 0")
        End If
        'Makes sure that square count is a power of two, i.e. equal vertical squares as horizontal squares
        If Math.Sqrt(InitSquareCount) Mod 1 <> 0 Then
            InitSquareCount = Math.Pow(Math.Floor(Math.Sqrt(InitSquareCount)), 2)
        End If
        'Makes sure that square count resolution never exceeds map size resulotion
        If Math.Sqrt(InitSquareCount) * Math.Pow(2, Layers - 1) > Math.Max(Width, Height) Then
            Throw New System.ArgumentException("Width/Height is not big enough to support given SquareCount and Depth. For the Deepest Depth there must be at minimum 4 tiles per square.\nEither make width/height larger, StartingSquareCount smaller, reduce # layers")
        End If

        Me.Seed = Seed
        Me.Width = Width
        Me.Height = Height
        Me.Min = Min
        Me.Max = Max
        Me.InitSquareCount = InitSquareCount
        Me.Layers = Layers

        rnd = New Random(CInt(Seed))

        Matrix = New Double(Width - 1, Height - 1) {}
    End Sub

    Public Function GenerateMatrix() As Double(,)
        'DECLARE VARIABLES
        Dim Length As Integer 'The larger of wt/ht to make a square matrix 'Only applies if given dimentions are not a square
        Dim Squares, TileWidth
        Dim InitSquaresPerSide As Integer 'The number of squares on the first layer
        Dim FinalSquaresPerSide As Integer 'The number of squares on the final layer
        Dim Matrices As Double()(,)

        'INITIALIZE VARIABLES
        Length = Math.Max(Width, Height)
        InitSquaresPerSide = Math.Sqrt(InitSquareCount)
        FinalSquaresPerSide = InitSquaresPerSide * Math.Pow(2, Layers - 1)
        Matrices = New Double(Layers - 1)(,) {}
        Matrix = New Double(Length - 1, Length - 1) {}


        For layer = 0 To Layers - 1
            'DECLERATIONS
            Dim oldSquares
            Dim oldTileWidth

            'INITIALIZATIONS
            Squares = InitSquaresPerSide * Math.Pow(2, layer)
            TileWidth = Math.Floor((Length) / (Squares))
            oldSquares = InitSquaresPerSide * Math.Pow(2, layer - 1)
            oldTileWidth = Math.Floor((Length) / (oldSquares))
            Matrices(layer) = New Double(Length - 1, Length - 1) {}

            For x = 0 To Squares
                For y = 0 To Squares
                    'DECLERATIONS
                    Dim PosX, oldPosX
                    Dim PosY, oldPosY
                    Dim RelX As Double, RelY As Double
                    Dim Value As Double
                    Dim A, B, C, D, AB, CD

                    'INITIALIZATIONS
                    PosX = x * TileWidth
                    PosY = y * TileWidth
                    oldPosX = Math.Floor(x / 2) * (oldTileWidth)
                    oldPosY = Math.Floor(y / 2) * (oldTileWidth)
                    RelX = CDbl(PosX - oldPosX) / CDbl(oldTileWidth)
                    RelY = CDbl(PosY - oldPosY) / CDbl(oldTileWidth)

                    'Keep Pos indicators from exceeding bounds
                    If PosX = Length Then
                        PosX = Length - 1
                    End If
                    If PosY = Length Then
                        PosY = Length - 1
                    End If
                    If oldPosX = Length Then
                        oldPosX = Length - 1
                    End If
                    If oldPosY = Length Then
                        oldPosY = Length - 1
                    End If


                    'FIRST OUTER LOOP ITERATION
                    'Set initial randomizing values
                    If layer = 0 Then
                        Value = rnd.NextDouble()
                        Matrices(layer)(PosX, PosY) = Value
                        Continue For
                    End If

                    'ALL OTHER ITERATIONS
                    'Put old value into new array if it already exists
                    If oldPosX = PosX And oldPosY = PosY Then
                        Value = Matrices(layer - 1)(oldPosX, oldPosY)
                        Matrices(layer)(oldPosX, oldPosY) = Value
                        Continue For
                    End If
                    If Math.Floor(oldPosX) = PosX Then
                        A = Matrices(layer - 1)(oldPosX, (oldPosY))
                        C = Matrices(layer - 1)(oldPosX, Math.Min(oldPosY + oldTileWidth, Length - 1))
                        Value = A + (1 - RelY) * (C - A)
                        Value = Value + ((C - A) / 2 * (rnd.NextDouble() * 2 - 1))
                        Matrices(layer)(PosX, PosY) = Value
                    ElseIf Math.Floor(oldPosY) = PosY Then
                        A = Matrices(layer - 1)(oldPosX, (oldPosY))
                        B = Matrices(layer - 1)(Math.Min(oldPosX + oldTileWidth, Length - 1), oldPosY)
                        Value = A + (1 - RelX) * (B - A)
                        Value = Value + ((B - A) / 2 * (rnd.NextDouble() * 2 - 1))
                        Matrices(layer)(PosX, PosY) = Value
                    ElseIf Math.Floor(oldPosX) <> PosX And Math.Floor(OldPosY) <> PosY Then
                        A = Matrices(layer - 1)(oldPosX, (oldPosY))
                        B = Matrices(layer - 1)(Math.Min(oldPosX + oldTileWidth, Length - 1), oldPosY)
                        C = Matrices(layer - 1)(oldPosX, Math.Min(oldPosY + oldTileWidth, Length - 1))
                        D = Matrices(layer - 1)(Math.Min(oldPosX + oldTileWidth, Length - 1), Math.Min(oldPosY + oldTileWidth, Length - 1))
                        AB = A + (1 - RelX) * (B - A)
                        CD = C + (1 - RelX) * (D - C)
                        Value = AB + (1 - RelY) * (CD - AB)
                        Matrices(layer)(PosX, PosY) = Value
                    End If

                Next
            Next
        Next

        Squares = InitSquaresPerSide * Math.Pow(2, Layers - 1)
        TileWidth = Math.Floor((Length) / (Squares))
        For x = 0 To Length - 1
            For y = 0 To Length - 1
                'DECLERATIONS
                Dim PosX
                Dim PosY
                Dim RelX As Double, RelY As Double
                Dim Value As Double
                Dim A, B, C, D, AB, CD
                Dim Ax, Ay, nextAx, nextAy

                'INITIALIZATIONS
                PosX = x / TileWidth
                PosY = y / TileWidth
                Ax = Math.Floor(PosX) * TileWidth
                Ay = Math.Floor(PosY) * TileWidth
                nextAy = Ay + TileWidth
                nextAx = Ax + TileWidth

                If x = Length - 1 Then
                    Ax = PosX * TileWidth
                End If
                If y = Length - 1 Then
                    Ay = PosY * TileWidth
                End If
                If nextAx >= Length Then
                    nextAx = Length - 1
                End If
                If nextAy >= Length Then
                    nextAy = Length - 1
                End If


                RelX = CDbl(x - Ax) / CDbl(TileWidth)
                RelY = CDbl(y - Ay) / CDbl(TileWidth)


                'SKIP TO NEXT ITERATION IF TILE ALREADY FILLED
                If (Matrices(Layers - 1)(x, y) <> 0) Then
                    Continue For
                End If

                'Interpolate Tile from vertical filled tiles (from the top / bottom)
                If Ax = x Then

                    A = Matrices(Layers - 1)(Ax, Ay)
                    C = Matrices(Layers - 1)(Ax, nextAy)
                    Value = A + RelY * (C - A)
                    Matrices(Layers - 1)(x, y) = Value
                ElseIf Ay = y Then 'Interpolate Tile from horizontal parents (from the right / left)
                    A = Matrices(Layers - 1)(Ax, Ay)
                    B = Matrices(Layers - 1)(nextAx, Ay)
                    Value = A + RelX * (B - A)
                    Matrices(Layers - 1)(x, y) = Value
                Else
                    A = Matrices(Layers - 1)(Ax, Ay)
                    B = Matrices(Layers - 1)(nextAx, Ay)
                    C = Matrices(Layers - 1)(Ax, nextAy)
                    D = Matrices(Layers - 1)(nextAx, nextAy)
                    AB = A + RelX * (B - A)
                    CD = C + RelX * (D - C)
                    Value = AB + RelY * (CD - AB)
                    Matrices(Layers - 1)(x, y) = Value
                End If



            Next
        Next
        Return Matrices(Layers - 1)
    End Function

    Public ReadOnly Property GetMatrix() As Double(,)
        Get
            Return Matrix
        End Get
    End Property


End Class
