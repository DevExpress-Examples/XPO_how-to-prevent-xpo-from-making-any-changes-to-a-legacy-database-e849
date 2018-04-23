Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace ReadOnlyApp
	<NonPersistent> _
	Public Class ReadOnlyObject
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		' prevents object saving via BindingManagerBase.EndCurrentEdit
		Protected Overrides Sub DoEndEditAction()
		End Sub
	End Class
End Namespace
