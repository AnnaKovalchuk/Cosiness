namespace Cosiness.View
{
    partial class FormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.labelRoomStatus = new System.Windows.Forms.Label();
            this.labelQuantityOfPeople = new System.Windows.Forms.Label();
            this.labelRoomCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomStatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownQuantityOfPeople = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityOfPeople)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxData
            // 
            this.comboBoxData.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "Rooms",
            "Booking"});
            this.comboBoxData.Location = new System.Drawing.Point(3, 3);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(149, 24);
            this.comboBoxData.TabIndex = 1;
            this.comboBoxData.SelectedIndexChanged += new System.EventHandler(this.comboBoxData_SelectedIndexChanged);
            // 
            // labelRoomStatus
            // 
            this.labelRoomStatus.AutoSize = true;
            this.labelRoomStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRoomStatus.Font = new System.Drawing.Font("Candara Light", 10F);
            this.labelRoomStatus.Location = new System.Drawing.Point(206, 0);
            this.labelRoomStatus.Name = "labelRoomStatus";
            this.labelRoomStatus.Size = new System.Drawing.Size(101, 32);
            this.labelRoomStatus.TabIndex = 2;
            this.labelRoomStatus.Text = "Room status";
            // 
            // labelQuantityOfPeople
            // 
            this.labelQuantityOfPeople.AutoSize = true;
            this.labelQuantityOfPeople.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelQuantityOfPeople.Font = new System.Drawing.Font("Candara Light", 10F);
            this.labelQuantityOfPeople.Location = new System.Drawing.Point(474, 0);
            this.labelQuantityOfPeople.Name = "labelQuantityOfPeople";
            this.labelQuantityOfPeople.Size = new System.Drawing.Size(143, 32);
            this.labelQuantityOfPeople.TabIndex = 2;
            this.labelQuantityOfPeople.Text = "Quantity of people";
            // 
            // labelRoomCategory
            // 
            this.labelRoomCategory.AutoSize = true;
            this.labelRoomCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRoomCategory.Font = new System.Drawing.Font("Candara Light", 10F);
            this.labelRoomCategory.Location = new System.Drawing.Point(805, 0);
            this.labelRoomCategory.Name = "labelRoomCategory";
            this.labelRoomCategory.Size = new System.Drawing.Size(122, 32);
            this.labelRoomCategory.TabIndex = 2;
            this.labelRoomCategory.Text = "Room category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(933, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(154, 24);
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxRoomStatus
            // 
            this.comboBoxRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRoomStatus.FormattingEnabled = true;
            this.comboBoxRoomStatus.Location = new System.Drawing.Point(313, 3);
            this.comboBoxRoomStatus.Name = "comboBoxRoomStatus";
            this.comboBoxRoomStatus.Size = new System.Drawing.Size(149, 24);
            this.comboBoxRoomStatus.TabIndex = 3;
            this.comboBoxRoomStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomStatus_SelectedIndexChanged);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToResizeColumns = false;
            this.dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewData.ColumnHeadersHeight = 29;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewData.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.RowHeadersWidth = 200;
            this.dataGridViewData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(1090, 532);
            this.dataGridViewData.TabIndex = 1;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckIn.Font = new System.Drawing.Font("Candara Light", 10F);
            this.buttonCheckIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCheckIn.Location = new System.Drawing.Point(3, 3);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(542, 59);
            this.buttonCheckIn.TabIndex = 0;
            this.buttonCheckIn.Text = "Check in";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxData, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelRoomStatus, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelQuantityOfPeople, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelRoomCategory, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxCategory, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxRoomStatus, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.numericUpDownQuantityOfPeople, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelName, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelArrival, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelDeparture, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePickerArrival, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePickerDeparture, 6, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBoxName, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1090, 64);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // numericUpDownQuantityOfPeople
            // 
            this.numericUpDownQuantityOfPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownQuantityOfPeople.Location = new System.Drawing.Point(623, 3);
            this.numericUpDownQuantityOfPeople.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownQuantityOfPeople.Name = "numericUpDownQuantityOfPeople";
            this.numericUpDownQuantityOfPeople.Size = new System.Drawing.Size(149, 22);
            this.numericUpDownQuantityOfPeople.TabIndex = 4;
            this.numericUpDownQuantityOfPeople.ValueChanged += new System.EventHandler(this.numericUpDownQuantityOfPeople_ValueChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelName.Font = new System.Drawing.Font("Candara Light", 10F);
            this.labelName.Location = new System.Drawing.Point(255, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 32);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelArrival.Font = new System.Drawing.Font("Candara Light", 10F);
            this.labelArrival.Location = new System.Drawing.Point(527, 32);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(90, 32);
            this.labelArrival.TabIndex = 5;
            this.labelArrival.Text = "Arrival date";
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDeparture.Font = new System.Drawing.Font("Candara Light", 10F);
            this.labelDeparture.Location = new System.Drawing.Point(808, 32);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(119, 32);
            this.labelDeparture.TabIndex = 5;
            this.labelDeparture.Text = "Departure date";
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerArrival.Location = new System.Drawing.Point(623, 35);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(149, 22);
            this.dateTimePickerArrival.TabIndex = 7;
            this.dateTimePickerArrival.ValueChanged += new System.EventHandler(this.dateTimePickerArrival_ValueChanged);
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(933, 35);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(154, 22);
            this.dateTimePickerDeparture.TabIndex = 7;
            this.dateTimePickerDeparture.ValueChanged += new System.EventHandler(this.dateTimePickerDeparture_ValueChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(313, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckOut.Font = new System.Drawing.Font("Candara Light", 10F);
            this.buttonCheckOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCheckOut.Location = new System.Drawing.Point(551, 3);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(542, 59);
            this.buttonCheckOut.TabIndex = 1;
            this.buttonCheckOut.Text = "Check out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonCheckOut, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCheckIn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 694);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1096, 65);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Candara Light", 18F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(112, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(981, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "ООО «Уют» ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1096, 71);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::Cosiness.Properties.Resources._28dbd4f450dfa1e8dc91aa85dbe16253;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 65);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewData, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1096, 608);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.166667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1102, 762);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 762);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Number of rooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityOfPeople)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Label labelRoomStatus;
        private System.Windows.Forms.Label labelQuantityOfPeople;
        private System.Windows.Forms.Label labelRoomCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxRoomStatus;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantityOfPeople;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.TextBox textBoxName;
    }
}