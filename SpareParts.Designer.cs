namespace repair
{
    partial class SpareParts
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
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DGExecutor = new System.Windows.Forms.DataGridView();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGExecutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Exit.Location = new System.Drawing.Point(448, 16);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 27);
            this.Exit.TabIndex = 44;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "ООО \"Техносервис\"";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(332, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 26);
            this.button1.TabIndex = 40;
            this.button1.Text = "Заказать запчасти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGExecutor
            // 
            this.DGExecutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGExecutor.Location = new System.Drawing.Point(12, 90);
            this.DGExecutor.Name = "DGExecutor";
            this.DGExecutor.Size = new System.Drawing.Size(543, 241);
            this.DGExecutor.TabIndex = 39;
            this.DGExecutor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGExecutor_CellEnter);
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Count.Location = new System.Drawing.Point(108, 58);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(74, 26);
            this.Count.TabIndex = 45;
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Count.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Кол-во -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "label6";
            // 
            // SpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 354);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGExecutor);
            this.Name = "SpareParts";
            this.Text = "SpareParts";
            this.Load += new System.EventHandler(this.SpareParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGExecutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGExecutor;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}