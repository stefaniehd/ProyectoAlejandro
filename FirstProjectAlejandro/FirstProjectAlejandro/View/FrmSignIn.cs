using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectAlejandro.View
{
    public partial class FrmSignIn : MetroFramework.Forms.MetroForm
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insert();
        }

        //it inserts a new user
        private void insert()
        {
            try
            {
                Model.User user = new Model.User();
                user.dni = txtId.Text;
                user.password = txtPass.Text;
                user.name = txtName.Text;
                user.type = "normal";
                if (user.password == this.txtVerPassword.Text.Trim())
                {
                    Controller.User cUser = new Controller.User(user);
                    cUser.insert();
                    MessageBox.Show("New User added!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please type the password again!");
                    txtVerPassword.Text = "";
                    txtPass.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Please, try again!");
            }
        }
    }
}
