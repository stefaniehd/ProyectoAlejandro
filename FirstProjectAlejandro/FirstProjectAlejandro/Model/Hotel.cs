using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class Hotel
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public int roomAmount { get; set; }
        public String name { get; set; }
        public int idPlace { get; set; }
        public int id { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }


        public Hotel()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        public bool insert()
        {
            try
            {
                String sql = "INSERT INTO public.hotel(name, room_ammount, id_place) VALUES('"
                    + this.name + "', " + this.roomAmount + ", " + this.idPlace + ");";

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
                string sql = "DELETE FROM public.hotel WHERE id = " + this.id + ";";

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
                String sql = "UPDATE public.hotel SET name = '" + this.name
                    + "', room_ammount = " + this.roomAmount + ", id_place = "+ this.idPlace + " WHERE id = " 
                    + this.id + ";";

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
                String sql = "SELECT * FROM public.hotel ORDER BY name ASC;";
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
