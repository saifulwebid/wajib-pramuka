Namespace WajibPramuka
    Module Cryptography

        ''' <summary>
        ''' Generate SHA1 hash from given username and plain password.
        ''' </summary>
        ''' <returns>The generated SHA1 hash.</returns>
        Public Function HashPassword(ByVal username As String, ByVal password As String) As String
            Dim PasswordByte() As Byte
            Dim SHA As New System.Security.Cryptography.SHA1CryptoServiceProvider
            Dim PasswordString As String = ""
            Dim PasswordOrigin As String = username & "_" & password

            ' First, get the bytes array from the given plaintext username and password.
            ' Second, get the SHA1 hash from that array, and assign it to PasswordByte variable.
            PasswordByte = SHA.ComputeHash(System.Text.Encoding.ASCII.GetBytes(PasswordOrigin))

            ' Convert PasswordByte (array of bytes) to PasswordString (array of char).
            For Each b As Byte In PasswordByte
                PasswordString += b.ToString("x2")
            Next

            Return PasswordString
        End Function

    End Module
End Namespace