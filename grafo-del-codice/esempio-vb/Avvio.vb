Imports System.Data.Common

''' <summary>Prepara il rapporto della settimana e lo annuncia quando è pronto.</summary>
Public Module Avvio

    Private WithEvents _rapporto As RapportoSettimanale

    Public Sub Prepara(connessione As DbConnection, settimana As Integer)
        _rapporto = New RapportoSettimanale(connessione)
        _rapporto.Prepara(settimana)
        _rapporto.Archivia("STORICO_RAPPORTI", settimana - 52)
    End Sub

    Private Sub QuandoPronto(settimana As Integer, ticket As Integer) Handles _rapporto.RapportoPronto
        Console.WriteLine($"Rapporto della settimana {settimana}: {ticket} ticket, {_rapporto.OperatoriAttivi} operatori attivi")
    End Sub

End Module
