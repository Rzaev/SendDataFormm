using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            listBox1.DisplayMember= ToString();
            Porm porm = new Porm();
            //porm.ShowDialog();
            List<User> users = new List<User>();

            //Porm porm = new Porm();
            if (porm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(new User
                {
                    Name = porm.Myuser.Name,
                    Country = porm.Myuser.Country,
                    Price = porm.Myuser.Price
                });
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //string message=listBox1.Items.ToString();
            //Porm porm = new Porm(message);
            //porm.ShowDialog();
            Porm porm = new Porm();
            string message = listBox1.Items.ToString();
            string[] sub = message.Split(' ');
            //porm.Myuser.Name = sub[0];
            //porm.Myuser.Country = sub[1];
            //porm.Myuser.Price =int.Parse(sub[2]);

           
            porm.NewMyuser.Name = sub[0];
            porm.NewMyuser.Country = sub[1];
            porm.NewMyuser.Price = int.Parse(sub[2]);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}

