using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace InfoManagementSystem
{
    public partial class UserSummary : Form
    {
        private User user;
        private string UserName;
        private int UserID;
        private SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Flights; Integrated Security=True;");

        public UserSummary(User user)
        {
            InitializeComponent();
            UserName = user.username;
            UserID = user.ID;
            hello.Text = $"Hello, {user.username}! Here are your flights in DeSky.";
            LoadDataIntoDataGridView();
            summary.CellClick += summary_CellClick;
        }

        private void summary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                int seatID = Convert.ToInt32(summary.Rows[e.RowIndex].Cells["seatID"].Value);
                int flightID = Convert.ToInt32(summary.Rows[e.RowIndex].Cells["flightID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to cancel this flight in ONE direction ONLY?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DeleteRecordFromTakenSeats(seatID, flightID);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row before attempting to cancel a flight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecordFromTakenSeats(int seatID, int flightID)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string query = "DELETE FROM takenSeats WHERE seatID = @SeatID AND flightID = @FlightID";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@SeatID", seatID);
                    command.Parameters.AddWithValue("@FlightID", flightID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Flight cancelled successfully.");
                        LoadDataIntoDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful cancellation.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string query = @"
                    SELECT ts.seatID, ts.flightID, f.[from], f.[to], f.departure, f.airline, f.type, f.price
                    FROM takenSeats ts
                    JOIN flights f ON ts.flightID = f.flightID
                    WHERE ts.userID = @UserID";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        summary.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading taken seats: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            WelcomePage Form1 = new WelcomePage();
            Hide();
            Form1.Show();
        }

        private void findflights_Click(object sender, EventArgs e)
        {
            User user = new User(UserID,UserName);
            FindFlightsPage form2 = new FindFlightsPage(user);
            form2.Show();
            Hide();
        }

       
        
    }
}

