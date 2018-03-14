using System;
using System.Data;

namespace FirstProjectAlejandro.Controller
{
    class Country
    {
		private Model.Country country;

        public Country()
        {
            this.country = new Model.Country();
        }

        public Country(Model.Country country)
        {
            this.country = country;

        }

		//inserts a new country or update a country
        public bool insert()
        {
            try
            {
                if (this.country.Id == 0)
                {
                    this.country.insert();
                }
                else
                {
                    this.country.update();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

		//deletes a country
        public bool delete()
        {
            try
            {
                this.country.delete();
                return true;
            }
            catch
            {
                return false;
            }
        }

		//returns all the countries
        public DataTable select()
        {
            try
            {
                return this.country.select();
            }
            catch
            {
                return null;
            }
        }
    }
}
