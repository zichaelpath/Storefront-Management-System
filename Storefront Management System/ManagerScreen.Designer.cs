
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dgvGameList = new System.Windows.Forms.DataGridView();
            this.gameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameESRB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameAgeVerify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameList)).BeginInit();
            this.SuspendLayout();
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
            // dgvGameList
            // 
            this.dgvGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameTitle,
            this.gameReleaseDate,
            this.gameESRB,
            this.gameStock,
            this.gamePrice,
            this.gameAgeVerify});
            this.dgvGameList.Location = new System.Drawing.Point(91, 237);
            this.dgvGameList.Name = "dgvGameList";
            this.dgvGameList.RowTemplate.Height = 25;
            this.dgvGameList.Size = new System.Drawing.Size(793, 150);
            this.dgvGameList.TabIndex = 2;
            // 
            // gameTitle
            // 
            this.gameTitle.HeaderText = "Title";
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Width = 250;
            // 
            // gameReleaseDate
            // 
            this.gameReleaseDate.HeaderText = "Release Date";
            this.gameReleaseDate.Name = "gameReleaseDate";
            // 
            // gameESRB
            // 
            this.gameESRB.HeaderText = "ESRB";
            this.gameESRB.Name = "gameESRB";
            // 
            // gameStock
            // 
            this.gameStock.HeaderText = "Stock";
            this.gameStock.Name = "gameStock";
            this.gameStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gameStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gamePrice
            // 
            this.gamePrice.HeaderText = "Price";
            this.gamePrice.Name = "gamePrice";
            // 
            // gameAgeVerify
            // 
            this.gameAgeVerify.HeaderText = "Age Check?";
            this.gameAgeVerify.Name = "gameAgeVerify";
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 633);
            this.Controls.Add(this.dgvGameList);
            this.Controls.Add(this.btnLogOut);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreen";
            this.Load += new System.EventHandler(this.ManagerScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvGameList;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameESRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameAgeVerify;
    }
}