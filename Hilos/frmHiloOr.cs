using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos
{
    public partial class frmHiloOr : Form
    {
        Thread proceso1, proceso2;
        byte r, g;
        bool b1, b2;
        Semaphore s1, s2;
        public frmHiloOr()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 0; g = 255; b1 = false; b2 = true;
            s1 = new Semaphore(1, 1); // Inicialmente permitido para hilo1
            s2 = new Semaphore(0, 1);
        }

        private void hilo1()
        {
            s1.WaitOne();
            while (true)
            {

                Thread.Sleep(10);
                if (r >= 0 && r <= 255 && b1 == false)
                {
                    r++;
                    if (r == 255)

                        b1 = true;



                }
                if (r >= 0 && r <= 255 && b1 == true)
                {
                    r--;
                    if (r == 0)
                        b1 = false;
                }

                pictureBox1.BackColor = Color.FromArgb(r, 100, 80);

            }
            s2.Release();

        }

        private void hilo2()
        {
            s2.WaitOne();
            while (true)
            {

                Thread.Sleep(10);
                if (r >= 0 && r <= 255 && b1 == false)
                {
                    r++;
                    if (r == 255)

                        b1 = true;



                }
                if (r >= 0 && r <= 255 && b1 == true)
                {
                    r--;
                    if (r == 0)
                        b1 = false;
                }

                pictureBox2.BackColor = Color.FromArgb(r, 80, 100);

            }
            s1.Release();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            proceso1 = new Thread(new ThreadStart(hilo1));
            proceso2 = new Thread(new ThreadStart(hilo2));
            proceso1.Start();
            proceso2.Start();
        }

        private void frmHiloOr_Load_1(object sender, EventArgs e)
        {

        }
    }
}
