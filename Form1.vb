Public Class Form1
    Public temppath As String
    Public GoGoGadgetLoader As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        temppath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"
        temppath = temppath & "\iREB"
        Folder_Delete(temppath)
        Create_Directory(temppath)
        If File_Exists(temppath & "\iREB.exe") = True Then
            Application.Exit()
        Else
            SaveToDisk("iREB.exe", temppath & "\iREB.exe")
            GoGoGadgetLoader = temppath & "\iREB.exe"
            Dim Go As New ProcessStartInfo(GoGoGadgetLoader)
            Go.WorkingDirectory = temppath
            Process.Start(Go)
            Me.Dispose()
        End If
    End Sub
End Class
