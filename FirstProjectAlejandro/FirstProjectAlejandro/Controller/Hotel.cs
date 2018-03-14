using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Controller
{
    class Hotel
    {
        private Model.Hotel hotel;

        public Hotel()
        {
            this.hotel = new Model.Hotel();
        }

        public Hotel(Model.Hotel hotel)
        {
            this.hotel = hotel;

        }

        public bool insert()
        {
            try
            {
                if (this.hotel.id == 0)
                {
                    this.hotel.insert();
                }
                else
                {
                    this.hotel.update();
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
                this.hotel.delete();
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
                return this.hotel.select();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
