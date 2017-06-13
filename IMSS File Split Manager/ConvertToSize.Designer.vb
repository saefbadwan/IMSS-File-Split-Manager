<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertToSize
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
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_CONTROL_HOLDERS = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_OK = New System.Windows.Forms.Button()
        Me._IMSS_CANCEL = New System.Windows.Forms.Button()
        Me._IMSS_Description_Label = New System.Windows.Forms.Label()
        Me._IMSS_TOTAL_SECTIONS = New System.Windows.Forms.NumericUpDown()
        Me._IMSS_BYTES_TEXTBOX = New System.Windows.Forms.TextBox()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_CONTROL_HOLDERS.SuspendLayout()
        CType(Me._IMSS_TOTAL_SECTIONS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CONTROL_HOLDERS)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Description_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_TOTAL_SECTIONS)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_BYTES_TEXTBOX)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(323, 99)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_CONTROL_HOLDERS
        '
        Me._IMSS_CONTROL_HOLDERS.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_CONTROL_HOLDERS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CONTROL_HOLDERS.Controls.Add(Me._IMSS_OK)
        Me._IMSS_CONTROL_HOLDERS.Controls.Add(Me._IMSS_CANCEL)
        Me._IMSS_CONTROL_HOLDERS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_CONTROL_HOLDERS.Location = New System.Drawing.Point(0, 64)
        Me._IMSS_CONTROL_HOLDERS.Name = "_IMSS_CONTROL_HOLDERS"
        Me._IMSS_CONTROL_HOLDERS.Size = New System.Drawing.Size(323, 35)
        Me._IMSS_CONTROL_HOLDERS.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_CONTROL_HOLDERS.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDERS.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me._IMSS_CONTROL_HOLDERS.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_CONTROL_HOLDERS.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_CONTROL_HOLDERS.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_CONTROL_HOLDERS.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_CONTROL_HOLDERS.Style.GradientAngle = 90
        Me._IMSS_CONTROL_HOLDERS.TabIndex = 6
        '
        '_IMSS_OK
        '
        Me._IMSS_OK.Location = New System.Drawing.Point(261, 7)
        Me._IMSS_OK.Name = "_IMSS_OK"
        Me._IMSS_OK.Size = New System.Drawing.Size(52, 23)
        Me._IMSS_OK.TabIndex = 2
        Me._IMSS_OK.Text = "&Ok"
        Me._IMSS_OK.UseVisualStyleBackColor = True
        '
        '_IMSS_CANCEL
        '
        Me._IMSS_CANCEL.Location = New System.Drawing.Point(192, 7)
        Me._IMSS_CANCEL.Name = "_IMSS_CANCEL"
        Me._IMSS_CANCEL.Size = New System.Drawing.Size(63, 23)
        Me._IMSS_CANCEL.TabIndex = 3
        Me._IMSS_CANCEL.Text = "&Cancel"
        Me._IMSS_CANCEL.UseVisualStyleBackColor = True
        '
        '_IMSS_Description_Label
        '
        Me._IMSS_Description_Label.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Description_Label.Location = New System.Drawing.Point(12, 6)
        Me._IMSS_Description_Label.Name = "_IMSS_Description_Label"
        Me._IMSS_Description_Label.Size = New System.Drawing.Size(299, 30)
        Me._IMSS_Description_Label.TabIndex = 1
        Me._IMSS_Description_Label.Text = "Please insert how many section the file need to be , and get the section size in " & _
            "byte"
        '
        '_IMSS_TOTAL_SECTIONS
        '
        Me._IMSS_TOTAL_SECTIONS.Location = New System.Drawing.Point(13, 39)
        Me._IMSS_TOTAL_SECTIONS.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me._IMSS_TOTAL_SECTIONS.Name = "_IMSS_TOTAL_SECTIONS"
        Me._IMSS_TOTAL_SECTIONS.Size = New System.Drawing.Size(50, 20)
        Me._IMSS_TOTAL_SECTIONS.TabIndex = 4
        '
        '_IMSS_BYTES_TEXTBOX
        '
        Me._IMSS_BYTES_TEXTBOX.BackColor = System.Drawing.Color.WhiteSmoke
        Me._IMSS_BYTES_TEXTBOX.Location = New System.Drawing.Point(69, 39)
        Me._IMSS_BYTES_TEXTBOX.Name = "_IMSS_BYTES_TEXTBOX"
        Me._IMSS_BYTES_TEXTBOX.ReadOnly = True
        Me._IMSS_BYTES_TEXTBOX.Size = New System.Drawing.Size(243, 20)
        Me._IMSS_BYTES_TEXTBOX.TabIndex = 5
        '
        'ConvertToSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 99)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(339, 137)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(339, 137)
        Me.Name = "ConvertToSize"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert sections to size"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me._IMSS_CONTROL_HOLDERS.ResumeLayout(False)
        CType(Me._IMSS_TOTAL_SECTIONS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_CONTROL_HOLDERS As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_OK As System.Windows.Forms.Button
    Friend WithEvents _IMSS_CANCEL As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Description_Label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_TOTAL_SECTIONS As System.Windows.Forms.NumericUpDown
    Friend WithEvents _IMSS_BYTES_TEXTBOX As System.Windows.Forms.TextBox
End Class
