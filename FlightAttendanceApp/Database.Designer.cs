namespace FlightAttendanceApp
{
    partial class Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.flight_selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seat_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_item_selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flight_selected,
            this.from,
            this.to,
            this.gender,
            this.seat_position,
            this.flight_class,
            this.food_item_selected,
            this.departure_date,
            this.return_date});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(317, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 40);
            this.button2.TabIndex = 33;
            this.button2.Text = "View Database";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flight_selected
            // 
            this.flight_selected.DataPropertyName = "flight_selected";
            this.flight_selected.HeaderText = "FlightSlected";
            this.flight_selected.MinimumWidth = 6;
            this.flight_selected.Name = "flight_selected";
            this.flight_selected.Width = 125;
            // 
            // from
            // 
            this.from.DataPropertyName = "from";
            this.from.HeaderText = "From";
            this.from.MinimumWidth = 6;
            this.from.Name = "from";
            this.from.Width = 125;
            // 
            // to
            // 
            this.to.DataPropertyName = "to";
            this.to.HeaderText = "To";
            this.to.MinimumWidth = 6;
            this.to.Name = "to";
            this.to.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 125;
            // 
            // seat_position
            // 
            this.seat_position.DataPropertyName = "seat_position";
            this.seat_position.HeaderText = "SeatPosition";
            this.seat_position.MinimumWidth = 6;
            this.seat_position.Name = "seat_position";
            this.seat_position.Width = 125;
            // 
            // flight_class
            // 
            this.flight_class.DataPropertyName = "Flight_class";
            this.flight_class.HeaderText = "FlightClass";
            this.flight_class.MinimumWidth = 6;
            this.flight_class.Name = "flight_class";
            this.flight_class.Width = 125;
            // 
            // food_item_selected
            // 
            this.food_item_selected.DataPropertyName = "food_item_select";
            this.food_item_selected.HeaderText = "FoodItemSelected";
            this.food_item_selected.MinimumWidth = 6;
            this.food_item_selected.Name = "food_item_selected";
            this.food_item_selected.Width = 125;
            // 
            // departure_date
            // 
            this.departure_date.DataPropertyName = "departure_date";
            this.departure_date.HeaderText = "DepartureData";
            this.departure_date.MinimumWidth = 6;
            this.departure_date.Name = "departure_date";
            this.departure_date.Width = 125;
            // 
            // return_date
            // 
            this.return_date.DataPropertyName = "return_date";
            this.return_date.HeaderText = "ReturnDate";
            this.return_date.MinimumWidth = 6;
            this.return_date.Name = "return_date";
            this.return_date.Width = 125;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_item_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
    }
}