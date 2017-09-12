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
            this.spriteSheetBox = new System.Windows.Forms.PictureBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentPosX = new System.Windows.Forms.NumericUpDown();
            this.currentPosY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentSizeX = new System.Windows.Forms.NumericUpDown();
            this.currentSizeY = new System.Windows.Forms.NumericUpDown();
            this.spriteSheetText = new System.Windows.Forms.TextBox();
            this.spriteNameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(668, 306);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 10;
            this.testBtn.Text = "button1";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // spriteSheetBox
            // 
            this.spriteSheetBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.spriteSheetBox.Location = new System.Drawing.Point(13, 12);
            this.spriteSheetBox.Name = "spriteSheetBox";
            this.spriteSheetBox.Size = new System.Drawing.Size(411, 288);
            this.spriteSheetBox.TabIndex = 1;
            this.spriteSheetBox.TabStop = false;
            this.spriteSheetBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.spriteSheetBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.spriteSheetBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spriteSheetBox_MouseDown);
            this.spriteSheetBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spriteSheetBox_MouseMove);
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
            this.gridButton.TabIndex = 0;
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
            this.yOffset.Tag = "";
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
            this.xOffset.TabIndex = 3;
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
            this.gridBoxX.TabIndex = 1;
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
            this.gridBoxY.TabIndex = 2;
            this.gridBoxY.Tag = "";
            this.gridBoxY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Position";
            // 
            // currentPosX
            // 
            this.currentPosX.Location = new System.Drawing.Point(450, 331);
            this.currentPosX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.currentPosX.Name = "currentPosX";
            this.currentPosX.Size = new System.Drawing.Size(48, 20);
            this.currentPosX.TabIndex = 5;
            this.currentPosX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.currentPosX.ValueChanged += new System.EventHandler(this.currentPosX_ValueChanged);
            // 
            // currentPosY
            // 
            this.currentPosY.Location = new System.Drawing.Point(519, 331);
            this.currentPosY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.currentPosY.Name = "currentPosY";
            this.currentPosY.Size = new System.Drawing.Size(48, 20);
            this.currentPosY.TabIndex = 6;
            this.currentPosY.Tag = "";
            this.currentPosY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.currentPosY.ValueChanged += new System.EventHandler(this.currentPosY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "x:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Size";
            // 
            // currentSizeX
            // 
            this.currentSizeX.Location = new System.Drawing.Point(450, 370);
            this.currentSizeX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.currentSizeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentSizeX.Name = "currentSizeX";
            this.currentSizeX.Size = new System.Drawing.Size(48, 20);
            this.currentSizeX.TabIndex = 7;
            this.currentSizeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentSizeX.ValueChanged += new System.EventHandler(this.currentSizeX_ValueChanged);
            // 
            // currentSizeY
            // 
            this.currentSizeY.Location = new System.Drawing.Point(519, 370);
            this.currentSizeY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.currentSizeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentSizeY.Name = "currentSizeY";
            this.currentSizeY.Size = new System.Drawing.Size(48, 20);
            this.currentSizeY.TabIndex = 8;
            this.currentSizeY.Tag = "";
            this.currentSizeY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentSizeY.ValueChanged += new System.EventHandler(this.currentSizeY_ValueChanged);
            // 
            // spriteSheetText
            // 
            this.spriteSheetText.Location = new System.Drawing.Point(179, 331);
            this.spriteSheetText.Name = "spriteSheetText";
            this.spriteSheetText.Size = new System.Drawing.Size(146, 20);
            this.spriteSheetText.TabIndex = 25;
            this.spriteSheetText.TextChanged += new System.EventHandler(this.spriteSheetText_TextChanged);
            // 
            // spriteNameText
            // 
            this.spriteNameText.Location = new System.Drawing.Point(573, 331);
            this.spriteNameText.Name = "spriteNameText";
            this.spriteNameText.Size = new System.Drawing.Size(146, 20);
            this.spriteNameText.TabIndex = 26;
            this.spriteNameText.TextChanged += new System.EventHandler(this.spriteNameText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sprite Sheet Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sprite Name";
            // 
            // SpriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(761, 402);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spriteNameText);
            this.Controls.Add(this.spriteSheetText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentPosX);
            this.Controls.Add(this.currentPosY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentSizeX);
            this.Controls.Add(this.currentSizeY);
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
            this.Controls.Add(this.spriteSheetBox);
            this.Controls.Add(this.testBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SpriteForm";
            this.Text = "SprtieForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpriteForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpriteForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.PictureBox spriteSheetBox;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown currentPosX;
        private System.Windows.Forms.NumericUpDown currentPosY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown currentSizeX;
        private System.Windows.Forms.NumericUpDown currentSizeY;
        private System.Windows.Forms.TextBox spriteSheetText;
        private System.Windows.Forms.TextBox spriteNameText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}