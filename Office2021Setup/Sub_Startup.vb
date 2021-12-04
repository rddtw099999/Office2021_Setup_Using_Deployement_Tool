Imports Microsoft.Win32
Imports System.IO

Public Class Sub_Startup
    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property


    Private Sub Btn_Uninstall_Click(sender As Object, e As EventArgs) Handles Btn_Uninstall.Click
        If System.IO.File.Exists("bin\uninstall.diagcab") = True Then
            Dim loc As String = Path.GetTempPath() + "uninstall.diagcab"
            File.Copy("bin\uninstall.diagcab", loc, True)   '相對路徑問題，顯把檔案複製到temp

            Shell("cmd /c msdt /cab " + Chr(34) + loc + Chr(34))
        Else
            MessageBox.Show("could not find uninstall.diacab , please check setup files integrity.", "Error occured", MessageBoxButtons.OK)
        End If


    End Sub


    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '=================  registry key check ==============
        Dim Reg As RegistryKey
        Reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft", True)
        If Reg.GetSubKeyNames().Contains("Office") = True Then
            Btn_Uninstall.Visible = True
            Label6.Visible = True
        End If
        ' ==========================================================



    End Sub


    Private Sub Btn_install_Click(sender As Object, e As EventArgs) Handles Btn_install.Click

        Dim Reg As RegistryKey
        Reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft", True)

        If Reg.GetSubKeyNames().Contains("Office") = True Then
            _Dialogue.Show()
        Else
            Main_Installer.Show()
            'Me.Close()
        End If

        Me.Close()
    End Sub

    Private Sub Btn_Troubleshooting_Click(sender As Object, e As EventArgs) Handles Btn_Troubleshooting.Click
        Sub_Troubleshoot.Show()
        Me.Close()

    End Sub


    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click
        Close()
    End Sub
End Class