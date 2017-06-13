Imports System.Windows.Forms

Public Class SplitFile

    Public Property _IMSS_TARGET_FILE As String = String.Empty
    Public Property _IMSS_OUTPUT_DIR As String = String.Empty
    Public Property _IMSS_DELETE_AFTERSPLIT As Boolean = False
    Public Property _IMSS_FILE_SIZE As ULong = 0
    Public Property _IMSS_SECTION_SIZE As ULong = 0

    Private _IMSS_PROGRESSBAR As ProgressBar = Nothing

    Public WriteOnly Property _IMSS_PROGRESS As ProgressBar
        Set(ByVal _IMSS_PROGRESS As ProgressBar)
            _IMSS_PROGRESSBAR = _IMSS_PROGRESS
        End Set
    End Property

    Public Sub _IMSS_SplitFile()

        Dim _IMSS_InputFIleOpen As New IO.FileStream(_IMSS_TARGET_FILE, IO.FileMode.Open)
        Dim _IMSS_InputBinaryReader As New IO.BinaryReader(_IMSS_InputFIleOpen)
        Dim _IMSS_OutputFIleOpen As IO.FileStream
        Dim _IMSS_OutputBinaryWriter As IO.BinaryWriter

        Dim _IMSS_Index As Short = 0
        Dim _IMSS_NumberOfSections As Integer = 0
        Dim _IMSS_RemainingBytes As Long = 0
        Dim _IMSS_Buffer As Byte() = New Byte() {}
        Dim _IMSS_StartPosition As Long = 0
        Dim _IMSS_ProgressValue As ULong = 0
        Dim _IMSS_OutputFile As String = String.Empty

        _IMSS_NumberOfSections = Math.Floor(_IMSS_FILE_SIZE / _IMSS_SECTION_SIZE)
        _IMSS_ProgressValue = (100 / _IMSS_NumberOfSections)
        _IMSS_RemainingBytes = _IMSS_FILE_SIZE - (_IMSS_NumberOfSections * _IMSS_SECTION_SIZE)

        If IO.File.Exists(_IMSS_TARGET_FILE) Then

            If IO.Directory.Exists(_IMSS_OUTPUT_DIR) Then

                _IMSS_InputBinaryReader.BaseStream.Seek(0, IO.SeekOrigin.Begin)

                For _IMSS_Index = 1 To _IMSS_NumberOfSections
                    _IMSS_OutputFile = Me._IMSS_OUTPUT_DIR & "\" & IO.Path.GetFileName(_IMSS_TARGET_FILE) & "." & Format(_IMSS_Index, "000")
                    ReDim _IMSS_Buffer(_IMSS_SECTION_SIZE - 1)
                    _IMSS_InputBinaryReader.Read(_IMSS_Buffer, 0, _IMSS_SECTION_SIZE)
                    _IMSS_StartPosition = _IMSS_InputBinaryReader.BaseStream.Seek(0, IO.SeekOrigin.Current)
                    If IO.File.Exists(_IMSS_OutputFile) Then IO.File.Delete(_IMSS_OutputFile)
                    _IMSS_OutputFIleOpen = New System.IO.FileStream(_IMSS_OutputFile, IO.FileMode.Create)
                    _IMSS_OutputBinaryWriter = New IO.BinaryWriter(_IMSS_OutputFIleOpen)
                    _IMSS_OutputBinaryWriter.Write(_IMSS_Buffer)
                    _IMSS_OutputFIleOpen.Flush()
                    _IMSS_OutputBinaryWriter.Close()
                    _IMSS_OutputFIleOpen.Close()

                    _IMSS_UpdateProgress(_IMSS_ProgressValue)

                Next _IMSS_Index


                If _IMSS_RemainingBytes > 0 Then
                    _IMSS_OutputFile = Me._IMSS_OUTPUT_DIR & "\" & IO.Path.GetFileName(_IMSS_TARGET_FILE) & "." & Format(_IMSS_Index, "000")
                    ReDim _IMSS_Buffer(_IMSS_RemainingBytes - 1)
                    _IMSS_InputBinaryReader.Read(_IMSS_Buffer, 0, _IMSS_RemainingBytes)
                    If IO.File.Exists(_IMSS_OutputFile) Then IO.File.Delete(_IMSS_OutputFile)
                    _IMSS_OutputFIleOpen = New System.IO.FileStream(_IMSS_OutputFile, IO.FileMode.Create)
                    _IMSS_OutputBinaryWriter = New IO.BinaryWriter(_IMSS_OutputFIleOpen)
                    _IMSS_OutputBinaryWriter.Write(_IMSS_Buffer)
                    _IMSS_OutputFIleOpen.Flush()
                    _IMSS_OutputBinaryWriter.Close()
                    _IMSS_OutputFIleOpen.Close()
                End If

                _IMSS_InputFIleOpen.Close()
                _IMSS_InputBinaryReader.Close()
                If Me._IMSS_DELETE_AFTERSPLIT Then IO.File.Delete(_IMSS_TARGET_FILE)

                _IMSS_UpdateProgress(100)

                System.Threading.Thread.Sleep(1000)

                _IMSS_PROGRESSBAR.Invoke(New _IMSS_OnComplete_Delegate(AddressOf _IMSS_OnComplete))

            End If

        End If

    End Sub
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
