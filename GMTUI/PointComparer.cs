using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GMTUI {
	class PointComparer : IComparer<Point> {
		public int Compare(Point ap, Point bp) {
			if (ap.Y != bp.Y) {
				return ap.Y < bp.Y ? -1 : 1;
			} else {
				return ap.X < bp.X ? -1 : 1;
			}
		}
	}
}
