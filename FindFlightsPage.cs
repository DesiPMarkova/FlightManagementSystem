using System;
using System.CodeDom;
using System.Windows.Forms;

namespace InfoManagementSystem
{
    public partial class FindFlightsPage : Form
    {
        private User user;
        public FindFlightsPage(User user)
        {
            InitializeComponent();
            this.user = user;
            welcome.Text = $"Hello, {user.username}! You can find flights here";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSummary usersummary = new UserSummary(user);
            usersummary.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(from.Text) || string.IsNullOrEmpty(to.Text) || string.IsNullOrEmpty(travellers.Text) || airline.SelectedItem == null || type.SelectedItem == null || fromCalendar.SelectionStart == null || toCalendar.SelectionStart == null)
            {
                MessageBox.Show("Please fill out all fields.");
            }
            else
            {
                if (int.TryParse(travellers.Text, out int numTravellers))
                {
                    DateTime currentDate = DateTime.Now;
                    DateTime departureDate = fromCalendar.SelectionStart;
                    DateTime returnDate = toCalendar.SelectionStart;

                    if (departureDate.Date >= currentDate.Date && returnDate > departureDate)
                    {
                        try
                        {
                            ResultsPage results = new ResultsPage(user, from.Text, to.Text, fromCalendar.SelectionStart.ToShortDateString(), toCalendar.SelectionStart.ToShortDateString(), airline.SelectedItem.ToString(), type.SelectedItem.ToString(), numTravellers);
                            results.Show();
                            Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    else if (departureDate.Date < currentDate.Date)
                    {
                        MessageBox.Show("Departure date cannot be in the past.");
                    }
                    else
                    {
                        MessageBox.Show("Return date must be later than departure date.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for travellers!");
                }
            }

        }
    }
}
