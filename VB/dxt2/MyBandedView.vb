Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.Handler
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing

Namespace dxt2
	Friend Class MyGridControl
		Inherits GridControl
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyAdvBandedGridInfoRegistrator())
		End Sub
	End Class

	Friend Class MyAdvBandedGridView
		Inherits AdvBandedGridView
		Public Sub New()
			MyBase.New()

		End Sub
		Public Sub New(ByVal g As GridControl)
			MyBase.New(g)

		End Sub
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyAdvBandedGridView"
			End Get
		End Property
	End Class

	Friend Class MyAdvBandedGridHandler
		Inherits AdvBandedGridHandler

		Public Sub New(ByVal view As MyAdvBandedGridView)
			MyBase.New(view)

		End Sub

		Protected Overrides Sub DoStartResize(ByVal hit As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo)
			If hit.HitTest = GridHitTest.ColumnEdge Then
				Dim hi As New BandedGridHitInfo()
				Dim ownerBand As GridBand = (TryCast(hit, BandedGridHitInfo)).Column.OwnerBand
				hi.Band = ownerBand
				hi.HitTest = BandedGridHitTest.BandEdge
				If IsHitPointAtTheEdge(hit) Then
					MyBase.DoStartResize(hi)
				Else
					MyBase.DoStartResize(hit)
				End If
			Else
				MyBase.DoStartResize(hit)
			End If
		End Sub

		Private Function IsHitPointAtTheEdge(ByVal hit As GridHitInfo) As Boolean
			Dim gridView As AdvBandedGridView = CType(hit.Column.View, AdvBandedGridView)
			Dim viewInfo As AdvBandedGridViewInfo = CType(gridView.GetViewInfo(), AdvBandedGridViewInfo)
			Dim bandBounds As Rectangle = viewInfo.BandsInfo((CType(hit, BandedGridHitInfo)).Column.OwnerBand).Bounds
			Return hit.HitPoint.X > (bandBounds.Right - 5)
		End Function
	End Class


	Public Class MyAdvBandedGridInfoRegistrator
		Inherits AdvBandedGridInfoRegistrator
		Public Sub New()
			MyBase.New()

		End Sub

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyAdvBandedGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyAdvBandedGridView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
			Return New AdvBandedGridViewInfo(TryCast(view, MyAdvBandedGridView))
		End Function
		Public Overrides Function CreateHandler(ByVal view As BaseView) As BaseViewHandler
			Return New MyAdvBandedGridHandler(TryCast(view, MyAdvBandedGridView))
		End Function
	End Class

End Namespace
