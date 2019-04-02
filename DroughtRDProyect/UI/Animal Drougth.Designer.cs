namespace DroughtRDProyect.UI
{
    partial class rAnimalDrougth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAnimalDrougth));
            this.MateriaSecaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PesoVivoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TempMinAmbTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LluviaTextBox = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MateriaSecaTextBox
            // 
            this.MateriaSecaTextBox.Location = new System.Drawing.Point(164, 21);
            this.MateriaSecaTextBox.Name = "MateriaSecaTextBox";
            this.MateriaSecaTextBox.Size = new System.Drawing.Size(100, 20);
            this.MateriaSecaTextBox.TabIndex = 0;
            this.MateriaSecaTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia Seca Consumida (KG)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso Vivo (KG)";
            // 
            // PesoVivoTextBox
            // 
            this.PesoVivoTextBox.Location = new System.Drawing.Point(164, 47);
            this.PesoVivoTextBox.Name = "PesoVivoTextBox";
            this.PesoVivoTextBox.Size = new System.Drawing.Size(100, 20);
            this.PesoVivoTextBox.TabIndex = 2;
            this.PesoVivoTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperatura Minima Ambiental";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TempMinAmbTextBox
            // 
            this.TempMinAmbTextBox.Location = new System.Drawing.Point(527, 21);
            this.TempMinAmbTextBox.Name = "TempMinAmbTextBox";
            this.TempMinAmbTextBox.Size = new System.Drawing.Size(100, 20);
            this.TempMinAmbTextBox.TabIndex = 4;
            this.TempMinAmbTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Milimetros lluvia medios anuales en la zona";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LluviaTextBox
            // 
            this.LluviaTextBox.Location = new System.Drawing.Point(527, 47);
            this.LluviaTextBox.Name = "LluviaTextBox";
            this.LluviaTextBox.Size = new System.Drawing.Size(100, 20);
            this.LluviaTextBox.TabIndex = 6;
            this.LluviaTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(260, 87);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 29);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(165, 122);
            this.ResultadoTextBox.Multiline = true;
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.ReadOnly = true;
            this.ResultadoTextBox.Size = new System.Drawing.Size(300, 26);
            this.ResultadoTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Formula Aprobada por Cardot y colaboradores en el 2008";
            // 
            // rAnimalDrougth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 205);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LluviaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TempMinAmbTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PesoVivoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MateriaSecaTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "rAnimalDrougth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal Drougth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MateriaSecaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PesoVivoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TempMinAmbTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LluviaTextBox;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label5;
    }
}