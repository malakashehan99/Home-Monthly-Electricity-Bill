namespace Monthly_Electricity_Bill
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel_1_left = new System.Windows.Forms.Panel();
            this.panel_category = new System.Windows.Forms.Panel();
            this.button_category_1_home = new System.Windows.Forms.Button();
            this.panel_billCalculator = new System.Windows.Forms.Panel();
            this.button_BillCalculator = new System.Windows.Forms.Button();
            this.panel_3_logo = new System.Windows.Forms.Panel();
            this.label_1_logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_2_right = new System.Windows.Forms.Panel();
            this.panel_1_left.SuspendLayout();
            this.panel_category.SuspendLayout();
            this.panel_billCalculator.SuspendLayout();
            this.panel_3_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_1_left
            // 
            this.panel_1_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_1_left.Controls.Add(this.panel_category);
            this.panel_1_left.Controls.Add(this.panel_billCalculator);
            this.panel_1_left.Controls.Add(this.panel_3_logo);
            this.panel_1_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_1_left.Location = new System.Drawing.Point(0, 0);
            this.panel_1_left.Name = "panel_1_left";
            this.panel_1_left.Size = new System.Drawing.Size(271, 612);
            this.panel_1_left.TabIndex = 0;
            this.panel_1_left.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_1_left_Paint);
            // 
            // panel_category
            // 
            this.panel_category.AutoScroll = true;
            this.panel_category.Controls.Add(this.button_category_1_home);
            this.panel_category.Location = new System.Drawing.Point(0, 367);
            this.panel_category.Name = "panel_category";
            this.panel_category.Size = new System.Drawing.Size(271, 98);
            this.panel_category.TabIndex = 2;
            this.panel_category.Visible = false;
            this.panel_category.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_category_1_home
            // 
            this.button_category_1_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_category_1_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_category_1_home.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category_1_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_category_1_home.Location = new System.Drawing.Point(0, 0);
            this.button_category_1_home.Name = "button_category_1_home";
            this.button_category_1_home.Size = new System.Drawing.Size(271, 41);
            this.button_category_1_home.TabIndex = 0;
            this.button_category_1_home.Text = "Home";
            this.button_category_1_home.UseVisualStyleBackColor = true;
            this.button_category_1_home.Click += new System.EventHandler(this.button_category_1_home_Click);
            // 
            // panel_billCalculator
            // 
            this.panel_billCalculator.Controls.Add(this.button_BillCalculator);
            this.panel_billCalculator.Location = new System.Drawing.Point(0, 304);
            this.panel_billCalculator.Name = "panel_billCalculator";
            this.panel_billCalculator.Size = new System.Drawing.Size(271, 59);
            this.panel_billCalculator.TabIndex = 1;
            // 
            // button_BillCalculator
            // 
            this.button_BillCalculator.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_BillCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BillCalculator.FlatAppearance.BorderSize = 0;
            this.button_BillCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_BillCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BillCalculator.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BillCalculator.ForeColor = System.Drawing.Color.Teal;
            this.button_BillCalculator.Location = new System.Drawing.Point(0, 3);
            this.button_BillCalculator.Name = "button_BillCalculator";
            this.button_BillCalculator.Size = new System.Drawing.Size(271, 54);
            this.button_BillCalculator.TabIndex = 0;
            this.button_BillCalculator.Text = "Bill Calculator\r\n";
            this.button_BillCalculator.UseVisualStyleBackColor = false;
            this.button_BillCalculator.Click += new System.EventHandler(this.button_BillCalculator_Click);
            // 
            // panel_3_logo
            // 
            this.panel_3_logo.Controls.Add(this.label_1_logo);
            this.panel_3_logo.Controls.Add(this.pictureBox1);
            this.panel_3_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_3_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_3_logo.Name = "panel_3_logo";
            this.panel_3_logo.Size = new System.Drawing.Size(271, 298);
            this.panel_3_logo.TabIndex = 0;
            // 
            // label_1_logo
            // 
            this.label_1_logo.AutoSize = true;
            this.label_1_logo.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1_logo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_1_logo.Location = new System.Drawing.Point(22, 223);
            this.label_1_logo.Name = "label_1_logo";
            this.label_1_logo.Size = new System.Drawing.Size(220, 28);
            this.label_1_logo.TabIndex = 1;
            this.label_1_logo.Text = "Monthly Electricity Bill";
            this.label_1_logo.Click += new System.EventHandler(this.label_1_logo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_2_right
            // 
            this.panel_2_right.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel_2_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_2_right.Location = new System.Drawing.Point(271, 0);
            this.panel_2_right.Name = "panel_2_right";
            this.panel_2_right.Size = new System.Drawing.Size(1030, 612);
            this.panel_2_right.TabIndex = 1;
            this.panel_2_right.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_2_right_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 612);
            this.Controls.Add(this.panel_2_right);
            this.Controls.Add(this.panel_1_left);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Electricity Bill";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel_1_left.ResumeLayout(false);
            this.panel_category.ResumeLayout(false);
            this.panel_billCalculator.ResumeLayout(false);
            this.panel_3_logo.ResumeLayout(false);
            this.panel_3_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_1_left;
        private System.Windows.Forms.Panel panel_2_right;
        private System.Windows.Forms.Panel panel_3_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_1_logo;
        private System.Windows.Forms.Panel panel_billCalculator;
        private System.Windows.Forms.Panel panel_category;
        private System.Windows.Forms.Button button_BillCalculator;
        private System.Windows.Forms.Button button_category_1_home;
    }
}

