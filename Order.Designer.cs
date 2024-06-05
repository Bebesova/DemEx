namespace repair
{
    partial class Order
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
            this.RTBDist = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBDevice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBPriority = new System.Windows.Forms.ComboBox();
            this.LDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGUser = new System.Windows.Forms.DataGridView();
            this.PhoneUS = new System.Windows.Forms.TextBox();
            this.BNewClient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).BeginInit();
            this.SuspendLayout();
            // 
            // RTBDist
            // 
            this.RTBDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RTBDist.Location = new System.Drawing.Point(20, 163);
            this.RTBDist.Name = "RTBDist";
            this.RTBDist.Size = new System.Drawing.Size(296, 62);
            this.RTBDist.TabIndex = 4;
            this.RTBDist.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(16, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Описание проблемы";
            // 
            // AddOrder
            // 
            this.AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddOrder.Location = new System.Drawing.Point(20, 548);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(296, 62);
            this.AddOrder.TabIndex = 10;
            this.AddOrder.Text = "Подать заявку";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BNewClient);
            this.groupBox1.Controls.Add(this.PhoneUS);
            this.groupBox1.Controls.Add(this.DGUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBDevice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBPriority);
            this.groupBox1.Controls.Add(this.LDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddOrder);
            this.groupBox1.Controls.Add(this.RTBDist);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 624);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заявка № ";
            // 
            // CBDevice
            // 
            this.CBDevice.FormattingEnabled = true;
            this.CBDevice.Items.AddRange(new object[] {
            "Обычная",
            "Срочная"});
            this.CBDevice.Location = new System.Drawing.Point(20, 101);
            this.CBDevice.Name = "CBDevice";
            this.CBDevice.Size = new System.Drawing.Size(296, 32);
            this.CBDevice.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(16, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Приоритет";
            // 
            // CBPriority
            // 
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.Items.AddRange(new object[] {
            "Обычный",
            "Вне очереди"});
            this.CBPriority.Location = new System.Drawing.Point(20, 254);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.Size = new System.Drawing.Size(296, 32);
            this.CBPriority.TabIndex = 14;
            this.CBPriority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Location = new System.Drawing.Point(16, 34);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(65, 24);
            this.LDate.TabIndex = 13;
            this.LDate.Text = "Дата -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Оборудование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "ООО \"Техносервис\"";
            // 
            // Bexit
            // 
            this.Bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Bexit.Location = new System.Drawing.Point(246, 5);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(102, 33);
            this.Bexit.TabIndex = 13;
            this.Bexit.Text = "Назад";
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(16, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Номер клиента";
            // 
            // DGUser
            // 
            this.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUser.Location = new System.Drawing.Point(20, 374);
            this.DGUser.Name = "DGUser";
            this.DGUser.Size = new System.Drawing.Size(296, 100);
            this.DGUser.TabIndex = 19;
            this.DGUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUser_CellContentClick);
            this.DGUser.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUser_CellEnter);
            // 
            // PhoneUS
            // 
            this.PhoneUS.Location = new System.Drawing.Point(20, 327);
            this.PhoneUS.Name = "PhoneUS";
            this.PhoneUS.Size = new System.Drawing.Size(296, 29);
            this.PhoneUS.TabIndex = 20;
            this.PhoneUS.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BNewClient
            // 
            this.BNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BNewClient.Location = new System.Drawing.Point(20, 480);
            this.BNewClient.Name = "BNewClient";
            this.BNewClient.Size = new System.Drawing.Size(296, 62);
            this.BNewClient.TabIndex = 21;
            this.BNewClient.Text = "зарегестрировать клиента";
            this.BNewClient.UseVisualStyleBackColor = true;
            this.BNewClient.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 684);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBDist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.ComboBox CBPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneUS;
        private System.Windows.Forms.DataGridView DGUser;
        private System.Windows.Forms.Button BNewClient;
    }
}