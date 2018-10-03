Imports System.Security.Cryptography
Imports System.Net.NetworkInformation
Public Class Form1
    Public NotInheritable Class Simple3Des
        Private TripleDes As New TripleDESCryptoServiceProvider
        Private Function TruncateHash(
            ByVal key As String,
            ByVal length As Integer) As Byte()
            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function
        Sub New(ByVal key As String)
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        End Sub
        Public Function EncryptData(
    ByVal plaintext As String) As String

            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        End Function
        Public Function DecryptData(
            ByVal encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms,
                TripleDes.CreateDecryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
        End Function
    End Class


    Sub TestEncoding()
        Dim plainText As String = TextBox1.Text
        Dim password As String = TxPassword.Text
        TextBox2.Text = ""
        Dim wrapper As New Simple3Des(password)
        Dim cipherText As String = wrapper.EncryptData(plainText)
        TextBox2.Text = cipherText
        'MsgBox("The cipher text is: " & cipherText)
        'My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\cipherText.txt", cipherText, False)
        My.Computer.Clipboard.SetText(cipherText)
    End Sub

    Sub TestDecoding()
        'Dim cipherText As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\cipherText.txt")
        Dim cipherText As String = TextBox2.Text
        Dim password As String = TxPassword.Text
        Dim wrapper As New Simple3Des(password)
        TextBox1.Text = ""
        ' DecryptData throws if the wrong password is used.
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            TextBox1.Text = plainText
            'MsgBox("The plain text is: " & plainText)
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TestEncoding()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestDecoding()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TxPassword.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        'Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
        'MsgBox(test)
        TxPassword.Text = GetDriveSerialNumber() & getMacAddress() ' met le numéro de serie du hdd comme pass par défaut concaténé avec la mac adress

    End Sub

    'recupere un process exemple netstat
    'Dim truc As New System.Diagnostics.Process()
    'truc.StartInfo.RedirectStandardOutput = True ' on redirige le flux de la console
    'truc.StartInfo.UseShellExecute = False ' pour que le flux arrive vers notre textbox
    'truc.StartInfo.CreateNoWindow = True ' true pour ne pas avoir la fenetre noire, false pour l'avoir
    'truc.StartInfo.Arguments = ("-an")
    'truc.StartInfo.FileName = ("C:\Windows\System32\NETSTAT.EXE")
    'truc.Start()
    'Me.TextBox1.Text = truc.StandardOutput.ReadToEnd ' on affiche le flux que nous avons préalablement redirigé
    Public Function GetDriveSerialNumber() As String
        Dim DriveSerial As Integer
        'Create a FileSystemObject object
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        Return DriveSerial.ToString("X2")
    End Function
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function

End Class
