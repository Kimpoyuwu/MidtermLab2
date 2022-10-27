using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace David_BasicThreading
{

    public partial class Form1 : Form
    {
        private Thread thread1, thread2;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            ThreadStart delthreadStart = new ThreadStart(MyThreadClass.Thread1);

            thread1 = new Thread(delthreadStart);
            thread1.Name = "Thread A";

            thread2 = new Thread(delthreadStart);
            thread2.Name = "Thread B";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("-End of Thread-");
            lblThreads.Text = "-End of Thread-";






        }
    }
}
