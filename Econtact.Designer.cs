
namespace Econtact
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IblContactID = new System.Windows.Forms.Label();
            this.textboxContactID = new System.Windows.Forms.TextBox();
            this.IblContactNumber = new System.Windows.Forms.Label();
            this.textboxContactNumber = new System.Windows.Forms.TextBox();
            this.IblLastName = new System.Windows.Forms.Label();
            this.textboxLastName = new System.Windows.Forms.TextBox();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.IblFirstName = new System.Windows.Forms.Label();
            this.IblAddress = new System.Windows.Forms.Label();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.IblGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewContactList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IblContactID
            // 
            this.IblContactID.AutoSize = true;
            this.IblContactID.BackColor = System.Drawing.Color.Transparent;
            this.IblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblContactID.Location = new System.Drawing.Point(9, 174);
            this.IblContactID.Name = "IblContactID";
            this.IblContactID.Size = new System.Drawing.Size(104, 25);
            this.IblContactID.TabIndex = 1;
            this.IblContactID.Text = "Contact ID";
            this.IblContactID.Click += new System.EventHandler(this.IblContactID_Click);
            // 
            // textboxContactID
            // 
            this.textboxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxContactID.Location = new System.Drawing.Point(158, 174);
            this.textboxContactID.Name = "textboxContactID";
            this.textboxContactID.ReadOnly = true;
            this.textboxContactID.Size = new System.Drawing.Size(208, 30);
            this.textboxContactID.TabIndex = 2;
            // 
            // IblContactNumber
            // 
            this.IblContactNumber.AutoSize = true;
            this.IblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.IblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblContactNumber.Location = new System.Drawing.Point(9, 339);
            this.IblContactNumber.Name = "IblContactNumber";
            this.IblContactNumber.Size = new System.Drawing.Size(115, 25);
            this.IblContactNumber.TabIndex = 3;
            this.IblContactNumber.Text = "Contact No.";
            this.IblContactNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxContactNumber
            // 
            this.textboxContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxContactNumber.Location = new System.Drawing.Point(158, 339);
            this.textboxContactNumber.Name = "textboxContactNumber";
            this.textboxContactNumber.Size = new System.Drawing.Size(208, 30);
            this.textboxContactNumber.TabIndex = 6;
            this.textboxContactNumber.TextChanged += new System.EventHandler(this.textboxContactNumber_TextChanged);
            // 
            // IblLastName
            // 
            this.IblLastName.AutoSize = true;
            this.IblLastName.BackColor = System.Drawing.Color.Transparent;
            this.IblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblLastName.Location = new System.Drawing.Point(9, 284);
            this.IblLastName.Name = "IblLastName";
            this.IblLastName.Size = new System.Drawing.Size(106, 25);
            this.IblLastName.TabIndex = 5;
            this.IblLastName.Text = "Last Name";
            this.IblLastName.Click += new System.EventHandler(this.IblLastName_Click);
            // 
            // textboxLastName
            // 
            this.textboxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLastName.Location = new System.Drawing.Point(158, 284);
            this.textboxLastName.Name = "textboxLastName";
            this.textboxLastName.Size = new System.Drawing.Size(208, 30);
            this.textboxLastName.TabIndex = 8;
            this.textboxLastName.TextChanged += new System.EventHandler(this.textboxLastName_TextChanged);
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFirstName.Location = new System.Drawing.Point(158, 226);
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.Size = new System.Drawing.Size(208, 30);
            this.textboxFirstName.TabIndex = 10;
            this.textboxFirstName.TextChanged += new System.EventHandler(this.textboxFirstName_TextChanged);
            // 
            // IblFirstName
            // 
            this.IblFirstName.AutoSize = true;
            this.IblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.IblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblFirstName.Location = new System.Drawing.Point(9, 226);
            this.IblFirstName.Name = "IblFirstName";
            this.IblFirstName.Size = new System.Drawing.Size(106, 25);
            this.IblFirstName.TabIndex = 9;
            this.IblFirstName.Text = "First Name";
            this.IblFirstName.Click += new System.EventHandler(this.IblFirstName_Click);
            // 
            // IblAddress
            // 
            this.IblAddress.AutoSize = true;
            this.IblAddress.BackColor = System.Drawing.Color.Transparent;
            this.IblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblAddress.Location = new System.Drawing.Point(9, 404);
            this.IblAddress.Name = "IblAddress";
            this.IblAddress.Size = new System.Drawing.Size(85, 25);
            this.IblAddress.TabIndex = 11;
            this.IblAddress.Text = "Address";
            // 
            // textboxAddress
            // 
            this.textboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAddress.Location = new System.Drawing.Point(158, 404);
            this.textboxAddress.Multiline = true;
            this.textboxAddress.Name = "textboxAddress";
            this.textboxAddress.Size = new System.Drawing.Size(208, 117);
            this.textboxAddress.TabIndex = 12;
            this.textboxAddress.TextChanged += new System.EventHandler(this.textboxAddress_TextChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(158, 549);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(208, 33);
            this.cmbGender.TabIndex = 13;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // IblGender
            // 
            this.IblGender.AutoSize = true;
            this.IblGender.BackColor = System.Drawing.Color.Transparent;
            this.IblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblGender.Location = new System.Drawing.Point(9, 557);
            this.IblGender.Name = "IblGender";
            this.IblGender.Size = new System.Drawing.Size(77, 25);
            this.IblGender.TabIndex = 14;
            this.IblGender.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(158, 621);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(551, 621);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(747, 621);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 50);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(349, 621);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewContactList
            // 
            this.dataGridViewContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactList.Location = new System.Drawing.Point(425, 226);
            this.dataGridViewContactList.Name = "dataGridViewContactList";
            this.dataGridViewContactList.RowHeadersWidth = 51;
            this.dataGridViewContactList.RowTemplate.Height = 24;
            this.dataGridViewContactList.Size = new System.Drawing.Size(680, 295);
            this.dataGridViewContactList.TabIndex = 21;
            this.dataGridViewContactList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactList_CellClick);
            this.dataGridViewContactList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewContactList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactList_CellDoubleClick);
            this.dataGridViewContactList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewContactList_RowHeaderMouseClick);
            this.dataGridViewContactList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactList_CellMouseEnter);
            this.dataGridViewContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewContactList_RowHeaderMouseClick);
            this.dataGridViewContactList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewContactList_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textboxSearch
            // 
            this.textboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSearch.Location = new System.Drawing.Point(630, 179);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(475, 30);
            this.textboxSearch.TabIndex = 23;
            this.textboxSearch.TextChanged += new System.EventHandler(this.textboxSearch_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(1145, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(67, 60);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Econtact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1224, 752);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewContactList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.IblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.textboxAddress);
            this.Controls.Add(this.IblAddress);
            this.Controls.Add(this.textboxFirstName);
            this.Controls.Add(this.IblFirstName);
            this.Controls.Add(this.textboxLastName);
            this.Controls.Add(this.textboxContactNumber);
            this.Controls.Add(this.IblLastName);
            this.Controls.Add(this.IblContactNumber);
            this.Controls.Add(this.textboxContactID);
            this.Controls.Add(this.IblContactID);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Econtact";
            this.Text = "EContact";
            this.Load += new System.EventHandler(this.Econtact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IblContactID;
        private System.Windows.Forms.TextBox textboxContactID;
        private System.Windows.Forms.Label IblContactNumber;
        private System.Windows.Forms.TextBox textboxContactNumber;
        private System.Windows.Forms.Label IblLastName;
        private System.Windows.Forms.TextBox textboxLastName;
        private System.Windows.Forms.TextBox textboxFirstName;
        private System.Windows.Forms.Label IblFirstName;
        private System.Windows.Forms.Label IblAddress;
        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label IblGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewContactList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

