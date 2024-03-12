using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLibrary2;

namespace test
{
    public partial class Form1 : Form
    {

        DataBase dataBase1 = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskLibrary2.DataBase dataBase = new TaskLibrary2.DataBase();

            TaskLibrary2.Form1 form1 = new TaskLibrary2.Form1();
            form1.Show();
        }
    }
}
