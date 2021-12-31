using MySql.Data.MySqlClient;
using pa3makeup.interfaces;
using pa3makeup.models;

namespace pa3makeup.database
{
    public class SavePost : ISavePost
    {
        public static void CreatePostTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE posts(id INTEGER PRIMARY KEY AUTO_INCREMENT, text TEXT, date DATE)";
            //string stm = @"CREATE TABLE posts(id INTEGER PRIMARY KEY AUTO_INCREMENT, date DATETIME, text TEXT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
        public void CreatePost(Post myPost)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO posts(text, date) VALUES(@text, @date)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@text", myPost.Text);
            cmd.Parameters.AddWithValue("@date", myPost.Date);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }

        void ISavePost.SavePost(Post myPost)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE posts set text = @text, date = @date";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@text", myPost.Text);
            cmd.Parameters.AddWithValue("@date", myPost.Date);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}