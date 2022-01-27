Public Class FormRekapHutang

    Dim bdRekapHutang As New BindingSource
    Dim dsRekapHutang As DataSet
    Dim drwRekapHutang As DataRowView

    Private Sub FormRekapHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click
        'dsRekapHutang = DataManager.ExecuteQuery()
    End Sub
End Class