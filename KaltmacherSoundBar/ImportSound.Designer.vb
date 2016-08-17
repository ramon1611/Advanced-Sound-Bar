<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportSound
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportSound))
        Me.ImportProgressBar = New System.Windows.Forms.ProgressBar()
        Me.PercentLabel = New System.Windows.Forms.Label()
        Me.ImportStatusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ImportProgressBar
        '
        Me.ImportProgressBar.Location = New System.Drawing.Point(12, 35)
        Me.ImportProgressBar.Name = "ImportProgressBar"
        Me.ImportProgressBar.Size = New System.Drawing.Size(437, 23)
        Me.ImportProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ImportProgressBar.TabIndex = 0
        '
        'PercentLabel
        '
        Me.PercentLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PercentLabel.Location = New System.Drawing.Point(12, 61)
        Me.PercentLabel.Name = "PercentLabel"
        Me.PercentLabel.Size = New System.Drawing.Size(437, 23)
        Me.PercentLabel.TabIndex = 1
        Me.PercentLabel.Text = "0%"
        Me.PercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImportStatusLabel
        '
        Me.ImportStatusLabel.Location = New System.Drawing.Point(12, 9)
        Me.ImportStatusLabel.Name = "ImportStatusLabel"
        Me.ImportStatusLabel.Size = New System.Drawing.Size(437, 23)
        Me.ImportStatusLabel.TabIndex = 3
        Me.ImportStatusLabel.Text = "$oldFile -> $newFile"
        Me.ImportStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImportSoundvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 93)
        Me.ControlBox = False
        Me.Controls.Add(Me.ImportStatusLabel)
        Me.Controls.Add(Me.PercentLabel)
        Me.Controls.Add(Me.ImportProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportSoundvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sound importieren ..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImportProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents PercentLabel As System.Windows.Forms.Label
    Friend WithEvents ImportStatusLabel As System.Windows.Forms.Label
End Class
