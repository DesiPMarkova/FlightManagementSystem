using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace InfoManagementSystem
{
    public partial class ResultsPage : Form
    {
        
        private SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Flights; Integrated Security=True;");
        private User user;
        public string From { get; set; }
        public string To { get; set; } 
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Airline { get; set; }
        public string Type { get; set; }
        public int Travellers { get; set; }

        public ResultsPage(User user, string from, string to, string fromDate, string toDate, string airline, string type, int travellers)
        { 
            InitializeComponent();
            this.user = user;
            From = from;
            To = to;
            FromDate = fromDate;
            ToDate = toDate;
            Airline = airline;
            Type = type;
            Travellers = travellers;

            DataGridViewButtonColumn bookButtonColumn = new DataGridViewButtonColumn();
            bookButtonColumn.Name = "Book";
            bookButtonColumn.Text = "Book";
            bookButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bookButtonColumn);

            dataGridView1.CellClick += (sender, e) =>
            {
                try
                {
                    if (e.ColumnIndex == dataGridView1.Columns["Book"].Index && e.RowIndex >= 0)
                    {
                        int ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["flightID"].Value);
                        int ID2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["flightID1"].Value);
                        SelectSeatsPage selectSeats = new SelectSeatsPage(user, Travellers, ID1, ID2);
                        selectSeats.Show();
                        Hide();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. " + ex.Message);
                }
            };


            LoadData();
        }

        private void LoadData()
        {
            sqlCon.Open();

            string query = @"
            SELECT f1.flightID, f1.[from], f1.departure, f1.type, f1.airline, f1.price, f2.flightID, f2.[from], f2.departure, f2.type, f2.airline, f2.price, (f1.price + f2.price) as 'total price'
            FROM flights f1
            JOIN flights f2 ON f1.[to] = f2.[from] AND f2.departure = @toDate
            WHERE f1.[from] = @from AND f1.departure = @fromDate
            AND (SELECT COUNT(*) FROM takenSeats WHERE flightID = f1.flightID) < (27 - @travellers)
            AND (SELECT COUNT(*) FROM takenSeats WHERE flightID = f2.flightID) < (27 - @travellers)";

            if (!Airline.Equals("No Preference"))
            {
                query += " AND f1.airline = @airline";
            }

            if (!Type.Equals("No Preference"))
            {
                query += " AND f1.type = @type";
            }
            

            SqlCommand cmd = new SqlCommand(query, sqlCon);

            cmd.Parameters.AddWithValue("@from", From);
            cmd.Parameters.AddWithValue("@to", To);
            cmd.Parameters.AddWithValue("fromDate", FromDate);
            cmd.Parameters.AddWithValue("toDate", ToDate);
            cmd.Parameters.AddWithValue("@airline", Airline);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@travellers", Travellers);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
            }
            sqlCon.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            FindFlightsPage form2 = new FindFlightsPage(user);
            form2.Show();
            Hide();
        }

    }
}
