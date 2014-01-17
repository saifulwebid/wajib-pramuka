Namespace WajibPramuka
    Module Cryptography
        Public Function HashPassword(ByVal username As String, ByVal password As String) As String
            Dim PasswordByte() As Byte
            Dim SHA As New System.Security.Cryptography.SHA1CryptoServiceProvider
            Dim PasswordString As String = ""
            Dim PasswordOrigin As String = username & "_" & password

            PasswordByte = SHA.ComputeHash(System.Text.Encoding.ASCII.GetBytes(PasswordOrigin))

            For Each b As Byte In PasswordByte
                PasswordString += b.ToString("x2")
            Next

            Return PasswordString
        End Function
    End Module
End Namespace