namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Red = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.size1 = new System.Windows.Forms.Button();
            this.size2 = new System.Windows.Forms.Button();
            this.size3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rezinka = new System.Windows.Forms.Button();
            this.Figure = new System.Windows.Forms.Label();
            this.Rectangle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Instrument = new System.Windows.Forms.Label();
            this.Pencil = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Clear_screen = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(1004, 45);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(36, 30);
            this.Red.TabIndex = 0;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Color_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Black.Location = new System.Drawing.Point(1056, 46);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(36, 29);
            this.Black.TabIndex = 1;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Color_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(1108, 46);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(36, 29);
            this.Blue.TabIndex = 2;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Color_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Location = new System.Drawing.Point(1004, 81);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(36, 30);
            this.Orange.TabIndex = 3;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Color_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(1056, 81);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(36, 29);
            this.Yellow.TabIndex = 4;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Color_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green.Location = new System.Drawing.Point(1108, 81);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(36, 29);
            this.Green.TabIndex = 5;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Толщина";
            // 
            // size1
            // 
            this.size1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.size1.Location = new System.Drawing.Point(846, 45);
            this.size1.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(101, 15);
            this.size1.TabIndex = 7;
            this.size1.UseVisualStyleBackColor = false;
            this.size1.Click += new System.EventHandler(this.size_Click);
            // 
            // size2
            // 
            this.size2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.size2.Location = new System.Drawing.Point(846, 66);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(101, 18);
            this.size2.TabIndex = 8;
            this.size2.UseVisualStyleBackColor = false;
            this.size2.Click += new System.EventHandler(this.size_Click);
            // 
            // size3
            // 
            this.size3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.size3.Location = new System.Drawing.Point(846, 90);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(101, 22);
            this.size3.TabIndex = 9;
            this.size3.UseVisualStyleBackColor = false;
            this.size3.Click += new System.EventHandler(this.size_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ластик";
            // 
            // rezinka
            // 
            this.rezinka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rezinka.BackgroundImage")));
            this.rezinka.Image = ((System.Drawing.Image)(resources.GetObject("rezinka.Image")));
            this.rezinka.Location = new System.Drawing.Point(694, 45);
            this.rezinka.Name = "rezinka";
            this.rezinka.Size = new System.Drawing.Size(103, 70);
            this.rezinka.TabIndex = 11;
            this.rezinka.UseVisualStyleBackColor = true;
            this.rezinka.Click += new System.EventHandler(this.Color_Click);
            // 
            // Figure
            // 
            this.Figure.AutoSize = true;
            this.Figure.Location = new System.Drawing.Point(465, 17);
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(67, 20);
            this.Figure.TabIndex = 12;
            this.Figure.Text = "Фигуры";
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(499, 46);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(158, 32);
            this.Rectangle.TabIndex = 13;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Figure_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1519, 666);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Instrument
            // 
            this.Instrument.AutoSize = true;
            this.Instrument.Location = new System.Drawing.Point(208, 17);
            this.Instrument.Name = "Instrument";
            this.Instrument.Size = new System.Drawing.Size(100, 20);
            this.Instrument.TabIndex = 15;
            this.Instrument.Text = "Инструмент";
            // 
            // Pencil
            // 
            this.Pencil.Location = new System.Drawing.Point(202, 46);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(117, 32);
            this.Pencil.TabIndex = 16;
            this.Pencil.Text = "Карандаш";
            this.Pencil.UseVisualStyleBackColor = true;
            this.Pencil.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(499, 83);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(158, 32);
            this.Circle.TabIndex = 17;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Figure_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(351, 46);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(142, 32);
            this.Triangle.TabIndex = 18;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Figure_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(351, 84);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(142, 31);
            this.Square.TabIndex = 19;
            this.Square.Text = "Квадрат";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Figure_Click);
            // 
            // Clear_screen
            // 
            this.Clear_screen.Location = new System.Drawing.Point(1212, 53);
            this.Clear_screen.Name = "Clear_screen";
            this.Clear_screen.Size = new System.Drawing.Size(153, 40);
            this.Clear_screen.TabIndex = 20;
            this.Clear_screen.Text = "Очистить экран";
            this.Clear_screen.UseVisualStyleBackColor = true;
            this.Clear_screen.Click += new System.EventHandler(this.Clear_screen_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(26, 46);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(113, 29);
            this.Save.TabIndex = 21;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Файл";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(26, 85);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(113, 29);
            this.Open.TabIndex = 23;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1558, 828);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear_screen);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Pencil);
            this.Controls.Add(this.Instrument);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Figure);
            this.Controls.Add(this.rezinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.size3);
            this.Controls.Add(this.size2);
            this.Controls.Add(this.size1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Red);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button size1;
        private System.Windows.Forms.Button size2;
        private System.Windows.Forms.Button size3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rezinka;
        private System.Windows.Forms.Label Figure;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Instrument;
        private System.Windows.Forms.Button Pencil;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Clear_screen;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Open;
    }
}

