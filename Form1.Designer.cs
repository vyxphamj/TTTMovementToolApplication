namespace TTTMovementToolApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Synctimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestMySQL = new System.Windows.Forms.Button();
            this.txtMySQLPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMySQLUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMySQLDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMySQLPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMySQLHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMSSQLTest = new System.Windows.Forms.Button();
            this.txtMSSQLDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSSQLDataSource = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Synctimer
            // 
            this.Synctimer.Interval = 5000;
            this.Synctimer.Tick += new System.EventHandler(this.Synctimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestMySQL);
            this.groupBox1.Controls.Add(this.txtMySQLPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMySQLUserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMySQLDatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMySQLPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMySQLHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL";
            // 
            // btnTestMySQL
            // 
            this.btnTestMySQL.Location = new System.Drawing.Point(104, 317);
            this.btnTestMySQL.Name = "btnTestMySQL";
            this.btnTestMySQL.Size = new System.Drawing.Size(140, 29);
            this.btnTestMySQL.TabIndex = 8;
            this.btnTestMySQL.Text = "Test Connection";
            this.btnTestMySQL.UseVisualStyleBackColor = true;
            this.btnTestMySQL.Click += new System.EventHandler(this.btnTestMySQL_Click);
            // 
            // txtMySQLPassword
            // 
            this.txtMySQLPassword.Location = new System.Drawing.Point(6, 280);
            this.txtMySQLPassword.Name = "txtMySQLPassword";
            this.txtMySQLPassword.Size = new System.Drawing.Size(238, 27);
            this.txtMySQLPassword.TabIndex = 7;
            this.txtMySQLPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // txtMySQLUserName
            // 
            this.txtMySQLUserName.Location = new System.Drawing.Point(6, 221);
            this.txtMySQLUserName.Name = "txtMySQLUserName";
            this.txtMySQLUserName.Size = new System.Drawing.Size(238, 27);
            this.txtMySQLUserName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            // 
            // txtMySQLDatabase
            // 
            this.txtMySQLDatabase.Location = new System.Drawing.Point(6, 161);
            this.txtMySQLDatabase.Name = "txtMySQLDatabase";
            this.txtMySQLDatabase.Size = new System.Drawing.Size(238, 27);
            this.txtMySQLDatabase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Database";
            // 
            // txtMySQLPort
            // 
            this.txtMySQLPort.Location = new System.Drawing.Point(6, 104);
            this.txtMySQLPort.Name = "txtMySQLPort";
            this.txtMySQLPort.Size = new System.Drawing.Size(238, 27);
            this.txtMySQLPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txtMySQLHost
            // 
            this.txtMySQLHost.Location = new System.Drawing.Point(6, 46);
            this.txtMySQLHost.Name = "txtMySQLHost";
            this.txtMySQLHost.Size = new System.Drawing.Size(238, 27);
            this.txtMySQLHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMSSQLTest);
            this.groupBox2.Controls.Add(this.txtMSSQLDatabase);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMSSQLDataSource);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 352);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MSSQL";
            // 
            // btnMSSQLTest
            // 
            this.btnMSSQLTest.Location = new System.Drawing.Point(104, 317);
            this.btnMSSQLTest.Name = "btnMSSQLTest";
            this.btnMSSQLTest.Size = new System.Drawing.Size(140, 29);
            this.btnMSSQLTest.TabIndex = 9;
            this.btnMSSQLTest.Text = "Test Connection";
            this.btnMSSQLTest.UseVisualStyleBackColor = true;
            this.btnMSSQLTest.Click += new System.EventHandler(this.btnMSSQLTest_Click);
            // 
            // txtMSSQLDatabase
            // 
            this.txtMSSQLDatabase.Location = new System.Drawing.Point(6, 161);
            this.txtMSSQLDatabase.Name = "txtMSSQLDatabase";
            this.txtMSSQLDatabase.Size = new System.Drawing.Size(238, 27);
            this.txtMSSQLDatabase.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Database";
            // 
            // txtMSSQLDataSource
            // 
            this.txtMSSQLDataSource.Location = new System.Drawing.Point(6, 46);
            this.txtMSSQLDataSource.Name = "txtMSSQLDataSource";
            this.txtMSSQLDataSource.Size = new System.Drawing.Size(238, 27);
            this.txtMSSQLDataSource.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Source";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(268, 172);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(97, 29);
            this.btnSync.TabIndex = 10;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTTMovementToolApplication.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(519, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 65);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Thanh Thien Data Movement Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Synctimer;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnTestMySQL;
        private TextBox txtMySQLPassword;
        private Label label5;
        private TextBox txtMySQLUserName;
        private Label label4;
        private TextBox txtMySQLDatabase;
        private Label label3;
        private TextBox txtMySQLPort;
        private Label label2;
        private TextBox txtMySQLHost;
        private GroupBox groupBox2;
        private TextBox txtMSSQLDataSource;
        private Label label6;
        private TextBox txtMSSQLDatabase;
        private Label label7;
        private Button btnMSSQLTest;
        private Button btnSync;
        private PictureBox pictureBox1;
    }
}