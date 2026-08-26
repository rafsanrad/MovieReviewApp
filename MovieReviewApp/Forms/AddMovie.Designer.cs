namespace MovieReviewApp.Forms
{
    partial class AddMovie
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblTitle.Location =
                new System.Drawing.Point(45, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size =
                new System.Drawing.Size(80, 28);
            this.lblTitle.Text = "Title:";

            // 
            // txtTitle
            // 
            this.txtTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );
            this.txtTitle.Location =
                new System.Drawing.Point(190, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size =
                new System.Drawing.Size(430, 30);

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblDescription.Location =
                new System.Drawing.Point(45, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size =
                new System.Drawing.Size(120, 28);
            this.lblDescription.Text = "Description:";

            // 
            // txtDescription
            // 
            this.txtDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );
            this.txtDescription.Location =
                new System.Drawing.Point(190, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size =
                new System.Drawing.Size(430, 90);

            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblReleaseYear.Location =
                new System.Drawing.Point(45, 195);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size =
                new System.Drawing.Size(125, 28);
            this.lblReleaseYear.Text = "Release Year:";

            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );
            this.txtReleaseYear.Location =
                new System.Drawing.Point(190, 192);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size =
                new System.Drawing.Size(430, 30);

            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblGenre.Location =
                new System.Drawing.Point(45, 245);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size =
                new System.Drawing.Size(65, 28);
            this.lblGenre.Text = "Genre:";

            // 
            // txtGenre
            // 
            this.txtGenre.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );
            this.txtGenre.Location =
                new System.Drawing.Point(190, 242);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size =
                new System.Drawing.Size(430, 30);

            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblDirector.Location =
                new System.Drawing.Point(45, 295);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size =
                new System.Drawing.Size(85, 28);
            this.lblDirector.Text = "Director:";

            // 
            // txtDirector
            // 
            this.txtDirector.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );
            this.txtDirector.Location =
                new System.Drawing.Point(190, 292);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size =
                new System.Drawing.Size(430, 30);

            // 
            // lblPosterPath
            // 
            this.lblPosterPath.AutoSize = true;
            this.lblPosterPath.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.lblPosterPath.Location =
                new System.Drawing.Point(45, 345);
            this.lblPosterPath.Name = "lblPosterPath";
            this.lblPosterPath.Size =
                new System.Drawing.Size(110, 28);
            this.lblPosterPath.Text = "Poster Path:";

            // 
            // txtPosterPath
            // 
            this.txtPosterPath.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F
                );
            this.txtPosterPath.Location =
                new System.Drawing.Point(190, 342);
            this.txtPosterPath.Name = "txtPosterPath";
            this.txtPosterPath.Size =
                new System.Drawing.Size(330, 30);

            // 
            // btnBrowse
            // 
            this.btnBrowse.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnBrowse.Location =
                new System.Drawing.Point(530, 341);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size =
                new System.Drawing.Size(90, 32);
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click +=
                new System.EventHandler(
                    this.btnBrowse_Click
                );

            // 
            // btnSave
            // 
            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnSave.ForeColor =
                System.Drawing.Color.Teal;
            this.btnSave.Location =
                new System.Drawing.Point(190, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size =
                new System.Drawing.Size(150, 45);
            this.btnSave.Text = "Save Movie";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click
                );

            // 
            // btnCancel
            // 
            this.btnCancel.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold
                );
            this.btnCancel.Location =
                new System.Drawing.Point(370, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size =
                new System.Drawing.Size(150, 45);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click
                );

            // 
            // AddMovie
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 21F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(680, 500);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
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

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8F
                );

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMovie";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Add Movie";

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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}