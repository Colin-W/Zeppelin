Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.RefreshIESettings(CrystalClearTextBox1.Text)
        Me.Close()
    End Sub
End Class