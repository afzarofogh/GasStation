﻿using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GasStation.Forms.Base
{
    public partial class CarModelForm : General.SuperForm
    {
        #region Variables

        #endregion

        #region Properties

        #endregion

        #region Methods
        /// <summary>
        /// Constructor
        /// </summary>
        public CarModelForm()
        {
            InitializeComponent();

            init();
        }

        /// <summary>
        /// Initilize
        /// </summary>
        private void init()
        {
            bindEvents();
            prepare();
        }

        /// <summary>
        /// Prepare
        /// </summary>
        private void prepare()
        {
			reload ();
        }

        /// <summary>
        /// Bind Events
        /// </summary>
        private void bindEvents()
        {
            exitMenu.Click      += exitMenu_Click;
			reloadMenu.Click	+= reloadMenu_Click;
            insertMenu.Click    += insertMenu_Click;
            modifyMenu.Click    += modifyMenu_Click;
			deleteMenu.Click	+= deleteMenu_Click;
        }

		/// <summary>
		/// Reload data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void reloadMenu_Click (object sender, EventArgs e)
		{
			reload ();
		}

		/// <summary>
		/// Delete menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void deleteMenu_Click (object sender, EventArgs e)
		{
			if ((null != resultGrid.CurrentRow) && 
				(MessageBox.Show (this, "آیا برای حذف اطمینان دارید؟", "حذف رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["id"].Value);

				Common.BLL.Entity.GasStation.Base__CarModel	model	= new Common.BLL.Entity.GasStation.Base__CarModel ()
				{
					id	= id
				};

				Common.BLL.Logic.GasStation.Base__CarModel	lCarModel	= new Common.BLL.Logic.GasStation.Base__CarModel (Common.Enum.EDatabase.GasStation);
				CommandResult	opResult	= lCarModel.delete (model);

				///TODO: CHECK RESULT
				if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
					reload ();
			}
			else
				/// TODO:SHOW MESSAGE
				;
		}

        /// <summary>
        /// Modify menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void modifyMenu_Click(object sender, EventArgs e)
        {
			if (null != resultGrid.CurrentRow)
			{ 
				int	id;

				// Get id
				id	= Convert.ToInt32 (resultGrid.CurrentRow.Cells["id"].Value);

				Common.BLL.Entity.GasStation.Base__CarModel		model	= new Common.BLL.Entity.GasStation.Base__CarModel ()
				{
					id	= id
				};

			 	CarModelEntryForm	form	= new CarModelEntryForm (model);
				if (form.ShowDialog () == System.Windows.Forms.DialogResult.OK)
					reload ();
			}
			else
				/// TODO:SHOW MESSAGE
				;
        }

        /// <summary>
        /// Insert Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void insertMenu_Click(object sender, EventArgs e)
        {
			CarModelEntryForm form	= new CarModelEntryForm ();

			if (form.ShowDialog () == System.Windows.Forms.DialogResult.OK)
				reload ();
        }

        /// <summary>
        /// Exit Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        } 

		/// <summary>
		/// Reload data
		/// </summary>
		void reload ()
		{
			Common.BLL.Logic.GasStation.Base__CarModel	lCarModel	= new Common.BLL.Logic.GasStation.Base__CarModel (Common.Enum.EDatabase.GasStation);

			CommandResult opResult	= lCarModel.allData ("", "model", false);
			resultGrid.DataSource	= opResult.model;
			//TODO: SET DATAGRID HEADER
		}
        #endregion

		
    }
}
