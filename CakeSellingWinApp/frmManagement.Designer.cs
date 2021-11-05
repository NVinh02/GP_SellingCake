
namespace CakeSellingWinApp
{
    partial class frmManagement
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnStaffList = new System.Windows.Forms.Button();
            this.btnCakeList = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDisplayer = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDisplayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnOrder);
            this.panelSidebar.Controls.Add(this.btnOrderList);
            this.panelSidebar.Controls.Add(this.btnStaffList);
            this.panelSidebar.Controls.Add(this.btnCakeList);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSidebar.Location = new System.Drawing.Point(773, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(177, 500);
            this.panelSidebar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(0, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Develop by \r\nGroup 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(0, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Location = new System.Drawing.Point(0, 260);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(177, 40);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(0, 220);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(177, 40);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderList.FlatAppearance.BorderSize = 0;
            this.btnOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderList.ForeColor = System.Drawing.Color.Black;
            this.btnOrderList.Location = new System.Drawing.Point(0, 180);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(177, 40);
            this.btnOrderList.TabIndex = 4;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.UseVisualStyleBackColor = false;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnStaffList
            // 
            this.btnStaffList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStaffList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffList.FlatAppearance.BorderSize = 0;
            this.btnStaffList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffList.ForeColor = System.Drawing.Color.Black;
            this.btnStaffList.Location = new System.Drawing.Point(0, 140);
            this.btnStaffList.Name = "btnStaffList";
            this.btnStaffList.Size = new System.Drawing.Size(177, 40);
            this.btnStaffList.TabIndex = 3;
            this.btnStaffList.Text = "Staff List";
            this.btnStaffList.UseVisualStyleBackColor = false;
            this.btnStaffList.Click += new System.EventHandler(this.btnStaffList_Click);
            // 
            // btnCakeList
            // 
            this.btnCakeList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCakeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCakeList.FlatAppearance.BorderSize = 0;
            this.btnCakeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCakeList.ForeColor = System.Drawing.Color.Black;
            this.btnCakeList.Location = new System.Drawing.Point(0, 100);
            this.btnCakeList.Name = "btnCakeList";
            this.btnCakeList.Size = new System.Drawing.Size(177, 40);
            this.btnCakeList.TabIndex = 1;
            this.btnCakeList.Text = "Cake List";
            this.btnCakeList.UseVisualStyleBackColor = false;
            this.btnCakeList.Click += new System.EventHandler(this.btnCakeList_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(177, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::CakeSellingWinApp.Properties.Resources.cake;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(46, 9);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelDisplayer
            // 
            this.panelDisplayer.BackColor = System.Drawing.SystemColors.Window;
            this.panelDisplayer.BackgroundImage = global::CakeSellingWinApp.Properties.Resources.chocolate_cake;
            this.panelDisplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDisplayer.Controls.Add(this.lbWelcome);
            this.panelDisplayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDisplayer.Location = new System.Drawing.Point(0, 0);
            this.panelDisplayer.Name = "panelDisplayer";
            this.panelDisplayer.Size = new System.Drawing.Size(774, 500);
            this.panelDisplayer.TabIndex = 1;
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbWelcome.Location = new System.Drawing.Point(41, 249);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(675, 32);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.panelDisplayer);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagement";
            this.Load += new System.EventHandler(this.frmManagement_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDisplayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnStaffList;
        private System.Windows.Forms.Button btnCakeList;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDisplayer;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label1;
    }
}