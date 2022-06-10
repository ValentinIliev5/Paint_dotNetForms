namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.addElipseButton = new System.Windows.Forms.ToolStripButton();
            this.addCircleBtn = new System.Windows.Forms.ToolStripButton();
            this.addSquare = new System.Windows.Forms.ToolStripButton();
            this.addTriangleButton = new System.Windows.Forms.ToolStripButton();
            this.groupButton = new System.Windows.Forms.ToolStripButton();
            this.DegroupButton = new System.Windows.Forms.ToolStripButton();
            this.rotateButton = new System.Windows.Forms.ToolStripButton();
            this.ChooseColorButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.opacityTextbox = new System.Windows.Forms.TextBox();
            this.outlineTextBox = new System.Windows.Forms.TextBox();
            this.outlineLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyDown);
            this.mainMenu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            this.statusBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyDown);
            this.statusBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyUp);
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.drawRectangleSpeedButton,
            this.addElipseButton,
            this.addCircleBtn,
            this.addSquare,
            this.addTriangleButton,
            this.groupButton,
            this.DegroupButton,
            this.rotateButton,
            this.ChooseColorButton,
            this.deleteButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(693, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyDown);
            this.speedMenu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyUp);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // addElipseButton
            // 
            this.addElipseButton.BackColor = System.Drawing.SystemColors.Control;
            this.addElipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addElipseButton.Image = ((System.Drawing.Image)(resources.GetObject("addElipseButton.Image")));
            this.addElipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addElipseButton.Name = "addElipseButton";
            this.addElipseButton.Size = new System.Drawing.Size(23, 22);
            this.addElipseButton.Text = "addElipse";
            this.addElipseButton.Click += new System.EventHandler(this.DrawEllipseButton);
            // 
            // addCircleBtn
            // 
            this.addCircleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCircleBtn.Image = ((System.Drawing.Image)(resources.GetObject("addCircleBtn.Image")));
            this.addCircleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCircleBtn.Name = "addCircleBtn";
            this.addCircleBtn.Size = new System.Drawing.Size(23, 22);
            this.addCircleBtn.Text = "add circle";
            this.addCircleBtn.Click += new System.EventHandler(this.addCircleBtn_Click);
            // 
            // addSquare
            // 
            this.addSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addSquare.Image = ((System.Drawing.Image)(resources.GetObject("addSquare.Image")));
            this.addSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addSquare.Name = "addSquare";
            this.addSquare.Size = new System.Drawing.Size(23, 22);
            this.addSquare.Text = "add square";
            this.addSquare.Click += new System.EventHandler(this.addSquare_Click);
            // 
            // addTriangleButton
            // 
            this.addTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("addTriangleButton.Image")));
            this.addTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTriangleButton.Name = "addTriangleButton";
            this.addTriangleButton.Size = new System.Drawing.Size(23, 22);
            this.addTriangleButton.Text = "toolStripButton1";
            this.addTriangleButton.Click += new System.EventHandler(this.addTriangleButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupButton.Image = ((System.Drawing.Image)(resources.GetObject("groupButton.Image")));
            this.groupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(23, 22);
            this.groupButton.Text = "toolStripButton1";
            this.groupButton.ToolTipText = "Group";
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // DegroupButton
            // 
            this.DegroupButton.BackColor = System.Drawing.Color.Red;
            this.DegroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DegroupButton.Image = ((System.Drawing.Image)(resources.GetObject("DegroupButton.Image")));
            this.DegroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DegroupButton.Name = "DegroupButton";
            this.DegroupButton.Size = new System.Drawing.Size(23, 22);
            this.DegroupButton.Text = "toolStripButton1";
            this.DegroupButton.Click += new System.EventHandler(this.DegroupButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateButton.Image")));
            this.rotateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(23, 22);
            this.rotateButton.Text = "toolStripButton1";
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // ChooseColorButton
            // 
            this.ChooseColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChooseColorButton.Image = ((System.Drawing.Image)(resources.GetObject("ChooseColorButton.Image")));
            this.ChooseColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChooseColorButton.Name = "ChooseColorButton";
            this.ChooseColorButton.Size = new System.Drawing.Size(23, 22);
            this.ChooseColorButton.Text = "Choose color";
            this.ChooseColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 22);
            this.deleteButton.Text = "delete ";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.BackColor = System.Drawing.Color.White;
            this.opacityLabel.Location = new System.Drawing.Point(297, 28);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(49, 13);
            this.opacityLabel.TabIndex = 5;
            this.opacityLabel.Text = "Opacity :";
            // 
            // opacityTextbox
            // 
            this.opacityTextbox.Location = new System.Drawing.Point(352, 25);
            this.opacityTextbox.Name = "opacityTextbox";
            this.opacityTextbox.Size = new System.Drawing.Size(33, 20);
            this.opacityTextbox.TabIndex = 6;
            this.opacityTextbox.Text = "100";
            this.opacityTextbox.TextChanged += new System.EventHandler(this.opacityTextbox_TextChanged);
            // 
            // outlineTextBox
            // 
            this.outlineTextBox.Location = new System.Drawing.Point(438, 25);
            this.outlineTextBox.Name = "outlineTextBox";
            this.outlineTextBox.Size = new System.Drawing.Size(21, 20);
            this.outlineTextBox.TabIndex = 8;
            this.outlineTextBox.Text = "5";
            this.outlineTextBox.TextChanged += new System.EventHandler(this.outlineTextBox_TextChanged);
            // 
            // outlineLabel
            // 
            this.outlineLabel.AutoSize = true;
            this.outlineLabel.BackColor = System.Drawing.Color.White;
            this.outlineLabel.Location = new System.Drawing.Point(391, 29);
            this.outlineLabel.Name = "outlineLabel";
            this.outlineLabel.Size = new System.Drawing.Size(43, 13);
            this.outlineLabel.TabIndex = 7;
            this.outlineLabel.Text = "Outline:";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(466, 24);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(48, 23);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(520, 23);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(48, 23);
            this.pasteButton.TabIndex = 10;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(693, 352);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyDown);
            this.viewPort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyUp);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.outlineTextBox);
            this.Controls.Add(this.outlineLabel);
            this.Controls.Add(this.opacityTextbox);
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyboard_KeyUp);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton addElipseButton;
        private System.Windows.Forms.ToolStripButton ChooseColorButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton addCircleBtn;
        private System.Windows.Forms.ToolStripButton addSquare;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TextBox opacityTextbox;
        private System.Windows.Forms.TextBox outlineTextBox;
        private System.Windows.Forms.Label outlineLabel;
        private System.Windows.Forms.ToolStripButton addTriangleButton;
        private System.Windows.Forms.ToolStripButton rotateButton;
        private System.Windows.Forms.ToolStripButton groupButton;
        private System.Windows.Forms.ToolStripButton DegroupButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}
