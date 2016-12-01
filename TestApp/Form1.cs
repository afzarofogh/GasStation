using BaseDAL.Model;
using System;
using System.Collections;
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
		public Form1 ()
		{
			InitializeComponent ();
		}

		private void button1_Click (object sender, EventArgs e)
		{
			Common.BLL.Logic.GasStation.Car lCar = new Common.BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			Common.BLL.Entity.GasStation.Car car = new Common.BLL.Entity.GasStation.Car ();
			CommandResult result;

			car.capacity = 10;
			car.carTypeId = 1;
			car.engineCode = "ENG100000";
			car.chasisCode = "CHS9900";

			result = lCar.create (car);


			car.id = 1;
			result = lCar.read (car);
			car.load_Base__CarType_carTypeId ();
			var x = car.Base__CarType_carTypeId;


			result = lCar.allData ("(capacity = @capacity)", "", false, true,
				new KeyValuePair ("@capacity", 10)
				);


			dataGridView1.DataSource = result.model as DataTable;

		}

		 private ArrayList HeaderGroup = new ArrayList();
		

		private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
			int i=0;
			for ( i= 0; i < 1000; i++)
			{
				
			}
			if (i == 1000)
				return;
        }

       
		 public virtual void GroupBy()
        {
            GroupBy((ColumnHeader[])HeaderGroup.ToArray(typeof(ColumnHeader)));
        }
		public void GroupBy (ColumnHeader[] Headers)
		{
			//if (this.InvokeRequired)
			//{
			//	dGroupBy d = new dGroupBy(GroupBy);
			//	this.Invoke(d, new object[] { Headers });
			//}
			//else
			//{
			//code
			//foreach (ListViewItem lvi in this.Items)
			//{
			//	string header = "";

			//	foreach (ColumnHeader ch in Headers)
			//	{
			//		header += " " + lvi.SubItems[ch.Index].Text;
			//	}

			//	ListViewGroup group = new ListViewGroup (header);
			//	ListViewGroup found = null;
			//	foreach (ListViewGroup g in Groups)
			//	{
			//		if (g.Header == group.Header)
			//		{ found = g; break; }
			//	}
			//	if (found == null)
			//	{
			//		this.Groups.Add (group);
			//		group.Items.Add (lvi);
			//	}
			//	else
			//	{
			//		found.Items.Add (lvi);
			//	}


			//}
			//}
		}

		private void button3_Click (object sender, EventArgs e)
		{
			//this.pictureBox1.Image = null;

		}

		private void Form1_Load (object sender, EventArgs e)
		{

		}
	}
}
