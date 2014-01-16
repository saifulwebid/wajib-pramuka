Namespace WajibPramuka
    Module Database
        ''' <summary>
        ''' Connection string for SQLiteConnection.
        ''' </summary>
        Public ConnectionString As String = "data source=WP.db"

        ''' <summary>
        ''' Initialize a connection instance for the application.
        ''' </summary>
        ''' <returns>An instance of SQLiteConnection.</returns>
        Public Function InitializeConnection() As SQLiteConnection

            'Initialize a new SQLiteConnection instance.
            Dim Connection As New SQLiteConnection

            'Set up SQLiteConnection defaults.
            Connection.ConnectionString = ConnectionString
            Connection.DefaultTimeout = 5

            'Return the instance.
            Return Connection
        End Function
    End Module
End Namespace