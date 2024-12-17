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
    public partial class frmHilosSemaforo : Form
    {

        Thread proceso1, proceso2, proceso3, proceso4;
        //byte r;
        byte r, g, b;
        bool b1; //detener;
        Semaphore s1, s2, s3, s4;
        public frmHilosSemaforo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // r = 0; b1 = false;
            r = 0; g = 100; b = 200; b1 = false; //detener = false; ;
            s1 = new Semaphore(1, 1); // Inicialmente permitido para hilo1
            s2 = new Semaphore(0, 1); // Inicialmente bloqueado para hilo2
            s3 = new Semaphore(0, 1);
            s4 = new Semaphore(0, 1);
        }

        private void hilo1()
        {
            while (true)
            {
                s1.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false)
                {
                    Thread.Sleep(2);
                    r++;
                    //
                   
                    //

                    if (r == 255)
                        b1 = true;
                    pictureBox1.BackColor = Color.FromArgb(r, g, b);
                }
                while (r >= 0 && r <= 255 && b1 == true)
                {
                    Thread.Sleep(2);
                    r--;
                   
                    if (r == 0)
                        b1 = false;
                    pictureBox1.BackColor = Color.FromArgb(r, g, b);
                }
                s2.Release(); // Permite hilo2
            }
        }

        private void hilo2()
        {
            while (true)
            {
                s2.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false)
                {
                    Thread.Sleep(2);
                    r++;
                    
                    if (r == 255)
                        b1 = true;
                    pictureBox2.BackColor = Color.FromArgb(r, g, b);
                }
                while (r >= 0 && r <= 255 && b1 == true)
                {
                    Thread.Sleep(2);
                    r--;
                   
                    if (r == 0)
                        b1 = false;
                    pictureBox2.BackColor = Color.FromArgb(r, g, b);
                }
                s3.Release(); // Permite hilo3
            }
        }

        private void hilo3()
        {
            while (true)
            {
                s3.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false)
                {
                    Thread.Sleep(2);
                    r++;
                   /* g = (byte)(255 - r);
                    b = (byte)((r + g) / 2);*/
                    if (r == 255)
                        b1 = true;
                    pictureBox3.BackColor = Color.FromArgb(r, g, b);
                }
                while (r >= 0 && r <= 255 && b1 == true)
                {
                    Thread.Sleep(2);
                    r--;
                   /* g = (byte)(255 - r);
                    b = (byte)((r + g) / 2);*/
                    if (r == 0)
                        b1 = false;
                    pictureBox3.BackColor = Color.FromArgb(r, g, b);
                }
                s4.Release(); // Permite hilo1
            }
        }

        private void hilo4()
        {
            while (true)
            {
                s4.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false)
                {
                    Thread.Sleep(2);
                    r++;
                    g = (byte)(255 - r);
                    b = (byte)((r + g) / 2);
                    if (r == 255)
                        b1 = true;
                    pictureBox4.BackColor = Color.FromArgb(r, g, b);
                }
                while (r >= 0 && r <= 255 && b1 == true)
                {
                    Thread.Sleep(2);
                    r--;
                    g = (byte)(255 - r);
                    b = (byte)((r + g) / 2);
                    if (r == 0)
                        b1 = false;
                    pictureBox4.BackColor = Color.FromArgb(r, g, b);
                }
                s1.Release(); // Permite hilo1
                //detener = true;
            }
        }

        private void btnIniciar1_Click(object sender, EventArgs e)
        {
            //detener= false;
            proceso1 = new Thread(new ThreadStart(hilo1));
            proceso2 = new Thread(new ThreadStart(hilo2));
            proceso3 = new Thread(new ThreadStart(hilo3));
            proceso4 = new Thread(new ThreadStart(hilo4));
            proceso1.Start();
            proceso2.Start();
            proceso3.Start();
            proceso4.Start();
        }
    }
}
