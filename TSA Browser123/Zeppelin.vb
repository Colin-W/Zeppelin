Imports System.IO
Imports System.Net

Public Class Form1
    Private path As String = "C:\Users\Public\"
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort
    Private Declare Auto Function InternetSetOption Lib "wininet.dll" (ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, ByVal lpdwBufferLength As Integer) As Boolean
    Public Structure Struct_INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public proxy As IntPtr
        Public proxyBypass As IntPtr
    End Structure
    Sub RefreshIESettings(ByVal strProxy As String)
        Const INTERNET_OPTION_PROXY As Integer = 38
        Const INTERNET_OPEN_TYPE_PROXY As Integer = 3
        Dim s_IPI As Struct_INTERNET_PROXY_INFO
        s_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY
        s_IPI.proxy = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(strProxy)
        s_IPI.proxyBypass = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi("Global")
        Dim intptrStruct As IntPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Runtime.InteropServices.Marshal.SizeOf(s_IPI))
        System.Runtime.InteropServices.Marshal.StructureToPtr(s_IPI, intptrStruct, True)
        InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, System.Runtime.InteropServices.Marshal.SizeOf(s_IPI))
    End Sub

    Private Sub CrystalClearButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton1.Click
        WebBrowser1.Navigate(CrystalClearTextBox1.Text)
    End Sub

    Private Sub CrystalClearButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton2.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub CrystalClearButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub CrystalClearButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton4.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub CrystalClearButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton5.Click
        If System.IO.File.Exists("C:\Users\Public\url.txt") = True Then
            Dim objreader As New System.IO.StreamReader("C:\Users\Public\url.txt")
            CrystalClearTextBox1.Text = objreader.ReadToEnd
            WebBrowser1.Navigate(CrystalClearTextBox1.Text)
            objreader.Close()
        Else
            MessageBox.Show("You don't have a home set!")
        End If
    End Sub

    Private Sub CrystalClearButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton6.Click
        WebBrowser1.Navigate("http://www.google.com/#sclient=psy-ab&hl=en&site=&source=hp&q=" + CrystalClearTextBox2.Text + "&oq=" + CrystalClearTextBox2.Text + "&gs_l=hp.3..0l4.1409.1663.0.2220.4.4.0.0.0.0.256.757.0j3j1.4.0.les;..0.0...1c.1.5.psy-ab.Ql5VwkvBFNU&pbx=1&bav=on.2,or.&bvm=bv.43287494,d.dmg&fp=7086776448bdb478&biw=1129&bih=554")
    End Sub

    Private Sub CrystalClearButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalClearButton7.Click
        Using writer As StreamWriter = New StreamWriter("C:\Users\Public\url.txt", False)
            writer.Write(CrystalClearTextBox1.Text)
        End Using
        MsgBox("You successfullly set this as your home page")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("C:\Users\Public\url.txt") = True Then
            Dim objreader As New System.IO.StreamReader("C:\Users\Public\url.txt")
            CrystalClearTextBox1.Text = objreader.ReadToEnd
            WebBrowser1.Navigate(CrystalClearTextBox1.Text)
            objreader.Close()
        Else
            WebBrowser1.Navigate("www.google.com")
        End If
        File.Create(path + "webhistory.txt").Dispose()
        File.Create(path + "bookmarks.txt").Dispose()
    End Sub

    Private Sub CrystalClearTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = Keys.Enter Then
            WebBrowser1.Navigate(CrystalClearTextBox1.Text)
        End If
    End Sub

    Private Sub CrystalClearTextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = Keys.Enter Then
            WebBrowser1.Navigate("https://www.google.com/#hl=en&safe=off&tbo=d&output=search&sclient=psy-ab&q=" + CrystalClearTextBox2.Text + "&oq=" + CrystalClearTextBox2.Text + "&gs_l=hp.3..0l4.1028.1278.0.1467.4.4.0.0.0.0.233.722.0j3j1.4.0.les%3B..0.0...1c.1.GV5PmtdQA8E&pbx=1&bav=on.2,or.r_gc.r_pw.r_cp.r_qf.&fp=590195a7cf0fc162&bpcl=39580677&biw=1600&bih=799")
        End If
    End Sub

    Private Sub ProxyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.Show()
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        CrystalClearTextBox1.ResetText()
        CrystalClearTextBox1.Text = WebBrowser1.Url.ToString

        Dim FILE_NAME As String = "C:\Users\Public\webhistory.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(CrystalClearTextBox1.Text)
            objWriter.Close()
        End If
        Dim lines As String() = IO.File.ReadAllLines("C:\Users\Public\webhistory.txt")
        lines = lines.Distinct().ToArray()
        IO.File.WriteAllLines("C:\Users\Public\webhistory.txt", lines)
        Form6.loadHistory()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub ProxyToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProxyToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookmarksToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class
