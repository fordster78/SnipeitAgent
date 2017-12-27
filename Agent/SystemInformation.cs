using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agent.Classes;
using Agent.Classes.Models;
using Agent.Classes.Queries;

namespace Agent
{
    public partial class SystemInformation : Form
    {
        public SystemInformation()
        {
            InitializeComponent();
        }

        private void Btn_FindManufacturer_Click(object sender, EventArgs e)
        {
            Lbl_Make.Text = MyManufacturer.Find(Hardware.ComputerMake());
            Btn_FindManufacturer.Enabled = false;
        }

        private void Btn_Category_Click(object sender, EventArgs e)
        {
            Lbl_category.Text = MyCategory.Find();
            Btn_Category.Enabled = false;
        }

        private void Btn_Model_Click(object sender, EventArgs e)
        {
            Lbl_Model.Text = MyAssetModel.Find(Hardware.ComputerMake(), Hardware.ComputerModel());
            Btn_Model.Enabled = false;
        }

        private void Btn_Company_Click(object sender, EventArgs e)
        {
            Lbl_Company.Text = MyCompany.Find();
            Btn_Company.Enabled = false;
        }

        private void Btn_Asset_Click(object sender, EventArgs e)
        {
            Lbl_Asset.Text = MyAsset.Find(Hardware.ComputerName(), Hardware.ComputerMake(), Hardware.ComputerModel(), Hardware.SerialNumber());
            Btn_Asset.Enabled = false;
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            Main.UploadData();
            MessageBox.Show("Upload Complete", "Data Upload");
        }

        private void Btn_GetData_Click(object sender, EventArgs e)
        {
            Btn_FindManufacturer.PerformClick();
            Btn_Category.PerformClick();
            Btn_Model.PerformClick();
            Btn_Company.PerformClick();
            Btn_Asset.PerformClick();
        }
    }
}
