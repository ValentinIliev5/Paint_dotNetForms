using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
	[Serializable]
	public class RectangleShape : Shape
	{
		#region Constructor

		public RectangleShape(RectangleF rect) : base(rect)
		{
		}

		public RectangleShape(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			Point[] points = new Point[1];
			points[0] = new Point((int)point.X, (int)point.Y);
			TransformationMatrix.TransformPoints(points);

			if (base.Contains(points[0]))
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}

		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			GraphicsState state = grfx.Save();

			Matrix m = grfx.Transform.Clone();
			m.Multiply(TransformationMatrix);

			grfx.Transform = m;

			grfx.FillRectangle(new SolidBrush(Color.FromArgb((int)(Opacity * 2.55), FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawRectangle(new Pen(Color.FromArgb((int)(Opacity * 2.55), OutlineColor), OutlineWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

			grfx.Restore(state);
		}
	}
}
