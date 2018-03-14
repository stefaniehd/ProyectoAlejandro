using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class Vehicle
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public int ammount { get; set; }
        public double price { get; set; }
        public String type { get; set; }
        public String model { get; set; }
        public String make { get; set; }
        public int id { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }

        public Vehicle()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        //saves a vehicle
        public bool insert()
        {
            try
            {
                String sql = "INSERT INTO public.vehicle(ammount, price, type, model, make) VALUES("
                    + this.ammount + ", " + this.price + ", '" + this.type + "', '" + this.model + "','" + this.make + "');";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
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
                string sql = "DELETE FROM public.vehicle WHERE id = " + this.id + ";";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //updates a vehicle
        public bool update()
        {
            try
            {
                String sql = "UPDATE public.vehicle SET ammount = " + this.ammount
                    + ", price = " + this.price + ", type = '" + this.type + "', model = '" + this.model + "', make = '" + this.make + "' WHERE id = " + this.id + ";";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
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
            NpgsqlConnection conn = new NpgsqlConnection(dBAccess);
            conn.Open();
            try
            {
                String sql = "SELECT * FROM public.vehicle ORDER BY make ASC;";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                return null;
            };
        }
    }
}
