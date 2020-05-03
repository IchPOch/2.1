namespace _2._1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.YY = new System.Windows.Forms.Label();
            this.XX = new System.Windows.Forms.Label();
            this.Sea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2._1.Properties.Resources.unknown__1_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 306);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(12, 97);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(100, 20);
            this.Y.TabIndex = 1;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(12, 52);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 20);
            this.X.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(118, 76);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // YY
            // 
            this.YY.AutoSize = true;
            this.YY.Location = new System.Drawing.Point(9, 81);
            this.YY.Name = "YY";
            this.YY.Size = new System.Drawing.Size(57, 13);
            this.YY.TabIndex = 4;
            this.YY.Text = "Введите y";
            // 
            // XX
            // 
            this.XX.AutoSize = true;
            this.XX.Location = new System.Drawing.Point(12, 36);
            this.XX.Name = "XX";
            this.XX.Size = new System.Drawing.Size(57, 13);
            this.XX.TabIndex = 5;
            this.XX.Text = "Введите x";
            // 
            // Sea
            // 
            this.Sea.Location = new System.Drawing.Point(12, 134);
            this.Sea.Name = "Sea";
            this.Sea.Size = new System.Drawing.Size(238, 20);
            this.Sea.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sea);
            this.Controls.Add(this.XX);
            this.Controls.Add(this.YY);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label YY;
        private System.Windows.Forms.Label XX;
        private System.Windows.Forms.TextBox Sea;
    }
}

