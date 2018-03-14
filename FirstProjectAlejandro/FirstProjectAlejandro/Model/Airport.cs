using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class Airport
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public String iata { get; set; }
        public int idPlace { get; set; }
        public String name { get; set; }
        public int id { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }

        public Airport()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        //saves an airport
        public bool insert()
        {
            try
            {
                String sql = "INSERT INTO public.airplane(name, id_place, iata) VALUES('"
                    + this.name + "', '" + this.idPlace + "', '" + this.iata + "');";

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

        //deletes an airport
        public bool delete()
        {
            try
            {
                string sql = "DELETE FROM public.airplane WHERE id = " + this.id + ";";

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

        //update an airport
        public bool update()
        {
            try
            {
                String sql = "UPDATE public.airplane SET name = '" + this.name
                    + "', iata = '" + this.iata + "', id_place = " + this.idPlace + " WHERE id = " + this.id + ";";

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

        //returns all the airports
        public DataTable select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(dBAccess);
            conn.Open();
            try
            {
                String sql = "SELECT * FROM public.airplane ORDER BY name ASC;";
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
            };
        }
    }
}
