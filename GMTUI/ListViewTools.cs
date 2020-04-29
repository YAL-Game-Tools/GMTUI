using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMTUI {
	public static class ListViewTools {
		/// <summary>
		/// Apparently if items are re-arranged by user/AutoArrange,
		/// the underlying Items collection order is unaffected.
		/// </summary>
		public static SortedList<Point, GameListItem> GetSortedItems(this ListView self) {
			var sortedItems = new SortedList<Point, GameListItem>(new PointComparer());
			foreach (var lvItem in self.Items) {
				if (!(lvItem is GameListItem)) continue;
				var item = lvItem as GameListItem;
				sortedItems.Add(item.Position, item);
			}
			return sortedItems;
		}
		public static void ReplaceByKey(this ImageList imageList, string key, Icon icon) {
			imageList.Images.RemoveByKey(key);
			imageList.Images.Add(key, icon);
		}
	}
}
