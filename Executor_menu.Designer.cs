namespace repair
{
    partial class Executor_menu
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
            this.DGExecutor = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BEditStatus = new System.Windows.Forms.Button();
            this.CBfilterStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGExecutor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGExecutor
            // 
            this.DGExecutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGExecutor.Location = new System.Drawing.Point(12, 91);
            this.DGExecutor.Name = "DGExecutor";
            this.DGExecutor.Size = new System.Drawing.Size(543, 241);
            this.DGExecutor.TabIndex = 0;
            this.DGExecutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGExecutor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGExecutor_CellEnter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Заказать запчасти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBStatus
            // 
            this.CBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Не начато",
            "В работе",
            "Выполнен"});
            this.CBStatus.Location = new System.Drawing.Point(256, 60);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(132, 28);
            this.CBStatus.TabIndex = 38;
            this.CBStatus.Text = "Выбирите";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Exit.Location = new System.Drawing.Point(12, 17);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 27);
            this.Exit.TabIndex = 37;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(125, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "ООО \"Техносервис\"";
            // 
            // BEditStatus
            // 
            this.BEditStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BEditStatus.Location = new System.Drawing.Point(394, 57);
            this.BEditStatus.Name = "BEditStatus";
            this.BEditStatus.Size = new System.Drawing.Size(161, 31);
            this.BEditStatus.TabIndex = 35;
            this.BEditStatus.Text = "Изменить статус";
            this.BEditStatus.UseVisualStyleBackColor = true;
            this.BEditStatus.Click += new System.EventHandler(this.BEditStatus_Click);
            // 
            // CBfilterStatus
            // 
            this.CBfilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBfilterStatus.FormattingEnabled = true;
            this.CBfilterStatus.Items.AddRange(new object[] {
            "Не обработан",
            "В работе",
            "Выполнен",
            "Все"});
            this.CBfilterStatus.Location = new System.Drawing.Point(12, 59);
            this.CBfilterStatus.Name = "CBfilterStatus";
            this.CBfilterStatus.Size = new System.Drawing.Size(178, 28);
            this.CBfilterStatus.TabIndex = 34;
            this.CBfilterStatus.Text = "Статус выполнения";
            this.CBfilterStatus.SelectedIndexChanged += new System.EventHandler(this.CBfilterStatus_SelectedIndexChanged);
            // 
            // Executor_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 407);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BEditStatus);
            this.Controls.Add(this.CBfilterStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGExecutor);
            this.Name = "Executor_menu";
            this.Text = "Executor_menu";
            this.Load += new System.EventHandler(this.Executor_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGExecutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGExecutor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BEditStatus;
        private System.Windows.Forms.ComboBox CBfilterStatus;
    }
}