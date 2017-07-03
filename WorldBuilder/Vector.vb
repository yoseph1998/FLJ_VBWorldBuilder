Public Class Vector
    Private x As Double
    Private y As Double
    Private magnitude As Double
    Private angle As Double

    Public Sub New()
        SetX(0)
        SetY(0)
    End Sub

    Public Sub New(x As Double, y As Double)
        SetX(x)
        SetY(y)
    End Sub

    Public Function Dot(vector As Vector) As Double
        Return (vector.GetX() * x + vector.GetY() * y)
    End Function

    Public Sub ComputeMagnitude()
        magnitude = Math.Pow(x, 2) + Math.Pow(y, 2)
        magnitude = Math.Sqrt(magnitude)
    End Sub

    Public Sub ComputeAngle()
        Dim angle = Math.Atan2(y, x)

        If x <= 0 And y > 0 Then 'Second
            angle = Math.PI - Math.Abs(angle)
        ElseIf x < 0 And y < 0 Then 'Third
            angle = Math.PI + angle
        ElseIf x >= 0 And y < 0 Then 'Fourth
            angle = 2 * Math.PI - Math.Abs(angle)
        End If
        Me.angle = angle
    End Sub

    Public Sub SetX(x As Double)
        Me.x = x
        ComputeMagnitude()
        ComputeAngle()
    End Sub

    Public Sub SetY(y As Double)
        Me.y = y
        ComputeMagnitude()
        ComputeAngle()
    End Sub

    Public ReadOnly Property getAngle() As Double
        Get
            Return angle
        End Get
    End Property

    Public ReadOnly Property getAngleAsDeg() As Double
        Get
            Return CDbl(angle / Math.PI * 180)
        End Get
    End Property

    Public ReadOnly Property getMagnitude() As Double
        Get
            Return magnitude
        End Get
    End Property

    Public ReadOnly Property GetX() As Double
        Get
            Return x
        End Get
    End Property

    Public ReadOnly Property GetY() As Double
        Get
            Return y
        End Get
    End Property

End Class
