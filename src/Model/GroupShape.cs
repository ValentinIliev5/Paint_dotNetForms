using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class GroupShape 
    {
		private List<Shape> shapes = new List<Shape>();
		public List<Shape> Shapes
		{
			get { return shapes; }
			set { shapes = value; }
		}

		public bool ContainsPoint(PointF point)
		{
			Point[] points = new Point[1];
			points[0] = new Point((int)point.X, (int)point.Y);

            foreach (var item in this.Shapes)
            {
				item.TransformationMatrix.TransformPoints(points);
				if (item.Contains(points[0]))
                {
					return true;
				}
				points[0] = new Point((int)point.X, (int)point.Y);

			}
			return false;
		}

		public void DrawSelf(Graphics grfx)
		{
            foreach (var item in this.Shapes)
            {
				item.DrawSelf(grfx);
            }
		}

		public static void Degroup(GroupShape groupShape)
		{
            foreach (var item in groupShape.Shapes.ToList())
            {
				item.IsInGroup = false;
				groupShape.Shapes.Remove(item);
            }
		}

	}
}
