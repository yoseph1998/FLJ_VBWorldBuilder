Public Class PerlinGenerator
    Private Seed As Long
    Private Width As Integer, Height As Integer
    Private Min As Double, Max As Double
    Private InitSquareCount As Integer, Layers As Integer

    Private PerlinMatrix As Double(,)

    Public Sub New(Seed As Long, Width As Integer, Height As Integer, Min As Double, Max As Double, InitSquareCount As Integer, Layers As Integer)
        'CHECK FOR INVALID PARAMETER INPUTS
        If Width < 16 Or Height < 16 Then
            Throw New System.ArgumentException("Both Width and Height values must be greater than 16")
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
            InitSquareCount = Math.Pow(Math.Ceiling(Math.Sqrt(InitSquareCount)), 2)
        End If
        'Makes sure that square count resolution never exceeds map size resulotion
        If Math.Max(Width, Height) / Math.Sqrt(InitSquareCount) * Math.Pow(2, Layers - 1) < 4 Then
            Throw New System.ArgumentException("Width/Height is not big enough to support given SquareCount and Depth. For the Deepest Depth there must be at minimum 4 tiles per square.\nEither make width/height larger, StartingSquareCount smaller, reduce # layers")
        End If

        Me.Seed = Seed
        Me.Width = Width
        Me.Height = Height
        Me.Min = Min
        Me.Max = Max
        Me.InitSquareCount = InitSquareCount
        Me.Layers = Layers

        PerlinMatrix = New Double(Width - 1, Height - 1) {}
    End Sub

    Public Function GenerateMatrix() As Double(,)
        'DECLARE VARIABLES
        Dim Length 'The larger of the width/height to make a square matrix 'Only applies if given dimentions are not a square
        Dim InitSquaresPerSide As Integer 'The number of squares on the first layer
        Dim FinalSquaresPerSide As Integer 'The number of squares on the final layer
        Dim Matrices As Double()(,) 'The matrix for every individual layer
        Dim RandMatrix As Double(,)
        Dim VectorsTable As Vector() 'List of all possible Vectors to choose from for VectorsGrid
        Dim VectorsGrid As Vector(,) 'Grid full of vectors to use in creating the matrix


        'INITIALIZE VARIABLES
        Length = Math.Max(Width, Height)
        InitSquaresPerSide = Math.Sqrt(InitSquareCount)
        FinalSquaresPerSide = InitSquaresPerSide * Math.Pow(2, Layers - 1)
        Matrices = New Double(Layers - 1)(,) {}
        RandMatrix = New Double(Length - 1, Length - 1) {}
        VectorsTable = New Vector(3) {New Vector(1, 1), New Vector(-1, 1), New Vector(-1, -1), New Vector(1, -1)}
        VectorsGrid = New Vector(FinalSquaresPerSide - 1, FinalSquaresPerSide - 1) {}

        'FILL VECTOR GRIDS
        For x = 0 To FinalSquaresPerSide - 1
            For y = 0 To FinalSquaresPerSide - 1
                Dim index = CInt(Rnd() * (VectorsTable.GetLength(0) - 1))
                Dim val = VectorsTable(index)
                VectorsGrid(x, y) = val 'Use Vector Table
                'VectorsGrid(x, y) = New Vector(Rnd() * 2 - 1, Rnd() * 2 - 1) 'Use Random Vectors
                RandMatrix(x, y) = Rnd()
            Next
        Next

        For layer = 0 To Layers - 1
            Dim SquareSideLength = CInt(Length / InitSquaresPerSide * Math.Pow(2, layer))
            Matrices(layer) = New Double(Width, Height) {}
            For x = 0 To Width - 1
                For y = 0 To Height - 1
                    'DECLERATION
                    Dim DecX, DecY 'Decimal coordinate each unit is one square length
                    Dim RelX, RelY 'Relative to the top left of the current Square
                    Dim VecA, VecB, VecC, VecD 'A is top left 'B is top right 'C is bottom left 'D is bottom right
                    Dim DotA, DotB, DotC, DotD
                    Dim AB, CD, Value ' The values of the interpolation process AB being between DotA and DotB and so forth
                    Dim FracM As Double 'The fraction to interpolate in adding current value to resultant Matrix

                    'CALCULATING POINT VALUE
                    DecX = CDbl(x) / CDbl(SquareSideLength)
                    DecY = CDbl(y) / CDbl(SquareSideLength)
                    RelX = DecX - Math.Floor(DecX)
                    RelY = DecY - Math.Floor(DecY)

                    VecA = New Vector(RelX, -RelY)
                    VecB = New Vector(RelX - 1, -RelY)
                    VecC = New Vector(RelX, 1 - RelY)
                    VecD = New Vector(RelX - 1, 1 - RelY)

                    DotA = VecA.Dot(VectorsGrid(DecX, DecY))
                    DotA /= 2
                    DotB = VecA.Dot(VectorsGrid(DecX + 1, DecY))
                    DotB /= 2
                    DotC = VecA.Dot(VectorsGrid(DecX, DecY + 1))
                    DotC /= 2
                    DotD = VecA.Dot(VectorsGrid(DecX + 1, DecY + 1))
                    DotD /= 2

                    AB = DotA + Math.Sin(Math.PI / 2 * RelX) * (DotB - DotA)
                    CD = DotC + Math.Sin(Math.PI / 2 * RelX) * (DotD - DotC)
                    Value = AB + Math.Sin(Math.PI / 2 * RelY) * (CD - AB)
                    Value = (Value + 1) / 2 'Move range from being +-1 to 0-1

                    'ADDING POINT VALUE TO MATRIX/MATRICES
                    Matrices(layer)(x, y) = Value

                    FracM = 1 - (CDbl(layer) / CDbl(Layers - 1))
                    PerlinMatrix(x, y) = PerlinMatrix(x, y) + FracM * (Value - PerlinMatrix(x, y))
                Next
            Next
        Next
        Return PerlinMatrix
    End Function

    Public ReadOnly Property GetMatrix() As Double(,)
        Get
            Return PerlinMatrix
        End Get
    End Property


End Class
