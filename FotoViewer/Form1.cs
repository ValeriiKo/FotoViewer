using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoViewer
{
    public partial class fFotoViewer : Form
    {
        string aPath; //a path to file of image

        private void ShowPicture(string aPath)
        {
            pbFV.Visible = false; //picture box (PB) is unvisible;
            pbFV.SizeMode = PictureBoxSizeMode.Zoom; // set size of image equal to PB
            pbFV.Image = new Bitmap(aPath + "\\" + lbFV.SelectedItem.ToString()); // load image to PB
            pbFV.Visible = true; // PB is visible
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Выберите папку, в которой находятся изображения \nдля их дальнейшего приятного просмотра\n(Внимание! Только в расширении - *.jpg)";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                aPath = fbd.SelectedPath;
                lblPath.Text = aPath;
            }
            if (!FillListBox(aPath))
            {
                pbFV.Image = null;
                MessageBox.Show("В этой папке нет изображений с раширением *.jpg\n Выберите другую папку...");
            }
        }

        public fFotoViewer()
        {
            InitializeComponent();
            
            lbFV.Sorted = true; // ascending sort
            //create new directory and set a path, for example: @"C:\image"
            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            aPath = di.FullName;//remember a path
            lblPath.Text = aPath;//write a path in Label
            FillListBox(aPath);// add image in listbox 
        }

        private bool FillListBox(string aPath)
        {
            lbFV.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(aPath);
            FileInfo[] fiArray = di.GetFiles("*.jpg");
            foreach (var fi in fiArray)
            {
                lbFV.Items.Add(fi.Name);
            }
            if (lbFV.Items.Count== 0)
            {
                return false;
            }
            else
            {
                lbFV.SelectedIndex = 0;
                btnPrev.Enabled = false;
                if (lbFV.Items.Count == 1)
                    btnNext.Enabled = false;
                //FillList(aPath);//write name of image in List
                return true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lbFV.SelectedIndex++;
            btnPrev.Enabled = true;
            if (lbFV.SelectedIndex == lbFV.Items.Count - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lbFV.SelectedIndex--;
            btnNext.Enabled = true;
            if (lbFV.SelectedIndex == 0)
            {
                btnPrev.Enabled = false;
            }
        }

        private void lbFV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFV.SelectedIndex!= lbFV.Items.Count - 1& lbFV.SelectedIndex !=0)
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
            if (lbFV.SelectedIndex == lbFV.Items.Count - 1)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = true;
            }
            if (lbFV.SelectedIndex == 0)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            ShowPicture(aPath);
        }
    }
}
