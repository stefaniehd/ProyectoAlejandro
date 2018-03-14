using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Controller
{
    class Place
    {
        private Model.Place places;

        public Place()
        {
            this.places = new Model.Place();
        }

        public Place(Model.Place places)
        {
            this.places = places;

        }

        //inserts a new place
        public bool insert()
        {
            try
            {
                if (this.places.id == 0)
                {
                    this.places.insert();
                }
                else
                {
                    this.places.update();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //deletes a place
        public bool delete()
        {
            try
            {
                this.places.delete();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //selects all the places
        public DataTable select()
        {
            try
            {
                return this.places.select();
            }
            catch
            {
                return null;
            }
        }
    }
}
