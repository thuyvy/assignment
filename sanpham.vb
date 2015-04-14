Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class sanpham
    Dim table As New DataTable
    Dim some As String = "workstation id=vyntps02268.mssql.somee.com;packet size=4096;user id=ps02268_SQLLogin_1;pwd=wdn1lom6l7;data source=vyntps02268.mssql.somee.com;persist security info=False;initial catalog=vyntps02268"
    Private Sub tai()
        Dim upload As New SqlConnection(some)
        Dim insert As New SqlDataAdapter(" select * from SanPham ", upload)
        Try
            upload.Open()
            insert.Fill(table)

        Catch ex As Exception
        End Try
        data1.DataSource = table
        upload.Close()
    End Sub
    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        Dim upload As New SqlConnection(some)
        Dim insert As New SqlDataAdapter(" select * from SanPham ", upload)
        Try
            upload.Open()
            insert.Fill(table)

        Catch ex As Exception
        End Try
        data1.DataSource = table
        upload.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim hienthi As New SqlConnection(some)
        Dim add As New SqlDataAdapter("insert into SanPham values ('" & txtma.Text & "','" & txtten.Text & "', '" & txtgia.Text & "', '" & txtso.Text & "', '" & txtct.Text & "', '" & txtloai.Text & "')", hienthi)
        Try
            hienthi.Open()
            add.Fill(table)

        Catch ex As Exception
            MessageBox.Show("thêm dữ liệu thành công!")
        End Try
        data1.DataSource = table
        hienthi.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim hienthi As New SqlConnection(some)
        hienthi.Open()
        Dim capnhat As String = "Update SanPham Set MaSanPham = @MaSanPham, TenSanPham = @TenSanPham, DonGia = @DonGia, SoLuong = @SoLuong, ChiTietSanPham = @ChiTietSanPham, MaLoai = @MaLoai Where MaLoai = @MaLoai "
        Dim com As New SqlCommand(capnhat, hienthi)
        Try
            'Them du lieu '
            com.Parameters.AddWithValue("@MaSanPham", txtma.Text)
            com.Parameters.AddWithValue("@TenSanPham", txtten.Text)
            com.Parameters.AddWithValue("@DonGia", txtgia.Text)
            com.Parameters.AddWithValue("@SoLuong", txtso.Text)
            com.Parameters.AddWithValue("@ChiTietSanPham", txtct.Text)
            com.Parameters.AddWithValue("@MaLoai", txtloai.Text)
            ' Thuc thi truy van '
            com.ExecuteNonQuery()
            hienthi.Close()
        Catch ex As Exception
            MessageBox.Show("Chỉnh sửa không thành công")

        End Try
        table.Clear()
        data1.DataSource = table
        data1.DataSource = Nothing
        tai()

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim delete As New SqlConnection(some)
        delete.Open()
        Dim capnhat As String = "Delete from SanPham Where TenSanPham=@TenSanPham"
        Dim com As New SqlCommand(capnhat, delete)
        Try

            com.Parameters.AddWithValue("TenSanPham", txtten.Text)
            com.ExecuteNonQuery()
            delete.Close()

        Catch ex As Exception
            MessageBox.Show("Xóa dữ liệu thành công")

        End Try
        table.Clear()
        data1.DataSource = table
        data1.DataSource = Nothing
        tai()
    End Sub
End Class