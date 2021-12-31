namespace pa3makeup
{
    public class ConnectionString
    {
        public string cs {get; set;}
        public ConnectionString()
        {
            string server = "ble5mmo2o5v9oouq.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "t4puxxbg38f9iqv0";
            string port = "3306";
            string userName = "ta2pu06qhgvb6eg7";
            string password = "banmlqzg6mcuog90";

            
            cs = $@"server={server};user={userName};database={database};port={port};password={password}";
        }
    }
}