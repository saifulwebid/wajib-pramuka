Namespace WajibPramuka
    Public Class Dialog
        Private Const ErrorTitle As String = "Ooopss......"
        Private Const ConfirmationTitle As String = "Konfirmasi"
        Private Const InformationTitle As String = "Informasi"
        Private Const ExceptionTitle As String = "We're sorry, our bad"
        Private Const ExceptionHeader As String = "Aplikasi mengalami kesalahan yang belum diantisipasi. " & _
            "Hubungi pembuat program ini dengan menyertakan informasi sebagai berikut:" & vbNewLine & vbNewLine
        Private Const ExceptionFooter As String = vbNewLine & vbNewLine & "Mohon maaf atas ketidaknyamanan Anda."

        ''' <summary>
        ''' Generate a MessageBox instance of an error message box.
        ''' </summary>
        ''' <param name="message">The message of the error.</param>
        ''' <returns>A DialogResult of the generated error message box.</returns>
        Public Shared Function ShowError(ByVal message As String) As DialogResult
            Return MessageBox.Show(message, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Function

        ''' <summary>
        ''' Generate a MessageBox instance of an exception handling message box.
        ''' </summary>
        ''' <param name="message">The message of the exception.</param>
        ''' <returns>A DialogResult of the generated exception handling message box.</returns>
        Public Shared Function ShowException(ByVal message As String) As DialogResult
            Return MessageBox.Show(ExceptionHeader & "Error message: " & message & ExceptionFooter, ExceptionTitle, _
                                   MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Function

        ''' <summary>
        ''' Generate a MessageBox instance of an exception handling message box.
        ''' </summary>
        ''' <param name="errorCode">The error code of the exception.</param>
        ''' <param name="message">The message of the exception.</param>
        ''' <returns>A DialogResult of the generated exception handling message box.</returns>
        Public Shared Function ShowException(ByVal errorCode As String, ByVal message As String) As DialogResult
            Return MessageBox.Show(ExceptionHeader & "Error code: " & errorCode & vbNewLine & _
                                   "Error message: " & message & ExceptionFooter, ExceptionTitle, _
                                   MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Function

        ''' <summary>
        ''' Generate a MessageBox instance of a confirmation dialog box.
        ''' </summary>
        ''' <param name="message">The message of the confirmation.</param>
        ''' <returns>A DialogResult of the generated confirmation dialog box.</returns>
        Public Shared Function ShowConfirmation(ByVal message As String) As DialogResult
            Return MessageBox.Show(message, ConfirmationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End Function

        ''' <summary>
        ''' Generate a MessageBox instance of a information message box.
        ''' </summary>
        ''' <param name="message">The message of the information.</param>
        ''' <returns>A DialogResult of the generated information message box.</returns>
        Public Shared Function ShowInformation(ByVal message As String) As DialogResult
            Return MessageBox.Show(message, InformationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Function
    End Class
End Namespace