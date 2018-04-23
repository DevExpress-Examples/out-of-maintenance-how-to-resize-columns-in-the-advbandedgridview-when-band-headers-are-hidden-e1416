using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;

namespace dxt2
{
    class MyGridControl : GridControl {
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyAdvBandedGridInfoRegistrator());
        }
    }

    class MyAdvBandedGridView : AdvBandedGridView
    {
        public MyAdvBandedGridView() : base()
        {

        }
        public MyAdvBandedGridView(GridControl g) : base(g)
        {

        }
        protected override string ViewName
        {
            get
            {
                return "MyAdvBandedGridView";
            }
        }
    }

    class MyAdvBandedGridHandler : AdvBandedGridHandler {

        public MyAdvBandedGridHandler(MyAdvBandedGridView view) : base(view)
        {

        }

        protected override void DoStartResize(DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hit)
        {
            if (hit.HitTest == GridHitTest.ColumnEdge) {
                BandedGridHitInfo hi = new BandedGridHitInfo();
                GridBand ownerBand = (hit as BandedGridHitInfo).Column.OwnerBand;
                hi.Band = ownerBand;
                hi.HitTest = BandedGridHitTest.BandEdge;
                if (IsHitPointAtTheEdge(hit)) base.DoStartResize(hi);
                else base.DoStartResize(hit);
            }
            else
                base.DoStartResize(hit);
        }

        private bool IsHitPointAtTheEdge(GridHitInfo hit) {
            AdvBandedGridView gridView = (AdvBandedGridView)hit.Column.View;
            AdvBandedGridViewInfo viewInfo = (AdvBandedGridViewInfo)gridView.GetViewInfo();
            Rectangle bandBounds = viewInfo.BandsInfo[((BandedGridHitInfo)hit).Column.OwnerBand].Bounds;
            return hit.HitPoint.X > (bandBounds.Right - 5);
        }
    }


    public class MyAdvBandedGridInfoRegistrator : AdvBandedGridInfoRegistrator
    {
        public MyAdvBandedGridInfoRegistrator() : base()
        {

        }

        public override string ViewName { get { return "MyAdvBandedGridView"; } }
        public override BaseView CreateView(GridControl grid)
        {
            return new MyAdvBandedGridView(grid as GridControl);
        }
        public override BaseViewInfo CreateViewInfo(BaseView view)
        {
            return new AdvBandedGridViewInfo(view as MyAdvBandedGridView);
        }
        public override BaseViewHandler CreateHandler(BaseView view)
        {
            return new MyAdvBandedGridHandler(view as MyAdvBandedGridView);
        }
    }

}
