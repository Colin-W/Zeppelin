Imports System.IO

Public Class Form6
    Private path As String = "C:\Users\Public\"

    Private Sub CrystalClearListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Form1.WebBrowser1.Navigate(ListBox1.SelectedItem)
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim a As String = My.Computer.FileSystem.ReadAllText(path & "webhistory.txt")
        'Dim b As String() = a.Split(vbNewLine)
        'ListBox1.Items.AddRange(b)
        loadHistory()
    End Sub

    Private Sub CrystalClearButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton1.Click
        ListBox1.Items.Clear()
        Using writer As StreamWriter = New StreamWriter("C:\Users\Public\webhistory.txt", False)
            writer.Write("")
        End Using
    End Sub
    Public Function loadHistory()
        Dim a As String = My.Computer.FileSystem.ReadAllText(path & "webhistory.txt")
        Dim b As String() = a.Split(vbNewLine)
        ListBox1.Items.AddRange(b)
    End Function
End Class