using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;      
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite.EF6;


namespace FlightAttendanceApp
{
    public partial class Database : Form
    {
        string path = "FlightDb.db";
        string rpath = @"URI=file:" + Application.StartupPath + "\\FligtDb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;



        public Database()
        {
            InitializeComponent();
        }

        //show data
        private void data_show()
        {
            var con = new SQLiteConnection();
            con.Open();

            string query = "SELECT * FROM flight_sql";
            var cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Insert(0, reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9));
            }
        }
        private void Database_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            data_show();


        }
    }
}
