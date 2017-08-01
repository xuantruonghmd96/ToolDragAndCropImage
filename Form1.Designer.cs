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
            this.pbxPicCrop = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnBMP = new System.Windows.Forms.RadioButton();
            this.rbtnPNG = new System.Windows.Forms.RadioButton();
            this.rbtnJPG = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDauFile = new System.Windows.Forms.TextBox();
            this.nudnNumber = new System.Windows.Forms.NumericUpDown();
            this.txbFolderSavePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFolderSavePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicCrop)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnNumber)).BeginInit();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbtnBMP);
            this.panel1.Controls.Add(this.rbtnPNG);
            this.panel1.Controls.Add(this.rbtnJPG);
            this.panel1.Location = new System.Drawing.Point(684, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 196);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output \r\nFile Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnBMP
            // 
            this.rbtnBMP.AutoSize = true;
            this.rbtnBMP.Location = new System.Drawing.Point(21, 159);
            this.rbtnBMP.Name = "rbtnBMP";
            this.rbtnBMP.Size = new System.Drawing.Size(61, 24);
            this.rbtnBMP.TabIndex = 2;
            this.rbtnBMP.TabStop = true;
            this.rbtnBMP.Text = "BMP";
            this.rbtnBMP.UseVisualStyleBackColor = true;
            // 
            // rbtnPNG
            // 
            this.rbtnPNG.AutoSize = true;
            this.rbtnPNG.Location = new System.Drawing.Point(21, 111);
            this.rbtnPNG.Name = "rbtnPNG";
            this.rbtnPNG.Size = new System.Drawing.Size(61, 24);
            this.rbtnPNG.TabIndex = 1;
            this.rbtnPNG.TabStop = true;
            this.rbtnPNG.Text = "PNG";
            this.rbtnPNG.UseVisualStyleBackColor = true;
            // 
            // rbtnJPG
            // 
            this.rbtnJPG.AutoSize = true;
            this.rbtnJPG.Location = new System.Drawing.Point(21, 66);
            this.rbtnJPG.Name = "rbtnJPG";
            this.rbtnJPG.Size = new System.Drawing.Size(58, 24);
            this.rbtnJPG.TabIndex = 0;
            this.rbtnJPG.TabStop = true;
            this.rbtnJPG.Text = "JPG";
            this.rbtnJPG.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number:";
            // 
            // txbDauFile
            // 
            this.txbDauFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDauFile.Location = new System.Drawing.Point(695, 298);
            this.txbDauFile.Name = "txbDauFile";
            this.txbDauFile.Size = new System.Drawing.Size(75, 26);
            this.txbDauFile.TabIndex = 4;
            this.txbDauFile.Text = "Cau ";
            // 
            // nudnNumber
            // 
            this.nudnNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudnNumber.Location = new System.Drawing.Point(695, 379);
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
            // txbFolderSavePath
            // 
            this.txbFolderSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFolderSavePath.Location = new System.Drawing.Point(694, 461);
            this.txbFolderSavePath.Name = "txbFolderSavePath";
            this.txbFolderSavePath.Size = new System.Drawing.Size(75, 26);
            this.txbFolderSavePath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 438);
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
            this.btnFolderSavePath.Location = new System.Drawing.Point(694, 493);
            this.btnFolderSavePath.Name = "btnFolderSavePath";
            this.btnFolderSavePath.Size = new System.Drawing.Size(75, 29);
            this.btnFolderSavePath.TabIndex = 8;
            this.btnFolderSavePath.Text = "Browse";
            this.btnFolderSavePath.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnFolderSavePath);
            this.Controls.Add(this.txbFolderSavePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudnNumber);
            this.Controls.Add(this.txbDauFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxPicCrop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cắt nửa vầng trăng tôi làm con đò nhỏ...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicCrop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPicCrop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnBMP;
        private System.Windows.Forms.RadioButton rbtnPNG;
        private System.Windows.Forms.RadioButton rbtnJPG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDauFile;
        private System.Windows.Forms.NumericUpDown nudnNumber;
        private System.Windows.Forms.TextBox txbFolderSavePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFolderSavePath;
    }
}

