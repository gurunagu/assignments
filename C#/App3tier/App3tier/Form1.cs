using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace App3tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BusinessL obj = new BusinessL();
        private void submit_Click(object sender, EventArgs e)
        {
            obj.EnterData(textBox2.Text,textBox1.Text);
            textBox2.Text = "";
            textBox1.Text = "";
            MessageBox.Show("data added Sucessfully!!!!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            obj.DeleteData(IdDel.Text);
            IdDel.Text = "";
            MessageBox.Show("data Deleted Sucessfully!!!!");
        }

        private void Display_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }
    }
}
