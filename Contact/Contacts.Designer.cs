
namespace Contact
{
    partial class Contacts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            label1 = new Label();
            label2 = new Label();
            txtBoxContactID = new TextBox();
            txtBoxFirstName = new TextBox();
            label3 = new Label();
            txtBoxLastName = new TextBox();
            label4 = new Label();
            txtBoxContactNo = new TextBox();
            label5 = new Label();
            txtBoxAddress = new TextBox();
            label6 = new Label();
            comboBoxGender = new ComboBox();
            label7 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvContactList = new DataGridView();
            label8 = new Label();
            SearchBar = new TextBox();
            CloseWindow = new PictureBox();
            pictureBox2 = new PictureBox();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseWindow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(492, 51);
            label1.Name = "label1";
            label1.Size = new Size(245, 54);
            label1.TabIndex = 0;
            label1.Text = "Contact App";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 169);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Contact ID";
            label2.Click += label2_Click;
            // 
            // txtBoxContactID
            // 
            txtBoxContactID.Anchor = AnchorStyles.Left;
            txtBoxContactID.Location = new Point(280, 169);
            txtBoxContactID.Name = "txtBoxContactID";
            txtBoxContactID.ReadOnly = true;
            txtBoxContactID.Size = new Size(244, 27);
            txtBoxContactID.TabIndex = 2;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Anchor = AnchorStyles.Left;
            txtBoxFirstName.Location = new Point(280, 222);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(244, 27);
            txtBoxFirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 222);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Anchor = AnchorStyles.Left;
            txtBoxLastName.Location = new Point(280, 275);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(244, 27);
            txtBoxLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 275);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // txtBoxContactNo
            // 
            txtBoxContactNo.Anchor = AnchorStyles.Left;
            txtBoxContactNo.Location = new Point(281, 327);
            txtBoxContactNo.Name = "txtBoxContactNo";
            txtBoxContactNo.Size = new Size(244, 27);
            txtBoxContactNo.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 327);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 7;
            label5.Text = "Contact No.";
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.Anchor = AnchorStyles.Left;
            txtBoxAddress.Location = new Point(281, 378);
            txtBoxAddress.Multiline = true;
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(244, 92);
            txtBoxAddress.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(108, 378);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Anchor = AnchorStyles.Left;
            comboBoxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(281, 491);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(244, 36);
            comboBoxGender.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(108, 495);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Location = new Point(108, 596);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 42);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.BackColor = Color.Green;
            btnUpdate.Location = new Point(217, 596);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 42);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(324, 595);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 43);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.Black;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(433, 596);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 42);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvContactList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvContactList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvContactList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvContactList.Location = new Point(652, 169);
            dgvContactList.Name = "dgvContactList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvContactList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvContactList.RowHeadersWidth = 51;
            dgvContactList.Size = new Size(583, 359);
            dgvContactList.TabIndex = 17;
            dgvContactList.CellContentClick += dgvContactList_CellContentClick;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(652, 596);
            label8.Name = "label8";
            label8.Size = new Size(85, 32);
            label8.TabIndex = 18;
            label8.Text = "Search";
            // 
            // SearchBar
            // 
            SearchBar.Font = new Font("Segoe UI", 12F);
            SearchBar.Location = new Point(773, 595);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(462, 34);
            SearchBar.TabIndex = 19;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // CloseWindow
            // 
            CloseWindow.BackColor = Color.Transparent;
            CloseWindow.Image = (Image)resources.GetObject("CloseWindow.Image");
            CloseWindow.Location = new Point(1179, 51);
            CloseWindow.Name = "CloseWindow";
            CloseWindow.Size = new Size(56, 54);
            CloseWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseWindow.TabIndex = 20;
            CloseWindow.TabStop = false;
            CloseWindow.Click += CloseWindow_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(433, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Contacts
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1338, 779);
            Controls.Add(pictureBox2);
            Controls.Add(CloseWindow);
            Controls.Add(SearchBar);
            Controls.Add(label8);
            Controls.Add(dgvContactList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(comboBoxGender);
            Controls.Add(txtBoxAddress);
            Controls.Add(label6);
            Controls.Add(txtBoxContactNo);
            Controls.Add(label5);
            Controls.Add(txtBoxLastName);
            Controls.Add(label4);
            Controls.Add(txtBoxFirstName);
            Controls.Add(label3);
            Controls.Add(txtBoxContactID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contacts";
            Text = "Contact App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxContactID;
        private TextBox txtBoxFirstName;
        private Label label3;
        private TextBox txtBoxLastName;
        private Label label4;
        private TextBox txtBoxContactNo;
        private Label label5;
        private TextBox txtBoxAddress;
        private Label label6;
        private ComboBox comboBoxGender;
        private Label label7;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvContactList;
        private Label label8;
        private TextBox SearchBar;
        private PictureBox CloseWindow;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        //private EventHandler btnAdd_Click;
    }
}
