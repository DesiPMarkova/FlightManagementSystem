using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InfoManagementSystem
{
    public partial class SelectSeatsPage : Form
    {
        private User user;
        private int travellers;
        private int selectedSeats = 0;
        private int ID1;
        private int ID2;
      
        public SelectSeatsPage(User user, int travellers, int ID1, int ID2)
        {
            InitializeComponent();
            this.user = user;
           
            this.travellers = travellers;
            this.ID1 = ID1;
            this.ID2 = ID2;
            seatselect.Text = $"{user.username}, please select seats!";

            Update();
        }

        private void Update()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Flights; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT seatID FROM takenSeats WHERE flightID = @ID1";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@ID1", ID1);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int seatID = reader.GetInt32(0);

                    Button seatButton = this.Controls.Find("seat" + seatID, true).FirstOrDefault() as Button;
                    if (seatButton != null)
                    {
                        seatButton.Enabled = false;
                        seatButton.BackColor = Color.Red;
                    }
                }
            }

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Flights; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT seatID FROM takenSeats WHERE flightID = @ID2";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@ID2", ID2);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int seatID = reader.GetInt32(0);

                    Button seatButton = this.Controls.Find("seat" + seatID + "A", true).FirstOrDefault() as Button;
                    if (seatButton != null)
                    {
                        seatButton.Enabled = false;
                        seatButton.BackColor = Color.Red;
                    }
                }
            }


            for (int i = 1; i <= 27; i++)
            {
                Button seatButton = this.Controls.Find("seat" + i, true).FirstOrDefault() as Button;
                Button seatButtonA = this.Controls.Find("seat" + i + "A", true).FirstOrDefault() as Button;

                if (seatButton != null && seatButton.Enabled)
                {
                    seatButton.BackColor = Color.Green;
                }

                if (seatButtonA != null && seatButtonA.Enabled)
                {
                    seatButtonA.BackColor = Color.Green;
                }
            }
        }

        private void seatClick(int seatID, int flightID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Flights; Integrated Security=True;"))
            {
                sqlCon.Open();
                string add = "INSERT INTO takenSeats (seatID, flightID, userID) VALUES (@seatID, @flightID1, @userID)";
                SqlCommand cmd = new SqlCommand(add, sqlCon);
                cmd.Parameters.AddWithValue("@seatID", seatID);
                cmd.Parameters.AddWithValue("@flightID1", flightID);
                cmd.Parameters.AddWithValue("@userID", user.ID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Seat Booked!");
                selectedSeats++;
                if (selectedSeats == 2*travellers)
                {
                    MessageBox.Show("You have booked your flights for departure and return!");
                    //  FindFlightsPage findFlights = new FindFlightsPage(user);
                    //findFlights.Show();
                    UserSummary usersummary = new UserSummary(user);
                    usersummary.Show();
                    Hide();
                }
                Update();
            }
        }

        private void seat1_Click(object sender, EventArgs e)
        {
            seatClick(1, ID1);
        }

        private void seat2_Click(object sender, EventArgs e)
        {
            seatClick(2, ID1);
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            seatClick(3, ID1);
        }

        private void seat4_Click(object sender, EventArgs e)
        {
            seatClick(4, ID1);
        }

        private void seat5_Click(object sender, EventArgs e)
        {
            seatClick(5, ID1);
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            seatClick(6, ID1);
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            seatClick(7, ID1);
        }

        private void seat8_Click(object sender, EventArgs e)
        {
            seatClick(8, ID1);
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            seatClick(9, ID1);
        }

        private void seat10_Click(object sender, EventArgs e)
        {
            seatClick(10, ID1);
        }

        private void seat11_Click(object sender, EventArgs e)
        {
            seatClick(11, ID1);
        }

        private void seat12_Click(object sender, EventArgs e)
        {
            seatClick(12, ID1);
        }

        private void seat13_Click(object sender, EventArgs e)
        {
            seatClick(13, ID1);
        }

        private void seat14_Click(object sender, EventArgs e)
        {
            seatClick(14, ID1);
        }

        private void seat15_Click(object sender, EventArgs e)
        {
            seatClick(15, ID1);
        }

        private void seat16_Click(object sender, EventArgs e)
        {
            seatClick(16, ID1);
        }

        private void seat17_Click(object sender, EventArgs e)
        {
            seatClick(17, ID1);
        }

        private void seat18_Click(object sender, EventArgs e)
        {
            seatClick(18, ID1);
        }

        private void seat19_Click(object sender, EventArgs e)
        {
            seatClick(19, ID1);
        }

        private void seat20_Click(object sender, EventArgs e)
        {
            seatClick(20, ID1);
        }

        private void seat21_Click(object sender, EventArgs e)
        {
            seatClick(21, ID1);
        }

        private void seat22_Click(object sender, EventArgs e)
        {
            seatClick(22, ID1);
        }

        private void seat23_Click(object sender, EventArgs e)
        {
            seatClick(23, ID1);
        }

        private void seat24_Click(object sender, EventArgs e)
        {
            seatClick(24, ID1);
        }

        private void seat25_Click(object sender, EventArgs e)
        {
            seatClick(25, ID1);
        }

        private void seat26_Click(object sender, EventArgs e)
        {
            seatClick(26, ID1);
        }

        private void seat27_Click(object sender, EventArgs e)
        {
            seatClick(27, ID1);
        }

        private void seat1A_Click(object sender, EventArgs e)
        {
            seatClick(1, ID2);
        }

        private void seat2A_Click(object sender, EventArgs e)
        {
            seatClick(2, ID2);
        }

        private void seat3A_Click(object sender, EventArgs e)
        {
            seatClick(3, ID2);
        }

        private void seat4A_Click(object sender, EventArgs e)
        {
            seatClick(4, ID2);
        }

        private void seat5A_Click(object sender, EventArgs e)
        {
            seatClick(5, ID2);
        }

        private void seat6A_Click(object sender, EventArgs e)
        {
            seatClick(6, ID2);
        }

        private void seat7A_Click(object sender, EventArgs e)
        {
            seatClick(7, ID2);
        }

        private void seat8A_Click(object sender, EventArgs e)
        {
            seatClick(8, ID2);
        }

        private void seat9A_Click(object sender, EventArgs e)
        {
            seatClick(9, ID2);
        }

        private void seat10A_Click(object sender, EventArgs e)
        {
            seatClick(10, ID2);
        }

        private void seat11A_Click(object sender, EventArgs e)
        {
            seatClick(11, ID2);
        }

        private void seat12A_Click(object sender, EventArgs e)
        {
            seatClick(12, ID2);
        }

        private void seat13A_Click(object sender, EventArgs e)
        {
            seatClick(13, ID2);
        }

        private void seat14A_Click(object sender, EventArgs e)
        {
            seatClick(14, ID2);
        }

        private void seat15A_Click(object sender, EventArgs e)
        {
            seatClick(15, ID2);
        }

        private void seat16A_Click(object sender, EventArgs e)
        {
            seatClick(16, ID2);
        }

        private void seat17A_Click(object sender, EventArgs e)
        {
            seatClick(17, ID2);
        }

        private void seat18A_Click(object sender, EventArgs e)
        {
            seatClick(18, ID2);
        }

        private void seat19A_Click(object sender, EventArgs e)
        {
            seatClick(19, ID2);
        }

        private void seat20A_Click(object sender, EventArgs e)
        {
            seatClick(20, ID2);
        }

        private void seat21A_Click(object sender, EventArgs e)
        {
            seatClick(21, ID2);
        }

        private void seat22A_Click(object sender, EventArgs e)
        {
            seatClick(22, ID2);
        }

        private void seat23A_Click(object sender, EventArgs e)
        {
            seatClick(23, ID2);
        }

        private void seat24A_Click(object sender, EventArgs e)
        {
            seatClick(24, ID2);
        }

        private void seat25A_Click(object sender, EventArgs e)
        {
            seatClick(25, ID2);
        }

        private void seat26A_Click(object sender, EventArgs e)
        {
            seatClick(26, ID2);
        }

        private void seat27A_Click(object sender, EventArgs e)
        {
            seatClick(27, ID2);
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            
            FindFlightsPage form2 = new FindFlightsPage(user);
            form2.Show();
            Hide();
        }
    }
}
