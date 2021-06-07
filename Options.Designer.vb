<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.lbldéb = New System.Windows.Forms.Label()
        Me.lblfin = New System.Windows.Forms.Label()
        Me.lblah = New System.Windows.Forms.Label()
        Me.lbldch = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(31, 36)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(757, 26)
        Me.HScrollBar1.TabIndex = 1
        '
        'lbldéb
        '
        Me.lbldéb.AutoSize = True
        Me.lbldéb.Location = New System.Drawing.Point(21, 14)
        Me.lbldéb.Name = "lbldéb"
        Me.lbldéb.Size = New System.Drawing.Size(53, 17)
        Me.lbldéb.TabIndex = 2
        Me.lbldéb.Text = "Difficile"
        '
        'lblfin
        '
        Me.lblfin.AutoSize = True
        Me.lblfin.Location = New System.Drawing.Point(715, 14)
        Me.lblfin.Name = "lblfin"
        Me.lblfin.Size = New System.Drawing.Size(45, 17)
        Me.lblfin.TabIndex = 3
        Me.lblfin.Text = "Facile"
        '
        'lblah
        '
        Me.lblah.AutoSize = True
        Me.lblah.Location = New System.Drawing.Point(238, 80)
        Me.lblah.Name = "lblah"
        Me.lblah.Size = New System.Drawing.Size(99, 17)
        Me.lblah.TabIndex = 5
        Me.lblah.Text = "Temps choisie"
        '
        'lbldch
        '
        Me.lbldch.AutoSize = True
        Me.lbldch.Location = New System.Drawing.Point(401, 80)
        Me.lbldch.Name = "lbldch"
        Me.lbldch.Size = New System.Drawing.Size(46, 17)
        Me.lbldch.TabIndex = 6
        Me.lbldch.Text = "label1"
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(434, 327)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(330, 23)
        Me.btnValider.TabIndex = 9
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.lbldch)
        Me.Controls.Add(Me.lblah)
        Me.Controls.Add(Me.lblfin)
        Me.Controls.Add(Me.lbldéb)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Options"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents lbldéb As Label
    Friend WithEvents lblfin As Label
    Friend WithEvents lblah As Label
    Friend WithEvents lbldch As Label
    Friend WithEvents btnValider As Button
    Friend WithEvents l As Label
    Friend WithEvents Timer1 As Timer
End Class
