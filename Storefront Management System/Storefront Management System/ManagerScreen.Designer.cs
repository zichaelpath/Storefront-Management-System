
namespace Storefront_Management_System
{
    partial class ManagerScreen
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
            this.lstGames = new System.Windows.Forms.ListView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.HideSelection = false;
            this.lstGames.Location = new System.Drawing.Point(191, 153);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(712, 366);
            this.lstGames.TabIndex = 0;
            this.lstGames.UseCompatibleStateImageBehavior = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(930, 598);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 633);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lstGames);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreen";
            this.Load += new System.EventHandler(this.ManagerScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstGames;
        private System.Windows.Forms.Button btnLogOut;
    }
}