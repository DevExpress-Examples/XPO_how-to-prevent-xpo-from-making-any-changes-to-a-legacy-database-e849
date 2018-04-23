Imports Microsoft.VisualBasic
Imports System
Namespace ReadOnlyApp
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
			Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOrderNumber = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' cardView1
			' 
			Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.gridColumn4, Me.colAccountNumber, Me.colCustomerType})
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			Me.cardView1.OptionsView.ShowCardExpandButton = False
			Me.cardView1.OptionsView.ShowHorzScrollBar = False
			Me.cardView1.OptionsView.ShowQuickCustomizeButton = False
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.OptionsColumn.ReadOnly = True
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Territory"
			Me.gridColumn4.FieldName = "Territory.ID"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 1
			' 
			' colAccountNumber
			' 
			Me.colAccountNumber.Caption = "AccountNumber"
			Me.colAccountNumber.FieldName = "AccountNumber"
			Me.colAccountNumber.Name = "colAccountNumber"
			Me.colAccountNumber.Visible = True
			Me.colAccountNumber.VisibleIndex = 2
			' 
			' colCustomerType
			' 
			Me.colCustomerType.Caption = "CustomerType"
			Me.colCustomerType.FieldName = "CustomerType"
			Me.colCustomerType.Name = "colCustomerType"
			Me.colCustomerType.Visible = True
			Me.colCustomerType.VisibleIndex = 3
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xpCollection1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			gridLevelNode1.LevelTemplate = Me.cardView1
			gridLevelNode1.RelationName = "Customer"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 46)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(852, 309)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.cardView1})
			' 
			' xpCollection1
			' 
			Me.xpCollection1.ObjectType = GetType(AdventureWorks.OrderHeader)
			Me.xpCollection1.Session = Me.unitOfWork1
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderNumber, Me.colSubTotal, Me.colModifiedDate, Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn5, Me.gridColumn6})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.AllowZoomDetail = False
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
			Me.gridView1.OptionsView.ShowFooter = True
			' 
			' colOrderNumber
			' 
			Me.colOrderNumber.Caption = "OrderNumber"
			Me.colOrderNumber.FieldName = "OrderNumber"
			Me.colOrderNumber.Name = "colOrderNumber"
			Me.colOrderNumber.OptionsColumn.ReadOnly = True
			Me.colOrderNumber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
			Me.colOrderNumber.Visible = True
			Me.colOrderNumber.VisibleIndex = 0
			' 
			' colSubTotal
			' 
			Me.colSubTotal.Caption = "SubTotal"
			Me.colSubTotal.FieldName = "SubTotal"
			Me.colSubTotal.Name = "colSubTotal"
			Me.colSubTotal.Visible = True
			Me.colSubTotal.VisibleIndex = 1
			' 
			' colModifiedDate
			' 
			Me.colModifiedDate.Caption = "ModifiedDate"
			Me.colModifiedDate.FieldName = "ModifiedDate"
			Me.colModifiedDate.Name = "colModifiedDate"
			Me.colModifiedDate.Visible = True
			Me.colModifiedDate.VisibleIndex = 2
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Territory Group"
			Me.gridColumn1.FieldName = "Territory.Group"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 3
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Territory Name"
			Me.gridColumn2.FieldName = "Territory.Name"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 4
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Customer Account Number"
			Me.gridColumn3.FieldName = "Customer.AccountNumber"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 5
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "Ship To City"
			Me.gridColumn5.FieldName = "ShipToAddress.City"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 6
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "Ship To Address Line 1"
			Me.gridColumn6.FieldName = "ShipToAddress.AddressLine1"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 7
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(852, 46)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "panelControl1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(13, 13)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(170, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Make Grid Read-Only"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(852, 355)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private colOrderNumber As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
		Private colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private colAccountNumber As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerType As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

