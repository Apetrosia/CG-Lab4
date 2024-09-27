namespace CG_Lab
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CurrColorPB = new System.Windows.Forms.PictureBox();
            this.NewPolygon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transformBox = new System.Windows.Forms.ComboBox();
            this.transformButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrColorPB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(3, 61);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1146, 480);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 12);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 43);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CurrColorPB
            // 
            this.CurrColorPB.Location = new System.Drawing.Point(114, 12);
            this.CurrColorPB.Name = "CurrColorPB";
            this.CurrColorPB.Size = new System.Drawing.Size(43, 43);
            this.CurrColorPB.TabIndex = 2;
            this.CurrColorPB.TabStop = false;
            // 
            // NewPolygon
            // 
            this.NewPolygon.Location = new System.Drawing.Point(163, 12);
            this.NewPolygon.Name = "NewPolygon";
            this.NewPolygon.Size = new System.Drawing.Size(143, 43);
            this.NewPolygon.TabIndex = 3;
            this.NewPolygon.Text = "новый полигон";
            this.NewPolygon.UseVisualStyleBackColor = true;
            this.NewPolygon.Click += new System.EventHandler(this.NewPolygon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Афинные преобраозвания";
            // 
            // transformBox
            // 
            this.transformBox.FormattingEnabled = true;
            this.transformBox.Items.AddRange(new object[] {
            "Смещение на dx, dy",
            "Поворот вокруг заданной пользователем точки",
            "Поворот вокруг своего центра",
            "Масштабирование относительно заданной точки",
            "Масштабирование относительно своего центра"});
            this.transformBox.Location = new System.Drawing.Point(312, 22);
            this.transformBox.Name = "transformBox";
            this.transformBox.Size = new System.Drawing.Size(411, 28);
            this.transformBox.TabIndex = 6;
            this.transformBox.Text = "Смещение на dx, dy";
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(729, 12);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(110, 43);
            this.transformButton.TabIndex = 7;
            this.transformButton.Text = "Применить";
            this.transformButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 542);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.transformBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPolygon);
            this.Controls.Add(this.CurrColorPB);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrColorPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.PictureBox CurrColorPB;
        private System.Windows.Forms.Button NewPolygon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox transformBox;
        private System.Windows.Forms.Button transformButton;
    }
}

