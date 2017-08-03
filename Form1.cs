using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolDragCropImage
{
    public partial class Form1 : Form
    {
        private Rectangle _r;
        private Point _pt;
        private Point _ptOffset;
        private string _fileSource;

        public Form1()
        {
            InitializeComponent();
            ComboBoxFileTypeBinding();

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            tbxFolderSavePath.Text = Directory.GetCurrentDirectory();

            //assign a - here- dynamically created - picture
            //pbxPicCrop.Image = SetUpPictures(this.pictureBox1);
            pbxPicCrop.MouseDown += new MouseEventHandler(pbxPicCrop_MouseDown);
            pbxPicCrop.MouseMove += new MouseEventHandler(pbxPicCrop_MouseMove);
            pbxPicCrop.MouseUp += new MouseEventHandler(pbxPicCrop_MouseUp);
            pbxPicCrop.Paint += new PaintEventHandler(pbxPicCrop_Paint);

            //cleanup, could also be handled in its event-handler method
            this.FormClosing += delegate
            {
                foreach (Control c in this.Controls)
                    if (c is PictureBox)
                    {
                        PictureBox pb = (PictureBox)c;
                        if (pb.Image != null) pb.Image.Dispose();
                    }
            };
        }

        void ComboBoxFileTypeBinding()
        {
            for (int i = 0; i < Contents.listImgType.Count; i++)
                cbxFileType.Items.Add(Contents.listImgType[i]);
            cbxFileType.DisplayMember = "DuoiFile";
            cbxFileType.SelectedIndex = 0;
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            _fileSource = files[0];
            pbxPicCrop.Image = Image.FromFile(_fileSource);
        }

        Rectangle GetSelectedPartImage(Rectangle rectSources)
        {
            int x = 0;
            int y = 0;
            int x2 = 0;
            int y2 = 0;

            //Get scale
            float scale;
            scale = (float)pbxPicCrop.Image.Height / (float)pbxPicCrop.Height;
            if (((float)pbxPicCrop.Image.Width / scale) > (pbxPicCrop.Width))
                scale = (float)pbxPicCrop.Image.Width / (float)pbxPicCrop.Width;

            //Autosize recSrc to fit to image
            float recSrcX = (rectSources.X * scale);
            float recSrcY = (rectSources.Y * scale);
            float recSrcX2 = ((rectSources.X + rectSources.Width) * scale);
            float recSrcY2 = ((rectSources.Y + rectSources.Height) * scale);

            //Get center of pictureBox
            Point centerRecSrc = new Point((int)((float)pbxPicCrop.Width * scale) / 2, (int)((float)pbxPicCrop.Height * scale) / 2);

            //Get img location
            int imgX = centerRecSrc.X - (pbxPicCrop.Image.Width / 2);
            int imgY = centerRecSrc.Y - (pbxPicCrop.Image.Height / 2);
            int imgX2 = imgX + pbxPicCrop.Image.Width;
            int imgY2 = imgY + pbxPicCrop.Image.Height;

            if (recSrcX >= imgX2 || recSrcY >= imgY2 || recSrcX2 <= imgX || recSrcY2 <= imgY)
                return new Rectangle(0, 0, 0, 0);

            x = (int)(recSrcX - imgX);
            y = (int)(recSrcY - imgY);
            x2 = (int)(recSrcX2 - imgX);
            y2 = (int)(recSrcY2 - imgY);
            if (x < 0)
                x = 0;
            if (y < 0)
                y = 0;
            if (x2 > pbxPicCrop.Image.Width)
                x2 = pbxPicCrop.Image.Width;
            if (y2 > pbxPicCrop.Image.Height)
                y2 = pbxPicCrop.Image.Height;

            return new Rectangle(x, y, x2 - x, y2 - y);
        }

        string GetOuputFileName()
        {
            string imageFilePath = tbxFolderSavePath.Text + @"/" + tbxDauFile.Text;
            int i = (int)nudnNumber.Value;
            if (i < 10)
                imageFilePath += "00";
            else if (i < 100)
                imageFilePath += "0";
            imageFilePath += i.ToString();
            imageFilePath += GetOutputFileType();
            return imageFilePath;
        }

        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        void GeneratePicture()
        {
            if (_fileSource == null)
            {
                MessageBox.Show("You have not import an image!" + Environment.NewLine + "Drag and drop an image file into this window!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Rectangle rect = GetSelectedPartImage(_r);
            if (rect.Width <= 0 || rect.Height <= 0)
                return;
            Bitmap source = Image.FromFile(_fileSource) as Bitmap;
            Bitmap CroppedImage = CropImage(source, rect);
            string path = GetOuputFileName();
            CroppedImage.Save(path, (cbxFileType.SelectedItem as ImageTypeManager).Format);
            nudnNumber.Value++;
        }

        void pbxPicCrop_Paint(object sender, PaintEventArgs e)
        {
            //if we have a valid rectangle, draw it
            if (_r.Width > 0 && _r.Height > 0)
            {
                //fill
                using (SolidBrush sb = new SolidBrush(Color.FromArgb(95, 255, 255, 255)))
                    e.Graphics.FillRectangle(sb, _r);
                //draw
                e.Graphics.DrawRectangle(Pens.Blue, _r);
            }
        }

        void pbxPicCrop_MouseDown(object sender, MouseEventArgs e)
        {
            //set the upper left point of our selection rectangle
            if (e.Button == MouseButtons.Left)
                _pt = e.Location;

            //set inner offset for moving
            if (e.Button == MouseButtons.Right && _r.Width > 0 && _r.Height > 0)
            {
                if (_r.Contains(e.Location))
                    _ptOffset = new Point(e.X - _r.X, e.Y - _r.Y);
            }
        }

        void pbxPicCrop_MouseMove(object sender, MouseEventArgs e)
        {
            //set the bottom right one
            if (e.Button == MouseButtons.Left)
            {
                _r = new Rectangle(_pt.X, _pt.Y, e.X - _pt.X, e.Y - _pt.Y);
                pbxPicCrop.Invalidate();
            }

            if (e.Button == MouseButtons.Right && _r.Width > 0 && _r.Height > 0)
            {
                //move the rectangle
                if (_r.Contains(e.Location))
                {
                    _r.Location = new Point(e.X - _ptOffset.X, e.Y - _ptOffset.Y);

                    pbxPicCrop.Invalidate();
                }
            }
        }

        void pbxPicCrop_MouseUp(object sender, MouseEventArgs e)
        {
            //display the selected part when mouse button gets released
            if (e.Button == MouseButtons.Left)
            {
                _r = new Rectangle(_pt.X, _pt.Y, e.X - _pt.X, e.Y - _pt.Y);
                GeneratePicture();
            }

            if (e.Button == MouseButtons.Right && _r.Width > 0 && _r.Height > 0)
            {
                if (_r.Contains(e.Location))
                {
                    _r.Location = new Point(e.X - _ptOffset.X, e.Y - _ptOffset.Y);

                    //redisplay selection image with new values
                    GeneratePicture();
                }
            }
        }

        private void btnFolderSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = tbxFolderSavePath.Text;
            //fbd.Description = "Chặt đôi câu thơ tôi làm mái chèo lướt sóng!";
            fbd.Description = "Select a folder to save your images";
            if (fbd.ShowDialog() == DialogResult.OK)
                tbxFolderSavePath.Text = fbd.SelectedPath;
        }

        private string GetOutputFileType()
        {
            return (cbxFileType.SelectedItem as ImageTypeManager).DuoiFile; 
        }
    }
}
