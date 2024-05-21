<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnOpen = New Button()
        txtDocument = New TextBox()
        lblLargestWord = New Label()
        SuspendLayout()
        ' 
        ' btnOpen
        ' 
        btnOpen.Location = New Point(146, 23)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(75, 23)
        btnOpen.TabIndex = 0
        btnOpen.Text = "Open"
        btnOpen.UseVisualStyleBackColor = True
        ' 
        ' txtDocument
        ' 
        txtDocument.Location = New Point(41, 65)
        txtDocument.Multiline = True
        txtDocument.Name = "txtDocument"
        txtDocument.Size = New Size(300, 139)
        txtDocument.TabIndex = 1
        ' 
        ' lblLargestWord
        ' 
        lblLargestWord.AutoSize = True
        lblLargestWord.Location = New Point(275, 218)
        lblLargestWord.Name = "lblLargestWord"
        lblLargestWord.Size = New Size(41, 15)
        lblLargestWord.TabIndex = 2
        lblLargestWord.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(405, 249)
        Controls.Add(lblLargestWord)
        Controls.Add(txtDocument)
        Controls.Add(btnOpen)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents txtDocument As TextBox
    Friend WithEvents lblLargestWord As Label

End Class
