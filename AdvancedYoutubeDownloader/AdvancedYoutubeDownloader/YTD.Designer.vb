<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YTD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPathBrowse = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pbDownProg = New System.Windows.Forms.ProgressBar()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblDownloadStatus = New System.Windows.Forms.Label()
        Me.chkPlay = New System.Windows.Forms.CheckBox()
        Me.comboFormats = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReqDLnks = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDefVideoTit = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDefVideoTit)
        Me.GroupBox1.Controls.Add(Me.btnPathBrowse)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.pbDownProg)
        Me.GroupBox1.Controls.Add(Me.lblPercentage)
        Me.GroupBox1.Controls.Add(Me.lblDownloadStatus)
        Me.GroupBox1.Controls.Add(Me.chkPlay)
        Me.GroupBox1.Controls.Add(Me.comboFormats)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnReqDLnks)
        Me.GroupBox1.Controls.Add(Me.btnDownload)
        Me.GroupBox1.Controls.Add(Me.btnPaste)
        Me.GroupBox1.Controls.Add(Me.txtURL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 548)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video Downloader"
        '
        'btnPathBrowse
        '
        Me.btnPathBrowse.BackColor = System.Drawing.Color.Maroon
        Me.btnPathBrowse.Location = New System.Drawing.Point(459, 232)
        Me.btnPathBrowse.Name = "btnPathBrowse"
        Me.btnPathBrowse.Size = New System.Drawing.Size(98, 35)
        Me.btnPathBrowse.TabIndex = 10
        Me.btnPathBrowse.Text = "Browse"
        Me.btnPathBrowse.UseVisualStyleBackColor = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(160, 288)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(338, 30)
        Me.txtTitle.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Video Title: "
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(115, 237)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(338, 30)
        Me.txtPath.TabIndex = 9
        Me.txtPath.Text = "F:\"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Path: "
        '
        'pbDownProg
        '
        Me.pbDownProg.Location = New System.Drawing.Point(115, 482)
        Me.pbDownProg.Name = "pbDownProg"
        Me.pbDownProg.Size = New System.Drawing.Size(338, 23)
        Me.pbDownProg.TabIndex = 7
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(232, 453)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(108, 16)
        Me.lblPercentage.TabIndex = 6
        Me.lblPercentage.Text = "Percentage"
        '
        'lblDownloadStatus
        '
        Me.lblDownloadStatus.AutoSize = True
        Me.lblDownloadStatus.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloadStatus.Location = New System.Drawing.Point(216, 424)
        Me.lblDownloadStatus.Name = "lblDownloadStatus"
        Me.lblDownloadStatus.Size = New System.Drawing.Size(139, 18)
        Me.lblDownloadStatus.TabIndex = 6
        Me.lblDownloadStatus.Text = "Download Status"
        '
        'chkPlay
        '
        Me.chkPlay.AutoSize = True
        Me.chkPlay.Location = New System.Drawing.Point(348, 513)
        Me.chkPlay.Name = "chkPlay"
        Me.chkPlay.Size = New System.Drawing.Size(209, 25)
        Me.chkPlay.TabIndex = 5
        Me.chkPlay.Text = "Play When Complete"
        Me.chkPlay.UseVisualStyleBackColor = True
        '
        'comboFormats
        '
        Me.comboFormats.BackColor = System.Drawing.Color.Black
        Me.comboFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFormats.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboFormats.ForeColor = System.Drawing.SystemColors.Info
        Me.comboFormats.FormattingEnabled = True
        Me.comboFormats.Location = New System.Drawing.Point(230, 182)
        Me.comboFormats.Name = "comboFormats"
        Me.comboFormats.Size = New System.Drawing.Size(286, 23)
        Me.comboFormats.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Available Formats: "
        '
        'btnReqDLnks
        '
        Me.btnReqDLnks.BackColor = System.Drawing.Color.Maroon
        Me.btnReqDLnks.Location = New System.Drawing.Point(101, 91)
        Me.btnReqDLnks.Name = "btnReqDLnks"
        Me.btnReqDLnks.Size = New System.Drawing.Size(338, 35)
        Me.btnReqDLnks.TabIndex = 2
        Me.btnReqDLnks.Text = "Request Download Links"
        Me.btnReqDLnks.UseVisualStyleBackColor = False
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.Maroon
        Me.btnDownload.Location = New System.Drawing.Point(115, 375)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(338, 35)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.Maroon
        Me.btnPaste.Location = New System.Drawing.Point(445, 32)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(98, 35)
        Me.btnPaste.TabIndex = 2
        Me.btnPaste.Text = "Paste"
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(101, 36)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(338, 30)
        Me.txtURL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "URL: "
        '
        'lblDefVideoTit
        '
        Me.lblDefVideoTit.AutoSize = True
        Me.lblDefVideoTit.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefVideoTit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDefVideoTit.Location = New System.Drawing.Point(43, 144)
        Me.lblDefVideoTit.Name = "lblDefVideoTit"
        Me.lblDefVideoTit.Size = New System.Drawing.Size(111, 23)
        Me.lblDefVideoTit.TabIndex = 11
        Me.lblDefVideoTit.Text = "[Video Title]"
        '
        'YTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(644, 572)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "YTD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtube Video Downloader"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPaste As Button
    Friend WithEvents txtURL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReqDLnks As Button
    Friend WithEvents comboFormats As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents pbDownProg As ProgressBar
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblDownloadStatus As Label
    Friend WithEvents chkPlay As CheckBox
    Friend WithEvents btnPathBrowse As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDefVideoTit As Label
End Class
