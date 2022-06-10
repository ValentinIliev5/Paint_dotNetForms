using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Draw
{
	/// <summary>
	/// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
	/// </summary>
	[Serializable]
	public abstract class Shape
	{
		#region Constructors

		public Shape()
		{
		}

		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}

		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;

			this.FillColor = shape.FillColor;
		}
		#endregion

		#region Properties

		/// <summary>
		/// Обхващащ правоъгълник на елемента.
		/// </summary>
		private RectangleF rectangle;

		public virtual RectangleF Rectangle
		{
			get { return rectangle; }
			set { rectangle = value; }
		}

		/// <summary>
		/// Широчина на елемента.
		/// </summary>
		public virtual float Width
		{
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}

		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height
		{
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}

		/// <summary>
		/// Горен ляв ъгъл на елемента.
		/// </summary>
		public virtual PointF Location
		{
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}

		/// <summary>
		/// Цвят на елемента.
		/// </summary>
		/// 

		public virtual Color FillColor
		{
			get { return fillColor; }
			set { fillColor = value; }
		}

		public virtual Color OutlineColor
		{
			get { return outlineColor; }
			set { outlineColor = value; }
		}
		public virtual float OutlineWidth
		{
			get { return outlineWidth; }
			set { outlineWidth = value; }
		}
		public virtual int Opacity
		{
			get { return opacity; }
			set { opacity = value; }
		}
		public virtual float RotationAngle
		{
			get { return rotationAngle; }
			set { rotationAngle = value; }
		}
		public virtual string Type
		{
			get { return type; }
			set { type = value; }
		}
		public virtual bool IsInGroup
		{
			get { return isInGroup; }
			set { isInGroup = value; }
		}

		public virtual Matrix TransformationMatrix
		{ 
			get { return matrix; }
			set { matrix = value; }
		}
		
		
		private Color fillColor;
		private Color outlineColor;
		private float outlineWidth;
		private int opacity;
		private string type;
		private bool isInGroup = false;
		private float rotationAngle = 0;
		[NonSerialized]
		private Matrix matrix = new Matrix();
		
		//ellipseCenter.X = Rectangle.X + (Rectangle.Width / 2);
		//ellipseCenter.Y = Rectangle.Y + (Rectangle.Height / 2);

		#endregion


		/// <summary>
		/// Проверка дали точка point принадлежи на елемента.
		/// </summary>
		/// <param name="point">Точка</param>
		/// <returns>Връща true, ако точката принадлежи на елемента и
		/// false, ако не пренадлежи</returns>
		public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
		}

		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
		}

	}
}
