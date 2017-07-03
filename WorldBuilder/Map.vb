Public Class Map
    Private Seed As Long
    Private Width As Integer = 1024
    Private Height As Integer = 1024

    Private ArcticRadius As Double = 0.25
    Private TropicZone As Double = 0.25
    Private MountainFreq As Double = 0.0
    Private ForestFreq As Double = 0.0
    Private GrasslandFreq As Double = 0.45
    Private DesertFreq As Double = 0.0
    Private SwampFreq As Double = 0.0
    Private RiverFreq As Double = 0.0
    Private LakeFreq As Double = 0.0

    Private MapMatrix As Double(,)
    Private Map As FrmMain.TileType(,)

    Public Sub New(sd As Long, wt As Integer, ht As Integer, ar As Double, tz As Double, mf As Double, ff As Double, glf As Double, df As Double, sf As Double, rf As Double, lf As Double)
        SetSeed(sd)
        SetWidth(wt)
        SetHeight(ht)
        SetArcticRadius(ar)
        SetTropicZone(tz)
        SetMountainFreq(mf)
        SetForestFreq(ff)
        SetGrasslandFreq(glf)
        SetDesertFreq(df)
        SetSwampFreq(sf)
        SetRiverFreq(rf)
        SetLakeFreq(lf)

        MapMatrix = New Double(Height - 1, Width - 1) {}

    End Sub

    Public Sub GenerateMap()
        GeneratePerlinMatrix()
        CreateMapFromMatrix()
    End Sub

    Public Sub CreateMapFromMatrix()
        Map = New FrmMain.TileType(Width - 1, Height - 1) {}
    End Sub

    Public Sub GeneratePerlinMatrix()
        MapMatrix = New Double(Width - 1, Height - 1) {}
    End Sub

    '---SETTER METHODS---'
    Public Sub SetSeed(value As Long)
        Seed = value
    End Sub

    Public Sub SetWidth(value As Integer)
        If value > 0 Then
            Width = value
        End If
    End Sub

    Public Sub SetHeight(value As Integer)
        If value > 0 Then
            Height = value
        End If
    End Sub

    Public Sub SetArcticRadius(value As Integer)
        If value > 0 And value <= 1 Then
            ArcticRadius = value
        End If
    End Sub

    Public Sub SetTropicZone(value As Integer)
        If value > 0 And value <= 1 Then
            TropicZone = value
        End If
    End Sub

    Public Sub SetMountainFreq(value As Integer)
        If value > 0 And value <= 1 Then
            MountainFreq = value
        End If
    End Sub

    Public Sub SetForestFreq(value As Integer)
        If value > 0 And value <= 1 Then
            ForestFreq = value
        End If
    End Sub

    Public Sub SetGrasslandFreq(value As Integer)
        If value > 0 And value <= 1 Then
            GrasslandFreq = value
        End If
    End Sub

    Public Sub SetDesertFreq(value As Integer)
        If value > 0 And value <= 1 Then
            DesertFreq = value
        End If
    End Sub

    Public Sub SetSwampFreq(value As Integer)
        If value > 0 And value <= 1 Then
            SwampFreq = value
        End If
    End Sub

    Public Sub SetRiverFreq(value As Integer)
        If value > 0 And value <= 1 Then
            RiverFreq = value
        End If
    End Sub

    Public Sub SetLakeFreq(value As Integer)
        If value > 0 And value <= 1 Then
            LakeFreq = value
        End If
    End Sub

    '---GETTER METHODS---'
    Public ReadOnly Property GetSeed() As Long
        Get
            Return Seed
        End Get
    End Property

    Public ReadOnly Property GetWidth() As Integer
        Get
            Return Width
        End Get
    End Property

    Public ReadOnly Property GetHeight() As Integer
        Get
            Return Height
        End Get
    End Property

    Public ReadOnly Property GetArcticRadius() As Double
        Get
            Return ArcticRadius
        End Get
    End Property

    Public ReadOnly Property GetTropicZone() As Double
        Get
            Return TropicZone
        End Get
    End Property

    Public ReadOnly Property GetMountainFreq() As Double
        Get
            Return MountainFreq
        End Get
    End Property

    Public ReadOnly Property GetForestFreq() As Double
        Get
            Return ForestFreq
        End Get
    End Property

    Public ReadOnly Property GetGrasslandFreq() As Double
        Get
            Return GrasslandFreq
        End Get
    End Property

    Public ReadOnly Property GetDesertFreq() As Double
        Get
            Return DesertFreq
        End Get
    End Property

    Public ReadOnly Property GetSwampFreq() As Double
        Get
            Return SwampFreq
        End Get
    End Property

    Public ReadOnly Property GetRiverFreq() As Double
        Get
            Return RiverFreq
        End Get
    End Property

    Public ReadOnly Property GetLakeFreq() As Double
        Get
            Return LakeFreq
        End Get
    End Property

    Public ReadOnly Property GetMapMatrix As Double(,)
        Get
            Return MapMatrix
        End Get
    End Property

    Public ReadOnly Property GetMap As FrmMain.TileType(,)
        Get
            Return Map
        End Get
    End Property


End Class
