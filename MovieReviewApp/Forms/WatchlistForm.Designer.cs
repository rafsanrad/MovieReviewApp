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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlWatchList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWatchList
            // 
            this.pnlWatchList.Controls.Add(this.flowlpWatchlist);
            this.pnlWatchList.Controls.Add(this.lblSubTitle);
            this.pnlWatchList.Controls.Add(this.lblTitle);
            this.pnlWatchList.Location = new System.Drawing.Point(76, 51);
            this.pnlWatchList.Name = "pnlWatchList";
            this.pnlWatchList.Size = new System.Drawing.Size(800, 552);
            this.pnlWatchList.TabIndex = 1;
            // 
            // flowlpWatchlist
            // 
            this.flowlpWatchlist.AutoScroll = true;
            this.flowlpWatchlist.Location = new System.Drawing.Point(24, 115);
            this.flowlpWatchlist.Name = "flowlpWatchlist";
            this.flowlpWatchlist.Size = new System.Drawing.Size(760, 415);
            this.flowlpWatchlist.TabIndex = 2;
            this.flowlpWatchlist.Paint += new System.Windows.Forms.PaintEventHandler(this.flowlpWatchlist_Paint);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(157, 71);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(500, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Movies you want to watch later";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTitle.Location = new System.Drawing.Point(92, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(638, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Watchlist 📋";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WatchlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 660);
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
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}