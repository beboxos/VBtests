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

Public Class Form2
    Dim zcode As String = ""


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Visible = True
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TBIPprt.Text = IO.File.ReadAllText("\\10.65.37.3\common\CONTRES\etiquettes\ZEBRAIP.ini")
        zcode = "~DGce,01392,016,N0JFCR03JFO07JFCQ01KFN01KFCQ07KFN07KFCP01LFM01LFCP07LFM0" & vbCrLf
        zcode = zcode & "7LFCP0MFM0MFCO03MFL01MFCO07MFL07MFCO0NFL0NFCN01NFK01NFCN03NFK03NFCN07NFK" & vbCrLf
        zcode = zcode & "07LFQ0LFCM07KFQ01KFEN0KFCQ03KFN01KFR07JFCN03JFCR07JFO03JFS0JFEO07IFER01J" & vbCrLf
        zcode = zcode & "FCO0JFCR01JFP0JF8R03IFEO01JFS03IFCO01IFES07IFCO03IFCS07IF8O03IFCS0JFP03I" & vbCrLf
        zcode = zcode & "F8S0IFEP07IFT0IFEP07IFS01IFCP07HFES01IFCP0IFES01IF8P0IFCS01IF8P0IFCS03IF" & vbCrLf
        zcode = zcode & "Q0IFCS03IFQ0IF8S03OFJ01IF8S03OFJ01IF8S03OFJ01IF8S03OFJ01IF8S03OFJ01IF8S0" & vbCrLf
        zcode = zcode & "7OFJ01IF8S07OFJ01IF8S07OFJ01IF8S07OFJ01IF8S07OFJ01IF8S03OFJ01IF8S03OFJ01" & vbCrLf
        zcode = zcode & "IF8S03OFJ01IF8S03OFK0IFCS03IFQ0IFCS03IFQ0IFCS03IF8P0IFES01IF8P0IFES01IF8" & vbCrLf
        zcode = zcode & "P07HFES01IFCP07IFS01IFCP07IF8S0IFEP03IF8S0JFP03IFCS07IFP01IFES07IF8O01IF" & vbCrLf
        zcode = zcode & "ES07IFCP0JFS03IFEP0JF8R03JFP07IFCR01JF8O07JFS0JFCO03JF8R0JFEO01JFCR07JF8" & vbCrLf
        zcode = zcode & "N01KFR03JFEO0KFCQ03KF8N07KF8P01KFEN03LFC1CN0MF03K01NFCN07NFL0NFCN03NFL07" & vbCrLf
        zcode = zcode & "MFCN01NFL03MFCO0NFL01MFCO07MFM0MFCO01MFM03LFCP0MFN0LFCP03LFN07KFCQ0LFN01" & vbCrLf
        zcode = zcode & "KFCQ03KFO03JFCR0KFP07IFCR01JFQ07HFCS01IFnH0" & vbCrLf
        zcode = zcode & "^XA" & vbCrLf
        zcode = zcode & "^LH0,0" & vbCrLf
        zcode = zcode & "^PR3^FS" & vbCrLf
        zcode = zcode & "^PF0^FS" & vbCrLf
        zcode = zcode & "^FT20,60^A0N,34,45^FDl01^FS" & vbCrLf
        zcode = zcode & "^FT20,100^ABN,25,15^FD^FS" & vbCrLf
        zcode = zcode & "^FT20,130^ABN,25,15^FD^FS" & vbCrLf
        zcode = zcode & "^FT20,170,^ABN,25,15^FDl02^FS" & vbCrLf
        zcode = zcode & "^FT20,200,^ABN,25,15^FDl03^FS" & vbCrLf
        zcode = zcode & "^FT20,230^ABN,25,15^FD^FS" & vbCrLf
        zcode = zcode & "^FT20,270^ABN,25,5^FDl04^FS" & vbCrLf
        zcode = zcode & "^FT20,300^ABN,25,5^FDl05^FS" & vbCrLf
        zcode = zcode & "^FT20,330^ABN,25,5^FDl06^FS" & vbCrLf
        zcode = zcode & "^FT380,310^GB100,0,60^FS" & vbCrLf
        zcode = zcode & "^FT390,300^A0N,34,50^FR^FDl07^FS" & vbCrLf
        zcode = zcode & "^FT20,340^GB500,0,8^FS" & vbCrLf
        zcode = zcode & "^FT20,370^ABN,25,15^FDCl.: l08^FS" & vbCrLf
        zcode = zcode & "^FT20,400^ABN,25,15^FDl09^FS" & vbCrLf
        zcode = zcode & "^FT20,440^ABN,25,15^FDl10^FS" & vbCrLf
        zcode = zcode & "^FT20,470^ABN,25,15^FD                       ^FS" & vbCrLf
        zcode = zcode & "^FT20,530^ABN,25,15^FDl11^FS" & vbCrLf
        zcode = zcode & "^FT400,730^GB100,0,55^FS" & vbCrLf
        zcode = zcode & "^FT400,727^A0N,65,65^FR^FDl17^FS" & vbCrLf
        zcode = zcode & "^FT20,560^ABN,25,15^FDTel.: l12^FS" & vbCrLf
        zcode = zcode & "^FT20,600^ABN,25,15^FDRef:l13^FS" & vbCrLf
        zcode = zcode & "^FT20,640^ABN,25,15^FDl14^FS" & vbCrLf
        zcode = zcode & "^FT20,670^ABN,25,15^FDl15^FS" & vbCrLf
        zcode = zcode & "^FT20,730^GB320,0,55^FS" & vbCrLf
        zcode = zcode & "^FT20,727^A0N,65,65^FR^FDl16^FS" & vbCrLf
        zcode = zcode & "^FT20,750^A0N,20,30^FDID.COLLO:^FS" & vbCrLf
        zcode = zcode & "^FT280,750^A0N,20,30^FDl18^FS" & vbCrLf
        zcode = zcode & "^FT380,750^A0N,20,30^FDl19^FS" & vbCrLf
        zcode = zcode & "^FT20,780^ABN,25,15^FDl20^FS" & vbCrLf
        zcode = zcode & "^BY3^FS" & vbCrLf
        zcode = zcode & "^FT100,940^BEN,150,Y,N^FDl21^FS" & vbCrLf
        zcode = zcode & "^FO180,1000^XGce.grf,1,1^FS" & vbCrLf
        zcode = zcode & "^FT188,1100^A0N,20,20^FDProdotto in^FS" & vbCrLf
        zcode = zcode & "^FT128,1125^A0N,20,20^FDVia Mantova 1023 -46030^FS" & vbCrLf
        zcode = zcode & "^FT98,1150^A0N,20,20^FDRomanore di Borgo Virgilio Mantova Italy^FS" & vbCrLf
        zcode = zcode & "^FT228,1200^A0N,30,30^FD07^FS" & vbCrLf
        zcode = zcode & "^FT138,1225^A0N,30,30^FDEN14428:2015^FS" & vbCrLf
        zcode = zcode & "^FT138,1250^A0N,25,25^FDPerformance Level 4^FS" & vbCrLf
        zcode = zcode & "^FT168,1275^A0N,25,25^FDDOp-B3460^FS" & vbCrLf
        zcode = zcode & "^PQ1,0,1,Y" & vbCrLf
        zcode = zcode & "^XZ" & vbCrLf
        ' -----------------
        Call ChrgEtiCode()
    End Sub
    Public Sub ChrgEtiCode()
        TBCodeZebra.Text = zcode
        'TBCodeZebra.Text = IO.File.ReadAllText("\\10.65.37.3\common\CONTRES\etiquettes\ETI_EXP.txt")
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l01", l1.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l02", l2.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l03", l3.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l04", l4.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l05", l5.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l06", l6.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l07", l7.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l08", l8.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l09", l9.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l10", l10.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l11", l11.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l12", l12.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l13", l13.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l14", l14.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l15", l15.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l16", l16.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l17", l17.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l18", l18.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l19", l19.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l20", l20.Text)
        TBCodeZebra.Text = TBCodeZebra.Text.Replace("l21", l21.Text)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Call ChrgEtiCode()
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

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Visible = True
        Me.Hide()
    End Sub

    Private Sub l1_Validated(sender As Object, e As EventArgs) Handles l1.Validated
        l1.Text = l1.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l2_Validated(sender As Object, e As EventArgs) Handles l2.Validated
        l2.Text = l2.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l3_Validated(sender As Object, e As EventArgs) Handles l3.Validated
        l3.Text = l3.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l4_Validated(sender As Object, e As EventArgs) Handles l4.Validated
        l4.Text = l4.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l5_Validated(sender As Object, e As EventArgs) Handles l5.Validated
        l5.Text = l5.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l6_Validated(sender As Object, e As EventArgs) Handles l6.Validated
        l6.Text = l6.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l7_Validated(sender As Object, e As EventArgs) Handles l7.Validated
        l7.Text = l7.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l8_Validated(sender As Object, e As EventArgs) Handles l8.Validated
        l8.Text = l8.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l9_Validated(sender As Object, e As EventArgs) Handles l9.Validated
        l9.Text = l9.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l10_Validated(sender As Object, e As EventArgs) Handles l10.Validated
        l10.Text = l10.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l11_Validated(sender As Object, e As EventArgs) Handles l11.Validated
        l11.Text = l11.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l12_Validated(sender As Object, e As EventArgs) Handles l12.Validated
        l12.Text = l12.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l13_Validated(sender As Object, e As EventArgs) Handles l13.Validated
        l13.Text = l13.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l14_Validated(sender As Object, e As EventArgs) Handles l14.Validated
        l14.Text = l14.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l15_Validated(sender As Object, e As EventArgs) Handles l15.Validated
        l15.Text = l15.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l16_Validated(sender As Object, e As EventArgs) Handles l16.Validated
        l16.Text = l16.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l17_Validated(sender As Object, e As EventArgs) Handles l17.Validated
        l17.Text = l17.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l18_Validated(sender As Object, e As EventArgs) Handles l18.Validated
        l18.Text = l18.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l19_Validated(sender As Object, e As EventArgs) Handles l19.Validated
        l19.Text = l19.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l20_Validated(sender As Object, e As EventArgs) Handles l20.Validated
        l20.Text = l20.Text.ToUpper
        Call ChrgEtiCode()
    End Sub
    Private Sub l21_Validated(sender As Object, e As EventArgs) Handles l21.Validated
        l21.Text = l21.Text.ToUpper
        Call ChrgEtiCode()
    End Sub

    Private Sub Comboprt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comboprt.SelectedIndexChanged
        If Form1.Comboprt.SelectedIndex <> Comboprt.SelectedIndex Then
            Form1.Comboprt.SelectedIndex = Comboprt.SelectedIndex
        End If
        Dim iplst = Split(Comboprt.Text, " ")
        TBIPprt.Text = iplst(0)
        'Form1.TBIPprt.Text = iplst(0)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        l1.Text = ""
        l2.Text = ""
        l3.Text = ""
        l4.Text = ""
        l5.Text = ""
        l6.Text = ""
        l7.Text = ""
        l8.Text = ""
        l9.Text = ""
        l10.Text = ""
        l11.Text = ""
        l12.Text = ""
        l13.Text = ""
        l14.Text = ""
        l15.Text = ""
        l16.Text = ""
        l17.Text = ""
        l18.Text = ""
        l19.Text = ""
        l20.Text = ""
        l21.Text = "000000000000"
        Call ChrgEtiCode()
    End Sub
End Class