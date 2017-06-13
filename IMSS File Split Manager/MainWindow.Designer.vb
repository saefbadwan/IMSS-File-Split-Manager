<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_SelectOutputFolder_butt = New System.Windows.Forms.Button()
        Me._IMSS_OutputFolder_txt = New System.Windows.Forms.TextBox()
        Me._IMSS_OutputFolder_lbl = New System.Windows.Forms.Label()
        Me._IMSS_FileName_txt = New System.Windows.Forms.TextBox()
        Me._IMSS_SelectFIleName_but = New System.Windows.Forms.Button()
        Me._IMSS_FileName_lbl = New System.Windows.Forms.Label()
        Me._IMSS_DESCRIPTION = New System.Windows.Forms.Label()
        Me._IMSS_MERGE_LOGO = New System.Windows.Forms.PictureBox()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_MAIN_CONTROL = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_Convert = New System.Windows.Forms.LinkLabel()
        Me._IMSS_SELECTED_FILE_SIZE_LABEL = New System.Windows.Forms.Label()
        Me._IMSS_SPLIT_PROGRESS = New System.Windows.Forms.ProgressBar()
        Me._IMSS_Description_label = New System.Windows.Forms.Label()
        Me._IMSS_Cancel_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_SPLIT_BUTTON = New DevComponents.DotNetBar.ButtonX()
        Me.chkOption = New System.Windows.Forms.CheckBox()
        Me.cmdBrowseFolder = New System.Windows.Forms.Button()
        Me.txtChunkSize = New System.Windows.Forms.TextBox()
        Me.lblChunkSize = New System.Windows.Forms.Label()
        Me.txtOutputFolder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.cmdBrowseFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me._IMSS_LOGO = New System.Windows.Forms.PictureBox()
        Me._IMSS_SplitFiles = New DevComponents.DotNetBar.SuperTabItem()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me._IMSS_CANCEL_BUTT = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Merge_But = New DevComponents.DotNetBar.ButtonX()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me._IMSS_Merge_PrBa = New System.Windows.Forms.ProgressBar()
        Me._IMSS_DeleteFileAfterMerge_CheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me._IMSS_MERGE_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MAIN_CONTROL.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me._IMSS_MAIN_CONTROL)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(548, 347)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_SplitFiles, Me.SuperTabItem1})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_DeleteFileAfterMerge_CheckBox)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_Merge_PrBa)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_CANCEL_BUTT)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_Merge_But)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_SelectOutputFolder_butt)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_OutputFolder_txt)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_OutputFolder_lbl)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_FileName_txt)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_SelectFIleName_but)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_FileName_lbl)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_DESCRIPTION)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_MERGE_LOGO)
        Me.SuperTabControlPanel2.Controls.Add(Me.ShapeContainer2)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(548, 322)
        Me.SuperTabControlPanel2.TabIndex = 2
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem1
        '
        '_IMSS_SelectOutputFolder_butt
        '
        Me._IMSS_SelectOutputFolder_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_SelectOutputFolder_butt.Location = New System.Drawing.Point(350, 137)
        Me._IMSS_SelectOutputFolder_butt.Name = "_IMSS_SelectOutputFolder_butt"
        Me._IMSS_SelectOutputFolder_butt.Size = New System.Drawing.Size(30, 20)
        Me._IMSS_SelectOutputFolder_butt.TabIndex = 39
        Me._IMSS_SelectOutputFolder_butt.Text = "..."
        '
        '_IMSS_OutputFolder_txt
        '
        Me._IMSS_OutputFolder_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._IMSS_OutputFolder_txt.Location = New System.Drawing.Point(126, 137)
        Me._IMSS_OutputFolder_txt.Name = "_IMSS_OutputFolder_txt"
        Me._IMSS_OutputFolder_txt.Size = New System.Drawing.Size(224, 20)
        Me._IMSS_OutputFolder_txt.TabIndex = 38
        '
        '_IMSS_OutputFolder_lbl
        '
        Me._IMSS_OutputFolder_lbl.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_OutputFolder_lbl.Location = New System.Drawing.Point(22, 137)
        Me._IMSS_OutputFolder_lbl.Name = "_IMSS_OutputFolder_lbl"
        Me._IMSS_OutputFolder_lbl.Size = New System.Drawing.Size(98, 24)
        Me._IMSS_OutputFolder_lbl.TabIndex = 37
        Me._IMSS_OutputFolder_lbl.Text = "Output Folder :"
        '
        '_IMSS_FileName_txt
        '
        Me._IMSS_FileName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._IMSS_FileName_txt.Location = New System.Drawing.Point(126, 103)
        Me._IMSS_FileName_txt.Name = "_IMSS_FileName_txt"
        Me._IMSS_FileName_txt.Size = New System.Drawing.Size(224, 20)
        Me._IMSS_FileName_txt.TabIndex = 36
        '
        '_IMSS_SelectFIleName_but
        '
        Me._IMSS_SelectFIleName_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_SelectFIleName_but.Location = New System.Drawing.Point(350, 103)
        Me._IMSS_SelectFIleName_but.Name = "_IMSS_SelectFIleName_but"
        Me._IMSS_SelectFIleName_but.Size = New System.Drawing.Size(30, 20)
        Me._IMSS_SelectFIleName_but.TabIndex = 35
        Me._IMSS_SelectFIleName_but.Text = "..."
        '
        '_IMSS_FileName_lbl
        '
        Me._IMSS_FileName_lbl.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_FileName_lbl.Location = New System.Drawing.Point(22, 103)
        Me._IMSS_FileName_lbl.Name = "_IMSS_FileName_lbl"
        Me._IMSS_FileName_lbl.Size = New System.Drawing.Size(80, 24)
        Me._IMSS_FileName_lbl.TabIndex = 34
        Me._IMSS_FileName_lbl.Text = "FileName :"
        '
        '_IMSS_DESCRIPTION
        '
        Me._IMSS_DESCRIPTION.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_DESCRIPTION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DESCRIPTION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_DESCRIPTION.Location = New System.Drawing.Point(72, 9)
        Me._IMSS_DESCRIPTION.Name = "_IMSS_DESCRIPTION"
        Me._IMSS_DESCRIPTION.Size = New System.Drawing.Size(451, 57)
        Me._IMSS_DESCRIPTION.TabIndex = 32
        Me._IMSS_DESCRIPTION.Text = resources.GetString("_IMSS_DESCRIPTION.Text")
        '
        '_IMSS_MERGE_LOGO
        '
        Me._IMSS_MERGE_LOGO.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_MERGE_LOGO.Image = Global.IMSS_File_Split_Manager.My.Resources.Resources._IMSS_SPLITMANAGER_SPLIT_LOGO
        Me._IMSS_MERGE_LOGO.Location = New System.Drawing.Point(9, 6)
        Me._IMSS_MERGE_LOGO.Name = "_IMSS_MERGE_LOGO"
        Me._IMSS_MERGE_LOGO.Size = New System.Drawing.Size(57, 57)
        Me._IMSS_MERGE_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_MERGE_LOGO.TabIndex = 33
        Me._IMSS_MERGE_LOGO.TabStop = False
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Merge Files"
        '
        '_IMSS_MAIN_CONTROL
        '
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.PictureBox1)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me._IMSS_Convert)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me._IMSS_SELECTED_FILE_SIZE_LABEL)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me._IMSS_SPLIT_PROGRESS)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me._IMSS_Description_label)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me._IMSS_Cancel_Button)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me._IMSS_SPLIT_BUTTON)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.chkOption)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.cmdBrowseFolder)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.txtChunkSize)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.lblChunkSize)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.txtOutputFolder)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.Label2)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.txtFileName)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.cmdBrowseFile)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.Label1)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me.ShapeContainer1)
        Me._IMSS_MAIN_CONTROL.Controls.Add(Me._IMSS_LOGO)
        Me._IMSS_MAIN_CONTROL.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MAIN_CONTROL.Location = New System.Drawing.Point(0, 25)
        Me._IMSS_MAIN_CONTROL.Name = "_IMSS_MAIN_CONTROL"
        Me._IMSS_MAIN_CONTROL.Size = New System.Drawing.Size(548, 322)
        Me._IMSS_MAIN_CONTROL.TabIndex = 1
        Me._IMSS_MAIN_CONTROL.TabItem = Me._IMSS_SplitFiles
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.IMSS_File_Split_Manager.My.Resources.Resources._IMSS_Info_Icon_16x16
        Me.PictureBox1.Location = New System.Drawing.Point(211, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_Convert
        '
        Me._IMSS_Convert.AutoSize = True
        Me._IMSS_Convert.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_Convert.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Convert.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._IMSS_Convert.Location = New System.Drawing.Point(229, 177)
        Me._IMSS_Convert.Name = "_IMSS_Convert"
        Me._IMSS_Convert.Size = New System.Drawing.Size(80, 14)
        Me._IMSS_Convert.TabIndex = 34
        Me._IMSS_Convert.TabStop = True
        Me._IMSS_Convert.Text = "Convert to size"
        '
        '_IMSS_SELECTED_FILE_SIZE_LABEL
        '
        Me._IMSS_SELECTED_FILE_SIZE_LABEL.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_SELECTED_FILE_SIZE_LABEL.Location = New System.Drawing.Point(386, 102)
        Me._IMSS_SELECTED_FILE_SIZE_LABEL.Name = "_IMSS_SELECTED_FILE_SIZE_LABEL"
        Me._IMSS_SELECTED_FILE_SIZE_LABEL.Size = New System.Drawing.Size(150, 20)
        Me._IMSS_SELECTED_FILE_SIZE_LABEL.TabIndex = 33
        Me._IMSS_SELECTED_FILE_SIZE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_IMSS_SPLIT_PROGRESS
        '
        Me._IMSS_SPLIT_PROGRESS.Location = New System.Drawing.Point(75, 228)
        Me._IMSS_SPLIT_PROGRESS.Name = "_IMSS_SPLIT_PROGRESS"
        Me._IMSS_SPLIT_PROGRESS.Size = New System.Drawing.Size(399, 23)
        Me._IMSS_SPLIT_PROGRESS.TabIndex = 32
        Me._IMSS_SPLIT_PROGRESS.Visible = False
        '
        '_IMSS_Description_label
        '
        Me._IMSS_Description_label.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_Description_label.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Description_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._IMSS_Description_label.Location = New System.Drawing.Point(72, 9)
        Me._IMSS_Description_label.Name = "_IMSS_Description_label"
        Me._IMSS_Description_label.Size = New System.Drawing.Size(451, 57)
        Me._IMSS_Description_label.TabIndex = 30
        Me._IMSS_Description_label.Text = resources.GetString("_IMSS_Description_label.Text")
        '
        '_IMSS_Cancel_Button
        '
        Me._IMSS_Cancel_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Cancel_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Cancel_Button.Location = New System.Drawing.Point(356, 284)
        Me._IMSS_Cancel_Button.Name = "_IMSS_Cancel_Button"
        Me._IMSS_Cancel_Button.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Cancel_Button.Size = New System.Drawing.Size(87, 23)
        Me._IMSS_Cancel_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Cancel_Button.TabIndex = 28
        Me._IMSS_Cancel_Button.Text = "Cancel"
        Me._IMSS_Cancel_Button.Visible = False
        '
        '_IMSS_SPLIT_BUTTON
        '
        Me._IMSS_SPLIT_BUTTON.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_SPLIT_BUTTON.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_SPLIT_BUTTON.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SPLIT_BUTTON.Location = New System.Drawing.Point(449, 284)
        Me._IMSS_SPLIT_BUTTON.Name = "_IMSS_SPLIT_BUTTON"
        Me._IMSS_SPLIT_BUTTON.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_SPLIT_BUTTON.Size = New System.Drawing.Size(87, 23)
        Me._IMSS_SPLIT_BUTTON.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_SPLIT_BUTTON.TabIndex = 27
        Me._IMSS_SPLIT_BUTTON.Text = "Split"
        '
        'chkOption
        '
        Me.chkOption.BackColor = System.Drawing.Color.Transparent
        Me.chkOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOption.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOption.Location = New System.Drawing.Point(126, 208)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(200, 16)
        Me.chkOption.TabIndex = 26
        Me.chkOption.Text = "Delete files after split process"
        Me.chkOption.UseVisualStyleBackColor = False
        '
        'cmdBrowseFolder
        '
        Me.cmdBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrowseFolder.Location = New System.Drawing.Point(350, 137)
        Me.cmdBrowseFolder.Name = "cmdBrowseFolder"
        Me.cmdBrowseFolder.Size = New System.Drawing.Size(30, 20)
        Me.cmdBrowseFolder.TabIndex = 25
        Me.cmdBrowseFolder.Text = "..."
        '
        'txtChunkSize
        '
        Me.txtChunkSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChunkSize.Location = New System.Drawing.Point(126, 175)
        Me.txtChunkSize.Name = "txtChunkSize"
        Me.txtChunkSize.Size = New System.Drawing.Size(80, 20)
        Me.txtChunkSize.TabIndex = 24
        '
        'lblChunkSize
        '
        Me.lblChunkSize.BackColor = System.Drawing.Color.Transparent
        Me.lblChunkSize.Location = New System.Drawing.Point(22, 177)
        Me.lblChunkSize.Name = "lblChunkSize"
        Me.lblChunkSize.Size = New System.Drawing.Size(112, 24)
        Me.lblChunkSize.TabIndex = 23
        Me.lblChunkSize.Text = "Section Size(Bytes) :"
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutputFolder.Location = New System.Drawing.Point(126, 137)
        Me.txtOutputFolder.Name = "txtOutputFolder"
        Me.txtOutputFolder.Size = New System.Drawing.Size(224, 20)
        Me.txtOutputFolder.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(22, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Output Folder :"
        '
        'txtFileName
        '
        Me.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileName.Location = New System.Drawing.Point(126, 103)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(224, 20)
        Me.txtFileName.TabIndex = 20
        '
        'cmdBrowseFile
        '
        Me.cmdBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrowseFile.Location = New System.Drawing.Point(350, 103)
        Me.cmdBrowseFile.Name = "cmdBrowseFile"
        Me.cmdBrowseFile.Size = New System.Drawing.Size(30, 20)
        Me.cmdBrowseFile.TabIndex = 19
        Me.cmdBrowseFile.Text = "..."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(22, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "FileName :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(548, 322)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 75
        Me.LineShape2.X2 = 473
        Me.LineShape2.Y1 = 256
        Me.LineShape2.Y2 = 256
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 75
        Me.LineShape1.X2 = 473
        Me.LineShape1.Y1 = 69
        Me.LineShape1.Y2 = 69
        '
        '_IMSS_LOGO
        '
        Me._IMSS_LOGO.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_LOGO.Image = Global.IMSS_File_Split_Manager.My.Resources.Resources._IMSS_SPLITMANAGER_SPLIT_LOGO
        Me._IMSS_LOGO.Location = New System.Drawing.Point(9, 6)
        Me._IMSS_LOGO.Name = "_IMSS_LOGO"
        Me._IMSS_LOGO.Size = New System.Drawing.Size(57, 57)
        Me._IMSS_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_LOGO.TabIndex = 31
        Me._IMSS_LOGO.TabStop = False
        '
        '_IMSS_SplitFiles
        '
        Me._IMSS_SplitFiles.AttachedControl = Me._IMSS_MAIN_CONTROL
        Me._IMSS_SplitFiles.GlobalItem = False
        Me._IMSS_SplitFiles.Name = "_IMSS_SplitFiles"
        Me._IMSS_SplitFiles.Text = "Split Files"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(548, 322)
        Me.ShapeContainer2.TabIndex = 41
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 75
        Me.LineShape3.X2 = 473
        Me.LineShape3.Y1 = 69
        Me.LineShape3.Y2 = 69
        '
        '_IMSS_CANCEL_BUTT
        '
        Me._IMSS_CANCEL_BUTT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_CANCEL_BUTT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_CANCEL_BUTT.Location = New System.Drawing.Point(356, 284)
        Me._IMSS_CANCEL_BUTT.Name = "_IMSS_CANCEL_BUTT"
        Me._IMSS_CANCEL_BUTT.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_CANCEL_BUTT.Size = New System.Drawing.Size(87, 23)
        Me._IMSS_CANCEL_BUTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_CANCEL_BUTT.TabIndex = 43
        Me._IMSS_CANCEL_BUTT.Text = "Cancel"
        Me._IMSS_CANCEL_BUTT.Visible = False
        '
        '_IMSS_Merge_But
        '
        Me._IMSS_Merge_But.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Merge_But.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Merge_But.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Merge_But.Location = New System.Drawing.Point(449, 284)
        Me._IMSS_Merge_But.Name = "_IMSS_Merge_But"
        Me._IMSS_Merge_But.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Merge_But.Size = New System.Drawing.Size(87, 23)
        Me._IMSS_Merge_But.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Merge_But.TabIndex = 42
        Me._IMSS_Merge_But.Text = "Merge"
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 75
        Me.LineShape4.X2 = 473
        Me.LineShape4.Y1 = 256
        Me.LineShape4.Y2 = 256
        '
        '_IMSS_Merge_PrBa
        '
        Me._IMSS_Merge_PrBa.Location = New System.Drawing.Point(75, 228)
        Me._IMSS_Merge_PrBa.Name = "_IMSS_Merge_PrBa"
        Me._IMSS_Merge_PrBa.Size = New System.Drawing.Size(399, 23)
        Me._IMSS_Merge_PrBa.TabIndex = 44
        Me._IMSS_Merge_PrBa.Visible = False
        '
        '_IMSS_DeleteFileAfterMerge_CheckBox
        '
        Me._IMSS_DeleteFileAfterMerge_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me._IMSS_DeleteFileAfterMerge_CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._IMSS_DeleteFileAfterMerge_CheckBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_DeleteFileAfterMerge_CheckBox.Location = New System.Drawing.Point(126, 208)
        Me._IMSS_DeleteFileAfterMerge_CheckBox.Name = "_IMSS_DeleteFileAfterMerge_CheckBox"
        Me._IMSS_DeleteFileAfterMerge_CheckBox.Size = New System.Drawing.Size(200, 16)
        Me._IMSS_DeleteFileAfterMerge_CheckBox.TabIndex = 45
        Me._IMSS_DeleteFileAfterMerge_CheckBox.Text = "Delete files after merge process"
        Me._IMSS_DeleteFileAfterMerge_CheckBox.UseVisualStyleBackColor = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 347)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(564, 385)
        Me.MinimumSize = New System.Drawing.Size(564, 385)
        Me.Name = "MainWindow"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS File Split Manager"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel2.PerformLayout()
        CType(Me._IMSS_MERGE_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MAIN_CONTROL.ResumeLayout(False)
        Me._IMSS_MAIN_CONTROL.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents _IMSS_MAIN_CONTROL As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_SplitFiles As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Description_label As System.Windows.Forms.Label
    Friend WithEvents _IMSS_Cancel_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_SPLIT_BUTTON As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chkOption As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBrowseFolder As System.Windows.Forms.Button
    Friend WithEvents txtChunkSize As System.Windows.Forms.TextBox
    Friend WithEvents lblChunkSize As System.Windows.Forms.Label
    Friend WithEvents txtOutputFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents _IMSS_SPLIT_PROGRESS As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_SELECTED_FILE_SIZE_LABEL As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Convert As System.Windows.Forms.LinkLabel
    Friend WithEvents _IMSS_SelectOutputFolder_butt As System.Windows.Forms.Button
    Friend WithEvents _IMSS_OutputFolder_txt As System.Windows.Forms.TextBox
    Friend WithEvents _IMSS_OutputFolder_lbl As System.Windows.Forms.Label
    Friend WithEvents _IMSS_FileName_txt As System.Windows.Forms.TextBox
    Friend WithEvents _IMSS_SelectFIleName_but As System.Windows.Forms.Button
    Friend WithEvents _IMSS_FileName_lbl As System.Windows.Forms.Label
    Friend WithEvents _IMSS_DESCRIPTION As System.Windows.Forms.Label
    Friend WithEvents _IMSS_MERGE_LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_Merge_PrBa As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_CANCEL_BUTT As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Merge_But As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents _IMSS_DeleteFileAfterMerge_CheckBox As System.Windows.Forms.CheckBox

End Class
