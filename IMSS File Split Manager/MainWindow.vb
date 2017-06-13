Public Class MainWindow

    Dim _IMSS_THREADS As New List(Of Threading.Thread)

    Private Sub cmdBrowseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseFile.Click
        Dim FileDialog As New OpenFileDialog()
        FileDialog.FilterIndex = 1
        If FileDialog.ShowDialog() = DialogResult.OK Then
            txtFileName.Text = FileDialog.FileName
            Try
                _IMSS_SELECTED_FILE_SIZE_LABEL.Text = _IMSS_FormatFileSize(New IO.FileInfo(FileDialog.FileName).Length)
                txtChunkSize.Text = New IO.FileInfo(FileDialog.FileName).Length.ToString()
            Catch
                _IMSS_SELECTED_FILE_SIZE_LABEL.Text = "Error loading size."
            End Try
        End If
        FileDialog = Nothing
    End Sub


    Private Sub cmdBrowseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseFolder.Click
        Dim _OpenDirectoryDialog As New OpenDirectoryDialog()
        _OpenDirectoryDialog.DialogTitle = "Select the output folder "
        If _OpenDirectoryDialog.ShowDialog(Me) = DialogResult.OK Then
            txtOutputFolder.Text = _OpenDirectoryDialog.DirectoryName
        End If
        _OpenDirectoryDialog = Nothing
    End Sub

    Private Function _IMSS_FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"B", "KB", "MB", "GB"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop

        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function

    Private Sub _IMSS_Convert_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_Convert.LinkClicked

        If Not txtChunkSize.Text.Length = 0 Then

            Dim _IMSS_ConvertToSize As New ConvertToSize(txtChunkSize)

            _IMSS_ConvertToSize.ShowDialog()

        End If

    End Sub

    Private Sub _IMSS_SPLIT_BUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SPLIT_BUTTON.Click
        If IO.File.Exists(txtFileName.Text) And IO.Directory.Exists(txtOutputFolder.Text) Then

            Me._IMSS_SPLIT_PROGRESS.Value = 0
            Me._IMSS_SPLIT_BUTTON.Enabled = False
            Me._IMSS_Cancel_Button.Enabled = True
            Me._IMSS_Cancel_Button.Visible = True

            Dim _IMSS_SplitFile As New SplitFile

            With _IMSS_SplitFile

                ._IMSS_DELETE_AFTERSPLIT = chkOption.Checked
                ._IMSS_FILE_SIZE = New IO.FileInfo(txtFileName.Text).Length
                ._IMSS_OUTPUT_DIR = txtOutputFolder.Text
                ._IMSS_PROGRESS = _IMSS_SPLIT_PROGRESS
                ._IMSS_SECTION_SIZE = txtChunkSize.Text
                ._IMSS_TARGET_FILE = txtFileName.Text

            End With


            _IMSS_SPLIT_PROGRESS.Visible = True

            Dim _IMSS_THREAD As New Threading.Thread(Sub()

                                                         _IMSS_SplitFile._IMSS_SplitFile()

                                                         Invoke(New _IMSS_OnComplete_Delegate(AddressOf _IMSS_OnSplitComplete))

                                                     End Sub) : _IMSS_THREAD.Start()
            _IMSS_THREADS.Add(_IMSS_THREAD)

        Else
            MessageBox.Show("Please select file you want split it , and select a folder to save the result in it !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
 

    End Sub

#Region "IMSS On Work Conplete"

    Private Delegate Sub _IMSS_OnComplete_Delegate()
    Private Sub _IMSS_OnSplitComplete()
        Me._IMSS_SPLIT_BUTTON.Enabled = True
        Me._IMSS_Cancel_Button.Enabled = False
        Me._IMSS_Cancel_Button.Visible = False
        Try
            Process.Start(txtOutputFolder.Text)
        Catch : End Try
    End Sub

    Private Sub _IMSS_OnMergeComplete()
        Me._IMSS_Merge_But.Enabled = True
        Me._IMSS_CANCEL_BUTT.Enabled = False
        Me._IMSS_CANCEL_BUTT.Visible = False
        Me._IMSS_Merge_PrBa.Value = 0
        Me._IMSS_Merge_PrBa.Visible = False
        Try
            Process.Start(_IMSS_OutputFolder_txt.Text)
        Catch : End Try
    End Sub

#End Region

    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        For Each _IMSS_THREAD In _IMSS_THREADS
            If Not _IMSS_THREAD Is Nothing Then
                Try
                    _IMSS_THREAD.Abort()
                Catch : End Try
            End If
        Next _IMSS_THREAD

        Me._IMSS_SPLIT_BUTTON.Enabled = True
        Me._IMSS_Cancel_Button.Enabled = False
        Me._IMSS_Cancel_Button.Visible = False

    End Sub

    Private Sub _IMSS_Merge_But_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Merge_But.Click

        If IO.File.Exists(_IMSS_FileName_txt.Text) And IO.Directory.Exists(_IMSS_OutputFolder_txt.Text) Then

            Me._IMSS_Merge_PrBa.Visible = True
            Me._IMSS_Merge_But.Enabled = False
            Me._IMSS_CANCEL_BUTT.Enabled = True
            Me._IMSS_CANCEL_BUTT.Visible = True

            Dim _IMSS_MergeFile As New MergeFile

            With _IMSS_MergeFile

                ._IMSS_TARGET_FILE = _IMSS_FileName_txt.Text

                ._IMSS_OUTPUT_DIR = _IMSS_OutputFolder_txt.Text

                ._IMSS_DELETE_AFTERMERGE = _IMSS_DeleteFileAfterMerge_CheckBox.Checked

                ._IMSS_PROGRESS = _IMSS_Merge_PrBa

            End With


            Dim _IMSS_THREAD As New Threading.Thread(Sub()

                                                         _IMSS_MergeFile._IMSS_MergeFile()

                                                         Invoke(New _IMSS_OnComplete_Delegate(AddressOf _IMSS_OnMergeComplete))

                                                     End Sub) : _IMSS_THREAD.Start()
            _IMSS_THREADS.Add(_IMSS_THREAD)

        Else
            MessageBox.Show("Please select files you want merge it , and select a folder to save the result in it !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub _IMSS_CANCEL_BUTT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CANCEL_BUTT.Click

        For Each _IMSS_THREAD In _IMSS_THREADS
            If Not _IMSS_THREAD Is Nothing Then
                Try
                    _IMSS_THREAD.Abort()
                Catch : End Try
            End If
        Next _IMSS_THREAD

        Me._IMSS_Merge_But.Enabled = True
        Me._IMSS_CANCEL_BUTT.Enabled = False
        Me._IMSS_CANCEL_BUTT.Visible = False

    End Sub

    Private Sub _IMSS_SelectFIleName_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SelectFIleName_but.Click
        Dim FileDialog As New OpenFileDialog()
        FileDialog.FilterIndex = 1
        If FileDialog.ShowDialog() = DialogResult.OK Then
            _IMSS_FileName_txt.Text = FileDialog.FileName()
        End If
        FileDialog = Nothing
    End Sub

    Private Sub _IMSS_SelectOutputFolder_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SelectOutputFolder_butt.Click

        Dim _OpenDirectoryDialog As New OpenDirectoryDialog()
        _OpenDirectoryDialog.DialogTitle = "Select the output folder "
        If _OpenDirectoryDialog.ShowDialog(Me) = DialogResult.OK Then
            _IMSS_OutputFolder_txt.Text = _OpenDirectoryDialog.DirectoryName()
        End If
        _OpenDirectoryDialog = Nothing

    End Sub

End Class
