using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Controller
{
    class Vehicle
    {
        private Model.Vehicle vehicles;

        public Vehicle()
        {
            this.vehicles = new Model.Vehicle();
        }

        public Vehicle(Model.Vehicle vehicles)
        {
            this.vehicles = vehicles;

        }

        //save a vehicle
        public bool insert()
        {
            try
            {
                if (this.vehicles.id == 0)
                {
                    this.vehicles.insert();
                }
                else
                {
                    this.vehicles.update();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //deletes a vehicle
        public bool delete()
        {
            try
            {
                this.vehicles.delete();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //returns all the vehicles
        public DataTable select()
        {
            try
            {
                return this.vehicles.select();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
