using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectAlejandro.View
{
    public partial class FrmOrder : MetroFramework.Forms.MetroForm
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetHotel_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM public.hotel INNER JOIN hotel_rate ON (hotel_rate.id_hotel = hotel.id) INNER JOIN public.place on(hotel.id_place = place.id);";
            if (cmbSearchHotel.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose an option!");
            }
            else if (cmbSearchHotel.SelectedIndex == 1)//country
            {
                sql = "SELECT * FROM public.hotel INNER JOIN hotel_rate ON (hotel_rate.id_hotel = hotel.id) INNER JOIN public.place on(hotel.id_place = place.id) WHERE country.name like '%" + txtSearch.Text + "%';";

            }
            else if (cmbSearchHotel.SelectedIndex == 2)//place
            {
                sql = "SELECT * FROM public.hotel INNER JOIN hotel_rate ON (hotel_rate.id_hotel = hotel.id) INNER JOIN public.place on(hotel.id_place = place.id) WHERE place.name like '%" + txtSearch.Text + "%';";
            }
            else if (cmbSearchHotel.SelectedIndex == 3)//name
            
                sql = "SELECT * FROM public.hotel INNER JOIN hotel_rate ON (hotel_rate.id_hotel = hotel.id) INNER JOIN public.place on(hotel.id_place = place.id) WHERE hotel.name like '%"+txtSearch.Text+"%';";
            }
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=travels;CommandTimeout=3600;");
            conn.Open();
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
                foreach (DataRow row in dt.Rows)
                {
                    dgvHotels.Rows.Add(row["name"], row["price"]);
                }
            }
            catch
            {
            };
        }
    }
}
