using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axMSFlexGrid2.set_TextMatrix(1, 1, "Test");
            this.axMSFlexGrid2.set_TextMatrix(2, 2, "Test");
            this.axMSFlexGrid2.set_TextMatrix(3, 3, "Test");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
