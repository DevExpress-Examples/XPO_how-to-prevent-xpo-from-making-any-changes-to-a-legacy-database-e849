Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace ReadOnlyApp
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			XPBaseObject.AutoSaveOnEndEdit = False
			Dim conn As String = MSSqlConnectionProvider.GetConnectionString("(local)", "AdventureWorks")
			Dim readOnlyStore As New ReadOnlyDataStore(XpoDefault.GetConnectionProvider(conn, AutoCreateOption.SchemaAlreadyExists))
			XpoDefault.DataLayer = New SimpleDataLayer(readOnlyStore)

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace