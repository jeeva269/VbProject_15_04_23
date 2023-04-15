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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OLDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRINTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOOLBARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCROLLBARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.QUITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.PRINTToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOOLBARToolStripMenuItem, Me.SCROLLBARToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "&VIEW"
        '
        'QUITToolStripMenuItem
        '
        Me.QUITToolStripMenuItem.Name = "QUITToolStripMenuItem"
        Me.QUITToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.QUITToolStripMenuItem.Text = "&QUIT"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NEWToolStripMenuItem.Text = "NEW"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RECENTToolStripMenuItem, Me.OLDToolStripMenuItem})
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OPENToolStripMenuItem.Text = "OPEN"
        '
        'RECENTToolStripMenuItem
        '
        Me.RECENTToolStripMenuItem.Name = "RECENTToolStripMenuItem"
        Me.RECENTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RECENTToolStripMenuItem.Text = "RECENT"
        '
        'OLDToolStripMenuItem
        '
        Me.OLDToolStripMenuItem.Name = "OLDToolStripMenuItem"
        Me.OLDToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OLDToolStripMenuItem.Text = "OLD"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'PRINTToolStripMenuItem
        '
        Me.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem"
        Me.PRINTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PRINTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PRINTToolStripMenuItem.Text = "PRINT"
        '
        'TOOLBARToolStripMenuItem
        '
        Me.TOOLBARToolStripMenuItem.Name = "TOOLBARToolStripMenuItem"
        Me.TOOLBARToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TOOLBARToolStripMenuItem.Text = "TOOLBAR"
        '
        'SCROLLBARToolStripMenuItem
        '
        Me.SCROLLBARToolStripMenuItem.Name = "SCROLLBARToolStripMenuItem"
        Me.SCROLLBARToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SCROLLBARToolStripMenuItem.Text = "SCROLLBAR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 538)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RECENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OLDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRINTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOOLBARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCROLLBARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
