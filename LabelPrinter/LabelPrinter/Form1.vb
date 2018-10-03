
Option Strict On
Option Infer On
Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Net.NetworkInformation
Imports System.ComponentModel

Public Class Form1
    Dim zcode As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TextBox1.Text = IO.File.ReadAllText("C:\MonFichier.txt")
        'TBIPprt.Text = IO.File.ReadAllText("\\10.65.37.3\common\CONTRES\etiquettes\ZEBRAIP.ini")
        zcode = "~DG1~DG1" & vbCrLf
        zcode = zcode & "~DGCE1,00520,010,jL01CN01EL01HFEM0HFEL01HFEL01HFEK01IFEL0IFEK01IFEL0IFEK" & vbCrLf
        zcode = zcode & "07IFEK03IFEK0IFCL0IFEK01IFCL0IFEK07HFM03HF8L07HFM03HF8L0HFCM07FCM0HF8M0H" & vbCrLf
        zcode = zcode & "FCL01HFN0HF8L01FEN0HFM01FEM01HFM03FCM01FEM07FCM01FCM07F8M03F8M07FN03F8M0" & vbCrLf
        zcode = zcode & "7FN07F8M07FN07F8M07FN07JFEJ07FN07JFEJ0FEN07JFEJ0FEN07JFEJ0FEN07JFEJ07FN0" & vbCrLf
        zcode = zcode & "7JFEJ07FN07FCM07F8M03F8M07F8M03F8M07F8M03FCM03FCM03FCM03FCM01FEM01FEM01H" & vbCrLf
        zcode = zcode & "FM01FEM01HFM01HF8M07FCM0HF8M07FCM07FEM07HFM03FEM03HFM03HFEL01IFM0HFEM0IF" & vbCrLf
        zcode = zcode & "M0JFEK07IFEK03IFEK01IFEK03IFEK01IFEL07HFEL03HFEL03HFEL01HFEM03FEM03FEN03" & vbCrLf
        zcode = zcode & "CO0EH0" & vbCrLf
        zcode = zcode & "^XA" & vbCrLf
        zcode = zcode & "^COY,0^MMT^MD+0^PON^PON" & vbCrLf
        zcode = zcode & "^XZ" & vbCrLf
        zcode = zcode & "^XA" & vbCrLf
        zcode = zcode & "^PR3^FS" & vbCrLf
        zcode = zcode & "^FT20,20^A0N,56,44^FDreference^FS" & vbCrLf
        zcode = zcode & "^FT20,75^A0N,40,25^FDdescription^FS" & vbCrLf
        zcode = zcode & "^FT210,75^A0N,40,25^FDmesure^FS" & vbCrLf
        zcode = zcode & "^BY2,2.5^FS" & vbCrLf
        zcode = zcode & "^FT60,860^BCN,120,N,N,Y^FD>;codebarre^FS" & vbCrLf
        zcode = zcode & "^FT80,890^AAN,18,10^FDcodebarre^FS" & vbCrLf
        zcode = zcode & "^FT370,890^AAN,18,10^FDpays^FS" & vbCrLf
        zcode = zcode & "^FT100,590^BEN,80,Y,N^FDcodeean13^FS" & vbCrLf
        zcode = zcode & "^FT270,120^A0N,24,30^FDhauteurlargeur^FS" & vbCrLf
        zcode = zcode & "^FT270,150^A0N,24,30^FDepaisseur^FS" & vbCrLf
        zcode = zcode & "^FT270,210^A0N,51,34^FDpoids^FS" & vbCrLf
        zcode = zcode & "^FT270,270^A0N,51,34^FR^FDserie^FS" & vbCrLf
        zcode = zcode & "^FT20,675^A0N,24,30^FDref4^FS" & vbCrLf
        zcode = zcode & "^FT20,442^A0N,24,30^FDref1^FS" & vbCrLf
        zcode = zcode & "^FT20,472^A0N,24,30^FDref3^FS" & vbCrLf
        zcode = zcode & "^FT20,500^A0N,24,30^FDref2^FS" & vbCrLf
        zcode = zcode & "^FT20,430^XG.grf,1,1^FS" & vbCrLf
        zcode = zcode & "^FT320,600^XGCE1.grf,0.5,0.5^FS" & vbCrLf
        zcode = zcode & "^FT310,640^A0N,24,30^FDEN14428^FS" & vbCrLf
        zcode = zcode & "^PF0^FS" & vbCrLf
        zcode = zcode & "^PQ1,0,0,Y" & vbCrLf
        zcode = zcode & "^XZ" & vbCrLf
        zcode = zcode & "^XA" & vbCrLf
        zcode = zcode & "^ID.grf" & vbCrLf
        zcode = zcode & "^ID.grf" & vbCrLf
        zcode = zcode & "^XZ" & vbCrLf
        Comboprt.SelectedIndex = 0
        Call ChrgEtiCode()
    End Sub
    Public Sub ChrgEtiCode()
        TBCodeZebra.Text = zcode
        'TBCodeZebra.Text = IO.File.ReadAllText("\\10.65.37.3\common\CONTRES\etiquettes\ETI_EXT.txt")
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("reference", TBReference.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("description", TBDescription.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("mesure", TBmerusre.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("hauteurlargeur", TBHauteurLargeur.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("epaisseur", TBEpaisseur.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("poids", TBPoids.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("serie", TBSerie.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("ref1", TBRef1.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("ref2", TBRef2.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("ref3", TBref3.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("ref4", TBref4.Text)
        If Val(MaskedTextBox1.Text) > 0 Then
            TBCodeZebra.Text = TBCodeZebra.Text.Replace("codeean13", MaskedTextBox1.Text).Replace(" ", "")
        Else
            TBCodeZebra.Text = TBCodeZebra.Text.Replace("^FT100,590^BEN,80,Y,N^FDcodeean13^FS", "")
        End If
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("pays", TBpays.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("codebarre", TBcodeBarre.Text)
        If CheckBoxCE.Checked = False Then
            TBCodeZebra.Text = TBCodeZebra.Text.Replace("^FT320,600^XGCE1.grf,0.5,0.5^FS", "")
            TBCodeZebra.Text = TBCodeZebra.Text.Replace("^FT310,640^A0N,24,30^FDEN14428^FS", "")
        End If
    End Sub

    Private Sub TBReference_Validated(sender As Object, e As EventArgs) Handles TBReference.Validated
        TBReference.Text = TBReference.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBDescription_Validated(sender As Object, e As EventArgs) Handles TBDescription.Validated
        TBDescription.Text = TBDescription.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBmerusre_Validated(sender As Object, e As EventArgs) Handles TBmerusre.Validated
        TBmerusre.Text = TBmerusre.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBHauteurLargeur_Validated(sender As Object, e As EventArgs) Handles TBHauteurLargeur.Validated
        TBHauteurLargeur.Text = TBHauteurLargeur.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBEpaisseur_Validated(sender As Object, e As EventArgs) Handles TBEpaisseur.Validated
        TBEpaisseur.Text = TBEpaisseur.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBPoids_Validated(sender As Object, e As EventArgs) Handles TBPoids.Validated
        TBPoids.Text = TBPoids.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBSerie_Validated(sender As Object, e As EventArgs) Handles TBSerie.Validated
        TBSerie.Text = TBSerie.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBRef1_Validated(sender As Object, e As EventArgs) Handles TBRef1.Validated
        TBRef1.Text = TBRef1.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBRef2_Validated(sender As Object, e As EventArgs) Handles TBRef2.Validated
        TBRef2.Text = TBRef2.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub TBRef3_Validated(sender As Object, e As EventArgs) Handles TBref3.Validated
        TBref3.Text = TBref3.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub TBRef4_Validated(sender As Object, e As EventArgs) Handles TBref4.Validated
        TBref4.Text = TBref4.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBpays_Validated(sender As Object, e As EventArgs) Handles TBpays.Validated
        TBpays.Text = TBpays.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub TBcodeBarre_Validated(sender As Object, e As EventArgs) Handles TBcodeBarre.Validated
        Call ChrgEtiCode()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sendStatus As Boolean
        Dim remoteAddress As String = TBIPprt.Text
        Dim txt As String = TBCodeZebra.Text
        Dim clientSocket As New TcpClient
        Dim ip As IPAddress = IPAddress.Any
        Dim isIp As Boolean = IPAddress.TryParse(remoteAddress, ip)
        Dim remotePort As Integer = 9100
        With clientSocket
            Try
                If isIp Then    ' ip address
                    .Connect(IPAddress.Parse(remoteAddress), remotePort)
                Else            ' DNS name
                    .Connect(remoteAddress, remotePort)
                End If

                Dim data() As Byte = Encoding.ASCII.GetBytes(txt)
                .NoDelay = True
                .GetStream().Write(data, 0, data.Length)
                .GetStream().Close()

                .Close()
                sendStatus = True
            Catch ex As Exception
                MsgBox("sendData: " & ex.Message, MsgBoxStyle.Exclamation)
                sendStatus = False
            Finally
                'RaiseEvent 
            End Try
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TBReference.Text = ""
        TBDescription.Text = ""
        TBmerusre.Text = ""
        TBHauteurLargeur.Text = ""
        TBEpaisseur.Text = ""
        TBPoids.Text = ""
        TBSerie.Text = ""
        TBRef1.Text = ""
        TBRef2.Text = ""
        TBref3.Text = ""
        TBref4.Text = ""
        MaskedTextBox1.Text = ""
        TBcodeBarre.Text = "00000000000000000000"
        TBpays.Text = "FR"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Visible = True
        Me.Hide()
    End Sub

    Private Sub Comboprt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comboprt.SelectedIndexChanged
        If Form2.Comboprt.SelectedIndex <> Comboprt.SelectedIndex Then
            Form2.Comboprt.SelectedIndex = Comboprt.SelectedIndex
        End If
        Dim iplst = Split(Comboprt.Text, " ")
        TBIPprt.Text = iplst(0)
        'Form2.TBIPprt.Text = iplst(0)
    End Sub
End Class
