namespace Unidad4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actividad4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividad4ToolStripMenuItem,
            this.ejercicio1ToolStripMenuItem1,
            this.ejercicio2ToolStripMenuItem1,
            this.ejercicio3ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actividad4ToolStripMenuItem
            // 
            this.actividad4ToolStripMenuItem.Name = "actividad4ToolStripMenuItem";
            this.actividad4ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.actividad4ToolStripMenuItem.Text = "Actividad 4";
            // 
            // ejercicio1ToolStripMenuItem1
            // 
            this.ejercicio1ToolStripMenuItem1.Name = "ejercicio1ToolStripMenuItem1";
            this.ejercicio1ToolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.ejercicio1ToolStripMenuItem1.Text = "Ejercicio1";
            this.ejercicio1ToolStripMenuItem1.Click += new System.EventHandler(this.ejercicio1ToolStripMenuItem1_Click);
            // 
            // ejercicio2ToolStripMenuItem1
            // 
            this.ejercicio2ToolStripMenuItem1.Name = "ejercicio2ToolStripMenuItem1";
            this.ejercicio2ToolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.ejercicio2ToolStripMenuItem1.Text = "Ejercicio2";
            this.ejercicio2ToolStripMenuItem1.Click += new System.EventHandler(this.ejercicio2ToolStripMenuItem1_Click);
            // 
            // ejercicio3ToolStripMenuItem1
            // 
            this.ejercicio3ToolStripMenuItem1.Name = "ejercicio3ToolStripMenuItem1";
            this.ejercicio3ToolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.ejercicio3ToolStripMenuItem1.Text = "Ejercicio3";
            this.ejercicio3ToolStripMenuItem1.Click += new System.EventHandler(this.ejercicio3ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actividad4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem1;
    }
}

