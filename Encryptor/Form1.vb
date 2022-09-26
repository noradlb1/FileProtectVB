Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Security.Cryptography

Namespace Encryptor
	Partial Public Class Encryptor
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			'Add files
			Dim filepath As New OpenFileDialog()
			filepath.Title = "Select File"
			filepath.InitialDirectory = "C:\"
			filepath.Filter = "All files (*.*)|*.*"
			filepath.Multiselect = True
			filepath.FilterIndex = 1
			filepath.ShowDialog()
			For Each file As String In filepath.FileNames
				listBox1.Items.Add(file) 'add file path to the listbox
			Next file
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			'Add folders
			Dim folderpath As New FolderBrowserDialog()
			folderpath.ShowDialog()
			listBox2.Items.Add(folderpath.SelectedPath)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Try
				listBox1.Items.Remove(listBox1.SelectedItem)
			Catch
			End Try
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			Try
				listBox2.Items.Remove(listBox2.SelectedItem)
			Catch
			End Try
		End Sub

		Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button7.Click
			'Clear values from listbox1, 2 and password text line
			listBox1.Items.Clear()
			listBox2.Items.Clear()
			textBox1.Text = ""
		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
			Dim msgbox = MessageBox.Show("This feature will encrypt selected files. Please write down your password or else you cannot revert this action. Continue?", "FileProtect™",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
			If msgbox = System.Windows.Forms.DialogResult.Yes Then
				'This function will encrypt selected files
				'Password must have 8 characters!
				Try
					If textBox1.Text.Length < 8 Then
						MessageBox.Show("Password must have 8 characters!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
					'This is for selected files
					If listBox1.Items.Count > 0 Then
						For num As Integer = 0 To listBox1.Items.Count - 1
							Dim e_file As String = "" & listBox1.Items(num)
							If (Not e_file.Trim().EndsWith(".!LOCKED")) AndAlso File.Exists(e_file) Then
								EncryptFile("" & listBox1.Items(num), "" & listBox1.Items(num) & ".!LOCKED", textBox1.Text)
								File.Delete("" & listBox1.Items(num))
							End If
						Next num
					End If
					'This is for selected folders
					If listBox2.Items.Count > 0 Then
						For num As Integer = 0 To listBox2.Items.Count - 1
							Dim d_file As String = "" & listBox2.Items(num)
							Dim get_files() As String = Directory.GetFiles(d_file)
							For Each name_file As String In get_files
								If (Not name_file.Trim().EndsWith(".!LOCKED")) AndAlso File.Exists(name_file) Then
									EncryptFile(name_file, name_file & ".!LOCKED", textBox1.Text)
									File.Delete(name_file)
								End If
							Next name_file
						Next num
					End If
				Catch

				End Try
				MessageBox.Show("File encription finished", "FileProtect™", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
			End If
		End Sub

		Private mychar() As Char = { "!"c, "."c, "L"c, "O"c, "C"c, "K"c, "E"c, "D"c }

		Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button6.Click
			Dim msgbox = MessageBox.Show("This will return the files you encrypted before. Please double check your password, because entering a wrong password will result in damaged files. Continue?", "FileProtect™",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
			If msgbox = System.Windows.Forms.DialogResult.Yes Then
				'This function will decrypt selected files
				'Password must have 8 characters!
				'Password must be correct!
				Try
					If textBox1.Text.Length < 8 Then
						MessageBox.Show("Password must have 8 characters!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
					'This is for selected files
					If listBox1.Items.Count > 0 Then
						For num As Integer = 0 To listBox1.Items.Count - 1
							Dim e_file As String = "" & listBox1.Items(num)
							If e_file.Trim().EndsWith(".!LOCKED") AndAlso File.Exists(e_file) Then
								DecryptFile(e_file, e_file.TrimEnd(mychar), textBox1.Text)
								File.Delete(e_file)
							End If
						Next num
					End If
					'This is for selected folders
					If listBox2.Items.Count > 0 Then
						For num As Integer = 0 To listBox2.Items.Count - 1
							Dim d_file As String = "" & listBox2.Items(num)
							Dim get_files() As String = Directory.GetFiles(d_file)
							For Each name_file As String In get_files
								If name_file.Trim().EndsWith(".!LOCKED") AndAlso File.Exists(name_file) Then
									DecryptFile(name_file, name_file.TrimEnd(mychar), textBox1.Text)
									File.Delete(name_file)
								End If
							Next name_file
						Next num
					End If
				Catch

				End Try
				MessageBox.Show("File decription finished", "FileProtect™",MessageBoxButtons.OK,MessageBoxIcon.Information)
			End If
		End Sub

		Private Sub DecryptFile(ByVal inputFile As String, ByVal outputFile As String, ByVal password As String)
			Try
				Dim UE As New UnicodeEncoding()
				Dim key() As Byte = UE.GetBytes(password)

				Dim fsCrypt As New FileStream(inputFile, FileMode.Open)

				Dim RMCrypto As New RijndaelManaged()

				Dim cs As New CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read)

				Dim fsOut As New FileStream(outputFile, FileMode.Create)

				Dim data As Integer
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: while ((data = cs.ReadByte()) != -1)
				data = cs.ReadByte()
				Do While data <> -1
					fsOut.WriteByte(CByte(data))
					data = cs.ReadByte()
				Loop

				fsOut.Close()
				cs.Close()
				fsCrypt.Close()
			Catch
			End Try
		End Sub

		Private Sub EncryptFile(ByVal inputFile As String, ByVal outputFile As String, ByVal password As String)
			Try
				Dim UE As New UnicodeEncoding()
				Dim key() As Byte = UE.GetBytes(password)

				Dim cryptFile As String = outputFile
				Dim fsCrypt As New FileStream(cryptFile, FileMode.Create)

				Dim RMCrypto As New RijndaelManaged()

				Dim cs As New CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write)

				Dim fsIn As New FileStream(inputFile, FileMode.Open)

				Dim data As Integer
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: while ((data = fsIn.ReadByte()) != -1)
				data = fsIn.ReadByte()
				Do While data <> -1
					cs.WriteByte(CByte(data))
					data = fsIn.ReadByte()
				Loop


				fsIn.Close()
				cs.Close()
				fsCrypt.Close()
			Catch
			End Try
		End Sub

		Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button8.Click
			MessageBox.Show("The generate password feature works only on the encrypting phase. Do not use with decryption!!!", "FileProtect™",MessageBoxButtons.OK,MessageBoxIcon.Information)
			textBox1.Text = GenerateRandomAlphanumericString(8)
		End Sub
		Public Shared Function GenerateRandomAlphanumericString(ByVal length As Integer) As String
			Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"

			Dim random = New Random()
			Dim randomString = New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
			Return randomString
		End Function
	End Class
End Namespace
