namespace MovieReviewApp.Forms
{
    partial class EditMovie
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblPosterPath = new System.Windows.Forms.Label();
            this.txtPosterPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(45, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 28);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(190, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(430, 34);
            this.txtTitle.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(45, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 28);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(190, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(430, 90);
            this.txtDescription.TabIndex = 11;
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReleaseYear.Location = new System.Drawing.Point(45, 195);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(136, 28);
            this.lblReleaseYear.TabIndex = 10;
            this.lblReleaseYear.Text = "Release Year:";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReleaseYear.Location = new System.Drawing.Point(190, 192);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(430, 34);
            this.txtReleaseYear.TabIndex = 9;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenre.Location = new System.Drawing.Point(45, 245);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(73, 28);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre:";
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGenre.Location = new System.Drawing.Point(190, 242);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(430, 34);
            this.txtGenre.TabIndex = 7;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDirector.Location = new System.Drawing.Point(45, 295);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(96, 28);
            this.lblDirector.TabIndex = 6;
            this.lblDirector.Text = "Director:";
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDirector.Location = new System.Drawing.Point(190, 292);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(430, 34);
            this.txtDirector.TabIndex = 5;
            // 
            // lblPosterPath
            // 
            this.lblPosterPath.AutoSize = true;
            this.lblPosterPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPosterPath.Location = new System.Drawing.Point(45, 345);
            this.lblPosterPath.Name = "lblPosterPath";
            this.lblPosterPath.Size = new System.Drawing.Size(125, 28);
            this.lblPosterPath.TabIndex = 4;
            this.lblPosterPath.Text = "Poster Path:";
            // 
            // txtPosterPath
            // 
            this.txtPosterPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosterPath.Location = new System.Drawing.Point(190, 342);
            this.txtPosterPath.Name = "txtPosterPath";
            this.txtPosterPath.Size = new System.Drawing.Size(330, 34);
            this.txtPosterPath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.Location = new System.Drawing.Point(530, 341);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 32);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(190, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(370, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPosterPath);
            this.Controls.Add(this.lblPosterPath);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Movie";
            this.Load += new System.EventHandler(this.EditMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.TextBox txtReleaseYear;

        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;

        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtDirector;

        private System.Windows.Forms.Label lblPosterPath;
        private System.Windows.Forms.TextBox txtPosterPath;

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}