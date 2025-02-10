Imports System.Data.Common
Imports SalouWS4Sql.Client

Public Class ToyStoreDataDB
    Public Shared Function GetConnection() As DbConnection
        Dim connectionString As String = "Data Source = localhost\sqlexpress; Integrated Security = true; " &
            "Initial Catalog = ToyStore;"
        Return New SalouConnection(New Uri("ws://localhost:5249/ws"), "Test", 120000, Nothing)
    End Function
End Class