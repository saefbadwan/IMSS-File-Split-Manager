Public Class ConvertToSize

    Private _IMSS_LOCAL_TEXTBOX_RESULT As TextBox = Nothing

    Public Sub New(ByRef _IMSS_TOTAL_SIZE As TextBox)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        '_IMSS_BYTES_TEXTBOX.Tag = _IMSS_TOTAL_SIZE.Text
        _IMSS_LOCAL_TEXTBOX_RESULT = _IMSS_TOTAL_SIZE

    End Sub
    Private Sub _IMSS_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub _IMSS_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OK.Click
        _IMSS_LOCAL_TEXTBOX_RESULT.Text = _IMSS_BYTES_TEXTBOX.Text
        Me.Close()
    End Sub

    Private Sub _IMSS_TOTAL_SECTIONS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_TOTAL_SECTIONS.ValueChanged
        If Not (_IMSS_TOTAL_SECTIONS.Value = 0) = True Then

            _IMSS_BYTES_TEXTBOX.Text = Math.Floor(CType(_IMSS_LOCAL_TEXTBOX_RESULT.Text, ULong) / _IMSS_TOTAL_SECTIONS.Value)

        Else

        End If
    End Sub
End Class