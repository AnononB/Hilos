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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Hilo1()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (label1.InvokeRequired)
                {
                    label1.Invoke(new MethodInvoker(delegate
                    {

                        label1.Text = i.ToString();
                    }));
                }

                Thread.Sleep(500);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Hilo1= new Thread(new Thread(Hilo1));

        }
    }
}
