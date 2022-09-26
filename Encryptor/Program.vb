Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Security.Principal
Imports System.Reflection
Imports System.Diagnostics

Namespace Encryptor
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
				Dim pricipal As New WindowsPrincipal(WindowsIdentity.GetCurrent())
				Dim hasAdministrativeRight As Boolean = pricipal.IsInRole(WindowsBuiltInRole.Administrator)
				If Not hasAdministrativeRight Then
				Dim dialog = MessageBox.Show("Would you like to start this program as administrator? Starting with admin privileges allows the program to encrypt admin-protected files.","FileProtect™",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)
				If dialog = DialogResult.Yes Then
					Dim fileName As String = System.Reflection.Assembly.GetExecutingAssembly().Location
					Dim processInfo As New ProcessStartInfo()
					processInfo.Verb = "runas"
					processInfo.FileName = fileName

					Try
						Process.Start(processInfo)
						Environment.Exit(0)
					Catch
						Application.Run(New Encryptor())
					End Try
				ElseIf dialog = DialogResult.Cancel Then
					Environment.Exit(0)
				Else
					Application.Run(New Encryptor())
				End If
				Else
					Application.Run(New Encryptor())
				End If
		End Sub
	End Class
End Namespace
