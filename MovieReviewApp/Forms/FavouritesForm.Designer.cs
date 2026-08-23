namespace MovieReviewApp.Forms
{
    partial class FavouritesForm
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
            this.pnlFavourites = new System.Windows.Forms.Panel();
            this.flowlpFavourites = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFavourites.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFavourites
            // 
            this.pnlFavourites.Controls.Add(this.flowlpFavourites);
            this.pnlFavourites.Controls.Add(this.lblSubTitle);
            this.pnlFavourites.Controls.Add(this.lblTitle);
            this.pnlFavourites.Location = new System.Drawing.Point(38, 38);
            this.pnlFavourites.Name = "pnlFavourites";
            this.pnlFavourites.Size = new System.Drawing.Size(800, 552);
            this.pnlFavourites.TabIndex = 0;
            // 
            // flowlpFavourites
            // 
            this.flowlpFavourites.AutoScroll = true;
            this.flowlpFavourites.Location = new System.Drawing.Point(23, 115);
            this.flowlpFavourites.Name = "flowlpFavourites";
            this.flowlpFavourites.Size = new System.Drawing.Size(760, 415);
            this.flowlpFavourites.TabIndex = 2;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(42, 64);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(700, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Movies you\'ve added to your favourites ";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(65, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(665, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Favourites ❤️";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FavouritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 628);
            this.Controls.Add(this.pnlFavourites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FavouritesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cineverse - My Favourites";
            this.pnlFavourites.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFavourites;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.FlowLayoutPanel flowlpFavourites;
    }
}