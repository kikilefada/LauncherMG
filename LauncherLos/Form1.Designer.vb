<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BugerBox = New System.Windows.Forms.PictureBox()
        Me.boutonbug = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bouton_instal_maj = New System.Windows.Forms.Button()
        Me.Bouton_actu = New System.Windows.Forms.Button()
        Me.Bouton_info_serveur = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BugerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Roboto", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(772, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(493, 145)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "LANCER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(103, 749)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1385, 33)
        Me.ProgressBar1.Step = 0
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.UseWaitCursor = True
        Me.ProgressBar1.Value = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.Test2ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(124, 64)
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(123, 30)
        Me.TestToolStripMenuItem.Text = "test"
        '
        'Test2ToolStripMenuItem
        '
        Me.Test2ToolStripMenuItem.Name = "Test2ToolStripMenuItem"
        Me.Test2ToolStripMenuItem.Size = New System.Drawing.Size(123, 30)
        Me.Test2ToolStripMenuItem.Text = "test2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.BugerBox)
        Me.Panel1.Controls.Add(Me.boutonbug)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(83, 807)
        Me.Panel1.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 407)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(401, 88)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "          Assistance"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 319)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(401, 88)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "          Twitch Tv"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 231)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(401, 88)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "          Staff"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BugerBox
        '
        Me.BugerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BugerBox.Image = CType(resources.GetObject("BugerBox.Image"), System.Drawing.Image)
        Me.BugerBox.Location = New System.Drawing.Point(311, 22)
        Me.BugerBox.Name = "BugerBox"
        Me.BugerBox.Size = New System.Drawing.Size(34, 30)
        Me.BugerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BugerBox.TabIndex = 9
        Me.BugerBox.TabStop = False
        '
        'boutonbug
        '
        Me.boutonbug.FlatAppearance.BorderSize = 0
        Me.boutonbug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boutonbug.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.boutonbug.Image = CType(resources.GetObject("boutonbug.Image"), System.Drawing.Image)
        Me.boutonbug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boutonbug.Location = New System.Drawing.Point(0, 143)
        Me.boutonbug.Margin = New System.Windows.Forms.Padding(0)
        Me.boutonbug.Name = "boutonbug"
        Me.boutonbug.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.boutonbug.Size = New System.Drawing.Size(401, 88)
        Me.boutonbug.TabIndex = 9
        Me.boutonbug.Text = "          Accueil"
        Me.boutonbug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.boutonbug.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.boutonbug.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.Button1.BackColor = System.Drawing.Color.GreenYellow
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1300, 577)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 145)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bouton_instal_maj
        '
        Me.bouton_instal_maj.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.bouton_instal_maj.BackColor = System.Drawing.Color.GreenYellow
        Me.bouton_instal_maj.BackgroundImage = CType(resources.GetObject("bouton_instal_maj.BackgroundImage"), System.Drawing.Image)
        Me.bouton_instal_maj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_instal_maj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_instal_maj.FlatAppearance.BorderSize = 0
        Me.bouton_instal_maj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bouton_instal_maj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.bouton_instal_maj.Location = New System.Drawing.Point(1048, 345)
        Me.bouton_instal_maj.Name = "bouton_instal_maj"
        Me.bouton_instal_maj.Size = New System.Drawing.Size(406, 196)
        Me.bouton_instal_maj.TabIndex = 3
        Me.bouton_instal_maj.UseVisualStyleBackColor = True
        '
        'Bouton_actu
        '
        Me.Bouton_actu.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.Bouton_actu.BackColor = System.Drawing.Color.GreenYellow
        Me.Bouton_actu.BackgroundImage = CType(resources.GetObject("Bouton_actu.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_actu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bouton_actu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_actu.FlatAppearance.BorderSize = 0
        Me.Bouton_actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bouton_actu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Bouton_actu.Location = New System.Drawing.Point(597, 345)
        Me.Bouton_actu.Name = "Bouton_actu"
        Me.Bouton_actu.Size = New System.Drawing.Size(420, 196)
        Me.Bouton_actu.TabIndex = 2
        Me.Bouton_actu.Text = "&"
        Me.Bouton_actu.UseVisualStyleBackColor = True
        '
        'Bouton_info_serveur
        '
        Me.Bouton_info_serveur.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.Bouton_info_serveur.BackColor = System.Drawing.Color.GreenYellow
        Me.Bouton_info_serveur.BackgroundImage = CType(resources.GetObject("Bouton_info_serveur.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_info_serveur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bouton_info_serveur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bouton_info_serveur.FlatAppearance.BorderSize = 0
        Me.Bouton_info_serveur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bouton_info_serveur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Bouton_info_serveur.Location = New System.Drawing.Point(142, 345)
        Me.Bouton_info_serveur.Name = "Bouton_info_serveur"
        Me.Bouton_info_serveur.Size = New System.Drawing.Size(424, 196)
        Me.Bouton_info_serveur.TabIndex = 0
        Me.Bouton_info_serveur.Text = "&"
        Me.Bouton_info_serveur.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 495)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(401, 88)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "          Soutien du projet"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1520, 807)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bouton_instal_maj)
        Me.Controls.Add(Me.Bouton_actu)
        Me.Controls.Add(Me.Bouton_info_serveur)
        Me.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher_LOS"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.BugerBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bouton_info_serveur As Button
    Friend WithEvents Bouton_actu As Button
    Friend WithEvents bouton_instal_maj As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Test2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents boutonbug As Button
    Friend WithEvents BugerBox As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
End Class
