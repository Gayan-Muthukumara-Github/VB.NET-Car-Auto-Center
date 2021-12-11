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
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseAVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.CARSToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1210, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.LogInToolStripMenuItem.Text = "Log In"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CARSToolStripMenuItem
        '
        Me.CARSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseAVehicleToolStripMenuItem, Me.AddAVehicleToolStripMenuItem, Me.UpdateAVehicleToolStripMenuItem})
        Me.CARSToolStripMenuItem.Name = "CARSToolStripMenuItem"
        Me.CARSToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.CARSToolStripMenuItem.Text = "CARS"
        '
        'PurchaseAVehicleToolStripMenuItem
        '
        Me.PurchaseAVehicleToolStripMenuItem.Name = "PurchaseAVehicleToolStripMenuItem"
        Me.PurchaseAVehicleToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.PurchaseAVehicleToolStripMenuItem.Text = "Purchase a vehicle"
        '
        'AddAVehicleToolStripMenuItem
        '
        Me.AddAVehicleToolStripMenuItem.Name = "AddAVehicleToolStripMenuItem"
        Me.AddAVehicleToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.AddAVehicleToolStripMenuItem.Text = "Add a vehicle"
        '
        'UpdateAVehicleToolStripMenuItem
        '
        Me.UpdateAVehicleToolStripMenuItem.Name = "UpdateAVehicleToolStripMenuItem"
        Me.UpdateAVehicleToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.UpdateAVehicleToolStripMenuItem.Text = "Update a vehicle"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBAutoCenter.My.Resources.Resources.close_up_sales_manager_black_suit_selling_car_customer
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1210, 720)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 748)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseAVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
