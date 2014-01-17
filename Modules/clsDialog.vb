Namespace WajibPramuka
    Public Class Dialog
        Private Const ErrorTitle As String = "Ooopss......"
        Private Const ConfirmationTitle As String = "Konfirmasi"
        Private Const InformationTitle As String = "Informasi"

        Private Const ExceptionTitle As String = "We're sorry, our bad"
        Private Const ExceptionHeader As String = "Aplikasi mengalami kesalahan yang belum diantisipasi. " & _
            "Hubungi pembuat program ini dengan menyertakan informasi sebagai berikut:" & vbNewLine & vbNewLine
        Private Const ExceptionFooter As String = vbNewLine & vbNewLine & "Mohon maaf atas ketidaknyamanan Anda."

        Public Shared Function ShowError(ByVal message As String) As DialogResult
            Return MessageBox.Show(message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Function

        Public Shared Function ShowException(ByVal message As String) As DialogResult
            Return MessageBox.Show(ExceptionHeader & "Error message: " & message & ExceptionFooter, ExceptionTitle, _
                                   MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Function

        Public Shared Function ShowException(ByVal errorCode As String, ByVal message As String) As DialogResult
            Return MessageBox.Show(ExceptionHeader & "Error code: " & errorCode & vbNewLine & _
                                   "Error message: " & message & ExceptionFooter, ExceptionTitle, _
                                   MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Function

        Public Shared Function ShowConfirmation(ByVal message As String) As DialogResult
            Return MessageBox.Show(message, ConfirmationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Function

        Public Shared Function ShowInformation(ByVal message As String) As DialogResult
            Return MessageBox.Show(message, InformationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Function
    End Class
End Namespace