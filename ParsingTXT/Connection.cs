using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParsingTXT
{
    public class Connection
    {

        private static MySqlConnection _conn;
        private string _connString;
        private Parsing _parsing;

        public Connection()
        {
            _parsing = new Parsing();
        }

        public void SetConnection()
        {
            try
            {
                if (_conn == null)
                {
                    _conn = new MySqlConnection();
                    _connString = "SERVER= db4free.net;PORT=3306;DATABASE=users_auth_app;UID=auth_app;PASSWORD=1e69589c;";
                    _conn.ConnectionString = _connString;
                    _conn.Open();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseConection()
        {
            _conn.Close();
        }

        public void Post(List<Sentence> sentences)
        {
            foreach (var sentence in sentences)
            {
                var s = _parsing.TurnTheSentence(sentence.Text);
                var query = "INSERT INTO `Sentences`(`number_of_matches`, `sentence`) VALUES (" 
                            + "\"" + sentence.NumberOfMatches + "\"" + ","
                            + "\"" +  s + "\"" 
                            + ")";
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                var read = dataReader.Read();
                dataReader.Close();
            }
        }

        public List<string> Get()
        {
            string query = "SELECT `sentence` FROM `Sentences`";
            MySqlCommand cmd = new MySqlCommand(query, _conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            var sentences = new List<string>();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    //Console.WriteLine("{0}", dataReader.GetString(0));
                    var sentence = _parsing.TurnTheSentence(dataReader.GetString(0));
                    sentences.Add(sentence);
                }
            }
            dataReader.Close();
            return sentences;
        }

    }
}
