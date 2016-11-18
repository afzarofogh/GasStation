using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp.Forms
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Common.BLL.Logic.GasStation.Base__CarColor lColorCar = new Common.BLL.Logic.GasStation.Base__CarColor(Common.Enum.EDatabase.GasStation);
            Common.BLL.Entity.GasStation.Base__CarColor Colorcar = new Common.BLL.Entity.GasStation.Base__CarColor();
            CommandResult result;
            Colorcar.color = txtColor.Text.Trim();
            Colorcar.insertedBy = 4;
            Colorcar.insertDate = DateTime.Now;
            result = lColorCar.create(Colorcar);
            
            
        }
    }
}
