<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scoresvb
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
        Me.btnfermer = New System.Windows.Forms.Button()
        Me.lbnom = New System.Windows.Forms.ListBox()
        Me.lbstat = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btncroisdecrois = New System.Windows.Forms.Button()
        Me.btnaffichestat = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clmname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnbcarr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmtmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmtmpjeu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nbrgame = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfermer
        '
        Me.btnfermer.Location = New System.Drawing.Point(649, 317)
        Me.btnfermer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnfermer.Name = "btnfermer"
        Me.btnfermer.Size = New System.Drawing.Size(94, 23)
        Me.btnfermer.TabIndex = 0
        Me.btnfermer.Text = "Fermer"
        Me.btnfermer.UseVisualStyleBackColor = True
        '
        'lbnom
        '
        Me.lbnom.FormattingEnabled = True
        Me.lbnom.ItemHeight = 16
        Me.lbnom.Location = New System.Drawing.Point(96, 30)
        Me.lbnom.Name = "lbnom"
        Me.lbnom.Size = New System.Drawing.Size(120, 84)
        Me.lbnom.TabIndex = 1
        '
        'lbstat
        '
        Me.lbstat.FormattingEnabled = True
        Me.lbstat.ItemHeight = 16
        Me.lbstat.Location = New System.Drawing.Point(558, 30)
        Me.lbstat.Name = "lbstat"
        Me.lbstat.Size = New System.Drawing.Size(120, 84)
        Me.lbstat.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(306, 337)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'btncroisdecrois
        '
        Me.btncroisdecrois.Location = New System.Drawing.Point(306, 290)
        Me.btncroisdecrois.Name = "btncroisdecrois"
        Me.btncroisdecrois.Size = New System.Drawing.Size(158, 28)
        Me.btncroisdecrois.TabIndex = 4
        Me.btncroisdecrois.Text = "Croissant/Décroissant"
        Me.btncroisdecrois.UseVisualStyleBackColor = True
        '
        'btnaffichestat
        '
        Me.btnaffichestat.Location = New System.Drawing.Point(343, 381)
        Me.btnaffichestat.Name = "btnaffichestat"
        Me.btnaffichestat.Size = New System.Drawing.Size(75, 23)
        Me.btnaffichestat.TabIndex = 5
        Me.btnaffichestat.Text = "Afficher Statistique"
        Me.btnaffichestat.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmname, Me.clmnbcarr, Me.clmtmp, Me.clmtmpjeu, Me.nbrgame})
        Me.DataGridView1.Location = New System.Drawing.Point(63, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(680, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'clmname
        '
        Me.clmname.HeaderText = "Nom"
        Me.clmname.MinimumWidth = 6
        Me.clmname.Name = "clmname"
        Me.clmname.Width = 125
        '
        'clmnbcarr
        '
        Me.clmnbcarr.HeaderText = "Nombre de carré(s) trouvé"
        Me.clmnbcarr.MinimumWidth = 6
        Me.clmnbcarr.Name = "clmnbcarr"
        Me.clmnbcarr.Width = 125
        '
        'clmtmp
        '
        Me.clmtmp.HeaderText = "Temps pour trouvé"
        Me.clmtmp.MinimumWidth = 6
        Me.clmtmp.Name = "clmtmp"
        Me.clmtmp.Width = 125
        '
        'clmtmpjeu
        '
        Me.clmtmpjeu.HeaderText = "Temps de jeux total"
        Me.clmtmpjeu.MinimumWidth = 6
        Me.clmtmpjeu.Name = "clmtmpjeu"
        Me.clmtmpjeu.Width = 125
        '
        'nbrgame
        '
        Me.nbrgame.HeaderText = "Nombre de partie(s)"
        Me.nbrgame.MinimumWidth = 6
        Me.nbrgame.Name = "nbrgame"
        Me.nbrgame.Width = 125
        '
        'Scoresvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 453)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnaffichestat)
        Me.Controls.Add(Me.btncroisdecrois)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbstat)
        Me.Controls.Add(Me.lbnom)
        Me.Controls.Add(Me.btnfermer)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Scoresvb"
        Me.Text = "Scoresvb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnfermer As Button
    Friend WithEvents lbnom As ListBox
    Friend WithEvents lbstat As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btncroisdecrois As Button
    Friend WithEvents btnaffichestat As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents clmname As DataGridViewTextBoxColumn
    Friend WithEvents clmnbcarr As DataGridViewTextBoxColumn
    Friend WithEvents clmtmp As DataGridViewTextBoxColumn
    Friend WithEvents clmtmpjeu As DataGridViewTextBoxColumn
    Friend WithEvents nbrgame As DataGridViewTextBoxColumn
End Class
