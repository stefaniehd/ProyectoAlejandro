using FirstProjectAlejandro.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectAlejandro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_MouseHover(object sender, EventArgs e)
        {
            btnGo.BackColor = Color.FromArgb(30, 144, 255);
        }

        private void btnGo_MouseLeave(object sender, EventArgs e)
        {
            btnGo.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            verifyUser();
        }

        //verifys the user
        private void verifyUser()
        {
            try
            {
                Model.User tUser = new Model.User();
                tUser.dni = txtDNI.Text.Trim();
                tUser.password = txtPassword.Text.Trim();
                Controller.User cUser = new Controller.User(tUser);
                Model.User mUser = cUser.verifyUser();
                if (mUser.type == "admin")
                {
                    clean();
                    View.FrmCrud oCrud = new View.FrmCrud();
                    oCrud.ShowDialog();
                }
                else
                {
                    clean();
                    View.FrmOrder oOrder = new View.FrmOrder();
                    oOrder.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Wrong data! Try again!");
            }
        }

        private void clean()
        {
            txtDNI.Text = "e.g. X0XXX0XXX";
            txtPassword.Text = "example";
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            FrmSignIn oSignIn = new FrmSignIn();
            oSignIn.Show();
        }

        private void txtDNI_DoubleClick(object sender, EventArgs e)
        {
            txtDNI.Text = "";
        }

        private void txtPassword_DoubleClick(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
