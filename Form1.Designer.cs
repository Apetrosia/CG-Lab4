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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrColorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(2, 40);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(944, 585);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(8, 8);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(64, 28);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CurrColorPB
            // 
            this.CurrColorPB.Location = new System.Drawing.Point(76, 8);
            this.CurrColorPB.Margin = new System.Windows.Forms.Padding(2);
            this.CurrColorPB.Name = "CurrColorPB";
            this.CurrColorPB.Size = new System.Drawing.Size(29, 28);
            this.CurrColorPB.TabIndex = 2;
            this.CurrColorPB.TabStop = false;
            // 
            // NewPolygon
            // 
            this.NewPolygon.Location = new System.Drawing.Point(109, 8);
            this.NewPolygon.Margin = new System.Windows.Forms.Padding(2);
            this.NewPolygon.Name = "NewPolygon";
            this.NewPolygon.Size = new System.Drawing.Size(95, 28);
            this.NewPolygon.TabIndex = 3;
            this.NewPolygon.Text = "новый полигон";
            this.NewPolygon.UseVisualStyleBackColor = true;
            this.NewPolygon.Click += new System.EventHandler(this.NewPolygon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
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
            this.transformBox.Location = new System.Drawing.Point(208, 14);
            this.transformBox.Margin = new System.Windows.Forms.Padding(2);
            this.transformBox.Name = "transformBox";
            this.transformBox.Size = new System.Drawing.Size(275, 21);
            this.transformBox.TabIndex = 6;
            this.transformBox.Text = "Смещение на dx, dy";
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(486, 8);
            this.transformButton.Margin = new System.Windows.Forms.Padding(2);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(73, 28);
            this.transformButton.TabIndex = 7;
            this.transformButton.Text = "Применить";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(798, 89);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(814, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Угол (в градусах)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(753, 244);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(847, 244);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(750, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Коэффициенты масштабирования";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.transformBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPolygon);
            this.Controls.Add(this.CurrColorPB);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrColorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
    }
}

