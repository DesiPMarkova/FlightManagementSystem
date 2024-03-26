using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InfoManagementSystem
{
    public partial class LogInPage : Form
    {

        public LogInPage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            string username = usernameBox.Text;
            string password = passwordBox.Text;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Flights; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT ID, username FROM Users WHERE username = @Username AND password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int userID = reader.GetInt32(0);
                        string name = reader.GetString(1);

                        User user = new User(userID, name);
                        UserSummary usersummary = new UserSummary(user);
                        usersummary.Show();
                       
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
        }
    }
}
