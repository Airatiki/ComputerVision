namespace Detection
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
            this.components = new System.ComponentModel.Container();
            this.CamBox = new Emgu.CV.UI.ImageBox();
            this.CannyEdgeBox = new Emgu.CV.UI.ImageBox();
            this.houghSpace = new System.Windows.Forms.PictureBox();
            this.trackBar_CountPoints = new System.Windows.Forms.TrackBar();
            this.Count_of_points = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.ValueOfpoints = new System.Windows.Forms.TrackBar();
            this.Threshold = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Select_Colour = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox_thickness = new System.Windows.Forms.ComboBox();
            this.LineThickness = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Parametres_of_line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyEdgeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houghSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CountPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueOfpoints)).BeginInit();
            this.SuspendLayout();
            // 
            // CamBox
            // 
            this.CamBox.Location = new System.Drawing.Point(26, 29);
            this.CamBox.Name = "CamBox";
            this.CamBox.Size = new System.Drawing.Size(514, 322);
            this.CamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamBox.TabIndex = 2;
            this.CamBox.TabStop = false;
            // 
            // CannyEdgeBox
            // 
            this.CannyEdgeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CannyEdgeBox.Location = new System.Drawing.Point(775, 29);
            this.CannyEdgeBox.Name = "CannyEdgeBox";
            this.CannyEdgeBox.Size = new System.Drawing.Size(514, 322);
            this.CannyEdgeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CannyEdgeBox.TabIndex = 2;
            this.CannyEdgeBox.TabStop = false;
            // 
            // houghSpace
            // 
            this.houghSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houghSpace.Location = new System.Drawing.Point(567, 29);
            this.houghSpace.Name = "houghSpace";
            this.houghSpace.Size = new System.Drawing.Size(181, 527);
            this.houghSpace.TabIndex = 4;
            this.houghSpace.TabStop = false;
            this.houghSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.houghSpace_MouseMove);
            // 
            // trackBar_CountPoints
            // 
            this.trackBar_CountPoints.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar_CountPoints.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_CountPoints.Location = new System.Drawing.Point(799, 461);
            this.trackBar_CountPoints.Maximum = 255;
            this.trackBar_CountPoints.Minimum = 1;
            this.trackBar_CountPoints.Name = "trackBar_CountPoints";
            this.trackBar_CountPoints.Size = new System.Drawing.Size(193, 45);
            this.trackBar_CountPoints.TabIndex = 6;
            this.trackBar_CountPoints.Value = 255;
            // 
            // Count_of_points
            // 
            this.Count_of_points.AutoSize = true;
            this.Count_of_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_of_points.Location = new System.Drawing.Point(796, 430);
            this.Count_of_points.Name = "Count_of_points";
            this.Count_of_points.Size = new System.Drawing.Size(180, 20);
            this.Count_of_points.TabIndex = 7;
            this.Count_of_points.Text = "Count of points on a line";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.Location = new System.Drawing.Point(412, 396);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(89, 24);
            this.checkBox.TabIndex = 8;
            this.checkBox.Text = "Cut lines";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // ValueOfpoints
            // 
            this.ValueOfpoints.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ValueOfpoints.Location = new System.Drawing.Point(1065, 461);
            this.ValueOfpoints.Maximum = 300;
            this.ValueOfpoints.Minimum = 50;
            this.ValueOfpoints.Name = "ValueOfpoints";
            this.ValueOfpoints.Size = new System.Drawing.Size(201, 45);
            this.ValueOfpoints.TabIndex = 9;
            this.ValueOfpoints.Value = 110;
            // 
            // Threshold
            // 
            this.Threshold.AutoSize = true;
            this.Threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Threshold.Location = new System.Drawing.Point(1062, 430);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(79, 20);
            this.Threshold.TabIndex = 10;
            this.Threshold.Text = "Threshold";
            // 
            // Select_Colour
            // 
            this.Select_Colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_Colour.Location = new System.Drawing.Point(40, 396);
            this.Select_Colour.Name = "Select_Colour";
            this.Select_Colour.Size = new System.Drawing.Size(169, 47);
            this.Select_Colour.TabIndex = 11;
            this.Select_Colour.Text = "Select colour of lines";
            this.Select_Colour.UseVisualStyleBackColor = true;
            this.Select_Colour.Click += new System.EventHandler(this.Select_Colour_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 370);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(514, 186);
            this.listBox1.TabIndex = 12;
            // 
            // comboBox_thickness
            // 
            this.comboBox_thickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_thickness.FormattingEnabled = true;
            this.comboBox_thickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_thickness.Location = new System.Drawing.Point(385, 508);
            this.comboBox_thickness.Name = "comboBox_thickness";
            this.comboBox_thickness.Size = new System.Drawing.Size(113, 21);
            this.comboBox_thickness.TabIndex = 13;
            // 
            // LineThickness
            // 
            this.LineThickness.AutoSize = true;
            this.LineThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineThickness.Location = new System.Drawing.Point(382, 478);
            this.LineThickness.Name = "LineThickness";
            this.LineThickness.Size = new System.Drawing.Size(110, 20);
            this.LineThickness.TabIndex = 14;
            this.LineThickness.Text = "Line thickness";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(775, 370);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(514, 186);
            this.listBox2.TabIndex = 15;
            // 
            // Parametres_of_line
            // 
            this.Parametres_of_line.AutoSize = true;
            this.Parametres_of_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parametres_of_line.Location = new System.Drawing.Point(36, 506);
            this.Parametres_of_line.Name = "Parametres_of_line";
            this.Parametres_of_line.Size = new System.Drawing.Size(204, 20);
            this.Parametres_of_line.TabIndex = 16;
            this.Parametres_of_line.Text = "Parametres of detected line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1314, 621);
            this.Controls.Add(this.Parametres_of_line);
            this.Controls.Add(this.LineThickness);
            this.Controls.Add(this.comboBox_thickness);
            this.Controls.Add(this.Select_Colour);
            this.Controls.Add(this.Threshold);
            this.Controls.Add(this.ValueOfpoints);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.Count_of_points);
            this.Controls.Add(this.trackBar_CountPoints);
            this.Controls.Add(this.houghSpace);
            this.Controls.Add(this.CannyEdgeBox);
            this.Controls.Add(this.CamBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox2);
            this.MaximumSize = new System.Drawing.Size(1330, 660);
            this.MinimumSize = new System.Drawing.Size(1330, 660);
            this.Name = "Form1";
            this.Text = "Line Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyEdgeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houghSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CountPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueOfpoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox CamBox;
        private Emgu.CV.UI.ImageBox CannyEdgeBox;
        private System.Windows.Forms.PictureBox houghSpace;
        private System.Windows.Forms.TrackBar trackBar_CountPoints;
        private System.Windows.Forms.Label Count_of_points;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TrackBar ValueOfpoints;
        private System.Windows.Forms.Label Threshold;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Select_Colour;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox_thickness;
        private System.Windows.Forms.Label LineThickness;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label Parametres_of_line;
    }
}

