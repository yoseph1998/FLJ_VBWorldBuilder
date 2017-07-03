<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtTextView = New System.Windows.Forms.TextBox()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.NumTilesX = New System.Windows.Forms.NumericUpDown()
        Me.NumTilesY = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumForest = New System.Windows.Forms.NumericUpDown()
        Me.NumMountain = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumDesert = New System.Windows.Forms.NumericUpDown()
        Me.NumGrassland = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumRivers = New System.Windows.Forms.NumericUpDown()
        Me.NumSwamp = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumLakes = New System.Windows.Forms.NumericUpDown()
        Me.BtnRandomize = New System.Windows.Forms.Button()
        Me.PicReference = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.ChkShowText = New System.Windows.Forms.CheckBox()
        Me.PgsText = New System.Windows.Forms.ProgressBar()
        CType(Me.NumTilesX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTilesY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumForest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMountain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDesert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumGrassland, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRivers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSwamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumLakes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicReference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTextView
        '
        Me.TxtTextView.Location = New System.Drawing.Point(25, 22)
        Me.TxtTextView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtTextView.MaxLength = 2147481599
        Me.TxtTextView.Multiline = True
        Me.TxtTextView.Name = "TxtTextView"
        Me.TxtTextView.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtTextView.Size = New System.Drawing.Size(814, 300)
        Me.TxtTextView.TabIndex = 0
        Me.TxtTextView.WordWrap = False
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(1032, 447)
        Me.BtnGenerate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(182, 70)
        Me.BtnGenerate.TabIndex = 1
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'NumTilesX
        '
        Me.NumTilesX.Location = New System.Drawing.Point(160, 347)
        Me.NumTilesX.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumTilesX.Maximum = New Decimal(New Integer() {4096, 0, 0, 0})
        Me.NumTilesX.Name = "NumTilesX"
        Me.NumTilesX.Size = New System.Drawing.Size(147, 31)
        Me.NumTilesX.TabIndex = 2
        Me.NumTilesX.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'NumTilesY
        '
        Me.NumTilesY.Location = New System.Drawing.Point(160, 384)
        Me.NumTilesY.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumTilesY.Maximum = New Decimal(New Integer() {4096, 0, 0, 0})
        Me.NumTilesY.Name = "NumTilesY"
        Me.NumTilesY.Size = New System.Drawing.Size(147, 31)
        Me.NumTilesY.TabIndex = 3
        Me.NumTilesY.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 350)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TilesX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 387)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TilesY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 382)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Forest %"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 345)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mountain %"
        '
        'NumForest
        '
        Me.NumForest.Location = New System.Drawing.Point(470, 379)
        Me.NumForest.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumForest.Name = "NumForest"
        Me.NumForest.Size = New System.Drawing.Size(147, 31)
        Me.NumForest.TabIndex = 7
        '
        'NumMountain
        '
        Me.NumMountain.Location = New System.Drawing.Point(470, 342)
        Me.NumMountain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumMountain.Name = "NumMountain"
        Me.NumMountain.Size = New System.Drawing.Size(147, 31)
        Me.NumMountain.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(330, 456)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Desert %"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 420)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Grassland %"
        '
        'NumDesert
        '
        Me.NumDesert.Location = New System.Drawing.Point(470, 454)
        Me.NumDesert.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumDesert.Name = "NumDesert"
        Me.NumDesert.Size = New System.Drawing.Size(147, 31)
        Me.NumDesert.TabIndex = 11
        '
        'NumGrassland
        '
        Me.NumGrassland.Location = New System.Drawing.Point(470, 417)
        Me.NumGrassland.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumGrassland.Name = "NumGrassland"
        Me.NumGrassland.Size = New System.Drawing.Size(147, 31)
        Me.NumGrassland.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(657, 344)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Rivers"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(330, 494)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Swamp %"
        '
        'NumRivers
        '
        Me.NumRivers.Location = New System.Drawing.Point(860, 339)
        Me.NumRivers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumRivers.Name = "NumRivers"
        Me.NumRivers.Size = New System.Drawing.Size(147, 31)
        Me.NumRivers.TabIndex = 15
        '
        'NumSwamp
        '
        Me.NumSwamp.Location = New System.Drawing.Point(470, 492)
        Me.NumSwamp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumSwamp.Name = "NumSwamp"
        Me.NumSwamp.Size = New System.Drawing.Size(147, 31)
        Me.NumSwamp.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(657, 381)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Lakes"
        '
        'NumLakes
        '
        Me.NumLakes.Location = New System.Drawing.Point(860, 376)
        Me.NumLakes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumLakes.Name = "NumLakes"
        Me.NumLakes.Size = New System.Drawing.Size(147, 31)
        Me.NumLakes.TabIndex = 18
        '
        'BtnRandomize
        '
        Me.BtnRandomize.Location = New System.Drawing.Point(160, 447)
        Me.BtnRandomize.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnRandomize.Name = "BtnRandomize"
        Me.BtnRandomize.Size = New System.Drawing.Size(147, 70)
        Me.BtnRandomize.TabIndex = 22
        Me.BtnRandomize.Text = "Randomize"
        Me.BtnRandomize.UseVisualStyleBackColor = True
        '
        'PicReference
        '
        Me.PicReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicReference.Location = New System.Drawing.Point(867, 22)
        Me.PicReference.Name = "PicReference"
        Me.PicReference.Size = New System.Drawing.Size(300, 300)
        Me.PicReference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicReference.TabIndex = 23
        Me.PicReference.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(657, 475)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 23)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Tropic Zone %"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(860, 470)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(147, 31)
        Me.NumericUpDown1.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(657, 438)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 23)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Arctid Radius %"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(860, 433)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(147, 31)
        Me.NumericUpDown2.TabIndex = 24
        '
        'ChkShowText
        '
        Me.ChkShowText.AutoSize = True
        Me.ChkShowText.Checked = True
        Me.ChkShowText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkShowText.Location = New System.Drawing.Point(25, 454)
        Me.ChkShowText.Name = "ChkShowText"
        Me.ChkShowText.Size = New System.Drawing.Size(124, 27)
        Me.ChkShowText.TabIndex = 28
        Me.ChkShowText.Text = "ShowText"
        Me.ChkShowText.UseVisualStyleBackColor = True
        '
        'PgsText
        '
        Me.PgsText.BackColor = System.Drawing.Color.Red
        Me.PgsText.ForeColor = System.Drawing.Color.Gold
        Me.PgsText.Location = New System.Drawing.Point(58, 112)
        Me.PgsText.Name = "PgsText"
        Me.PgsText.Size = New System.Drawing.Size(732, 68)
        Me.PgsText.TabIndex = 29
        Me.PgsText.Visible = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 542)
        Me.Controls.Add(Me.PgsText)
        Me.Controls.Add(Me.ChkShowText)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.PicReference)
        Me.Controls.Add(Me.BtnRandomize)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumLakes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumRivers)
        Me.Controls.Add(Me.NumSwamp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumDesert)
        Me.Controls.Add(Me.NumGrassland)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumForest)
        Me.Controls.Add(Me.NumMountain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumTilesY)
        Me.Controls.Add(Me.NumTilesX)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.TxtTextView)
        Me.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmMain"
        Me.Text = "World Builder"
        CType(Me.NumTilesX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTilesY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumForest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMountain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDesert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumGrassland, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRivers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSwamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumLakes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicReference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTextView As TextBox
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents NumTilesX As NumericUpDown
    Friend WithEvents NumTilesY As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumForest As NumericUpDown
    Friend WithEvents NumMountain As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumDesert As NumericUpDown
    Friend WithEvents NumGrassland As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumRivers As NumericUpDown
    Friend WithEvents NumSwamp As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents NumLakes As NumericUpDown
    Friend WithEvents BtnRandomize As Button
    Friend WithEvents PicReference As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents ChkShowText As CheckBox
    Friend WithEvents PgsText As ProgressBar
End Class
