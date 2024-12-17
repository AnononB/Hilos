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
    public partial class frmHiloScT : Form
    {
        Thread proceso1, proceso2, proceso3, proceso4;
        byte r, g, b;
        bool b1, detener;
        Semaphore sem1, sem2, sem3, sem4;
        int contador;
        System.Windows.Forms.Timer timer;

        public frmHiloScT()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 0; g = 100; b = 200; b1 = false; detener = false;
            sem1 = new Semaphore(1, 1); // Inicialmente permitido para hilo1
            sem2 = new Semaphore(0, 1); // Inicialmente bloqueado para hilo2
            sem3 = new Semaphore(0, 1); // Inicialmente bloqueado para hilo3
            sem4 = new Semaphore(0, 1); // Inicialmente bloqueado para hilo4
            contador = 5; // Conteo de 5 segundos
            timer.Interval = 1000; // Intervalo de 1 segundo
            timer.Tick += new EventHandler(TimerTick);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
                lbl1.Text = contador.ToString();
                lbl2.Text = contador.ToString();
                lbl3.Text = contador.ToString();
                lbl4.Text = contador.ToString();
            }
            else
            {
                detener = true;
                timer.Stop();
            }
        }

        private void hilo1()
        {
            while (!detener)
            {
                sem1.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r++;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 255)
                        b1 = true;
                    pictureBox1.BackColor = Color.FromArgb(r, g, b);
                }
                while (r >= 0 && r <= 255 && b1 == true && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r--;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 0)
                        b1 = false;
                    pictureBox1.BackColor = Color.FromArgb(r, g, b);
                }
                sem2.Release(); // Permite hilo2
            }
        }

        private void hilo2()
        {
            while (!detener)
            {
                sem2.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r++;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 255)
                        b1 = true;
                    pictureBox2.BackColor = Color.FromArgb(r, b, g); // Cambia el orden de los colores
                }
                while (r >= 0 && r <= 255 && b1 == true && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r--;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 0)
                        b1 = false;
                    pictureBox2.BackColor = Color.FromArgb(r, b, g); // Cambia el orden de los colores
                }
                sem3.Release(); // Permite hilo3
            }
        }

        private void hilo3()
        {
            while (!detener)
            {
                sem3.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r++;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 255)
                        b1 = true;
                    pictureBox3.BackColor = Color.FromArgb(g, r, b); // Cambia el orden de los colores
                }
                while (r >= 0 && r <= 255 && b1 == true && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r--;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 0)
                        b1 = false;
                    pictureBox3.BackColor = Color.FromArgb(g, r, b); // Cambia el orden de los colores
                }
                sem4.Release(); // Permite hilo4
            }
        }

        private void hilo4()
        {
            while (!detener)
            {
                sem4.WaitOne(); // Espera permiso
                while (r >= 0 && r <= 255 && b1 == false && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r++;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 255)
                        b1 = true;
                    pictureBox4.BackColor = Color.FromArgb(b, r, g); // Cambia el orden de los colores
                }
                while (r >= 0 && r <= 255 && b1 == true && !detener)
                {
                    Thread.Sleep(1); // Tiempo de espera reducido para aumentar la velocidad
                    r--;
                    g = (byte)(255 - r); // Inviertes el valor de g
                    b = (byte)((r + g) / 2); // Mezcla r y g para b
                    if (r == 0)
                        b1 = false;
                    pictureBox4.BackColor = Color.FromArgb(b, r, g); // Cambia el orden de los colores
                }
                sem1.Release(); // Permite hilo1
                detener = true; // Detiene todos los hilos al terminar el ciclo del cuarto PictureBox
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            detener = false; // Asegúrate de que detener sea false cuando inicies el ciclo
            contador = 5; // Reinicia el contador a 5 segundos
            lbl1.Text = contador.ToString();
            lbl2.Text = contador.ToString();
            lbl3.Text = contador.ToString();
            lbl4.Text = contador.ToString();
            timer.Start(); // Inicia el temporizador
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

