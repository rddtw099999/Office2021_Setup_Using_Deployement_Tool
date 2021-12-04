Imports System.IO

Public Class Sub_Troubleshoot
    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Sub_Startup.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Uninstaller_Click(sender As Object, e As EventArgs) Handles Btn_Uninstaller.Click
        If System.IO.File.Exists("bin\uninstall.diagcab") = True Then
            File.Copy("bin\uninstall.diagcab", Path.GetTempPath() + "uninstall.diagcab", True)   '相對路徑問題，顯把檔案複製到temp
            Shell("cmd /c msdt /cab " & Chr(34) + Path.GetTempPath() + "uninstall.diagcab" + Chr(34))
        Else
            MessageBox.Show("Could not find  uninstall.diagcab, please check setup files integrity.", "Error occured", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Btn_DotNetFixUp_Click(sender As Object, e As EventArgs) Handles Btn_DotNetFixUp.Click
        If System.IO.File.Exists("bin\dotnetfix.exe") = True Then
            Process.Start("bin\dotnetfix.exe")
        Else
            MessageBox.Show("Could not find  dotnetfix.exe, please check setup files integrity.", "Error occured", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Close()
    End Sub

End Class