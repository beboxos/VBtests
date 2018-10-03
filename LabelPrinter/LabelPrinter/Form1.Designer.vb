<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCE = New System.Windows.Forms.CheckBox()
        Me.TBref4 = New System.Windows.Forms.TextBox()
        Me.TBref3 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TBSerie = New System.Windows.Forms.TextBox()
        Me.TBPoids = New System.Windows.Forms.TextBox()
        Me.TBpays = New System.Windows.Forms.TextBox()
        Me.TBcodeBarre = New System.Windows.Forms.TextBox()
        Me.TBRef2 = New System.Windows.Forms.TextBox()
        Me.TBRef1 = New System.Windows.Forms.TextBox()
        Me.TBEpaisseur = New System.Windows.Forms.TextBox()
        Me.TBHauteurLargeur = New System.Windows.Forms.TextBox()
        Me.TBmerusre = New System.Windows.Forms.TextBox()
        Me.TBDescription = New System.Windows.Forms.TextBox()
        Me.TBReference = New System.Windows.Forms.TextBox()
        Me.TBCodeZebra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBIPprt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Comboprt = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.CheckBoxCE)
        Me.GroupBox1.Controls.Add(Me.TBref4)
        Me.GroupBox1.Controls.Add(Me.TBref3)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.TBSerie)
        Me.GroupBox1.Controls.Add(Me.TBPoids)
        Me.GroupBox1.Controls.Add(Me.TBpays)
        Me.GroupBox1.Controls.Add(Me.TBcodeBarre)
        Me.GroupBox1.Controls.Add(Me.TBRef2)
        Me.GroupBox1.Controls.Add(Me.TBRef1)
        Me.GroupBox1.Controls.Add(Me.TBEpaisseur)
        Me.GroupBox1.Controls.Add(Me.TBHauteurLargeur)
        Me.GroupBox1.Controls.Add(Me.TBmerusre)
        Me.GroupBox1.Controls.Add(Me.TBDescription)
        Me.GroupBox1.Controls.Add(Me.TBReference)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 517)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Etiquette"
        '
        'CheckBoxCE
        '
        Me.CheckBoxCE.AutoSize = True
        Me.CheckBoxCE.Checked = True
        Me.CheckBoxCE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCE.Location = New System.Drawing.Point(232, 353)
        Me.CheckBoxCE.Name = "CheckBoxCE"
        Me.CheckBoxCE.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxCE.TabIndex = 18
        Me.CheckBoxCE.UseVisualStyleBackColor = True
        '
        'TBref4
        '
        Me.TBref4.Location = New System.Drawing.Point(6, 372)
        Me.TBref4.Name = "TBref4"
        Me.TBref4.Size = New System.Drawing.Size(288, 20)
        Me.TBref4.TabIndex = 17
        '
        'TBref3
        '
        Me.TBref3.Location = New System.Drawing.Point(6, 237)
        Me.TBref3.Name = "TBref3"
        Me.TBref3.Size = New System.Drawing.Size(288, 20)
        Me.TBref3.TabIndex = 16
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(60, 337)
        Me.MaskedTextBox1.Mask = "0 000000 00000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 12
        Me.MaskedTextBox1.Text = "123456789012"
        '
        'TBSerie
        '
        Me.TBSerie.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSerie.Location = New System.Drawing.Point(194, 169)
        Me.TBSerie.Name = "TBSerie"
        Me.TBSerie.Size = New System.Drawing.Size(100, 36)
        Me.TBSerie.TabIndex = 11
        Me.TBSerie.Text = "Ser.201837"
        '
        'TBPoids
        '
        Me.TBPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPoids.Location = New System.Drawing.Point(194, 132)
        Me.TBPoids.Name = "TBPoids"
        Me.TBPoids.Size = New System.Drawing.Size(100, 31)
        Me.TBPoids.TabIndex = 10
        Me.TBPoids.Text = "20.526"
        '
        'TBpays
        '
        Me.TBpays.Location = New System.Drawing.Point(215, 469)
        Me.TBpays.Name = "TBpays"
        Me.TBpays.Size = New System.Drawing.Size(40, 20)
        Me.TBpays.TabIndex = 9
        Me.TBpays.Text = "FR"
        '
        'TBcodeBarre
        '
        Me.TBcodeBarre.Location = New System.Drawing.Point(60, 469)
        Me.TBcodeBarre.Name = "TBcodeBarre"
        Me.TBcodeBarre.Size = New System.Drawing.Size(147, 20)
        Me.TBcodeBarre.TabIndex = 8
        Me.TBcodeBarre.Text = "80031209000069010000"
        '
        'TBRef2
        '
        Me.TBRef2.Location = New System.Drawing.Point(6, 259)
        Me.TBRef2.Name = "TBRef2"
        Me.TBRef2.Size = New System.Drawing.Size(288, 20)
        Me.TBRef2.TabIndex = 6
        Me.TBRef2.Text = "VETRO TEMP.TRASP."
        '
        'TBRef1
        '
        Me.TBRef1.Location = New System.Drawing.Point(6, 214)
        Me.TBRef1.Name = "TBRef1"
        Me.TBRef1.Size = New System.Drawing.Size(288, 20)
        Me.TBRef1.TabIndex = 5
        Me.TBRef1.Text = "BIANCO 030/ CROMO"
        '
        'TBEpaisseur
        '
        Me.TBEpaisseur.Location = New System.Drawing.Point(194, 106)
        Me.TBEpaisseur.Name = "TBEpaisseur"
        Me.TBEpaisseur.Size = New System.Drawing.Size(100, 20)
        Me.TBEpaisseur.TabIndex = 4
        Me.TBEpaisseur.Text = "L 0900/0900"
        '
        'TBHauteurLargeur
        '
        Me.TBHauteurLargeur.Location = New System.Drawing.Point(194, 80)
        Me.TBHauteurLargeur.Name = "TBHauteurLargeur"
        Me.TBHauteurLargeur.Size = New System.Drawing.Size(100, 20)
        Me.TBHauteurLargeur.TabIndex = 3
        Me.TBHauteurLargeur.Text = "L 0900/0900"
        '
        'TBmerusre
        '
        Me.TBmerusre.Location = New System.Drawing.Point(155, 54)
        Me.TBmerusre.Name = "TBmerusre"
        Me.TBmerusre.Size = New System.Drawing.Size(100, 20)
        Me.TBmerusre.TabIndex = 2
        Me.TBmerusre.Text = "CO. 90 R90X90"
        '
        'TBDescription
        '
        Me.TBDescription.Location = New System.Drawing.Point(6, 54)
        Me.TBDescription.Name = "TBDescription"
        Me.TBDescription.Size = New System.Drawing.Size(100, 20)
        Me.TBDescription.TabIndex = 1
        Me.TBDescription.Text = "LUNES"
        '
        'TBReference
        '
        Me.TBReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBReference.Location = New System.Drawing.Point(6, 19)
        Me.TBReference.Name = "TBReference"
        Me.TBReference.Size = New System.Drawing.Size(225, 29)
        Me.TBReference.TabIndex = 0
        Me.TBReference.Text = "LUNESR90L-1D"
        '
        'TBCodeZebra
        '
        Me.TBCodeZebra.Location = New System.Drawing.Point(318, 66)
        Me.TBCodeZebra.Multiline = True
        Me.TBCodeZebra.Name = "TBCodeZebra"
        Me.TBCodeZebra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBCodeZebra.Size = New System.Drawing.Size(493, 460)
        Me.TBCodeZebra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code Imprimante ZEBRA"
        '
        'TBIPprt
        '
        Me.TBIPprt.Location = New System.Drawing.Point(321, -8)
        Me.TBIPprt.Name = "TBIPprt"
        Me.TBIPprt.Size = New System.Drawing.Size(100, 20)
        Me.TBIPprt.TabIndex = 3
        Me.TBIPprt.Text = "10.65.34.29"
        Me.TBIPprt.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(318, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(426, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Adresse ip Zebra"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(613, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Aller à  Etiquette Expedition Custom"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.LabelPrinter.My.Resources.Resources.samplecode
        Me.PictureBox3.Location = New System.Drawing.Point(49, 400)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(164, 67)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LabelPrinter.My.Resources.Resources.ce
        Me.PictureBox2.Location = New System.Drawing.Point(166, 322)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabelPrinter.My.Resources.Resources.sampleean13
        Me.PictureBox1.Location = New System.Drawing.Point(60, 285)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Comboprt
        '
        Me.Comboprt.FormattingEnabled = True
        Me.Comboprt.Items.AddRange(New Object() {"10.65.34.29 Bureau", "10.65.34.30 SAV", "10.65.34.42 Retour Client", "10.65.34.48 Bureau Logistique", "10.65.34.26 Quai 1", "10.65.34.23 Quai 2"})
        Me.Comboprt.Location = New System.Drawing.Point(411, 12)
        Me.Comboprt.Name = "Comboprt"
        Me.Comboprt.Size = New System.Drawing.Size(178, 21)
        Me.Comboprt.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 534)
        Me.Controls.Add(Me.Comboprt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBIPprt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBCodeZebra)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Etiquette externe Custom"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TBSerie As TextBox
    Friend WithEvents TBPoids As TextBox
    Friend WithEvents TBpays As TextBox
    Friend WithEvents TBcodeBarre As TextBox
    Friend WithEvents TBRef2 As TextBox
    Friend WithEvents TBRef1 As TextBox
    Friend WithEvents TBEpaisseur As TextBox
    Friend WithEvents TBHauteurLargeur As TextBox
    Friend WithEvents TBmerusre As TextBox
    Friend WithEvents TBDescription As TextBox
    Friend WithEvents TBReference As TextBox
    Friend WithEvents TBCodeZebra As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TBref4 As TextBox
    Friend WithEvents TBref3 As TextBox
    Friend WithEvents TBIPprt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents CheckBoxCE As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Comboprt As ComboBox
End Class
