Imports System.Data.Common

''' <summary>
''' Il rapporto settimanale dell'help desk: conta i ticket della settimana, lo scrive nello storico e chiude la
''' settimana nel database. Quando ha finito avvisa chi ascolta con l'evento RapportoPronto.
''' </summary>
Public Class RapportoSettimanale

    Public Event RapportoPronto(settimana As Integer, ticket As Integer)

    Private Const SqlOperatoriAttivi As String = "SELECT ID, NOME FROM OPERATORE WHERE ATTIVO = 1"

    Private ReadOnly _connessione As DbConnection

    Public Sub New(connessione As DbConnection)
        _connessione = connessione
    End Sub

    Public Function Prepara(settimana As Integer) As Integer
        Dim sql As String = "SELECT T.ID, T.STATO, O.NOME FROM TICKET T" &
            " JOIN OPERATORE O ON O.ID = T.OPERATORE_ID" &
            " WHERE T.SETTIMANA = " & settimana.ToString()
        Dim ticket = Conta(sql)
        Esegui("INSERT INTO STORICO_RAPPORTI (SETTIMANA, TICKET) VALUES (" & settimana & ", " & ticket & ")")
        Esegui("BEGIN PKG_RAPPORTI.CHIUDI_SETTIMANA(" & settimana & "); END;")
        RaiseEvent RapportoPronto(settimana, ticket)
        Return ticket
    End Function

    ''' <summary>Toglie le righe vecchie da una tabella che sceglie chi chiama.</summary>
    Public Sub Archivia(tabella As String, primaDi As Integer)
        Esegui("DELETE FROM " & tabella & " WHERE SETTIMANA < " & primaDi)
    End Sub

    Public Function OperatoriAttivi() As Integer
        Return Conta(SqlOperatoriAttivi)
    End Function

    Private Function Conta(sql As String) As Integer
        Using cmd = _connessione.CreateCommand()
            cmd.CommandText = "SELECT COUNT(*) FROM (" & sql & ")"
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub Esegui(sql As String)
        Using cmd = _connessione.CreateCommand()
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
