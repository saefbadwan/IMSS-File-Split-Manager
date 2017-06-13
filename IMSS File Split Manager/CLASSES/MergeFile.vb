Imports System.IO

Public Class MergeFile

    Public Property _IMSS_TARGET_FILE As String = String.Empty
    Public Property _IMSS_OUTPUT_DIR As String = String.Empty
    Public Property _IMSS_DELETE_AFTERMERGE As Boolean = False

    Private _IMSS_PROGRESSBAR As ProgressBar = Nothing

    Public WriteOnly Property _IMSS_PROGRESS As ProgressBar
        Set(ByVal _IMSS_PROGRESS As ProgressBar)
            _IMSS_PROGRESSBAR = _IMSS_PROGRESS
        End Set
    End Property

    Public Sub _IMSS_MergeFile()

        If Not Directory.Exists(Me._IMSS_OUTPUT_DIR) Then Directory.CreateDirectory(Me._IMSS_OUTPUT_DIR)

        If IO.File.Exists(_IMSS_TARGET_FILE) = True Then

            Dim _IMSS_InputFIleOpen As IO.FileStream
            Dim _IMSS_OutputFIleOpen As IO.FileStream
            Dim _IMSS_InputBinaryReader As IO.BinaryReader
            Dim _IMSS_OutputBinaryWriter As IO.BinaryWriter

            Dim _IMSS_MergeFiles() As String = Nothing
            Dim _IMSS_OutputFile As String = String.Empty
            Dim _IMSS_FileSize As Long = 0
            Dim _IMSS_Buffer As Byte() = New Byte() {}
            Dim _IMSS_ProgressValue As ULong = 0
            Dim _IMSS_Index As Short = 0

            _IMSS_MergeFiles = _IMSS_GetMergeFiles(Me._IMSS_TARGET_FILE.Substring(0, Me._IMSS_TARGET_FILE.Length - 4))

            If Not IsNothing(_IMSS_MergeFiles) Then

                _IMSS_OutputFile = Me._IMSS_OUTPUT_DIR & "\" & IO.Path.GetFileName(Me._IMSS_TARGET_FILE.Substring(0, Me._IMSS_TARGET_FILE.Length - 4))

                If File.Exists(_IMSS_OutputFile) Then File.Delete(_IMSS_OutputFile)

                _IMSS_OutputFIleOpen = New FileStream(_IMSS_OutputFile, FileMode.CreateNew)

                _IMSS_OutputBinaryWriter = New BinaryWriter(_IMSS_OutputFIleOpen)

                For _IMSS_Index = 0 To _IMSS_MergeFiles.Length - 1
                    _IMSS_FileSize = _IMSS_GetFileSize(_IMSS_MergeFiles(_IMSS_Index))
                    _IMSS_InputFIleOpen = New FileStream(_IMSS_MergeFiles(_IMSS_Index), FileMode.Open)
                    _IMSS_InputBinaryReader = New BinaryReader(_IMSS_InputFIleOpen)
                    _IMSS_InputBinaryReader.BaseStream.Seek(0, SeekOrigin.Begin)
                    ReDim _IMSS_Buffer(_IMSS_FileSize - 1)
                    _IMSS_InputBinaryReader.Read(_IMSS_Buffer, 0, _IMSS_Buffer.Length)
                    _IMSS_OutputBinaryWriter.Write(_IMSS_Buffer)
                    _IMSS_OutputFIleOpen.Flush()
                    _IMSS_InputBinaryReader.Close()
                    _IMSS_InputFIleOpen.Close()

                    _IMSS_UpdateProgress(_IMSS_ProgressValue)

                Next _IMSS_Index

                _IMSS_OutputFIleOpen.Close()
                _IMSS_OutputBinaryWriter.Close()

                If Me._IMSS_DELETE_AFTERMERGE Then
                    For _IMSS_Index = 0 To _IMSS_MergeFiles.Length - 1
                        Try
                            IO.File.Delete(_IMSS_MergeFiles(_IMSS_Index))
                        Catch : End Try
                    Next _IMSS_Index
                End If

                _IMSS_UpdateProgress(100)

                System.Threading.Thread.Sleep(1000)

                _IMSS_PROGRESSBAR.Invoke(New _IMSS_OnComplete_Delegate(AddressOf _IMSS_OnComplete))

            End If


        End If

    End Sub

    Private Function _IMSS_GetFileSize(ByVal _IMSS_FileName As String) As Long
        Return (New FileInfo(_IMSS_FileName).Length)
    End Function

    Private Function _IMSS_GetMergeFiles(ByVal MergeFileName As String) As String()
        Dim _tempFiles As String() = System.IO.Directory.GetFiles(System.IO.Directory.GetParent(MergeFileName).ToString)
        Dim _MergeFiles() As String = Nothing
        Dim _Index As Short
        Do
            _Index += 1
            If Array.BinarySearch(_tempFiles, MergeFileName & "." & Format(_Index, "000")) >= 0 Then
                ReDim Preserve _MergeFiles(_Index - 1)
                _MergeFiles(_Index - 1) = MergeFileName & "." & Format(_Index, "000")
            Else
                Exit Do
            End If
        Loop
        Return _MergeFiles
    End Function

    Private Delegate Sub _IMSS_UpdateProgress_Delagte(ByVal _IMSS_ProgreesValue As ULong)
    Private Sub _IMSS_UpdateProgress(ByVal _IMSS_ProgreesValue As ULong)
        If _IMSS_PROGRESSBAR.InvokeRequired = True Then
            _IMSS_PROGRESSBAR.Invoke(New _IMSS_UpdateProgress_Delagte(AddressOf _IMSS_UpdateProgress), _IMSS_ProgreesValue)
        Else

            _IMSS_PROGRESSBAR.Value = _IMSS_ProgreesValue
        End If
    End Sub

    Private Delegate Sub _IMSS_OnComplete_Delegate()
    Private Sub _IMSS_OnComplete()


        _IMSS_PROGRESSBAR.Visible = False

    End Sub

End Class
