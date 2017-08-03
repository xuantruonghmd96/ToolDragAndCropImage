namespace ToolDragCropImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxPicCrop = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDauFile = new System.Windows.Forms.TextBox();
            this.nudnNumber = new System.Windows.Forms.NumericUpDown();
            this.tbxFolderSavePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFolderSavePath = new System.Windows.Forms.Button();
            this.cbxFileType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxPicCrop
            // 
            this.pbxPicCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPicCrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPicCrop.Image = global::ToolDragCropImage.Properties.Resources._002;
            this.pbxPicCrop.Location = new System.Drawing.Point(0, 0);
            this.pbxPicCrop.Margin = new System.Windows.Forms.Padding(0);
            this.pbxPicCrop.Name = "pbxPicCrop";
            this.pbxPicCrop.Size = new System.Drawing.Size(681, 560);
            this.pbxPicCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPicCrop.TabIndex = 0;
            this.pbxPicCrop.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output \r\nFile Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number:";
            // 
            // tbxDauFile
            // 
            this.tbxDauFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDauFile.Location = new System.Drawing.Point(13, 174);
            this.tbxDauFile.Name = "tbxDauFile";
            this.tbxDauFile.Size = new System.Drawing.Size(75, 26);
            this.tbxDauFile.TabIndex = 4;
            this.tbxDauFile.Text = "Cau ";
            // 
            // nudnNumber
            // 
            this.nudnNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudnNumber.Location = new System.Drawing.Point(13, 255);
            this.nudnNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudnNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudnNumber.Name = "nudnNumber";
            this.nudnNumber.Size = new System.Drawing.Size(68, 26);
            this.nudnNumber.TabIndex = 5;
            this.nudnNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxFolderSavePath
            // 
            this.tbxFolderSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFolderSavePath.Location = new System.Drawing.Point(12, 337);
            this.tbxFolderSavePath.Name = "tbxFolderSavePath";
            this.tbxFolderSavePath.ReadOnly = true;
            this.tbxFolderSavePath.Size = new System.Drawing.Size(75, 26);
            this.tbxFolderSavePath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Save to:";
            // 
            // btnFolderSavePath
            // 
            this.btnFolderSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolderSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnFolderSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderSavePath.Location = new System.Drawing.Point(12, 369);
            this.btnFolderSavePath.Name = "btnFolderSavePath";
            this.btnFolderSavePath.Size = new System.Drawing.Size(75, 29);
            this.btnFolderSavePath.TabIndex = 8;
            this.btnFolderSavePath.Text = "Browse";
            this.btnFolderSavePath.UseVisualStyleBackColor = false;
            this.btnFolderSavePath.Click += new System.EventHandler(this.btnFolderSavePath_Click);
            // 
            // cbxFileType
            // 
            this.cbxFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFileType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFileType.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbxFileType.FormattingEnabled = true;
            this.cbxFileType.Location = new System.Drawing.Point(15, 84);
            this.cbxFileType.Name = "cbxFileType";
            this.cbxFileType.Size = new System.Drawing.Size(72, 28);
            this.cbxFileType.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxFileType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFolderSavePath);
            this.panel1.Controls.Add(this.tbxDauFile);
            this.panel1.Controls.Add(this.tbxFolderSavePath);
            this.panel1.Controls.Add(this.nudnNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(684, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 504);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxPicCrop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cắt nửa vầng trăng tôi làm con đò nhỏ...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudnNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPicCrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDauFile;
        private System.Windows.Forms.NumericUpDown nudnNumber;
        private System.Windows.Forms.TextBox tbxFolderSavePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFolderSavePath;
        private System.Windows.Forms.ComboBox cbxFileType;
        private System.Windows.Forms.Panel panel1;
    }
}

