using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Common.BLL.Logic.GasStation.Car lCar = new Common.BLL.Logic.GasStation.Car(Common.Enum.EDatabase.GasStation);
            Common.BLL.Entity.GasStation.Car car = new Common.BLL.Entity.GasStation.Car();
            CommandResult result;

            car.capacity = 10;
            car.carTypeId = 1;
            car.engineCode = "ENG100000";
            car.chasisCode = "CHS9900";
            
            result = lCar.create(car);
            

            car.id = 1;
            result = lCar.read(car);
            car.load_Base__CarType_carTypeId();
            var x = car.Base__CarType_carTypeId;
            

            result = lCar.allData("(capacity = @capacity)", "", false, true,
                new KeyValuePair("@capacity", 10)
                );
            

            dataGridView1.DataSource = result.model as DataTable;
         
        }
    }
}
