using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamestitel
{
    public partial class App : Form
    {
        public bool showMessage;

        public string beforeFolderRoot;
        public string afterFolderRoot;

        public App()
        {
            InitializeComponent();

            Meverything.Checked = true;
            CusOneCheck.Checked = true;
            CusTwoCheck.Checked = true;
            CusThreeCheck.Checked = true;
            CusFourCheck.Checked = true;
        }

        private void Move_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void BeforeFolder_TextChanged(object sender, EventArgs e)
        {
            beforeFolderRoot = @BeforeFolder.Text;
        }

        void AfterFolder_TextChanged(object sender, EventArgs e)
        {
            afterFolderRoot = @AfterFolder.Text;
        }

        void main_Click(object sender, EventArgs e)
        {


            

            try
            {
                string[] files = Directory.GetFiles(beforeFolderRoot);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string finalPath = Path.Combine(afterFolderRoot, fileName);
                        if (fileName.Contains(".zip") && Mzip.Checked ||
                           fileName.Contains(".7z") && M7z.Checked ||
                           fileName.Contains(".rar") && MRar.Checked ||
                           fileName.Contains(".exe") && Mexe.Checked ||
                           fileName.Contains(".bat") && Mbat.Checked ||
                           fileName.Contains(".txt") && Mtxt.Checked ||
                           fileName.Contains("." + CusOne.Text ) && CusOneCheck.Checked ||
                           fileName.Contains("." + CusTwo.Text) && CusTwoCheck.Checked ||
                           fileName.Contains("." + CusThree.Text) && CusThreeCheck.Checked ||
                           fileName.Contains("." + CusFour.Text) && CusFourCheck.Checked)
                        {
                            File.Move(file, finalPath);
                        }
                    
                }
                if (MoveMessage.Checked)
                {
                    MessageBox.Show($"all files from the folder are moved to {afterFolderRoot}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (MoveMessage.Checked)
                {
                    MessageBox.Show($"Unknown path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Meverything_CheckedChanged(object sender, EventArgs e)
        {
            if (Meverything.Checked)
            {
                Mfolders.Checked = false;
                Mzip.Checked = true;
                M7z.Checked = true;
                MRar.Checked = true;
                Mexe.Checked = true;
                Mbat.Checked = true;
                Mtxt.Checked = true;
            }

            if (Mfolders.Checked == false ||
            Mzip.Checked == false ||
            M7z.Checked == false ||
            MRar.Checked == false ||
            Mexe.Checked == false ||
            Mbat.Checked == false ||
            Mtxt.Checked ) { Meverything.Checked = false; }
        }

        void WholeFolder_Click(object sender, EventArgs e)
        {
            string finalRoot = Path.Combine(afterFolderRoot, Path.GetFileName(beforeFolderRoot));
            try
            {
                Directory.Move(afterFolderRoot, beforeFolderRoot);
                if (MoveMessage.Checked)
                {
                    MessageBox.Show($"all files from the folder are moved to {afterFolderRoot}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (MoveMessage.Checked)
                {
                    MessageBox.Show($"Unknown path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
