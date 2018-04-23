Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base

Namespace ReadOnlyApp
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			' process template views
			For Each view As ColumnView In gridControl1.ViewCollection
				view.OptionsBehavior.Editable = False
			Next view

			' process visible clone views
			For Each view As ColumnView In gridControl1.Views
				view.OptionsBehavior.Editable = False
			Next view
		End Sub
	End Class
End Namespace