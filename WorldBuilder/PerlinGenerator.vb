Public Class PerlinGenerator
    Private Width As Integer, Height As Integer
    Private Min As Double, Max As Double
    Private StartingSquareCount As Integer, Layers As Integer

    Private PerlinMatrix As Double(,)

    Public Sub New(Width As Integer, Height As Integer, Min As Double, Max As Double, StartingSquareCount As Integer, Layers As Integer)
        If Width < 16 Or Height < 16 Then
            Throw New System.ArgumentException("Both Width and Height values must be greater than 16")
        End If
        If Max >= Min Then
            Throw New System.ArgumentException("Max cannot be less than or qual to Min")
        End If
        If StartingSquareCount < 1 Then
            Throw New System.ArgumentException("StartingSquareCount Must be greater than 0")
        End If
        If Layers < 1 Then
            Throw New System.ArgumentException("Depth must be greater than 0")
        End If
        'Makes sure that square count is a power of two, i.e. equal vertical squares as horizontal squares
        If Math.Sqrt(StartingSquareCount) Mod 1 <> 0 Then
            StartingSquareCount = Math.Pow(Math.Ceiling(Math.Sqrt(StartingSquareCount)), 2)
        End If
        'Makes sure that square count resolution never exceeds map size resulotion
        If Math.Max(Width, Height) / Math.Sqrt(StartingSquareCount) * Layers < 4 Then
            Throw New System.ArgumentException("Width/Height is not big enough to support given SquareCount and Depth. For the Deepest Depth there must be at minimum 4 tiles per square.\nEither make width/height larger, StartingSquareCount smaller, reduce # layers")
        End If

        Me.Width = Width
        Me.Height = Height
        Me.Min = Min
        Me.Max = Max
        Me.StartingSquareCount = StartingSquareCount
        Me.Layers = Layers

        PerlinMatrix = New Double(Width, Height) {}
    End Sub



End Class
