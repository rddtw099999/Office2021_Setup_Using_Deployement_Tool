Imports System.IO
Public Class _Dialogue
    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main_Installer.Show()
        Me.Close()
    End Sub

    Private Sub Dialogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists("bin\uninstall.diagcab") = True Then
            File.Copy("bin\uninstall.diagcab", Path.GetTempPath() + "uninstall.diagcab", True)   '相對路徑問題，顯把檔案複製到temp
            Shell("cmd /c msdt /cab " & Chr(34) + Path.GetTempPath() + "uninstall.diagcab" + Chr(34))

            Sub_Startup.Show()
            Me.Close()
        Else
            MessageBox.Show("Could not find uninstall.diagcab , please check setup files integrity.", "Error occured", MessageBoxButtons.OK)
        End If
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class