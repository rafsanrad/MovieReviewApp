namespace MovieReviewApp.Forms
{
    partial class WatchlistForm
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
            this.pnlWatchList = new System.Windows.Forms.Panel();
            this.flowlpWatchlist = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlWatchList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWatchList
            // 
            this.pnlWatchList.Controls.Add(this.flowlpWatchlist);
            this.pnlWatchList.Controls.Add(this.btnBack);
            this.pnlWatchList.Controls.Add(this.lblSubTitle);
            this.pnlWatchList.Controls.Add(this.lblTitle);
            this.pnlWatchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWatchList.Location = new System.Drawing.Point(0, 0);
            this.pnlWatchList.Name = "pnlWatchList";
            this.pnlWatchList.Size = new System.Drawing.Size(878, 594);
            this.pnlWatchList.TabIndex = 1;
            // 
            // flowlpWatchlist
            // 
            this.flowlpWatchlist.AutoScroll = true;
            this.flowlpWatchlist.Location = new System.Drawing.Point(40, 115);
            this.flowlpWatchlist.Name = "flowlpWatchlist";
            this.flowlpWatchlist.Size = new System.Drawing.Size(800, 450);
            this.flowlpWatchlist.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "◀️ Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(95, 76);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(700, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Movies you want to watch later";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTitle.Location = new System.Drawing.Point(50, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Watchlist 📋";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WatchlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 594);
            this.Controls.Add(this.pnlWatchList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WatchlistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cineverse - My Watchlist";
            this.pnlWatchList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWatchList;
        private System.Windows.Forms.FlowLayoutPanel flowlpWatchlist;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}