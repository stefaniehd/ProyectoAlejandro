using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectAlejandro.Model
{
    class User
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public String dni { get; set; }
        public String name { get; set; }
        public String password { get; set; }
        public String type { get; set; }
        public int id { get; set; }
        public string dBAccess { get; set; }
        public NpgsqlConnection conn { get; set; }

        public User()
        {
            dBAccess = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;";
            conn = new NpgsqlConnection(dBAccess);
            conn.Open();
        }

        //adds a new user
        public bool insert()
        {
            try
            {
                string hash = "";
                using (MD5 md5Hash = MD5.Create())
                {
                    hash = Util.Hash.GetMd5Hash(md5Hash, this.password);
                }
                String sql = "INSERT INTO public.user(name, password, type, dni) VALUES('"
                    + this.name + "', '" + hash + "', '" + this.type + "', '" + this.dni + "');";

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

        //deletes an user object
        public bool delete()
        {
            try
            {
                string sql = "DELETE FROM public.user WHERE id = " + this.id + ";";

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


        public bool update()
        {
            try
            {
                string hash = "";
                using (MD5 md5Hash = MD5.Create())
                {
                    hash = Util.Hash.GetMd5Hash(md5Hash, this.password);
                }
                String sql = "UPDATE public.user SET dni = '" + this.dni + "', name = '" + this.name
                    + "', password = '" + this.password + "', type = '" + this.type + "' WHERE id = " + this.id + ";";

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

        //returns all the registered users
        public DataTable select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(dBAccess);
            conn.Open();
            try
            {
                String sql = "SELECT * FROM public.user ORDER BY name ASC;";
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

        public Model.User verifyUser()
        {
            NpgsqlConnection conn = new NpgsqlConnection(dBAccess);
            conn.Open();
            try
            {
                string hash = "";
                string sql = "";
                using (MD5 md5Hash = MD5.Create())
                {
                    hash = Util.Hash.GetMd5Hash(md5Hash, this.password);
                    sql = "SELECT * FROM public.user WHERE dni = '" + this.dni + "' and password = '" + Util.Hash.GetMd5Hash(md5Hash, this.password) + "';";
                }
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                Model.User u = new User();
                u.id = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                u.name = dt.Rows[0]["name"].ToString();
                u.password = dt.Rows[0]["password"].ToString();
                u.dni = dt.Rows[0]["dni"].ToString();
                u.type = dt.Rows[0]["type"].ToString();
                return u;
            }
            catch
            {
                return null;
            };
        }
    }
}
