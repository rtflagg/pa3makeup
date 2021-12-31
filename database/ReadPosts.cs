using MySql.Data.MySqlClient;
using pa3makeup.interfaces;
using pa3makeup.models;

namespace pa3makeup.database
{
    public class ReadPosts : IReadAllPosts, IGetPost
    {
        public List<Post> GetAllPosts()
        {
            List<Post> allPosts = new List<Post>();

            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM posts";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Post> posts = new List<Post>();

            while (rdr.Read())
            {
                Post p = new Post()
                {
                    Text = rdr.GetString(0),
                    Date = rdr.GetInt32(1)
                };
            }
            return allPosts;
        }

        public Post GetPost(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM posts WHERE id = @id";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            Post p = new Post()
            {
                Text = rdr.GetString(0),
                Date = rdr.GetDateTime(1)
            };
            return p;
        }
    }
}