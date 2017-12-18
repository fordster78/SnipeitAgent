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
using SnipeSharp.Endpoints.Models;

namespace Agent
{
    public partial class Win_info : Form
    {
        public Win_info()
        {
            InitializeComponent();
        }

        private void Win_info_Load(object sender, EventArgs e)
        {
            LBL_CompName.Text = LBL_CompName.Text + ": " + GetHardware.ComputerName();
            LBL_Serial.Text = LBL_Serial.Text + ": " + GetHardware.SerialNumber();
            LBL_Make.Text = LBL_Make.Text + ": " + GetHardware.ComputerMake();
            LBL_Model.Text = LBL_Model.Text + ": " + GetHardware.ComputerModel();
        }

        private void Btn_SendData_Click(object sender, EventArgs e)
        {
            String Name = GetHardware.ComputerName();
            String Serial = GetHardware.SerialNumber();
            Snipeit.SendTo(Name, Serial, "BGS00002");
        }

        private void Btn_GetData_Click(object sender, EventArgs e)
        {
            Snipeit.GetInfo();
        }

        private void Btn_UpdateData_Click(object sender, EventArgs e)
        {
            String Name = GetHardware.ComputerName();
            String Serial = GetHardware.SerialNumber();
            Snipeit.UpdateInfo(Name, Serial, "BGS00001");
        }
    }
}
