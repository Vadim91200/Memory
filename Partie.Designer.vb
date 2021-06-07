<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partie
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
        Me.components = New System.ComponentModel.Container()
        Me.lbljoueur = New System.Windows.Forms.Label()
        Me.lblnom = New System.Windows.Forms.Label()
        Me.Lbltmrest = New System.Windows.Forms.Label()
        Me.lblcompteur = New System.Windows.Forms.Label()
        Me.btnabandon = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbljoueur
        '
        Me.lbljoueur.AutoSize = True
        Me.lbljoueur.Location = New System.Drawing.Point(7, 26)
        Me.lbljoueur.Name = "lbljoueur"
        Me.lbljoueur.Size = New System.Drawing.Size(64, 17)
        Me.lbljoueur.TabIndex = 0
        Me.lbljoueur.Text = "Joueur : "
        '
        'lblnom
        '
        Me.lblnom.AutoSize = True
        Me.lblnom.Location = New System.Drawing.Point(76, 26)
        Me.lblnom.Name = "lblnom"
        Me.lblnom.Size = New System.Drawing.Size(51, 17)
        Me.lblnom.TabIndex = 1
        Me.lblnom.Text = "Label1"
        '
        'Lbltmrest
        '
        Me.Lbltmrest.AutoSize = True
        Me.Lbltmrest.Location = New System.Drawing.Point(186, 26)
        Me.Lbltmrest.Name = "Lbltmrest"
        Me.Lbltmrest.Size = New System.Drawing.Size(120, 17)
        Me.Lbltmrest.TabIndex = 2
        Me.Lbltmrest.Text = "- Temps restant : "
        '
        'lblcompteur
        '
        Me.lblcompteur.AutoSize = True
        Me.lblcompteur.Location = New System.Drawing.Point(329, 26)
        Me.lblcompteur.Name = "lblcompteur"
        Me.lblcompteur.Size = New System.Drawing.Size(51, 17)
        Me.lblcompteur.TabIndex = 3
        Me.lblcompteur.Text = "Label1"
        '
        'btnabandon
        '
        Me.btnabandon.Location = New System.Drawing.Point(479, 23)
        Me.btnabandon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnabandon.Name = "btnabandon"
        Me.btnabandon.Size = New System.Drawing.Size(94, 23)
        Me.btnabandon.TabIndex = 4
        Me.btnabandon.Text = "Abandonnez"
        Me.btnabandon.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox3.Location = New System.Drawing.Point(37, 39)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(92, 127)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox1.Location = New System.Drawing.Point(164, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 127)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox2.Location = New System.Drawing.Point(295, 39)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 127)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox4.Location = New System.Drawing.Point(547, 39)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(91, 127)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox5.Location = New System.Drawing.Point(424, 39)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(88, 127)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox6.Location = New System.Drawing.Point(547, 184)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(88, 127)
        Me.PictureBox6.TabIndex = 17
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox7.Location = New System.Drawing.Point(295, 184)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(91, 127)
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox8.Location = New System.Drawing.Point(424, 184)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(88, 127)
        Me.PictureBox8.TabIndex = 15
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox9.Location = New System.Drawing.Point(164, 184)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(92, 127)
        Me.PictureBox9.TabIndex = 14
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox10.Location = New System.Drawing.Point(36, 184)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(92, 127)
        Me.PictureBox10.TabIndex = 13
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox11.Location = New System.Drawing.Point(547, 476)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(88, 125)
        Me.PictureBox11.TabIndex = 27
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox12.Location = New System.Drawing.Point(421, 476)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(91, 125)
        Me.PictureBox12.TabIndex = 26
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox13.Location = New System.Drawing.Point(298, 476)
        Me.PictureBox13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(88, 125)
        Me.PictureBox13.TabIndex = 25
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox14.Location = New System.Drawing.Point(164, 476)
        Me.PictureBox14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(92, 125)
        Me.PictureBox14.TabIndex = 24
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox15.Location = New System.Drawing.Point(37, 476)
        Me.PictureBox15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(92, 125)
        Me.PictureBox15.TabIndex = 23
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox16.Location = New System.Drawing.Point(547, 330)
        Me.PictureBox16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(88, 127)
        Me.PictureBox16.TabIndex = 22
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox17.Location = New System.Drawing.Point(295, 330)
        Me.PictureBox17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(91, 127)
        Me.PictureBox17.TabIndex = 21
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox18.Location = New System.Drawing.Point(424, 330)
        Me.PictureBox18.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(88, 127)
        Me.PictureBox18.TabIndex = 20
        Me.PictureBox18.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox19.Location = New System.Drawing.Point(164, 330)
        Me.PictureBox19.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(92, 127)
        Me.PictureBox19.TabIndex = 19
        Me.PictureBox19.TabStop = False
        '
        'PictureBox20
        '
        Me.PictureBox20.BackgroundImage = Global.Memory.My.Resources.Resources.BackCard
        Me.PictureBox20.Location = New System.Drawing.Point(36, 330)
        Me.PictureBox20.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(92, 127)
        Me.PictureBox20.TabIndex = 18
        Me.PictureBox20.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox12)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox13)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox14)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox15)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.PictureBox16)
        Me.Panel1.Controls.Add(Me.PictureBox9)
        Me.Panel1.Controls.Add(Me.PictureBox17)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.PictureBox18)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox19)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox20)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 633)
        Me.Panel1.TabIndex = 28
        '
        'Partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnabandon)
        Me.Controls.Add(Me.lblcompteur)
        Me.Controls.Add(Me.Lbltmrest)
        Me.Controls.Add(Me.lblnom)
        Me.Controls.Add(Me.lbljoueur)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Partie"
        Me.Text = "Partie"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbljoueur As Label
    Friend WithEvents lblnom As Label
    Friend WithEvents Lbltmrest As Label
    Friend WithEvents lblcompteur As Label
    Friend WithEvents btnabandon As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
