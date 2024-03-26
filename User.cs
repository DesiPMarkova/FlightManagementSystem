namespace InfoManagementSystem
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }

        public User(int iD, string username)
        {
            ID = iD;
            this.username = username;
        }
    }
}
