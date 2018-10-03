Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fichier As String = ""
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            TextBoxSource.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxDestination.Text = ""
        TextBoxSource.Text = ""
        TextBoxVarName.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxVarName.Text = "" Then
            MsgBox("Nom de la variable non renseigné", vbCritical)
            Exit Sub
        End If
        If TextBoxSource.Text = "" Then
            MsgBox("Aucun texte source", vbCritical)
            Exit Sub
        End If
        Dim tempo As Array = Split(TextBoxSource.Text, vbCrLf)
        TextBoxDestination.Text = "Dim " & TextBoxVarName.Text & " as String = vbEmpty" & vbCrLf
        For n = LBound(tempo) To UBound(tempo) - 1
            TextBoxDestination.Text = TextBoxDestination.Text & TextBoxVarName.Text & " = " & TextBoxVarName.Text & " & """ & tempo(n).ToString.Replace("""", """""") & """ & vbCrLf" & vbCrLf
        Next n
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        TextBoxSource.Width = Me.Width - 43
        TextBoxDestination.Width = Me.Width - 43
        TextBoxDestination.Height = Me.Height - 241
    End Sub
End Class
