
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
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.HideSelection = false;
            this.lstGames.Location = new System.Drawing.Point(107, 107);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(712, 366);
            this.lstGames.TabIndex = 0;
            this.lstGames.UseCompatibleStateImageBehavior = false;
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 542);
            this.Controls.Add(this.lstGames);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreen";
            this.Load += new System.EventHandler(this.ManagerScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstGames;
    }
}