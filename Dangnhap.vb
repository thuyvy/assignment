Imports System.Data.SqlClient
Public Class fmdangnhap

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbpass.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttdangnhap.Click
        Dim dayconnect As String = "workstation id=vyntps02268.mssql.somee.com;packet size=4096;user id=ps02268_SQLLogin_1;pwd=wdn1lom6l7;data source=vyntps02268.mssql.somee.com;persist security info=False;initial catalog=vyntps02268"
        Dim connect As SqlConnection = New SqlConnection(dayconnect)
        Dim SqlAdapter As New SqlDataAdapter("Select * from ThongTinNhanVien Where ID ='" & txtdangnhap.Text & "' and Pass = '" & txtpass.Text & "' ", dayconnect)
        Dim tb As New DataTable
        Try
            connect.Open()
            SqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("chào mừng bạn")
                main.Show()
                Me.Hide()
            Else
                MessageBox.Show(" Sai pass rồi")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub fmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
