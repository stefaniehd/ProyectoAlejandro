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
    public partial class FrmCrud : MetroFramework.Forms.MetroForm
    {
        private byte[] flag { get; set; }

        public FrmCrud()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnDoCountry_Click(object sender, EventArgs e)
        {
            doCountry();
        }

        //loads all the countries
        private void refreshCountry()
        {
            try
            {
                dgvCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Controller.Country cCountry = new Controller.Country();
                DataTable dtCountry = cCountry.select();
                dgvCountry.Rows.Clear();

                foreach (DataRow row in dtCountry.Rows)
                {
                    dgvCountry.Rows.Add(row["id"], row["name"], row["flag"]);
                }

                cmbCountries.DisplayMember = "Name";
                cmbCountries.ValueMember = "id";
                cmbCountries.DataSource = dtCountry;
                
                cmbPlaceByPCountry.DisplayMember = "Name";
                cmbPlaceByPCountry.ValueMember = "id";
                cmbPlaceByPCountry.DataSource = dtCountry;

                cmbFrom.DisplayMember = "Name";
                cmbFrom.ValueMember = "id";
                cmbFrom.DataSource = dtCountry;
            }
            catch
            {
            }
        }

        //loads all the place
        private void refreshPlace()
        {
            try
            {
                dgvPlace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Controller.Place cPlace = new Controller.Place();
                DataTable dtPlace = cPlace.select();
                dgvPlace.Rows.Clear();

                foreach (DataRow row in dtPlace.Rows)
                {
                    dgvPlace.Rows.Add(row["id"], row["name"], row["id_country"]);
                }

                cmbPlace.DisplayMember = "Name";
                cmbPlace.ValueMember = "id";
                cmbPlace.DataSource = dtPlace;

                cmbAirportsByPlace.DisplayMember = "Name";
                cmbAirportsByPlace.ValueMember = "id";
                cmbAirportsByPlace.DataSource = dtPlace;

                cmbHotelByLocation.DisplayMember = "Name";
                cmbHotelByLocation.ValueMember = "id";
                cmbHotelByLocation.DataSource = dtPlace;
            }
            catch
            {
            }
        }

        //does an action of the country tab
        private void doCountry()
        {
            Model.Country mCountry = new Model.Country();
            Controller.Country cCountry = new Controller.Country();
            if (cmbCountryAction.SelectedIndex == 0)
            {
                MessageBox.Show("Please, choose an action!");
            }
            else if (cmbCountryAction.SelectedIndex == 1) //select
            {
                refreshCountry();
            }
            else if (cmbCountryAction.SelectedIndex == 2) //delete
            {
                mCountry.Id = Convert.ToInt32(cmbCountries.SelectedValue.ToString());
                cCountry = new Controller.Country(mCountry);
                cCountry.delete();
                refreshCountry();
            }
            else if (cmbCountryAction.SelectedIndex == 3)
            {
                cmbCountries.Enabled = true;
                gbNewCountry.Visible = true;
                txtCountryId.Text = cmbCountries.SelectedValue.ToString();
                gbNewCountry.Visible = true;
            }
            else if (cmbCountryAction.SelectedIndex == 4)
            {
                cmbCountries.Enabled = false;
                gbNewCountry.Visible = true;
                txtCountryId.Text = "0";
                gbNewCountry.Visible = true;
            }
        }

        //does an action of the country tab
        private void doPlace()
        {
            Model.Place mPlace = new Model.Place();
            Controller.Place cPlace = new Controller.Place();
            if (cmbCountryAction.SelectedIndex == 0)
            {
                MessageBox.Show("Please, choose an action!");
                cmbPlace.Enabled = false;
            }
            else if (cmbPlacesActions.SelectedIndex == 1) //select
            {
                refreshCountry();
                cmbPlace.Enabled = false;
                refreshPlace();
            }
            else if (cmbPlacesActions.SelectedIndex == 2) //delete
            {
                cmbPlace.Enabled = true;
                mPlace.id = Convert.ToInt32(cmbPlace.SelectedValue.ToString());
                cPlace = new Controller.Place(mPlace);
                cPlace.delete();
                refreshPlace();
            }
            else if (cmbPlacesActions.SelectedIndex == 3)
            {
                cmbPlace.Enabled = true;
                gbNewCountry.Visible = true;
                gbPlaceActions.Visible = true;
                txtPlaceId.Text = cmbPlace.SelectedValue.ToString();
            }
            else if (cmbPlacesActions.SelectedIndex == 4)
            {
                cmbPlace.Enabled = false;
                gbPlaceActions.Visible = true;
                txtPlaceId.Text = "0";
            }
        }

        //saves a country
        private void saveCountry()
        {
            try
            {
                Model.Country mCountry = new Model.Country();
                Controller.Country cCountry = new Controller.Country();
                mCountry.Id = Convert.ToInt32(txtCountryId.Text.ToString());
                mCountry.Name = txtCountryName.Text;
                mCountry.Flag = this.flag;
                cCountry = new Controller.Country(mCountry);
                cCountry.insert();
                refreshCountry();
            }
            catch
            {
                MessageBox.Show("Please, try again!");
            }
        }

        //Saves a place
        private void savePlace()
        {
            try
            {
                Model.Place mPlace = new Model.Place();
                mPlace.id = Convert.ToInt32(txtPlaceId.Text);
                mPlace.name = txtPlaceName.Text;
                mPlace.idCountry = (int)cmbPlaceByPCountry.SelectedValue;
                Controller.Place cPlaces = new Controller.Place(mPlace);
                cPlaces.insert();
                refreshPlace();
            }
            catch
            {

            }
        }

        //loads all the airports
        private void refreshAirports()
        {
            try
            {
                dgvAirport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Controller.Airport cPlace = new Controller.Airport();
                DataTable dtAirport = cPlace.select();
                dgvAirport.Rows.Clear();

                foreach (DataRow row in dtAirport.Rows)
                {
                    dgvAirport.Rows.Add(row["id"], row["name"], row["id_place"], row["iata"]);
                }

                cmbPlace.DisplayMember = "Name";
                cmbPlace.ValueMember = "id";
                cmbPlace.DataSource = dtAirport;
            }
            catch
            {
            }
        }

        //loads all the hotels
        private void refreshHotel()
        {
            try
            {
                dgvHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Controller.Hotel cPlace = new Controller.Hotel();
                DataTable dtAirport = cPlace.select();
                dgvHotel.Rows.Clear();

                foreach (DataRow row in dtAirport.Rows)
                {
                    dgvHotel.Rows.Add(row["id"], row["name"], row["id_place"], row["room_ammount"]);
                }

                cmbHotelRate.DisplayMember = "Name";
                cmbHotelRate.ValueMember = "id";
                cmbHotelRate.DataSource = dtAirport;
                
            }
            catch
            {
            }
        }

        //loads all the hotel's rates
        private void refreshHotelRate()
        {
            try
            {
                dgvHotelRate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Controller.HotelRate cPlace = new Controller.HotelRate();
                DataTable dtAirport = cPlace.select();
                dgvHotelRate.Rows.Clear();

                foreach (DataRow row in dtAirport.Rows)
                {
                    dgvHotelRate.Rows.Add(row["id"], row["price"], row["id_hotel"]);
                }

            }
            catch
            {
            }
        }

        //Airport's actions
        private void doAirport()
        {
            Model.Airport mAirport = new Model.Airport();
            Controller.Airport cAirport = new Controller.Airport();
            if (cmbAirportsAction.SelectedIndex == 0)//insert
            {
                MessageBox.Show("Please, choose an action!");
            }
            else if (cmbAirportsAction.SelectedIndex == 1)//insert
            {
                saveAirports();
            }
            else if (cmbAirportsAction.SelectedIndex == 2)//delete
            {
                int select = dgvAirport.CurrentCell.RowIndex;
                mAirport.id = Convert.ToInt32(dgvAirport.Rows[select].Cells["cAirportId"].Value.ToString());
                cAirport = new Controller.Airport(mAirport);
                cAirport.delete();
                refreshAirports();
            }
            else if (cmbAirportsAction.SelectedIndex == 3)//update
            {
                dgvAirport.Enabled = true;
                saveAirports();
            }
            else if (cmbAirportsAction.SelectedIndex == 4)//refresh
            {
                refreshAirports();
            }
        }

        //loads all the airlines
        private void refreshAirline()
        {
            try
            {
                dgvAirline.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Controller.Airline cPlace = new Controller.Airline();
                DataTable dtPlace = cPlace.select();
                dgvAirline.Rows.Clear();

                foreach (DataRow row in dtPlace.Rows)
                {
                    dgvAirline.Rows.Add(row["id"], row["id_from_country"], row["id_to_country"], row["duration"]);
                }
                
            }
            catch
            {
            }
        }

        //saves an airport
        private void saveAirports()
        {
            try
            {
                if (!cmbAirportsByPlace.Enabled)
                {
                    Model.Airport mAirport = new Model.Airport();
                    int select = dgvAirport.CurrentCell.RowIndex;
                    mAirport.name = dgvAirport.Rows[select].Cells["cAirportName"].Value.ToString();
                    mAirport.iata = dgvAirport.Rows[select].Cells["cIata"].Value.ToString();
                    mAirport.id = Convert.ToInt32(dgvAirport.Rows[select].Cells["cAirportId"].Value.ToString());
                    mAirport.idPlace = Convert.ToInt32(dgvAirport.Rows[select].Cells["cAirportLocation"].Value.ToString());
                    Controller.Airport cAirport = new Controller.Airport(mAirport);
                    cAirport.insert();
                    refreshAirports();
                    return;
                }
                else
                {
                        Model.Airport mAirport = new Model.Airport();
                        mAirport.name = dgvAirport.Rows[dgvAirport.Rows.Count-1].Cells["cAirportName"].Value.ToString();
                        mAirport.iata = dgvAirport.Rows[dgvAirport.Rows.Count - 1].Cells["cIata"].Value.ToString();
                        mAirport.id = Convert.ToInt32(dgvAirport.Rows[dgvAirport.Rows.Count - 1].Cells["cAirportId"].Value.ToString());
                        mAirport.idPlace = Convert.ToInt32(cmbAirportsByPlace.SelectedValue); ;
                        Controller.Airport cAirport = new Controller.Airport(mAirport);
                        cAirport.insert();
                }
                refreshAirports();
            }
            catch
            {
            }
        }

        //saves an hotel
        private void saveHotel()
        {
            try
            {
                if (!cmbHotelByLocation.Enabled)
                {
                    Model.Hotel mAirport = new Model.Hotel();
                    int select = dgvAirport.CurrentCell.RowIndex;
                    mAirport.name = dgvHotel.Rows[select].Cells["cHotelName"].Value.ToString();
                    mAirport.roomAmount = Convert.ToInt32(dgvHotel.Rows[select].Cells["cHotelRooms"].Value.ToString());
                    mAirport.id = Convert.ToInt32(dgvHotel.Rows[select].Cells["cHotelId"].Value.ToString());
                    mAirport.idPlace = Convert.ToInt32(dgvHotel.Rows[select].Cells["cHotelPlace"].Value.ToString());
                    Controller.Hotel cAirport = new Controller.Hotel(mAirport);
                    cAirport.insert();
                    refreshHotel();
                    return;
                }
                else
                {
                    Model.Hotel mAirport = new Model.Hotel();
                    mAirport.name = dgvHotel.Rows[dgvHotel.Rows.Count-1].Cells["cHotelName"].Value.ToString();
                    mAirport.roomAmount = Convert.ToInt32(dgvHotel.Rows[dgvHotel.Rows.Count - 1].Cells["cHotelRooms"].Value.ToString());
                    mAirport.idPlace = Convert.ToInt32(cmbHotelByLocation.SelectedValue); ;
                    Controller.Hotel cAirport = new Controller.Hotel(mAirport);
                    cAirport.insert();
                }
                refreshHotel();
            }
            catch
            {
            }
        }

        //saves an hotel's rate
        private void saveHotelRate()
        {
            try
            {
                if (!cmbHotelRate.Enabled)
                {
                    Model.HotelRate mAirport = new Model.HotelRate();
                    int select = dgvHotelRate.CurrentCell.RowIndex;
                    mAirport.id_hotel = Convert.ToInt32(dgvHotelRate.Rows[select].Cells["cHotelRateHotel"].Value.ToString());
                    mAirport.price = Convert.ToInt32(dgvHotelRate.Rows[select].Cells["cHotelRatePrice"].Value.ToString());
                    mAirport.id = Convert.ToInt32(dgvHotelRate.Rows[select].Cells["cHotelRateId"].Value.ToString());
                    Controller.HotelRate cAirport = new Controller.HotelRate(mAirport);
                    cAirport.insert();
                    refreshHotelRate();
                    return;
                }
                else
                {
                    Model.HotelRate mAirport = new Model.HotelRate();
                    mAirport.id_hotel = Convert.ToInt32(cmbHotelRate.SelectedValue);
                    mAirport.price = Convert.ToInt32(dgvHotelRate.Rows[dgvHotelRate.Rows.Count - 1].Cells["cHotelRatePrice"].Value.ToString());
                    Controller.HotelRate cAirport = new Controller.HotelRate(mAirport);
                    cAirport.insert();
                }
                refreshHotelRate();
            }
            catch
            {
            }
        }

        //loads all the vehicles
        private void refreshVehicles()
        {
            try
            {
                dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Controller.Vehicle cPlace = new Controller.Vehicle();
                DataTable dtVehicle = cPlace.select();
                dgvVehicles.Rows.Clear();

                foreach (DataRow row in dtVehicle.Rows)
                {
                    dgvVehicles.Rows.Add(row["id"], row["make"], row["model"], row["type"], row["price"], row["ammount"]);
                }
            }
            catch
            {
            }
        }

        //saves an vehicle
        private void saveVecicle()
        {
            try
            {
               Model.Vehicle mVehicle = new Model.Vehicle();
               int select = dgvVehicles.CurrentCell.RowIndex;
               mVehicle.make = dgvVehicles.Rows[select].Cells["cVehicleMake"].Value.ToString();
               mVehicle.model = dgvVehicles.Rows[select].Cells["cVehicleModel"].Value.ToString();
               mVehicle.id = Convert.ToInt32(dgvVehicles.Rows[select].Cells["cVehicleId"].Value.ToString());
               mVehicle.type = dgvVehicles.Rows[select].Cells["cVehicleType"].Value.ToString();
               mVehicle.price = Convert.ToDouble(dgvVehicles.Rows[select].Cells["cVehiclePrice"].Value.ToString());
               mVehicle.ammount = Convert.ToInt32(dgvVehicles.Rows[select].Cells["cVehicleAmmount"].Value.ToString());
               Controller.Vehicle cVehcle = new Controller.Vehicle(mVehicle);
               cVehcle.insert();
               refreshVehicles();
            }
            catch(Exception e)
            {
            }
        }

        //Airport's actions
        private void doVehicle()
        {
            Model.Vehicle mAirport = new Model.Vehicle();
            Controller.Vehicle cAirport = new Controller.Vehicle();
            if (cmbVehicleActions.SelectedIndex == 0)//nothing
            {
                MessageBox.Show("Please, choose an action!");
            }
            else if (cmbVehicleActions.SelectedIndex == 1)//select
            {
                refreshVehicles();
            }
            else if (cmbVehicleActions.SelectedIndex == 2)//delete
            {
                int select = dgvVehicles.CurrentCell.RowIndex;
                mAirport.id = Convert.ToInt32(dgvVehicles.Rows[select].Cells["cVehicleId"].Value.ToString());
                cAirport = new Controller.Vehicle(mAirport);
                cAirport.delete();
                refreshAirports();
            }
            else if (cmbVehicleActions.SelectedIndex == 3)//update
            {
                saveVecicle();
            }
            else if (cmbVehicleActions.SelectedIndex == 4)//insert
            {
                saveVecicle();
            }
        }

        //Airport's actions
        private void doAirlne()
        {
            Model.Airline mAirport = new Model.Airline();
            Controller.Airline cAirport = new Controller.Airline();
            if (cmbAirlineActions.SelectedIndex == 0)//nothing
            {
                MessageBox.Show("Please, choose an action!");
            }
            else if (cmbAirlineActions.SelectedIndex == 1)//select
            {
                refreshAirline();
            }
            else if (cmbAirlineActions.SelectedIndex == 2)//delete
            {
                cAirport = new Controller.Airline();
                int select = dgvAirline.CurrentCell.RowIndex;
                mAirport.id = Convert.ToInt32(dgvAirline.Rows[select].Cells["cAirlineId"].Value.ToString());
                cAirport = new Controller.Airline(mAirport);
                cAirport.delete();
            }
            else if (cmbAirlineActions.SelectedIndex == 3)//update
            {
                cAirport = new Controller.Airline();
                int select = dgvVehicles.CurrentCell.RowIndex;
                mAirport.id = Convert.ToInt32(dgvAirline.Rows[select].Cells["cAirlineId"].Value.ToString());
                mAirport.idFromCountry = Convert.ToInt32(cmbFrom.SelectedValue);
                mAirport.idToCountry = Convert.ToInt32(cmbTo.SelectedValue);
                mAirport.duration = Convert.ToInt32(txtHoursAirline.Text.Trim());
                cAirport = new Controller.Airline(mAirport);
                cAirport.insert();
            }
            else if (cmbAirlineActions.SelectedIndex == 4)//insert
            {
                cAirport = new Controller.Airline();
                mAirport.idFromCountry = Convert.ToInt32(cmbFrom.SelectedValue);
                mAirport.idToCountry = Convert.ToInt32(cmbTo.SelectedValue);
                mAirport.duration = Convert.ToInt32(txtHoursAirline.Text.Trim());
                cAirport = new Controller.Airline(mAirport);
                cAirport.insert();
            }
        }

        //Hotel's actions
        private void doHotel()
        {
            Model.Hotel mAirport = new Model.Hotel();
            Controller.Hotel cAirport = new Controller.Hotel();
            if (cmbHotelAction.SelectedIndex == 0)//insert
            {
                MessageBox.Show("Please, choose an action!");
            }
            else if (cmbHotelAction.SelectedIndex == 1)//insert
            {
                saveHotel();
            }
            else if (cmbHotelAction.SelectedIndex == 2)//delete
            {
                int select = dgvAirport.CurrentCell.RowIndex;
                mAirport.id = Convert.ToInt32(dgvHotel.Rows[select].Cells["cHotelId"].Value.ToString());
                cAirport = new Controller.Hotel(mAirport);
                cAirport.delete();
                refreshHotel();
            }
            else if (cmbHotelAction.SelectedIndex == 3)//update
            {
                dgvHotel.Enabled = true;
                saveHotel();
            }
            else if (cmbHotelAction.SelectedIndex == 4)//refresh
            {
                refreshHotel();
            }
        }

        //Hotel's actions
        private void doHotelRate()
        {
            Model.HotelRate mAirport = new Model.HotelRate();
            Controller.HotelRate cAirport = new Controller.HotelRate();
            if (cmbHotelRateActions.SelectedIndex == 0)//insert
            {
                MessageBox.Show("Please, choose an action!");
            }
            else if (cmbHotelRateActions.SelectedIndex == 1)//insert
            {
                saveHotelRate();
            }
            else if (cmbHotelRateActions.SelectedIndex == 2)//delete
            {
                int select = dgvHotelRate.CurrentCell.RowIndex;
                mAirport.id = Convert.ToInt32(dgvHotelRate.Rows[select].Cells["cHotelRateId"].Value.ToString());
                cAirport = new Controller.HotelRate(mAirport);
                cAirport.delete();
                refreshHotelRate();
            }
            else if (cmbHotelRateActions.SelectedIndex == 3)//update
            {
                dgvHotelRate.Enabled = true;
                saveHotelRate();
            }
            else if (cmbHotelRateActions.SelectedIndex == 4)//refresh
            {
                refreshHotelRate();
            }
        }

        private void cmbCountryAction_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCountryAction.SelectedIndex == 0)
            {
                cmbCountries.Enabled = false;
                gbNewCountry.Visible = false;
            }
            else if (cmbCountryAction.SelectedIndex == 1)
            {
                cmbCountries.Enabled = false;
                gbNewCountry.Visible = false;
            }
            else if (cmbCountryAction.SelectedIndex == 2)
            {
                cmbCountries.Enabled = true;
                gbNewCountry.Visible = false;
            }
            else if (cmbCountryAction.SelectedIndex == 3)
            {
                cmbCountries.Enabled = true;
                gbNewCountry.Visible = false;
            }
            else if (cmbCountryAction.SelectedIndex == 4)
            {
                cmbCountries.Enabled = false;
                gbNewCountry.Visible = false;
            }
        }

        private void btnSearchFlag_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.flag = System.IO.File.ReadAllBytes(ofd.FileName);
            }
        }

        private void btnSaveCountry_Click(object sender, EventArgs e)
        {
            saveCountry();
        }

        private void cmbPlacesActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlacesActions.SelectedIndex == 0)
            {
                cmbPlace.Enabled = false;
                gbPlaceActions.Visible = false;
            }
            else if (cmbPlacesActions.SelectedIndex == 1)
            {
                cmbPlace.Enabled = false;
                gbPlaceActions.Visible = false;
            }
            else if (cmbPlacesActions.SelectedIndex == 2)
            {
                cmbPlace.Enabled = true;
                gbPlaceActions.Visible = false;
            }
            else if (cmbPlacesActions.SelectedIndex == 3)
            {
                cmbPlace.Enabled = true;
                gbPlaceActions.Visible = false;
            }
            else if (cmbPlacesActions.SelectedIndex == 4)
            {
                cmbPlace.Enabled = true;
                gbPlaceActions.Visible = false;
            }
        }

        private void btnDoPlace_Click(object sender, EventArgs e)
        {
            doPlace();
        }

        private void btnSavePlace_Click(object sender, EventArgs e)
        {
            savePlace();
        }

        private void cmbAirportsAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAirportsAction.SelectedIndex == 1)//insert
            {
                dgvAirport.Enabled = true;
                dgvAirport.Rows.Add(0, "", 0, "");
                cmbAirportsByPlace.Enabled = true;
            }
            else if (cmbAirportsAction.SelectedIndex == 2)//delete
            {
                dgvAirport.Enabled = true;
                cmbAirportsByPlace.Enabled = false;
            }
            else if (cmbAirportsAction.SelectedIndex == 3)//update
            {
                dgvAirport.Enabled = true;
                cmbAirportsByPlace.Enabled = false;
            }
            else if (cmbAirportsAction.SelectedIndex == 0)//update
            {
                dgvAirport.Enabled = false;
                cmbAirportsByPlace.Enabled = false;
            }
            else if (cmbAirportsAction.SelectedIndex == 1)//update
            {
                dgvAirport.Enabled = false;
                cmbAirportsByPlace.Enabled = false;
            }
        }

        private void btnSaveAirports_Click(object sender, EventArgs e)
        {
            doAirport();
        }

        private void cmbVehicleActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicleActions.SelectedIndex == 1)//select
            {
                dgvAirport.Enabled = false;
            }
            else if (cmbVehicleActions.SelectedIndex == 2)//delete
            {
                dgvAirport.Enabled = true;
            }
            else if (cmbVehicleActions.SelectedIndex == 3)//update
            {
                dgvAirport.Enabled = true;
            }
            else if (cmbVehicleActions.SelectedIndex == 0)//nothing
            {
                dgvAirport.Enabled = false;
            }
            else if (cmbVehicleActions.SelectedIndex == 4)//insert
            {
                dgvVehicles.Enabled = true;
                dgvVehicles.Rows.Add(0, "", "", "", 0, 0);
            }
        }

        private void btnVehicleDone_Click(object sender, EventArgs e)
        {
            doVehicle();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAirlineActions.SelectedIndex == 1)//select
            {
                dgvAirline.Enabled = false;
            }
            else if (cmbAirlineActions.SelectedIndex == 2)//delete
            {
                dgvAirline.Enabled = true;
            }
            else if (cmbAirlineActions.SelectedIndex == 3)//update
            {
                dgvAirline.Enabled = true;
            }
            else if (cmbAirlineActions.SelectedIndex == 0)//nothing
            {
                dgvAirline.Enabled = false;
            }
            else if (cmbAirlineActions.SelectedIndex == 4)//insert
            {
                dgvAirline.Enabled = false;

                Controller.Country cCountry = new Controller.Country();
                DataTable dtCountry = cCountry.select();

                cmbTo.DisplayMember = "Name";
                cmbTo.ValueMember = "id";
                cmbTo.DataSource = dtCountry;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doAirlne();
        }

        private void cmbHotelAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHotelAction.SelectedIndex == 1)//insert
            {
                dgvHotel.Enabled = true;
                dgvHotel.Rows.Add(0, "", 0, 0);
                cmbHotelByLocation.Enabled = true;
            }
            else if (cmbHotelAction.SelectedIndex == 2)//delete
            {
                dgvHotel.Enabled = true;
                cmbHotelByLocation.Enabled = false;
            }
            else if (cmbHotelAction.SelectedIndex == 3)//update
            {
                dgvHotel.Enabled = true;
                cmbHotelByLocation.Enabled = false;
            }
            else if (cmbHotelAction.SelectedIndex == 0)//update
            {
                dgvHotel.Enabled = false;
                cmbHotelByLocation.Enabled = false;
            }
            else if (cmbHotelAction.SelectedIndex == 1)//update
            {
                dgvHotel.Enabled = false;
                cmbHotelByLocation.Enabled = false;
            }
        }

        private void btnDoneHotel_Click(object sender, EventArgs e)
        {
            doHotel();
        }

        private void cmbHotelRateActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHotelRateActions.SelectedIndex == 1)//insert
            {
                dgvHotelRate.Enabled = true;
                dgvHotelRate.Rows.Add(0, 0, 0);
                cmbHotelRate.Enabled = true;
            }
            else if (cmbHotelRateActions.SelectedIndex == 2)//delete
            {
                dgvHotelRate.Enabled = true;
                cmbHotelRate.Enabled = false;
            }
            else if (cmbHotelRateActions.SelectedIndex == 3)//update
            {
                dgvHotelRate.Enabled = true;
                cmbHotelRate.Enabled = false;
            }
            else if (cmbHotelRateActions.SelectedIndex == 0)//update
            {
                dgvHotelRate.Enabled = false;
                cmbHotelRate.Enabled = false;
            }
            else if (cmbHotelRateActions.SelectedIndex == 1)//update
            {
                dgvHotelRate.Enabled = false;
                cmbHotelRate.Enabled = false;
            }
        }

        private void btnDoneHotelRate_Click(object sender, EventArgs e)
        {
            doHotelRate();
        }
    }
}
