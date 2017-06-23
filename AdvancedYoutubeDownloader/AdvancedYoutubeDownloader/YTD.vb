Imports YoutubeExtractor
Imports System.Net

Public Class YTD

    Dim wc As WebClient
    Dim strArrayLinks(), strArrayExts(), strDefTitle, strFullPath As String

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        txtURL.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub btnReqDLnks_Click(sender As Object, e As EventArgs) Handles btnReqDLnks.Click
        Dim vInfos As IEnumerable(Of VideoInfo)
        vInfos = DownloadUrlResolver.GetDownloadUrls(txtURL.Text, False)

        comboFormats.Items.Clear()

        Dim listDL As New List(Of String)
        Dim listExt As New List(Of String)

        Dim blnFlag As Boolean = True
        For Each vi As VideoInfo In vInfos
            If blnFlag = True Then
                strDefTitle = vi.Title
                blnFlag = False
            End If
            Dim strQuality As String
            strQuality = "Resoultion: " & vi.Resolution & " Format: " & vi.VideoExtension
            comboFormats.Items.Add(strQuality)

            'If the video has a decrypted signature, decipher it
            If vi.RequiresDecryption Then
                DownloadUrlResolver.DecryptDownloadUrl(vi)
            End If

            listDL.Add(vi.DownloadUrl)
            listExt.Add(vi.VideoExtension)

        Next
        strArrayLinks = listDL.ToArray
        strArrayExts = listExt.ToArray

        lblDefVideoTit.Text = strDefTitle
    End Sub

    Private Sub btnPathBrowse_Click(sender As Object, e As EventArgs) Handles btnPathBrowse.Click
        Dim fldBrowse As New FolderBrowserDialog
        If fldBrowse.ShowDialog() = DialogResult.OK Then
            txtPath.Text = fldBrowse.SelectedPath
        Else
            txtPath.Text = "C:\"
        End If
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        txtTitle.SelectAll()
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        wc = New WebClient()
        AddHandler wc.DownloadProgressChanged, AddressOf downloadPC
        AddHandler wc.DownloadFileCompleted, AddressOf downloadComp
        If txtTitle.Text = "" Then
            strFullPath = txtPath.Text & "\" & strDefTitle & strArrayExts(comboFormats.SelectedIndex)
            wc.DownloadFileAsync(New Uri(strArrayLinks(comboFormats.SelectedIndex)), strFullPath)
        Else
            strFullPath = txtPath.Text & "\" & txtTitle.Text & strArrayExts(comboFormats.SelectedIndex)
            wc.DownloadFileAsync(New Uri(strArrayLinks(comboFormats.SelectedIndex)), strFullPath)
        End If
    End Sub

    Private Sub downloadPC(sender As Object, e As DownloadProgressChangedEventArgs)
        pbDownProg.Value = e.ProgressPercentage
        lblPercentage.Text = e.ProgressPercentage.ToString() & "%"
        lblDownloadStatus.Text = String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
        '1 Bytes = 1024 Kilo Bytes
        '1 Kilo Bytes = 1024 Mega Bytes
    End Sub

    Private Sub downloadComp(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        MessageBox.Show("Your Download is Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If chkPlay.Checked = True Then
            Process.Start(strFullPath)
        End If
    End Sub

End Class
