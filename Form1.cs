using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Name", 300 , HorizontalAlignment.Left);
            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Sec", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Eng", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Math", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("logic", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("DS", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Acc", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("OOP", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Percentage", 100 , HorizontalAlignment.Center);
            listView1.Columns.Add("gpa", 60, HorizontalAlignment.Center);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double eng, mat, log, ds, acc, opp, tot1 ;
            string gpa = "" ; 
            eng = Convert.ToDouble(teng.Text);
            mat = Convert.ToDouble(tmath.Text);
            log = Convert.ToDouble(tlogic.Text);
            ds = Convert.ToDouble(tdata.Text);
            acc = Convert.ToDouble(tacc.Text);
            opp = Convert.ToDouble(toop.Text);
            tot1 = ( (eng + mat + log + ds + acc + opp) / (600) ) *100;
            double tot = Math.Round(tot1, 2);
            bool found = true ; 
            if(tot > 100 || 0 > tot)
            {
                MessageBox.Show("Invlaid marks please chek it again");
                found = false ;
            }
            else if (100 >= tot && tot >= 90) gpa = "A+";
            else if (90 > tot && tot >= 85) gpa = "A";
            else if (85 > tot && tot >= 80) gpa = "B";
            else if (80 > tot && tot >= 70) gpa = "C";
            else if (70 > tot && tot >= 50) gpa = "D";
            else gpa = "F";
            if (found == true)
            {
                string a = Convert.ToString(tot);
                string[] res = { tname.Text, tid.Text, tsec.Text, teng.Text, tmath.Text, tlogic.Text, tdata.Text, tacc.Text, toop.Text, a + "%", gpa };
                ListViewItem item = new ListViewItem(res);
                listView1.Items.Add(item);
                ClEAR();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = tname.Text ;
            listView1.SelectedItems[0].SubItems[1].Text = tid.Text;
            listView1.SelectedItems[0].SubItems[2].Text = tsec.Text;
            listView1.SelectedItems[0].SubItems[3].Text = teng.Text;
            listView1.SelectedItems[0].SubItems[4].Text = tmath.Text;
            listView1.SelectedItems[0].SubItems[5].Text = tlogic.Text;
            listView1.SelectedItems[0].SubItems[6].Text = tdata.Text;
            listView1.SelectedItems[0].SubItems[7].Text = tacc.Text;
            listView1.SelectedItems[0].SubItems[8].Text = toop.Text;
            double eng, mat, log, ds, acc, opp, tot1;
            string gpa = "" ;
            eng = Convert.ToDouble(teng.Text);
            mat = Convert.ToDouble(tmath.Text);
            log = Convert.ToDouble(tlogic.Text);
            ds = Convert.ToDouble(tdata.Text);
            acc = Convert.ToDouble(tacc.Text);
            opp = Convert.ToDouble(toop.Text);
            tot1 = ((eng + mat + log + ds + acc + opp) / (600)) * 100;
            double tot = Math.Round(tot1, 2);
            bool found = true; 
            if (tot > 100 || 0 > tot)
            {
                MessageBox.Show("Invlaid marks please chek it again");
                found = false ; 
            }
            else if (100 >= tot && tot >= 90) gpa = "A+";
            else if (90 > tot && tot >= 85) gpa = "A";
            else if (85 > tot && tot >= 80) gpa = "B";
            else if (80 > tot && tot >= 70) gpa = "C";
            else if (70 > tot && tot >= 50) gpa = "D";
            else gpa = "F";
            if(found == true)
            {
                string a = Convert.ToString(tot);
                listView1.SelectedItems[0].SubItems[9].Text = a;
                listView1.SelectedItems[0].SubItems[10].Text = gpa;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void teng_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ClEAR()
        {
            tname.Clear();
            tsec.Clear();
            tmath.Clear();
            teng.Clear();
            tlogic.Clear();
            toop.Clear();
            tdata.Clear();
            tacc.Clear();
            tid.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ClEAR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure ???", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            tname.Text = listView1.SelectedItems[0].SubItems[0].Text;
            tid.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tsec.Text = listView1.SelectedItems[0].SubItems[2].Text;
            teng.Text = listView1.SelectedItems[0].SubItems[3].Text;
            tmath.Text = listView1.SelectedItems[0].SubItems[4].Text;
            tlogic.Text = listView1.SelectedItems[0].SubItems[5].Text;
            tdata.Text = listView1.SelectedItems[0].SubItems[6].Text;
            tacc.Text = listView1.SelectedItems[0].SubItems[7].Text;
            toop.Text = listView1.SelectedItems[0].SubItems[8].Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
