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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BusinessL l = new BusinessL();
            string[] name = l.GetNames();
            int[] no = l.GetNo();
            for(int i=0;i<name.Length;i++)
            {
                if(name[i]!=null)
                dataGridView1.Rows.Add(name[i],no[i]);
            }
        }
    }
}
