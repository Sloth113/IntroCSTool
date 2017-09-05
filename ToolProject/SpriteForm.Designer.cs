namespace ToolProject {
    partial class SpriteForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.testBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gridButton = new System.Windows.Forms.Button();
            this.yOffset = new System.Windows.Forms.NumericUpDown();
            this.xOffset = new System.Windows.Forms.NumericUpDown();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.xOffsetLab = new System.Windows.Forms.Label();
            this.yOffsetLab = new System.Windows.Forms.Label();
            this.yBoxLab = new System.Windows.Forms.Label();
            this.xBoxLab = new System.Windows.Forms.Label();
            this.gridBoxLab = new System.Windows.Forms.Label();
            this.gridBoxX = new System.Windows.Forms.NumericUpDown();
            this.gridBoxY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxY)).BeginInit();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(668, 306);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "button1";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 288);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(430, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 288);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // gridButton
            // 
            this.gridButton.Location = new System.Drawing.Point(76, 302);
            this.gridButton.Name = "gridButton";
            this.gridButton.Size = new System.Drawing.Size(75, 23);
            this.gridButton.TabIndex = 3;
            this.gridButton.Text = "Make Grid";
            this.gridButton.UseVisualStyleBackColor = true;
            this.gridButton.Click += new System.EventHandler(this.gridButton_Click);
            // 
            // yOffset
            // 
            this.yOffset.Location = new System.Drawing.Point(103, 370);
            this.yOffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.yOffset.Name = "yOffset";
            this.yOffset.Size = new System.Drawing.Size(48, 20);
            this.yOffset.TabIndex = 4;
            this.yOffset.Tag = "Y Offset / Gap";
            // 
            // xOffset
            // 
            this.xOffset.Location = new System.Drawing.Point(34, 370);
            this.xOffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.xOffset.Name = "xOffset";
            this.xOffset.Size = new System.Drawing.Size(48, 20);
            this.xOffset.TabIndex = 5;
            // 
            // offsetLabel
            // 
            this.offsetLabel.AutoSize = true;
            this.offsetLabel.Location = new System.Drawing.Point(19, 354);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(27, 13);
            this.offsetLabel.TabIndex = 6;
            this.offsetLabel.Text = "Gap";
            // 
            // xOffsetLab
            // 
            this.xOffsetLab.AutoSize = true;
            this.xOffsetLab.Location = new System.Drawing.Point(19, 375);
            this.xOffsetLab.Name = "xOffsetLab";
            this.xOffsetLab.Size = new System.Drawing.Size(15, 13);
            this.xOffsetLab.TabIndex = 7;
            this.xOffsetLab.Text = "x:";
            // 
            // yOffsetLab
            // 
            this.yOffsetLab.AutoSize = true;
            this.yOffsetLab.Location = new System.Drawing.Point(89, 375);
            this.yOffsetLab.Name = "yOffsetLab";
            this.yOffsetLab.Size = new System.Drawing.Size(15, 13);
            this.yOffsetLab.TabIndex = 8;
            this.yOffsetLab.Text = "y:";
            // 
            // yBoxLab
            // 
            this.yBoxLab.AutoSize = true;
            this.yBoxLab.Location = new System.Drawing.Point(89, 336);
            this.yBoxLab.Name = "yBoxLab";
            this.yBoxLab.Size = new System.Drawing.Size(15, 13);
            this.yBoxLab.TabIndex = 13;
            this.yBoxLab.Text = "y:";
            // 
            // xBoxLab
            // 
            this.xBoxLab.AutoSize = true;
            this.xBoxLab.Location = new System.Drawing.Point(19, 336);
            this.xBoxLab.Name = "xBoxLab";
            this.xBoxLab.Size = new System.Drawing.Size(15, 13);
            this.xBoxLab.TabIndex = 12;
            this.xBoxLab.Text = "x:";
            // 
            // gridBoxLab
            // 
            this.gridBoxLab.AutoSize = true;
            this.gridBoxLab.Location = new System.Drawing.Point(19, 315);
            this.gridBoxLab.Name = "gridBoxLab";
            this.gridBoxLab.Size = new System.Drawing.Size(25, 13);
            this.gridBoxLab.TabIndex = 11;
            this.gridBoxLab.Text = "Box";
            // 
            // gridBoxX
            // 
            this.gridBoxX.Location = new System.Drawing.Point(34, 331);
            this.gridBoxX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.gridBoxX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridBoxX.Name = "gridBoxX";
            this.gridBoxX.Size = new System.Drawing.Size(48, 20);
            this.gridBoxX.TabIndex = 10;
            this.gridBoxX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gridBoxY
            // 
            this.gridBoxY.Location = new System.Drawing.Point(103, 331);
            this.gridBoxY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.gridBoxY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridBoxY.Name = "gridBoxY";
            this.gridBoxY.Size = new System.Drawing.Size(48, 20);
            this.gridBoxY.TabIndex = 9;
            this.gridBoxY.Tag = "Y Offset / Gap";
            this.gridBoxY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SpriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(761, 402);
            this.Controls.Add(this.yBoxLab);
            this.Controls.Add(this.xBoxLab);
            this.Controls.Add(this.gridBoxLab);
            this.Controls.Add(this.gridBoxX);
            this.Controls.Add(this.gridBoxY);
            this.Controls.Add(this.yOffsetLab);
            this.Controls.Add(this.xOffsetLab);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.xOffset);
            this.Controls.Add(this.yOffset);
            this.Controls.Add(this.gridButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.testBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpriteForm";
            this.Text = "SprtieForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button gridButton;
        private System.Windows.Forms.NumericUpDown yOffset;
        private System.Windows.Forms.NumericUpDown xOffset;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.Label xOffsetLab;
        private System.Windows.Forms.Label yOffsetLab;
        private System.Windows.Forms.Label yBoxLab;
        private System.Windows.Forms.Label xBoxLab;
        private System.Windows.Forms.Label gridBoxLab;
        private System.Windows.Forms.NumericUpDown gridBoxX;
        private System.Windows.Forms.NumericUpDown gridBoxY;
    }
}