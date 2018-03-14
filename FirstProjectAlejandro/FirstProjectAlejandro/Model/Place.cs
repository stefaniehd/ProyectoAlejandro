using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class Place
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public String name { get; set; }
        public int id { get; set; }
        public int idCountry { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }


        public Place()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        //inserts a new place
        public bool insert()
        {
            try
            {

                String sql = "INSERT INTO public.place(name, id_country) VALUES('"
                    + this.name + "', " + this.idCountry + ");";

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

        //deletes a place
        public bool delete()
        {
            try
            {
                string sql = "DELETE FROM public.place WHERE id = " + this.id + ";";

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

        //updates a place
        public bool update()
        {
            try
            {

                String sql = "UPDATE public.place SET name = '" + this.name + "', id_country = " + this.idCountry
                    + " WHERE id = " + this.id + ";";

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

        //selects all the places
        public DataTable select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(dBAccess);
            conn.Open();
            try
            {
                String sql = "SELECT * FROM public.place ORDER BY name ASC;";
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
