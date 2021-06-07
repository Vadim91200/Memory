<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cbnom = New System.Windows.Forms.ComboBox()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.btnjouer = New System.Windows.Forms.Button()
        Me.btnoptions = New System.Windows.Forms.Button()
        Me.btnscores = New System.Windows.Forms.Button()
        Me.btnquitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbnom
        '
        Me.cbnom.FormattingEnabled = True
        Me.cbnom.Location = New System.Drawing.Point(151, 103)
        Me.cbnom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbnom.Name = "cbnom"
        Me.cbnom.Size = New System.Drawing.Size(166, 24)
        Me.cbnom.TabIndex = 0
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(12, 106)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(128, 17)
        Me.LblNom.TabIndex = 1
        Me.LblNom.Text = "Entrez votre nom : "
        '
        'btnjouer
        '
        Me.btnjouer.Location = New System.Drawing.Point(109, 138)
        Me.btnjouer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnjouer.Name = "btnjouer"
        Me.btnjouer.Size = New System.Drawing.Size(94, 24)
        Me.btnjouer.TabIndex = 2
        Me.btnjouer.Text = "Jouer"
        Me.btnjouer.UseVisualStyleBackColor = True
        '
        'btnoptions
        '
        Me.btnoptions.Location = New System.Drawing.Point(109, 166)
        Me.btnoptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnoptions.Name = "btnoptions"
        Me.btnoptions.Size = New System.Drawing.Size(94, 24)
        Me.btnoptions.TabIndex = 3
        Me.btnoptions.Text = "Options"
        Me.btnoptions.UseVisualStyleBackColor = True
        '
        'btnscores
        '
        Me.btnscores.Location = New System.Drawing.Point(109, 195)
        Me.btnscores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnscores.Name = "btnscores"
        Me.btnscores.Size = New System.Drawing.Size(94, 24)
        Me.btnscores.TabIndex = 4
        Me.btnscores.Text = "Scores"
        Me.btnscores.UseVisualStyleBackColor = True
        '
        'btnquitter
        '
        Me.btnquitter.Location = New System.Drawing.Point(109, 224)
        Me.btnquitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnquitter.Name = "btnquitter"
        Me.btnquitter.Size = New System.Drawing.Size(94, 24)
        Me.btnquitter.TabIndex = 5
        Me.btnquitter.Text = "Quitter"
        Me.btnquitter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Memory.My.Resources.Resources.Memorygame
        Me.PictureBox1.Location = New System.Drawing.Point(46, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 86)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 255)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnquitter)
        Me.Controls.Add(Me.btnscores)
        Me.Controls.Add(Me.btnoptions)
        Me.Controls.Add(Me.btnjouer)
        Me.Controls.Add(Me.LblNom)
        Me.Controls.Add(Me.cbnom)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbnom As ComboBox
    Friend WithEvents LblNom As Label
    Friend WithEvents btnjouer As Button
    Friend WithEvents btnoptions As Button
    Friend WithEvents btnscores As Button
    Friend WithEvents btnquitter As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
