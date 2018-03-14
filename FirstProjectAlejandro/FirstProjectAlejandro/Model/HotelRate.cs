using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class HotelRate { 


        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public double price { get; set; }
        public int id_hotel { get; set; }
        public int id { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }

        public HotelRate()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        public bool insert()
        {
            try
            {

                String sql = "INSERT INTO public.hotel_rate(id_hotel, price) VALUES("
                    + this.id_hotel + ", " + this.price + ");";

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
                string sql = "DELETE FROM public.hotel_rate WHERE id = " + this.id + ";";

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

                String sql = "UPDATE public.hotel_rate SET id_hotel = " + this.id_hotel + ", price = " + this.price
                    + " WHERE id = " + this.id + ";";

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
                String sql = "SELECT * FROM public.hotel_rate;";
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
