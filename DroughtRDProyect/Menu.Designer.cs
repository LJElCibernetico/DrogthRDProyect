namespace DroughtRDProyect
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.droughtAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantingDroughtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalDroughtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earthlyDroughtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.droughtAnimalToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // droughtAnimalToolStripMenuItem
            // 
            this.droughtAnimalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalDroughtToolStripMenuItem,
            this.earthlyDroughtToolStripMenuItem,
            this.plantingDroughtToolStripMenuItem});
            this.droughtAnimalToolStripMenuItem.Name = "droughtAnimalToolStripMenuItem";
            this.droughtAnimalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.droughtAnimalToolStripMenuItem.Text = "Proyects";
            this.droughtAnimalToolStripMenuItem.Click += new System.EventHandler(this.droughtAnimalToolStripMenuItem_Click);
            // 
            // plantingDroughtToolStripMenuItem
            // 
            this.plantingDroughtToolStripMenuItem.Image = global::DroughtRDProyect.Properties.Resources.sequia_1_;
            this.plantingDroughtToolStripMenuItem.Name = "plantingDroughtToolStripMenuItem";
            this.plantingDroughtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantingDroughtToolStripMenuItem.Text = "Planting drought";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // animalDroughtToolStripMenuItem
            // 
            this.animalDroughtToolStripMenuItem.Image = global::DroughtRDProyect.Properties.Resources.huella_de_pata;
            this.animalDroughtToolStripMenuItem.Name = "animalDroughtToolStripMenuItem";
            this.animalDroughtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animalDroughtToolStripMenuItem.Text = "Animal Drought";
            this.animalDroughtToolStripMenuItem.Click += new System.EventHandler(this.animalDroughtToolStripMenuItem_Click);
            // 
            // earthlyDroughtToolStripMenuItem
            // 
            this.earthlyDroughtToolStripMenuItem.Image = global::DroughtRDProyect.Properties.Resources.sequia_2_;
            this.earthlyDroughtToolStripMenuItem.Name = "earthlyDroughtToolStripMenuItem";
            this.earthlyDroughtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.earthlyDroughtToolStripMenuItem.Text = "Earthly Drought";
            this.earthlyDroughtToolStripMenuItem.Click += new System.EventHandler(this.earthlyDroughtToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem droughtAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalDroughtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earthlyDroughtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantingDroughtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

