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
    public partial class Porm : Form
    {
        public Porm()
        {
            InitializeComponent();
        }

        //public Porm(User user)
        //{
        //    InitializeComponent();
        //    Nametxt.Text = user.Name;
        //    Countrytxt.Text = user.Country;
        //    Pricetxt.Text = (user.Price).ToString();
        //}

        public Porm(string message)
        {
            InitializeComponent();
            string[] sub = message.Split(' ');
            Nametxt.Text = sub[0];
            Countrytxt.Text = sub[1];
            Pricetxt.Text = sub[2];
        }


        public User Myuser = new User();
        public User NewMyuser = new User();

        private void Okbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Myuser.Name = Nametxt.Text;
            Myuser.Country = Countrytxt.Text;
            Myuser.Price = int.Parse(Pricetxt.Text);
        }


    }
}
