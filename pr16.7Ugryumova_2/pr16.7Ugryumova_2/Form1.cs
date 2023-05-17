using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pr16._7Ugryumova_2
{
    public partial class Form1 : Form
    {
        string line;
        Queue<Employees> all = new Queue<Employees>();
        public Form1()
        {
            InitializeComponent();
            
            StreamReader file = new StreamReader("text.txt");
            while ((line = file.ReadLine()) != null)
            {
                Employees m = new Employees();
                string[] t = line.Split(' ');
                m.surname = t[0];
                m.name = t[1];
                m.patronymic = t[2];
                m.sex = t[3];
                m.age = t[4];
                m.salary = int.Parse(t[5]);
                all.Enqueue(m);
            }
            foreach (Employees member in all)
                if (member.salary < 10000)
                    listBox1.Items.Add(member);
            foreach (Employees member in all)
                if (member.salary >= 10000)
                    listBox1.Items.Add(member);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
