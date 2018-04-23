Imports Microsoft.VisualBasic
Imports System
Namespace dxt2
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
			Me.gridControl1 = New dxt2.MyGridControl()
			Me.myAdvBandedGridView1 = New dxt2.MyAdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myAdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.myAdvBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(721, 522)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myAdvBandedGridView1})
'			Me.gridControl1.Click += New System.EventHandler(Me.gridControl1_Click);
			' 
			' myAdvBandedGridView1
			' 
			Me.myAdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2, Me.gridBand3})
			Me.myAdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.bandedGridColumn1, Me.bandedGridColumn2, Me.bandedGridColumn3, Me.bandedGridColumn4, Me.bandedGridColumn5, Me.bandedGridColumn6, Me.bandedGridColumn7})
			Me.myAdvBandedGridView1.GridControl = Me.gridControl1
			Me.myAdvBandedGridView1.Name = "myAdvBandedGridView1"
			Me.myAdvBandedGridView1.OptionsView.ColumnAutoWidth = True
			Me.myAdvBandedGridView1.OptionsView.ShowBands = False
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Columns.Add(Me.bandedGridColumn1)
			Me.gridBand1.Columns.Add(Me.bandedGridColumn2)
			Me.gridBand1.MinWidth = 20
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 214
			' 
			' bandedGridColumn1
			' 
			Me.bandedGridColumn1.Caption = "bandedGridColumn1"
			Me.bandedGridColumn1.Name = "bandedGridColumn1"
			Me.bandedGridColumn1.Visible = True
			Me.bandedGridColumn1.Width = 214
			' 
			' bandedGridColumn2
			' 
			Me.bandedGridColumn2.Caption = "bandedGridColumn2"
			Me.bandedGridColumn2.Name = "bandedGridColumn2"
			Me.bandedGridColumn2.RowIndex = 1
			Me.bandedGridColumn2.Visible = True
			Me.bandedGridColumn2.Width = 214
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "gridBand2"
			Me.gridBand2.Columns.Add(Me.bandedGridColumn3)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn4)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn7)
			Me.gridBand2.MinWidth = 20
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 154
			' 
			' bandedGridColumn3
			' 
			Me.bandedGridColumn3.Caption = "bandedGridColumn3"
			Me.bandedGridColumn3.Name = "bandedGridColumn3"
			Me.bandedGridColumn3.Visible = True
			Me.bandedGridColumn3.Width = 154
			' 
			' bandedGridColumn4
			' 
			Me.bandedGridColumn4.Caption = "bandedGridColumn4"
			Me.bandedGridColumn4.Name = "bandedGridColumn4"
			Me.bandedGridColumn4.RowIndex = 1
			Me.bandedGridColumn4.Visible = True
			Me.bandedGridColumn4.Width = 88
			' 
			' bandedGridColumn7
			' 
			Me.bandedGridColumn7.Caption = "bandedGridColumn7"
			Me.bandedGridColumn7.Name = "bandedGridColumn7"
			Me.bandedGridColumn7.RowIndex = 1
			Me.bandedGridColumn7.Visible = True
			Me.bandedGridColumn7.Width = 66
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "gridBand3"
			Me.gridBand3.Columns.Add(Me.bandedGridColumn5)
			Me.gridBand3.Columns.Add(Me.bandedGridColumn6)
			Me.gridBand3.MinWidth = 20
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Width = 332
			' 
			' bandedGridColumn5
			' 
			Me.bandedGridColumn5.Caption = "bandedGridColumn5"
			Me.bandedGridColumn5.Name = "bandedGridColumn5"
			Me.bandedGridColumn5.Visible = True
			Me.bandedGridColumn5.Width = 332
			' 
			' bandedGridColumn6
			' 
			Me.bandedGridColumn6.Caption = "bandedGridColumn6"
			Me.bandedGridColumn6.Name = "bandedGridColumn6"
			Me.bandedGridColumn6.RowIndex = 1
			Me.bandedGridColumn6.Visible = True
			Me.bandedGridColumn6.Width = 332
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(721, 522)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myAdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridControl1 As MyGridControl
		Private myAdvBandedGridView1 As MyAdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	End Class
End Namespace

