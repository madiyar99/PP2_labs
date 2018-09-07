namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ship4 = new System.Windows.Forms.Button();
            this.ship1 = new System.Windows.Forms.Button();
            this.ship2 = new System.Windows.Forms.Button();
            this.ship3 = new System.Windows.Forms.Button();
            this.hor = new System.Windows.Forms.Button();
            this.vertic = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(48, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 310);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // ship4
            // 
            this.ship4.Location = new System.Drawing.Point(527, 244);
            this.ship4.Name = "ship4";
            this.ship4.Size = new System.Drawing.Size(92, 36);
            this.ship4.TabIndex = 2;
            this.ship4.Text = "ship4";
            this.ship4.UseVisualStyleBackColor = true;
            this.ship4.Click += new System.EventHandler(this.ship_Click);
            // 
            // ship1
            // 
            this.ship1.Location = new System.Drawing.Point(527, 74);
            this.ship1.Name = "ship1";
            this.ship1.Size = new System.Drawing.Size(92, 36);
            this.ship1.TabIndex = 3;
            this.ship1.Text = "ship1";
            this.ship1.UseVisualStyleBackColor = true;
            this.ship1.Click += new System.EventHandler(this.ship_Click);
            // 
            // ship2
            // 
            this.ship2.Location = new System.Drawing.Point(527, 131);
            this.ship2.Name = "ship2";
            this.ship2.Size = new System.Drawing.Size(92, 36);
            this.ship2.TabIndex = 4;
            this.ship2.Text = "ship2";
            this.ship2.UseVisualStyleBackColor = true;
            this.ship2.Click += new System.EventHandler(this.ship_Click);
            // 
            // ship3
            // 
            this.ship3.Location = new System.Drawing.Point(527, 188);
            this.ship3.Name = "ship3";
            this.ship3.Size = new System.Drawing.Size(92, 35);
            this.ship3.TabIndex = 5;
            this.ship3.Text = "ship3";
            this.ship3.UseVisualStyleBackColor = true;
            this.ship3.Click += new System.EventHandler(this.ship_Click);
            // 
            // hor
            // 
            this.hor.Location = new System.Drawing.Point(508, 320);
            this.hor.Name = "hor";
            this.hor.Size = new System.Drawing.Size(137, 37);
            this.hor.TabIndex = 7;
            this.hor.Text = "Горизонтально";
            this.hor.UseVisualStyleBackColor = true;
            this.hor.Click += new System.EventHandler(this.direct_Click);
            // 
            // vertic
            // 
            this.vertic.Location = new System.Drawing.Point(508, 375);
            this.vertic.Name = "vertic";
            this.vertic.Size = new System.Drawing.Size(137, 37);
            this.vertic.TabIndex = 8;
            this.vertic.Text = "Вертикально";
            this.vertic.UseVisualStyleBackColor = true;
            this.vertic.Click += new System.EventHandler(this.direct_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(48, 539);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 310);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(752, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(351, 308);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 930);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.vertic);
            this.Controls.Add(this.hor);
            this.Controls.Add(this.ship3);
            this.Controls.Add(this.ship2);
            this.Controls.Add(this.ship1);
            this.Controls.Add(this.ship4);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ship4;
        private System.Windows.Forms.Button ship1;
        private System.Windows.Forms.Button ship2;
        private System.Windows.Forms.Button ship3;
        private System.Windows.Forms.Button hor;
        private System.Windows.Forms.Button vertic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

