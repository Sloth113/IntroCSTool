namespace ToolProject {
    partial class Menu {
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
            this.spriteMenuBttn = new System.Windows.Forms.Button();
            this.mapMenuBttn = new System.Windows.Forms.Button();
            this.collisionMenuBttn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteThingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapThingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collisionThingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spriteMenuBttn
            // 
            this.spriteMenuBttn.Location = new System.Drawing.Point(12, 437);
            this.spriteMenuBttn.Name = "spriteMenuBttn";
            this.spriteMenuBttn.Size = new System.Drawing.Size(96, 23);
            this.spriteMenuBttn.TabIndex = 1;
            this.spriteMenuBttn.Text = "Sprite Stuff";
            this.spriteMenuBttn.UseVisualStyleBackColor = true;
            this.spriteMenuBttn.Click += new System.EventHandler(this.spriteMenuBttn_Click);
            // 
            // mapMenuBttn
            // 
            this.mapMenuBttn.Location = new System.Drawing.Point(114, 437);
            this.mapMenuBttn.Name = "mapMenuBttn";
            this.mapMenuBttn.Size = new System.Drawing.Size(96, 23);
            this.mapMenuBttn.TabIndex = 2;
            this.mapMenuBttn.Text = "Map Stuff";
            this.mapMenuBttn.UseVisualStyleBackColor = true;
            this.mapMenuBttn.Click += new System.EventHandler(this.mapMenuBttn_Click);
            // 
            // collisionMenuBttn
            // 
            this.collisionMenuBttn.Location = new System.Drawing.Point(216, 437);
            this.collisionMenuBttn.Name = "collisionMenuBttn";
            this.collisionMenuBttn.Size = new System.Drawing.Size(96, 23);
            this.collisionMenuBttn.TabIndex = 3;
            this.collisionMenuBttn.Text = "Collision Stuff";
            this.collisionMenuBttn.UseVisualStyleBackColor = true;
            this.collisionMenuBttn.Click += new System.EventHandler(this.collisionMenuBttn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spriteThingToolStripMenuItem,
            this.mapThingToolStripMenuItem,
            this.collisionThingToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // spriteThingToolStripMenuItem
            // 
            this.spriteThingToolStripMenuItem.Name = "spriteThingToolStripMenuItem";
            this.spriteThingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.spriteThingToolStripMenuItem.Text = "Sprite Thing";
            this.spriteThingToolStripMenuItem.Click += new System.EventHandler(this.spriteThingToolStripMenuItem_Click);
            // 
            // mapThingToolStripMenuItem
            // 
            this.mapThingToolStripMenuItem.Name = "mapThingToolStripMenuItem";
            this.mapThingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.mapThingToolStripMenuItem.Text = "Map Thing";
            // 
            // collisionThingToolStripMenuItem
            // 
            this.collisionThingToolStripMenuItem.Name = "collisionThingToolStripMenuItem";
            this.collisionThingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.collisionThingToolStripMenuItem.Text = "Collision Thing ";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(717, 437);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 472);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.collisionMenuBttn);
            this.Controls.Add(this.mapMenuBttn);
            this.Controls.Add(this.spriteMenuBttn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spriteMenuBttn;
        private System.Windows.Forms.Button mapMenuBttn;
        private System.Windows.Forms.Button collisionMenuBttn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spriteThingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapThingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collisionThingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button quitButton;
    }
}

