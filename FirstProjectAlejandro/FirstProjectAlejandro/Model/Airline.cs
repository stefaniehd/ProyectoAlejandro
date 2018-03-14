using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class Airline
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public int duration { get; set; }
        public int idToCountry { get; set; }
        public int idFromCountry { get; set; }
        public int id { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }

        public Airline()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        public bool insert()
        {
            try
            {
                String sql = "INSERT INTO public.airline(id_to_country, id_from_country, duration) VALUES(" + 
                    this.idToCountry + ", " + this.idFromCountry + ", " + this.duration + ");";

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


        public bool delete()
        {
            try
            {
                string sql = "DELETE FROM public.airline WHERE id = " + this.id + ";";

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

        public bool update()
        {
            try
            {

                String sql = "UPDATE public.airline SET id_to_Country = '" + this.idToCountry
                    + "', id_from_country = '" + this.idFromCountry + "', duration = '" + this.duration + "' WHERE id = " + this.id + ";";

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

        public DataTable select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(dBAccess);
            conn.Open();
            try
            {
                String sql = "SELECT * FROM public.airline;";
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
