using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Controller
{
    class Airline
    {
        private Model.Airline route;

        public Airline()
        {
            this.route = new Model.Airline();
        }

        public Airline(Model.Airline route)
        {
            this.route = route;

        }

        public bool insert()
        {
            try
            {
                if (this.route.id == 0)
                {
                    this.route.insert();
                }
                else
                {
                    this.route.update();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete()
        {
            try
            {
                this.route.delete();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable select()
        {
            try
            {
                return this.route.select();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
