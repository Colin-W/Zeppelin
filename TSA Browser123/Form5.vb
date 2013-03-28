Imports System.IO

Public Class Form5
    Private path As String = "C:\Users\Public\"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using writer As StreamWriter = New StreamWriter("C:\Users\Public\bookmarks.txt", True)
            writer.WriteLine(TextBox1.Text)
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim a As String = My.Computer.FileSystem.ReadAllText(path & "bookmarks.txt")
        Dim b As String() = a.Split(vbNewLine)
        ListBox1.Items.AddRange(b)
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Dim a As String = My.Computer.FileSystem.ReadAllText(path & "bookmarks.txt")
        Dim b As String() = a.Split(vbNewLine)
        ListBox1.Items.AddRange(b)
        File.Create(path + "bookmarks.txt").Dispose()
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Form1.WebBrowser1.Navigate(ListBox1.SelectedItem)
    End Sub
End Class