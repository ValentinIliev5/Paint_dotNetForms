using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Избран елемент.
		/// </summary>
		/// 

		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}

		private Color chosenColor;
		public Color ChosenColor
		{
			get { return chosenColor; }
			set { chosenColor = value; }
		}

		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		private List<GroupShape> groups = new List<GroupShape>();
		public List<GroupShape> Groups
		{
			get { return groups; }
			set { groups = value; }
		}
		#endregion
		private List<Shape> lastCopy;
		public List<Shape> LastCopy
		{
			get { return lastCopy; }
			set { lastCopy = value; }
		}
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle(int opacity, float outlineWidth)
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;
			rect.RotationAngle = 90;
			rect.Type = "rectangle";
			//rect.TransformationMatrix.RotateAt(rect.RotationAngle, new PointF(
			//	rect.Rectangle.X+(rect.Rectangle.Width /2),
			//	rect.Rectangle.Y+(rect.Rectangle.Height) /2));

			//rect.TransformationMatrix.Scale(2, 2);
			//rect.TransformationMatrix.Reset();
			rect.OutlineColor = ChosenColor;
			rect.OutlineWidth = outlineWidth;
			rect.Opacity = opacity;

			ShapeList.Add(rect);
		}
		public void AddRectangle(int opacity, float outlineWidth, int X,int Y, int width,int height)
		{

			RectangleShape rect = new RectangleShape(new Rectangle(X, Y, width, height));
			rect.FillColor = Color.White;
			rect.RotationAngle = 90;
			rect.Type = "rectangle";
			//rect.TransformationMatrix.RotateAt(rect.RotationAngle, new PointF(
			//	rect.Rectangle.X+(rect.Rectangle.Width /2),
			//	rect.Rectangle.Y+(rect.Rectangle.Height) /2));

			//rect.TransformationMatrix.Scale(2, 2);
			//rect.TransformationMatrix.Reset();
			rect.OutlineColor = ChosenColor;
			rect.OutlineWidth = outlineWidth;
			rect.Opacity = opacity;

			ShapeList.Add(rect);
		}
		public void AddRandomEllipse(int opacity, float outlineWidth)
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));

			ellipse.Type = "ellipse";
			ellipse.FillColor = Color.White;
			ellipse.RotationAngle = 90;
			//ellipse.TransformationMatrix.RotateAt(ellipse.RotationAngle,new PointF(ellipse.Rectangle.X,ellipse.Rectangle.Y));
			ellipse.OutlineColor = ChosenColor;

			ellipse.OutlineWidth = outlineWidth;
			ellipse.Opacity = opacity;

			ShapeList.Add(ellipse);
		}
		public void AddEllipse(int opacity, float outlineWidth, int X, int Y, int width, int height)
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(X, Y, width, height));

			ellipse.Type = "ellipse";
			ellipse.FillColor = Color.White;
			//ellipse.RotationAngle = 90;
			//ellipse.TransformationMatrix.RotateAt(ellipse.RotationAngle,new PointF(ellipse.Rectangle.X,ellipse.Rectangle.Y));
			ellipse.OutlineColor = ChosenColor;

			ellipse.OutlineWidth = outlineWidth;
			ellipse.Opacity = opacity;

			ShapeList.Add(ellipse);
		}
		public void AddRandomCircle(int opacity, float outlineWidth)
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape circle = new EllipseShape(new Rectangle(x, y, 200, 200));

			circle.Type = "circle";
			circle.FillColor = Color.White;
			//ellipse.RotationAngle = 90;
			//ellipse.TransformationMatrix.RotateAt(ellipse.RotationAngle,new PointF(ellipse.Rectangle.X,ellipse.Rectangle.Y));
			circle.OutlineColor = ChosenColor;

			circle.OutlineWidth = outlineWidth;
			circle.Opacity = opacity;

			ShapeList.Add(circle);
		}
		public void AddCircle(int opacity, float outlineWidth, int X, int Y, int width, int height)
		{

			EllipseShape circle = new EllipseShape(new Rectangle(X, Y, width, height));

			circle.Type = "circle";
			circle.FillColor = Color.White;
			//ellipse.RotationAngle = 90;
			//ellipse.TransformationMatrix.RotateAt(ellipse.RotationAngle,new PointF(ellipse.Rectangle.X,ellipse.Rectangle.Y));
			circle.OutlineColor = ChosenColor;

			circle.OutlineWidth = outlineWidth;
			circle.Opacity = opacity;

			ShapeList.Add(circle);
		}
		public void AddRandomSquare(int opacity, float outlineWidth)
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);


			RectangleShape square = new RectangleShape(new Rectangle(x, y, 200, 200));

			square.Type = "square";
			square.FillColor = Color.White;
			square.RotationAngle = 45;
			//ellipse.TransformationMatrix.RotateAt(ellipse.RotationAngle,new PointF(ellipse.Rectangle.X,ellipse.Rectangle.Y));
			square.OutlineColor = ChosenColor;

			square.OutlineWidth = outlineWidth;
			square.Opacity = opacity;

			ShapeList.Add(square);
		}
		public void AddSquare(int opacity, float outlineWidth, int X, int Y, int width, int height)
		{

			RectangleShape square = new RectangleShape(new Rectangle(X, Y, width, height));

			square.Type = "square";
			square.FillColor = Color.White;
			//ellipse.RotationAngle = 90;
			//ellipse.TransformationMatrix.RotateAt(ellipse.RotationAngle,new PointF(ellipse.Rectangle.X,ellipse.Rectangle.Y));
			square.OutlineColor = ChosenColor;

			square.OutlineWidth = outlineWidth;
			square.Opacity = opacity;

			ShapeList.Add(square);
		}
		public void AddRandomTriangle(int opacity, float outlineWidth)
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 250, 200));

			triangle.Type = "triangle";
			triangle.FillColor = Color.White;
			triangle.OutlineColor = ChosenColor;

			triangle.RotationAngle = 90;
			triangle.OutlineWidth = outlineWidth;
			triangle.Opacity = opacity;

			ShapeList.Add(triangle);
		}
		public void AddTriangle(int opacity, float outlineWidth, int X, int Y, int width, int height)
		{

			TriangleShape triangle = new TriangleShape(new Rectangle(X, Y, width, height));

			triangle.Type = "triangle";
			triangle.FillColor = Color.White;
			triangle.OutlineColor = ChosenColor;

			triangle.OutlineWidth = outlineWidth;
			triangle.Opacity = opacity;

			ShapeList.Add(triangle);
		}
		public void DeleteShape(Shape shape)
		{
			ShapeList.Remove(shape);
		}
		public void RotateShape(Shape shape)
		{
			PointF center = new PointF();
			center.X = shape.Location.X + shape.Width / 2;
			center.Y = shape.Location.Y + shape.Height / 2;

			shape.TransformationMatrix.RotateAt(shape.RotationAngle, center);
		}
		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					//ShapeList[i].FillColor = Color.Red;
						
					return ShapeList[i];
				}	
			}
			return null;
		}
		public void Copy()
		{
			this.LastCopy = new List<Shape>();
            foreach (var item in this.Selection)
            {
				this.LastCopy.Add(item);
            }
		}
		public void Paste()
		{
            foreach (var item in this.LastCopy)
            {
                switch (item.Type)
                {
					case "ellipse": 
						AddEllipse(item.Opacity, item.OutlineWidth,(int)item.Location.X, (int)item.Location.Y, (int)item.Width, (int)item.Height);
						break;
					case "circle":
						AddCircle(item.Opacity, item.OutlineWidth, (int)item.Location.X, (int)item.Location.Y, (int)item.Width, (int)item.Height);
						break;
					case "square":
						AddSquare(item.Opacity, item.OutlineWidth, (int)item.Location.X, (int)item.Location.Y, (int)item.Width, (int)item.Height);
						break;
					case "rectangle":
						AddRectangle(item.Opacity, item.OutlineWidth, (int)item.Location.X, (int)item.Location.Y, (int)item.Width, (int)item.Height);
						break;
					case "triangle":
						AddTriangle(item.Opacity, item.OutlineWidth, (int)item.Location.X, (int)item.Location.Y, (int)item.Width, (int)item.Height);
						break;
					default:
                        break;
                }
            }
		}
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(Point point)
		{
			Point[] points = new Point[1];
			points[0] = point;

			if (selection != null) {
                foreach (var item in selection)
                {
					item.TransformationMatrix.Invert();
					item.TransformationMatrix.TransformPoints(points);

					item.TransformationMatrix.Invert();

					item.Location = new PointF
						(item.Location.X + points[0].X - lastLocation.X, 
						item.Location.Y + points[0].Y - lastLocation.Y);
				}
				lastLocation = points[0];
			}
		}
		public void Save()
		{
			using (StreamWriter file = File.CreateText("C:\\drawGPI\\ProjectFolderRepo\\saveData.json"))
			{
				file.Write("[");
				JsonSerializer serializer = new JsonSerializer();
				foreach (var item in this.ShapeList)
				{
					
					serializer.Serialize(file, item);
					file.Write(",");
				}
				file.Write("]");
			}
		}
		public void Load(int opacity, int outlineWidth)
		{
			ShapeList = new List<Shape>();
			JToken token = JToken.Parse(File.ReadAllText("C:\\drawGPI\\ProjectFolderRepo\\saveData.json"));
            foreach (var item in token)
            {
                if (item["Type"].ToString() == "ellipse")
                {
					AddEllipse(opacity, outlineWidth,
						int.Parse(item["Location"]["X"].ToString()),
						int.Parse(item["Location"]["Y"].ToString()),
						int.Parse(item["Width"].ToString()),
						int.Parse(item["Height"].ToString())
						);
                }
				if (item["Type"].ToString() == "circle")
				{
					AddCircle(opacity, outlineWidth,
						int.Parse(item["Location"]["X"].ToString()),
						int.Parse(item["Location"]["Y"].ToString()),
						int.Parse(item["Width"].ToString()),
						int.Parse(item["Height"].ToString()));
				}
				if (item["Type"].ToString() == "square")
				{
					AddSquare(opacity, outlineWidth,
						int.Parse(item["Location"]["X"].ToString()),
						int.Parse(item["Location"]["Y"].ToString()),
						int.Parse(item["Width"].ToString()),
						int.Parse(item["Height"].ToString()));
				}
				if (item["Type"].ToString() == "rectangle")
				{
					AddRectangle(opacity, outlineWidth,
						int.Parse(item["Location"]["X"].ToString()),
						int.Parse(item["Location"]["Y"].ToString()),
						int.Parse(item["Width"].ToString()),
						int.Parse(item["Height"].ToString()));
				}
				if (item["Type"].ToString() == "triangle")
				{
					AddTriangle(opacity, outlineWidth,
						int.Parse(item["Location"]["X"].ToString()),
						int.Parse(item["Location"]["Y"].ToString()),
						int.Parse(item["Width"].ToString()),
						int.Parse(item["Height"].ToString()));
				}
			}

		}

		public override void DrawShape(Graphics grfx, Shape item)
        {
            base.DrawShape(grfx, item);

			
            if (selection.Contains(item))
            {
				grfx.DrawRectangle(new Pen(Color.Black),
					item.Location.X-7,
					item.Location.Y-7, 
					item.Rectangle.Width+14,
					item.Rectangle.Height+14);
            }
        }
    }
}
