Imports System.Reflection
Imports System.IO
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDocument.TextChanged

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.Filter = "DOCX FILE |*.docx"

        If openfiledialog.ShowDialog() = DialogResult.OK Then
            Using WordDocument As WordprocessingDocument = WordprocessingDocument.Open(openfiledialog.FileName, False)
                Dim body As New Body
                body = WordDocument.MainDocumentPart.Document.Body
                Dim text As String = ""

                For Each paragraph As Paragraph In body.Elements(Of Paragraph)()
                    For Each run As Run In paragraph.Elements(Of Run)()
                        For Each textElement As Text In run.Elements(Of Text)()
                            text += textElement.Text
                        Next
                    Next
                Next

                txtDocument.Text = text

                Dim Words() As String = text.Split({" ", vbTab, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                Dim LargestWord As String = ""
                For Each Word As String In Words
                    If Word.Length > LargestWord.Length Then
                        LargestWord = Word
                    End If
                Next
                lblLargestWord.Text = "Largest Word: " + LargestWord

            End Using
        End If


    End Sub
End Class
