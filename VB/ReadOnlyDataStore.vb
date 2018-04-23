Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata

Namespace ReadOnlyApp

	Friend Class ReadOnlyDataStore
		Inherits DataStoreSerialized
		Public Sub New(ByVal nestedProvider As IDataStore)
			MyBase.New(nestedProvider)
		End Sub
		Protected Overrides Function ProcessModifyData(ParamArray ByVal dmlStatements() As ModificationStatement) As ModificationResult
			Throw New InvalidOperationException("Cannot modify data.")
		End Function
	End Class
End Namespace
