Imports System.IO

Public Class Form1
    Public Sub New()
        InitializeComponent()
        LstvContentData.FullRowSelect = True
    End Sub

    Private Sub SaveArrayBtn_Click(sender As Object, e As EventArgs) Handles SaveArrayBtn.Click
        Dim x As ItemForContainter

        Dim Name As String = NamePdrocutTxt.Text

        Dim Quantity As Integer = Convert.ToInt32(QuantityNud.Value)
        Dim Price As Integer = Convert.ToInt32(PriseNud.Value)
        Price = Price * Quantity

        x = New ItemForContainter(Name, Quantity, Price)

        Dim row As New ListViewItem(x.Name.ToString())
        row.SubItems.Add(x.Quantity.ToString())
        row.SubItems.Add(x.Price.ToString())
        LstvContentData.Items.Add(row)
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Text Files|*.txt"
        dialog.Title = "Guardar en archivo de Texto"

        If dialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(dialog.FileName)
                    ' Agregar nombres de columna
                    Dim headerRow As String = ""
                    For Each columnHeader As ColumnHeader In LstvContentData.Columns
                        headerRow += columnHeader.Text & vbTab
                    Next
                    writer.WriteLine(headerRow.TrimEnd(vbTab))

                    ' Agregar datos del ListView
                    For Each item As ListViewItem In LstvContentData.Items
                        Dim row As String = ""
                        For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                            row += subItem.Text & vbTab
                        Next
                        writer.WriteLine(row.TrimEnd(vbTab))
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error al guardar el archivo de texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LstvContentData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstvContentData.SelectedIndexChanged

    End Sub
End Class
