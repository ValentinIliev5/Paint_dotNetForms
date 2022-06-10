using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
	public class TriangleShape : Shape
    {
        public TriangleShape(RectangleF rect) : base(rect)
        {

        }
        public TriangleShape(RectangleShape rectangle) : base(rectangle)
        {

        }
		public override bool Contains(PointF point)
		{
			PointF[] Points = { new PointF(Rectangle.X, Rectangle.Y + Height), new PointF(Rectangle.X + Width / 2, Rectangle.Y), new PointF(Rectangle.X + Width, Rectangle.Y + Height) };

			PointF[] checkPoint = new PointF[1];
			checkPoint[0] = new PointF(point.X, point.Y);
			TransformationMatrix.TransformPoints(checkPoint);

			if (IsInside(Points[0], Points[1], Points[2], checkPoint[0]))
				return true;
			else
				return false;
		}
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			GraphicsState state = grfx.Save();


			Matrix m = grfx.Transform.Clone();
			m.Multiply(TransformationMatrix);

			grfx.Transform = m;

			PointF[] Points = { new PointF(Rectangle.X,Rectangle.Y+Height), new PointF(Rectangle.X+ Width/2, Rectangle.Y), new PointF(Rectangle.X+Width, Rectangle.Y+Height) };
			

			grfx.FillPolygon(new SolidBrush(Color.FromArgb((int)(Opacity * 2.55), FillColor)), Points);
			grfx.DrawPolygon(new Pen(Color.FromArgb((int)(Opacity * 2.55), OutlineColor), OutlineWidth), Points);

			grfx.Restore(state);
		}

		private float Area(PointF A ,PointF B, PointF C)
		{
			return (float)Math.Abs((A.X * (B.Y -C.Y) +
							 B.X * (C.Y - A.Y) +
							 C.X * (A.Y - B.Y)) / 2.0);
		}
		private bool IsInside(PointF A, PointF B, PointF C,PointF X)
		{
			float S = Area(A, B, C);
			float S1 = Area(A, B, X);
			float S2 = Area(A, X, C);
			float S3 = Area(X, B, C);

			return (S == S1 + S2 + S3);

		}
	}
}
