using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Data.SqlClient;
//using Sqtlie_project_tutorial;


namespace FlightAttendanceApp
{
    public partial class MainForm : Form
    {
        //path to data base

        string path = "FlightDb.db";
        string rpath = @"URI=file:" + Application.StartupPath + "\\FligtDb.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        

        //private DataTable Ticket = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        //inserting datas
        public void insert()
        {
            string selectFlight = comboBox1.Text;
            string from = comboBox2.Text;
            string to = comboBox3.Text;
            string gender = comboBox5.Text;
            string seatP = groupBox1.Text;
            string flightclass = groupBox2.Text;
            string foodselect = checkedListBox1.SelectedIndex.ToString();
            string departure = dateTimePicker1.Text.ToString();
            string return_date = dateTimePicker2.Text.ToString();
            
            if (comboBox1.Equals("") || comboBox2.Equals("") || comboBox3.Equals("") || comboBox5.Equals("") || groupBox1.Equals("") || groupBox2.Equals("") || checkedListBox1.Equals("") || dateTimePicker1.Equals("") || dateTimePicker2.Equals(""))
            {
                MessageBox.Show("Missing Values");
                return;
            }
            else
            {   

               

                try
                {

                    var con = new SQLiteConnection(@"Data Source="+path);
                    con.Open(); 
                    //var cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO flight_sql(flight_selected,from,to,gender,seat_position,flight_class,food_item_select,departure_date,return_date) " +
                          "VALUES ('" + selectFlight + "','" + from + "','" + to + "','" + gender + "','" + seatP + "','" + flightclass + "','" + foodselect + "','" + departure + "','" + return_date + "')";
                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }



            /**cmd.Parameters.AddWithValue("@flight_selected", selectFlight);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@seatP", seatP);
            cmd.Parameters.AddWithValue("@flightclass", flightclass);
            cmd.Parameters.AddWithValue("@foodselect", foodselect);
            cmd.Parameters.AddWithValue("@departure_date", departure);
            cmd.Parameters.AddWithValue("@return_date", return_date);**/

            //string path = "FlightDb.db";
            //string qs = @"URI=file:" + Application.StartupPath + "\\FlightDb.db";//databse create debug folder 


            //SQLiteDataReader reader;
            //string query = "INSERT INTO flight_sql(FlightSelected, From, To, Gender, SeatPosition, FlightClass, FoodItemSelected, DepartureDate, ReturnDate) " +
            //      "VALUES ('" + selectFlight + "','" + from + "','" + to + "' ,'" + gender + "','" + seatP + "','" + flightclass + "','" + foodselect + "','" + departure + "','" + return_date + "')";
            // SQLiteConnection con = new SQLiteConnection(Connection);

            //SQLiteCommand cmd = new SQLiteCommand(query, con);
            /**cmd.Parameters.AddWithValue("@SelectFlight", selectFlight);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@seatP", seatP);
            cmd.Parameters.AddWithValue("@flightclass", flightclass);
            cmd.Parameters.AddWithValue("@foodselect", foodselect);
            cmd.Parameters.AddWithValue("@departure", departure);
            cmd.Parameters.AddWithValue("@return_date", return_date);**/
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //return;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s = comboBox1.SelectedItem.ToString();
            //pictureBox3.Image = new Bitmap(s);
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

       /** private void filled_teble()
        {
            Ticket.Columns.Add("ID", typeof(int));
            Ticket.Columns.Add("Flight Name");
            Ticket.Columns.Add("Seat Position");
            Ticket.Columns.Add("Flight Class");
            Ticket.Columns.Add("from");
            Ticket.Columns.Add("To");
            Ticket.Columns.Add("Gender");
            Ticket.Columns.Add("Food Selected");
            Ticket.Columns.Add("departure Date");
            Ticket.Columns.Add("departure Time");
            Ticket.Columns.Add("Return Date");
            Ticket.Columns.Add("Return Time");

            
            Ticket.Rows.Add(1, comboBox1.SelectedItem, GrpBox1(),GrpBox2(), comboBox2.Text, comboBox3.Text, comboBox5.Text,
                dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Text.ToString(),
                dateTimePicker2.Value.ToShortDateString(), dateTimePicker2.Text.ToString());

            //Ticket.Rows.Add(2,"suleja", "katsina", "Male", "5th-june-2021", "5:00pm", "6th-june-2021", "2:00pm");
        }**/

        private void Reset()
        {
            

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox5.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text="";

        }

        
        private string GrpBox1()
        {
            RadioButton[] checkBoxes = new RadioButton[3];
            checkBoxes[0] = radioButton1;
            checkBoxes[1] = radioButton2;
            checkBoxes[2] = radioButton3;
            
            for (int i = 0; i < 0; i++)
            {
                if (checkBoxes[i].Checked == true)
                {
                    return checkBoxes[i].Text;
                }

            }
            return checkBoxes[0].Text;


        }

        private string GrpBox2()
        {
            RadioButton[] checkBoxes = new RadioButton[3];
            checkBoxes[0] = radioButton4;
            checkBoxes[1] = radioButton5;
            checkBoxes[2] = radioButton6;

            for (int i = 0; i > 0; i++)
            {
                if (checkBoxes[i].Checked == true)
                {
                    return checkBoxes[i].Text;
                }

            }
            return "";
        }

        private string Combo5()
        {
            if(comboBox5.SelectedIndex == 0)
            {
                return comboBox5.Text = "Female";
            }
            else if (comboBox5.SelectedIndex ==1)
            {
                return comboBox5.Text = "Male";
            }
        return comboBox5.Text;
        }

       

        /**private void StreamWrite() 
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Level_400\\" + "FlightAttendance.txt");

            //sw.WriteLine("Flight Name:{0}", );
            sw.WriteLine("Start Date:{0}", dateTimePicker1.Text);
            sw.WriteLine("Start Date:{0}", dateTimePicker2.Text);
            sw.WriteLine("local Flight:{0}", comboBox1.SelectedItem);
            sw.WriteLine("From:{0}", comboBox2.SelectedItem);
            sw.WriteLine("To:{0}", comboBox3.SelectedItem);
            sw.WriteLine("Gender:{0}", comboBox5.Text);
            sw.WriteLine("Seat Postition:{0}", groupBox1.Text);
            sw.WriteLine("Flight Class:{0}", groupBox2.Text);
            //sw.WriteLine("Food Selection:{0}", );
            //filled_teble();

            sw.Close();

        }**/

       

        private void label11_Click_1(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();
            this.Close();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            Form about = new about();
            about.Show();   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            insert();
            Reset();
            MessageBox.Show("Successfully Booked and saved!!!");
            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Your Flight Has been Saved and Booked");
            // DialogResult dialbox = MessageBox.Show("1.Do you want to Book now and view reeceipt", "/n2. Cancel Booking", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            /**if (dialbox == DialogResult.Yes)
            {
                
                StreamWrite();
                var filepath = @"C:\Users\El_Musty\Desktop\C#\FlightAttendanceApp\FlightAttendanceApp\bin\Debug\Level_400\FlightAttendance.txt";
                using (var sstreamReader = new StreamReader(filepath)) 
                {
                    string line;
                    while (!string.IsNullOrWhiteSpace(line = sstreamReader.ReadLine())) 
                    {
                        //listBox1.Items.Add(line);
                    }

                }


            }

            else if (dialbox == DialogResult.No)
            {
                MessageBox.Show("Booking Reservation Canceled");
            }

            else
            {
                MessageBox.Show("ok to Cancel reservation", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }**/





        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // this.comboBox1.Items.Clear();
            comboBox1.Text = "__Select Flight__";
            /*string[] imgs = Directory.GetFiles(@"C:\Users\El_Musty\Desktop\C#\FlightAttendanceApp\FlightAttendanceApp\bin\Debug\img");
            foreach (string file in imgs) 
            {
                comboBox1.Items.Add(file);
            }*/
            //filled_teble();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

            
        }
        private int imageNumber = 1;

        private void LoadNextImage() 
        {
            if (imageNumber == 9) 
            {
                imageNumber= 1; 
            }
            SlidePic.ImageLocation = String.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /**SqlDataBind go = new SqlDataBind();
            go.MdiParent = this;
            go.Show();**/
        }

        private void SlidePic_Click(object sender, EventArgs e)
        {

        }
    }
}
