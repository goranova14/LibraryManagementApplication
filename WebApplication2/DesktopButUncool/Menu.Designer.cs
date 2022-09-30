namespace DesktopButUncool
{
    partial class Menu
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.lblInro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tpPeople = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tpItems = new System.Windows.Forms.TabPage();
            this.tcAdmin.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpHome);
            this.tcAdmin.Controls.Add(this.tpPeople);
            this.tcAdmin.Controls.Add(this.tpItems);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1408, 577);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.lblInro);
            this.tpHome.Controls.Add(this.label1);
            this.tpHome.Controls.Add(this.lblWelcome);
            this.tpHome.Location = new System.Drawing.Point(4, 29);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(1400, 544);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // lblInro
            // 
            this.lblInro.AutoSize = true;
            this.lblInro.Location = new System.Drawing.Point(175, 153);
            this.lblInro.Name = "lblInro";
            this.lblInro.Size = new System.Drawing.Size(50, 20);
            this.lblInro.TabIndex = 2;
            this.lblInro.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(140, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1001, 73);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Student Library management system";
            // 
            // tpPeople
            // 
            this.tpPeople.Controls.Add(this.label5);
            this.tpPeople.Controls.Add(this.label4);
            this.tpPeople.Controls.Add(this.label3);
            this.tpPeople.Controls.Add(this.label2);
            this.tpPeople.Controls.Add(this.tbLastName);
            this.tpPeople.Controls.Add(this.tbUsername);
            this.tpPeople.Controls.Add(this.tbAddress);
            this.tpPeople.Controls.Add(this.tbFirstName);
            this.tpPeople.Controls.Add(this.btnEdit);
            this.tpPeople.Controls.Add(this.listView1);
            this.tpPeople.Location = new System.Drawing.Point(4, 29);
            this.tpPeople.Name = "tpPeople";
            this.tpPeople.Padding = new System.Windows.Forms.Padding(3);
            this.tpPeople.Size = new System.Drawing.Size(1400, 544);
            this.tpPeople.TabIndex = 1;
            this.tpPeople.Text = "People";
            this.tpPeople.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(203, 354);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(125, 27);
            this.tbLastName.TabIndex = 6;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(204, 411);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(125, 27);
            this.tbUsername.TabIndex = 5;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(204, 481);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(125, 27);
            this.tbAddress.TabIndex = 3;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(203, 289);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(125, 27);
            this.tbFirstName.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(399, 481);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 56);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit information";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1388, 229);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tpItems
            // 
            this.tpItems.Location = new System.Drawing.Point(4, 29);
            this.tpItems.Name = "tpItems";
            this.tpItems.Size = new System.Drawing.Size(1400, 544);
            this.tpItems.TabIndex = 2;
            this.tpItems.Text = "Items";
            this.tpItems.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 636);
            this.Controls.Add(this.tcAdmin);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpPeople.ResumeLayout(false);
            this.tpPeople.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpHome;
        private Label lblWelcome;
        private TabPage tpPeople;
        private TabPage tpItems;
        private Label lblInro;
        private Label label1;
        private ListView listView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbLastName;
        private TextBox tbUsername;
        private TextBox tbAddress;
        private TextBox tbFirstName;
        private Button btnEdit;
    }
}