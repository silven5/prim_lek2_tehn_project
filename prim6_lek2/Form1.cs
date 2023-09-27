using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prim6_lek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.LastName = LastName.Text;
            person.Age=Convert.ToInt32(Age.Text);
            person.Salary=Convert.ToDouble(Salary.Text);
           
            Rezult.Text = person.LastName + " " +
                person.Age.ToString() + " " +
                person.Status;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
