Imports System.Data.Common

Public Class Ricerca
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        If Not IsPostBack Then filtro.Prepara()
    End Sub

    Protected Sub btnCerca_Click(sender As Object, e As EventArgs)
        Using cmd = Connessione().CreateCommand()
            cmd.CommandText = "SELECT ID, STATO FROM TICKET WHERE CLIENTE = :cliente"
            grigliaTicket.DataSource = cmd.ExecuteReader()
        End Using
    End Sub

    Protected Sub grigliaTicket_SelectedIndexChanged(sender As Object, e As EventArgs)
        Response.Redirect("Dettaglio.aspx?id=" & grigliaTicket.SelectedValue.ToString())
    End Sub

    Private Sub btnStampa_Click(sender As Object, e As EventArgs) Handles btnStampa.Click
        Using cmd = Connessione().CreateCommand()
            cmd.CommandText = "BEGIN PKG_RAPPORTI.CHIUDI_SETTIMANA(:s); END;"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function Connessione() As DbConnection
        Return Nothing
    End Function
End Class
