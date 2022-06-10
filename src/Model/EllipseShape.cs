using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
    public class EllipseShape : Shape
    {
		public EllipseShape(RectangleF rect) : base(rect)
		{

		}

		public EllipseShape(RectangleShape rectangle) : base(rectangle)
		{

		}
		public override bool Contains(PointF point)
		{
			PointF ellipseCenter = new PointF();

			PointF[] checkPoint = new PointF[1];
			checkPoint[0] = new PointF(point.X, point.Y);
			TransformationMatrix.TransformPoints(checkPoint);

			ellipseCenter.X = Rectangle.X + (Rectangle.Width / 2);
			ellipseCenter.Y = Rectangle.Y + (Rectangle.Height / 2);
			double formulaResult = (Math.Pow(checkPoint[0].X - ellipseCenter.X, 2) / Math.Pow(Rectangle.Width / 2, 2))
				+ (Math.Pow(checkPoint[0].Y - ellipseCenter.Y, 2) / Math.Pow(Rectangle.Height / 2, 2));

			if (formulaResult <= 1)
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
			
			grfx.FillEllipse(new SolidBrush(Color.FromArgb((int)(Opacity * 2.55), FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			
			grfx.DrawEllipse(new Pen(Color.FromArgb((int)(Opacity * 2.55), OutlineColor), OutlineWidth),
				Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);


			grfx.Restore(state);
		}

	}
}
