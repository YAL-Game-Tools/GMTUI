using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// ListView seems to floor item positions for snapping by default and it doesn't feel very nice.
/// But also there's no way to get column/row sizes/offsets? What a trouble.
/// </summary>
namespace GMTUI {
	class ListViewItemSnap {
		public int refX = 0;
		public int refY = 0;
		public int divX = 0;
		public int divY = 0;
		private ListViewItemSnap() {

		}
		public Point Snap(Point p) {
			var nx = p.X;
			var ny = p.Y;
			if (divX != 0 && false) { // oddly enough, it snaps better if we don't.
				nx = (int)Math.Round((double)(nx - refX) / divX);
				nx = refX + divX * nx;
			}
			if (divY != 0) {
				ny = (int)Math.Round((double)(ny - refY) / divY);
				ny = refY + divY * ny;
			}
			return new Point(nx, ny);
		}
		public static ListViewItemSnap Start(ListView lv) {
			switch (lv.View) {
				case View.LargeIcon:
				case View.Tile:
					break;
				default: return null;
			}
			//
			var items = lv.GetSortedItems();
			var q = new ListViewItemSnap();
			GameListItem first = null;
			foreach (var pair in items) {
				var item = pair.Value;
				if (first == null) {
					first = item;
					q.refX = first.Position.X;
					q.refY = first.Position.Y;
				} else if (q.divX == 0 && item.Position.X != q.refX) {
					q.divX = item.Position.X - first.Position.X;
				} else if (q.divY == 0 && item.Position.Y != q.refY) {
					q.divY = item.Position.Y - first.Position.Y;
				}
			}
			return first != null ? q : null;
		}
	}
}
