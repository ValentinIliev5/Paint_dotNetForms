using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();
		private List<Keys> pressedKeys = new List<Keys>();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}

		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle(int.Parse(opacityTextbox.Text), int.Parse(outlineTextBox.Text));

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}
		private void DrawEllipseButton(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomEllipse(int.Parse(opacityTextbox.Text), int.Parse(outlineTextBox.Text));

			statusBar.Items[0].Text = "Последно действие: Рисуване на елипса.";

			viewPort.Invalidate();
		}
		private void addCircleBtn_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomCircle(int.Parse(opacityTextbox.Text), int.Parse(outlineTextBox.Text));

			statusBar.Items[0].Text = "Последно действие: Рисуване на кръг.";

			viewPort.Invalidate();
		}
		private void addSquare_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomSquare(int.Parse(opacityTextbox.Text), int.Parse(outlineTextBox.Text));

			statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат.";

			viewPort.Invalidate();
		}
		private void addTriangleButton_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomTriangle(int.Parse(opacityTextbox.Text), int.Parse(outlineTextBox.Text));

			statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник.";

			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked)
			{
				Shape temp = dialogProcessor.ContainsPoint(e.Location);

                

				if (temp != null) 
				{
					if (!dialogProcessor.Selection.Contains(temp))
					{	
						if (dialogProcessor.Groups.Any(w =>w.Shapes.Contains(temp)))
							{
								dialogProcessor.Selection.AddRange(dialogProcessor.Groups.First(w => w.Shapes.Contains(temp)).Shapes);
							}
                        else
                        {
							dialogProcessor.Selection.Add(temp);
                        }
						
					}
					else
					{
						if (dialogProcessor.Groups.Any(w => w.Shapes.Contains(temp)))
						{
							foreach (var item in dialogProcessor.Groups.First(w => w.Shapes.Contains(temp)).Shapes)
							{
								dialogProcessor.Selection.Remove(item);
							}
						}
                        else
                        {
							dialogProcessor.Selection.Remove(temp);
                        }
					}
					
				
				}
				
				if (dialogProcessor.Selection != null)
				{
					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging)
			{
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		/// bonus comment for commit 
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection = new List<Shape>();
        }

        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
			ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()==DialogResult.OK)
            {
				dialogProcessor.ChosenColor = colorDialog.Color;
            }
            foreach (var item in dialogProcessor.Selection)
            {
				item.OutlineColor = colorDialog.Color;
            }
			viewPort.Invalidate();
		}

        private void deleteButton_Click(object sender, EventArgs e)
        {
			foreach (var item in dialogProcessor.Selection)
			{
				dialogProcessor.DeleteShape(item);
			}
			statusBar.Items[0].Text = "Изтриване на селектираните предмети.";
			viewPort.Invalidate();
		}

        private void rotateButton_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {

				dialogProcessor.RotateShape(item);
				
            }
			statusBar.Items[0].Text = "Завъртане на селектираните предмети.";
			viewPort.Invalidate();
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            GroupShape groupShape = new GroupShape();
            foreach (var item in dialogProcessor.Selection)
            {
				if (item.IsInGroup)
                {
					GroupShape.Degroup(dialogProcessor.Groups.First(w => w.Shapes.Contains(item)));
					groupShape.Shapes.Add(item);

                }
                if (!item.IsInGroup)
                {
                    if (!groupShape.Shapes.Contains(item))
                    {
						item.IsInGroup = true;
						groupShape.Shapes.Add(item);
                    }
					
                }
                
				
            }
			dialogProcessor.Groups.Add(groupShape);
        }

        private void DegroupButton_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection.ToList())
            {
                if (item.IsInGroup)
                {
					GroupShape.Degroup(dialogProcessor.Groups.FirstOrDefault(w => w.Shapes.Contains(item)));
					break;
                }
            }
        }
		private void copyButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.Copy();
			statusBar.Items[0].Text = "Последно действие: Копиране.";
			viewPort.Invalidate();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
			dialogProcessor.Paste();
			statusBar.Items[0].Text = "Последно действие: Поставяне.";
			viewPort.Invalidate();
		}

        private void Keyboard_KeyDown(object sender, KeyEventArgs e)
        {
			pressedKeys.Add(e.KeyCode);
            if (pressedKeys.Any(w=>w.ToString()=="ControlKey") && pressedKeys.Any(w => w.ToString() == "C"))
            {
				dialogProcessor.LastCopy = new List<Shape>();
				dialogProcessor.Copy();
				statusBar.Items[0].Text = "Последно действие: Копиране на елемент/и.";
				viewPort.Invalidate();
			}

			if (pressedKeys.Any(w => w.ToString() == "ControlKey") && pressedKeys.Any(w => w.ToString() == "A"))
			{
				dialogProcessor.Selection = new List<Shape>();
                foreach (var item in dialogProcessor.ShapeList)
                {
					dialogProcessor.Selection.Add(item);
					statusBar.Items[0].Text = "Последно действие: Маркиране на всички елементи.";
					viewPort.Invalidate();
				}
			}

			if (pressedKeys.Any(w => w.ToString() == "ControlKey") && pressedKeys.Any(w => w.ToString() == "V"))
			{
				dialogProcessor.Selection = new List<Shape>();

				dialogProcessor.Paste();
				
				statusBar.Items[0].Text = "Последно действие: Поставяне на елемент/и.";
				viewPort.Invalidate();
			}
			if (pressedKeys.Any(w => w.ToString() == "Delete"))
			{
                foreach (var item in dialogProcessor.Selection.ToList())
                {
					dialogProcessor.Selection.Remove(item);
					dialogProcessor.ShapeList.Remove(item);
                }
				statusBar.Items[0].Text = "Последно действие: Изтриване на елемент/и.";
				viewPort.Invalidate();
			}
		}

        private void Keyboard_KeyUp(object sender, KeyEventArgs e)
        {
			pressedKeys.Remove(e.KeyCode);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Save();
			viewPort.Invalidate();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Load(int.Parse(opacityTextbox.Text), int.Parse(outlineTextBox.Text));
			viewPort.Invalidate();
        }

        private void opacityTextbox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
				if (opacityTextbox.Text == string.Empty)
				{
					
				}
				else item.Opacity = int.Parse(opacityTextbox.Text);
            }
			viewPort.Invalidate();
        }

        private void outlineTextBox_TextChanged(object sender, EventArgs e)
        {
			foreach (var item in dialogProcessor.Selection)
			{
				if (outlineTextBox.Text == string.Empty)
				{

				}
				else item.OutlineWidth = int.Parse(outlineTextBox.Text);
			}
			viewPort.Invalidate();
		}
    }
}
