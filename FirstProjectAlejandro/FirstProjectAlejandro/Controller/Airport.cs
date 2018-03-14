using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Controller
{
    class Airport
    {
        private Model.Airport Airports;

        public Airport()
        {
            this.Airports = new Model.Airport();
        }

        public Airport(Model.Airport airports)
        {
            this.Airports = airports;

        }

        //saves an airport
        public bool insert()
        {
            try
            {
                if (this.Airports.id == 0)
                {
                    this.Airports.insert();
                }
                else
                {
                    this.Airports.update();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //deletes an airport
        public bool delete()
        {
            try
            {
                this.Airports.delete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Returns all the airports
        public DataTable select()
        {
            try
            {
                return this.Airports.select();
            }
            catch
            {
                return null;
            }
        }
    }
}
