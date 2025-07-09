using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteGeeks_IT
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void StartingProgress_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 10;
            StartingProgress.Value = startpoint;
            if (StartingProgress.Value == 100)
            {
                StartingProgress.Value = 0;
                timer1.Stop();
                ServerAccess serverAccess = new ServerAccess();
                this.Hide();
                serverAccess.Show();
            }
        }
    }
    
}
