namespace Hilos
{
    partial class frmHilosSemaforo
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnIniciar1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(154, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 139);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(415, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 142);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnIniciar1
            // 
            btnIniciar1.Location = new Point(366, 448);
            btnIniciar1.Name = "btnIniciar1";
            btnIniciar1.Size = new Size(94, 29);
            btnIniciar1.TabIndex = 2;
            btnIniciar1.Text = "Iniciar";
            btnIniciar1.UseVisualStyleBackColor = true;
            btnIniciar1.Click += btnIniciar1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(415, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(171, 142);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(166, 237);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(171, 142);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // frmHilosSemaforo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 535);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnIniciar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmHilosSemaforo";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnIniciar1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}