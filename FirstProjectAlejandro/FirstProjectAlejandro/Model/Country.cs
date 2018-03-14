using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class Country
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Flag { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }

        public Country()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        //returns all the countries
        public DataTable select()
        {
            try
            {
                String sql = "SELECT * FROM public.country ORDER BY name ASC;";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        //inserts a new country
        public bool insert()
        {
            try
            {
                byte[] productImageByte = (byte[])this.Flag;
                String sql = "INSERT INTO public.country(name, flag) VALUES('"
                    + this.Name + "', '" + productImageByte + "');";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //delete a country
        public bool delete()
        {
            try
            {
                string sql = "DELETE FROM public.country WHERE id = " + this.Id + ";";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //update a country
        public bool update()
        {
            try
            {
                String sql = "UPDATE public.country SET  name = '" + this.Name
                    + "', flag = '" + this.Flag + "' WHERE id = " + this.Id + ";";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
