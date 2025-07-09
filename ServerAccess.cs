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
    public partial class ServerAccess : Form
    {
        public ServerAccess()
        {
            InitializeComponent();
        }

        private void ServerAccess_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
