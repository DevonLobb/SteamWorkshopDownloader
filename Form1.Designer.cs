namespace SteamWorkshopDownloader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.idBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.updatedBox = new System.Windows.Forms.TextBox();
            this.updatedLabel = new System.Windows.Forms.Label();
            this.createdBox = new System.Windows.Forms.TextBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.filetitleLabel = new System.Windows.Forms.Label();
            this.fileurlBox = new System.Windows.Forms.TextBox();
            this.fileurlLabel = new System.Windows.Forms.Label();
            this.filesizeBox = new System.Windows.Forms.TextBox();
            this.filesizeLabel = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.idBox);
            this.flowLayoutPanel1.Controls.Add(this.submitButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(126, 305);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(3, 3);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 1;
            this.idBox.Text = "Workshop ID";
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.Location = new System.Drawing.Point(3, 29);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(46, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Go";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.44584F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.55416F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date Updated";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.updatedBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.updatedLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.createdBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.createdLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.titleBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.filetitleLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileurlBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.fileurlLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.filesizeBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.filesizeLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.filenameBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.filenameLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(137, 316);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 206);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // updatedBox
            // 
            this.updatedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatedBox.Location = new System.Drawing.Point(83, 133);
            this.updatedBox.Name = "updatedBox";
            this.updatedBox.ReadOnly = true;
            this.updatedBox.Size = new System.Drawing.Size(516, 20);
            this.updatedBox.TabIndex = 11;
            // 
            // updatedLabel
            // 
            this.updatedLabel.Location = new System.Drawing.Point(3, 130);
            this.updatedLabel.Name = "updatedLabel";
            this.updatedLabel.Size = new System.Drawing.Size(74, 23);
            this.updatedLabel.TabIndex = 10;
            this.updatedLabel.Text = "Date Updated";
            this.updatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createdBox
            // 
            this.createdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createdBox.Location = new System.Drawing.Point(83, 107);
            this.createdBox.Name = "createdBox";
            this.createdBox.ReadOnly = true;
            this.createdBox.Size = new System.Drawing.Size(516, 20);
            this.createdBox.TabIndex = 9;
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createdLabel.Location = new System.Drawing.Point(3, 104);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(74, 26);
            this.createdLabel.TabIndex = 8;
            this.createdLabel.Text = "Date Created";
            this.createdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleBox
            // 
            this.titleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBox.Location = new System.Drawing.Point(83, 3);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(516, 20);
            this.titleBox.TabIndex = 7;
            // 
            // filetitleLabel
            // 
            this.filetitleLabel.AutoSize = true;
            this.filetitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filetitleLabel.Location = new System.Drawing.Point(3, 0);
            this.filetitleLabel.Name = "filetitleLabel";
            this.filetitleLabel.Size = new System.Drawing.Size(74, 26);
            this.filetitleLabel.TabIndex = 6;
            this.filetitleLabel.Text = "Title";
            this.filetitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileurlBox
            // 
            this.fileurlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileurlBox.Location = new System.Drawing.Point(83, 81);
            this.fileurlBox.Name = "fileurlBox";
            this.fileurlBox.ReadOnly = true;
            this.fileurlBox.Size = new System.Drawing.Size(516, 20);
            this.fileurlBox.TabIndex = 5;
            // 
            // fileurlLabel
            // 
            this.fileurlLabel.AutoSize = true;
            this.fileurlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileurlLabel.Location = new System.Drawing.Point(3, 78);
            this.fileurlLabel.Name = "fileurlLabel";
            this.fileurlLabel.Size = new System.Drawing.Size(74, 26);
            this.fileurlLabel.TabIndex = 4;
            this.fileurlLabel.Text = "File URL";
            this.fileurlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filesizeBox
            // 
            this.filesizeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesizeBox.Location = new System.Drawing.Point(83, 55);
            this.filesizeBox.Name = "filesizeBox";
            this.filesizeBox.ReadOnly = true;
            this.filesizeBox.Size = new System.Drawing.Size(516, 20);
            this.filesizeBox.TabIndex = 3;
            // 
            // filesizeLabel
            // 
            this.filesizeLabel.AutoSize = true;
            this.filesizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesizeLabel.Location = new System.Drawing.Point(3, 52);
            this.filesizeLabel.Name = "filesizeLabel";
            this.filesizeLabel.Size = new System.Drawing.Size(74, 26);
            this.filesizeLabel.TabIndex = 2;
            this.filesizeLabel.Text = "File Size";
            this.filesizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filenameBox
            // 
            this.filenameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filenameBox.Location = new System.Drawing.Point(83, 29);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.ReadOnly = true;
            this.filenameBox.Size = new System.Drawing.Size(516, 20);
            this.filenameBox.TabIndex = 1;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filenameLabel.Location = new System.Drawing.Point(3, 26);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(74, 26);
            this.filenameLabel.TabIndex = 0;
            this.filenameLabel.Text = "Filename:";
            this.filenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.downloadButton);
            this.panel1.Location = new System.Drawing.Point(4, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 100);
            this.panel1.TabIndex = 3;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(0, 0);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(137, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 529);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 15);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Steam Workshop Downloader";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox updatedBox;
        private System.Windows.Forms.Label updatedLabel;
        private System.Windows.Forms.TextBox createdBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label filetitleLabel;
        private System.Windows.Forms.TextBox fileurlBox;
        private System.Windows.Forms.Label fileurlLabel;
        private System.Windows.Forms.TextBox filesizeBox;
        private System.Windows.Forms.Label filesizeLabel;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

