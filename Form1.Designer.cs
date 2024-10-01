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
            this.searchingBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrColorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(3, 61);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1416, 900);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 12);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 42);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CurrColorPB
            // 
            this.CurrColorPB.Location = new System.Drawing.Point(114, 12);
            this.CurrColorPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrColorPB.Name = "CurrColorPB";
            this.CurrColorPB.Size = new System.Drawing.Size(44, 42);
            this.CurrColorPB.TabIndex = 2;
            this.CurrColorPB.TabStop = false;
            // 
            // NewPolygon
            // 
            this.NewPolygon.Location = new System.Drawing.Point(163, 12);
            this.NewPolygon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewPolygon.Name = "NewPolygon";
            this.NewPolygon.Size = new System.Drawing.Size(143, 42);
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
            this.transformBox.Location = new System.Drawing.Point(312, 21);
            this.transformBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transformBox.Name = "transformBox";
            this.transformBox.Size = new System.Drawing.Size(410, 28);
            this.transformBox.TabIndex = 6;
            this.transformBox.Text = "Смещение на dx, dy";
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(729, 12);
            this.transformButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(109, 42);
            this.transformButton.TabIndex = 7;
            this.transformButton.Text = "Применить";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(1153, 139);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1177, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Угол (в градусах)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(1130, 375);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(116, 26);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(1270, 375);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1125, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Коэффициенты масштабирования";
            // 
            // searchingBox
            // 
            this.searchingBox.FormattingEnabled = true;
            this.searchingBox.Items.AddRange(new object[] {
            "Положение точки",
            "Точка пересечения",
            "Принадлежит ли точка полигону"});
            this.searchingBox.Location = new System.Drawing.Point(943, 20);
            this.searchingBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.searchingBox.Name = "searchingBox";
            this.searchingBox.Size = new System.Drawing.Size(325, 28);
            this.searchingBox.TabIndex = 10;
            this.searchingBox.Text = "Векторные алгоритмы";
            this.searchingBox.TextChanged += new System.EventHandler(this.searchingBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1177, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "dx";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Location = new System.Drawing.Point(1130, 248);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown4.TabIndex = 15;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Location = new System.Drawing.Point(1270, 248);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(116, 26);
            this.numericUpDown5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1308, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "dy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1414, 960);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.searchingBox);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrColorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
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
        private System.Windows.Forms.ComboBox searchingBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label5;
    }
}

