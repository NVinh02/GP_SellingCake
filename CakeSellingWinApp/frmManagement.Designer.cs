
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnSatffList = new System.Windows.Forms.Button();
            this.btnCakeList = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDisplayer = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnOrderList);
            this.panelSidebar.Controls.Add(this.btnSatffList);
            this.panelSidebar.Controls.Add(this.btnCakeList);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSidebar.Location = new System.Drawing.Point(773, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(177, 500);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Location = new System.Drawing.Point(0, 420);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(177, 40);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(0, 460);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnOrderList.TabIndex = 3;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.UseVisualStyleBackColor = false;
            // 
            // btnSatffList
            // 
            this.btnSatffList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSatffList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatffList.FlatAppearance.BorderSize = 0;
            this.btnSatffList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatffList.ForeColor = System.Drawing.Color.Black;
            this.btnSatffList.Location = new System.Drawing.Point(0, 140);
            this.btnSatffList.Name = "btnSatffList";
            this.btnSatffList.Size = new System.Drawing.Size(177, 40);
            this.btnSatffList.TabIndex = 2;
            this.btnSatffList.Text = "Staff List";
            this.btnSatffList.UseVisualStyleBackColor = false;
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
            this.panelDisplayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDisplayer.Location = new System.Drawing.Point(0, 0);
            this.panelDisplayer.Name = "panelDisplayer";
            this.panelDisplayer.Size = new System.Drawing.Size(774, 500);
            this.panelDisplayer.TabIndex = 1;
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
            this.Text = "frmManagement";
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnSatffList;
        private System.Windows.Forms.Button btnCakeList;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDisplayer;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}