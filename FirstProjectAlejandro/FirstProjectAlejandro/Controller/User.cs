using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Controller
{
    class User
    {
        private Model.User user;

        public User()
        {
            this.user = new Model.User();
        }

        public User(Model.User user)
        {
            this.user = user;

        }

        //adds a new user
        public bool insert()
        {
            try
            {
                if (this.user.id == 0)
                {
                    this.user.insert();
                }
                else
                {
                    this.user.update();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //deletes an user object
        public bool delete()
        {
            try
            {
                this.user.delete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //returns all the registered users
        public DataTable select()
        {
            try
            {
                return this.user.select();
            }
            catch
            {
                return null;
            }
        }

        //verifys the login data
        public Model.User verifyUser()
        {
            try
            {
                return this.user.verifyUser();
            }
            catch
            {
                return null;
            }
        }
    }
}
