using BaseDAL.Model;
using Common.Helper.Antenna;
using Common.Network.Core;
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


			//dataGridView1.DataSource = result.model as DataTable;

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

		

		private void Form1_Load (object sender, EventArgs e)
		{
		}


		byte tag_flag = 0;
		int tagCount = 0;
		byte[,] tagData = new byte[500, 14];

		Common.Helper.Antenna.MR6100 m = new Common.Helper.Antenna.MR6100 ();

		private void button1_Click_1 (object sender, EventArgs e)
		{
			int status = m.TcpConnectReader ("192.168.1.200", 100);
			byte v1 = 0;
			byte v2 = 0;

			if (status == MR6100.SUCCESS_RETURN)
			{
				status = m.GetFirmwareVersion (255, ref v1, ref v2);

				if (status == MR6100.SUCCESS_RETURN)
				{
					listBox1.Items.Insert (0, "Version " + v1.ToString () + v2.ToString ());
				}
			}
		}

		private void button2_Click (object sender, EventArgs e)
		{
			m.TcpCloseConnect ();
		}

		private void button3_Click (object sender, EventArgs e)
		{
			Timer t = new Timer ()
			{
				Interval    = 100,
				Enabled     = true
			};
			t.Start ();

			t.Tick   +=T_Tick;
		}

		private void T_Tick (object sender, EventArgs e)
		{
			int status = m.EpcMultiTagIdentify (255, ref tagData, ref tagCount, ref tag_flag);

			if (status == MR6100.SUCCESS_RETURN)
			{
				string strAnteNo = "", strID = "", strTemp = "";

				for (int i = 0; i < tagCount; i++)
				{
					int j = 0;
					strID = "";
					strAnteNo = string.Format ("{0:X2}", tagData[i, 1]);
					for (j = 2; j < 14; j++) // update: 0->2, 12->14
					{
						strTemp = string.Format ("{0:X2}", tagData[i, j]);
						strID += strTemp;
					}
					if (strID == "000000000000000000000000")
						continue;
					else
						listBox1.Items.Insert (0, strID);
				}
			}
		}


		NetTcpServer	server;
		NetTcpClient	client;
		private void button4_Click (object sender, EventArgs e)
		{
			server	= new NetTcpServer (10000, 1024);
			client	= new NetTcpClient ("127.0.0.1", 10000, 1024);

			server.strat ();
			client.connect ();

			client.onReceiveData	+= Client_onReceiveData;
			server.onReceiveData    += Server_onReceiveData;
			server.onAcceptClient   +=Server_onAcceptClient;
		}

		private void Server_onAcceptClient (NetTcpServer sender, NetTcpClient client)
		{
			Invoke ((Action)delegate
			{
				listBox1.Items.Insert (0, "Connected");
			});
		}

		private void Server_onReceiveData (NetTcpServer sender, NetTcpClient client, CommandResult data)
		{
			Invoke ((Action)delegate
			{
			listBox1.Items.Insert (0, "S - Receive data" + data.message);
			});
			client.write ("Response ");
		}

		private void Client_onReceiveData (NetTcpClient sender, CommandResult data)
		{
			Invoke ((Action)delegate
			{
			listBox1.Items.Insert (0, "C - Receive data" + data.message);
			});
		}

		private void button5_Click (object sender, EventArgs e)
		{
			client.disconnect ();
			server.stop ();
		}

		private void button6_Click (object sender, EventArgs e)
		{
			client.write ("Hello");
		}

		private void button7_Click (object sender, EventArgs e)
		{
 
		}
	}
}
