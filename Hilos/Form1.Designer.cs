namespace Hilos
{
    partial class frmHilo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            hilosToolStripMenuItem = new ToolStripMenuItem();
            hilosSemaforoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hilosToolStripMenuItem, hilosSemaforoToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // hilosToolStripMenuItem
            // 
            hilosToolStripMenuItem.Name = "hilosToolStripMenuItem";
            hilosToolStripMenuItem.Size = new Size(224, 26);
            hilosToolStripMenuItem.Text = "Hilos ";
            hilosToolStripMenuItem.Click += hilosToolStripMenuItem_Click;
            // 
            // hilosSemaforoToolStripMenuItem
            // 
            hilosSemaforoToolStripMenuItem.Name = "hilosSemaforoToolStripMenuItem";
            hilosSemaforoToolStripMenuItem.Size = new Size(224, 26);
            hilosSemaforoToolStripMenuItem.Text = "Hilos semaforo";
            hilosSemaforoToolStripMenuItem.Click += hilosSemaforoToolStripMenuItem_Click;
            // 
            // frmHilo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "frmHilo";
            Text = "Demostració de hilos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem hilosToolStripMenuItem;
        private ToolStripMenuItem hilosSemaforoToolStripMenuItem;
    }
}
