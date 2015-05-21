/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* This code is generated by a tool and is provided "as is", without warranty of any kind,
* express or implied, including but not limited to the warranties of merchantability,
* fitness for a particular purpose and non-infringement.
* In no event shall the authors or copyright holders be liable for any claim, damages or
* other liability, whether in an action of contract, tort or otherwise, arising from,
* out of or in connection with the software or the use or other dealings in the software.
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PEIMSV3Cs
{
	public partial class frmInventoryItem : Form
	{
		private MySqlDataAdapter ad;
		
		public frmInventoryItem()
		{
			InitializeComponent();
		}
		
		private void frminventoryitem_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `inventoryitem`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.inventoryitem);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			if( (( DataRowView )inventoryitemBindingSource.Current )[ "dateStamp" ] is DBNull )
			{
				((DataRowView)inventoryitemBindingSource.Current)["dateStamp"] = dateStamp_dateTimePicker.Value;
			}
			if( (( DataRowView )inventoryitemBindingSource.Current )[ "soldDate" ] is DBNull )
			{
				((DataRowView)inventoryitemBindingSource.Current)["soldDate"] = soldDate_dateTimePicker.Value;
			}
			inventoryitemBindingSource.EndEdit();
			ad.Update(this.newDataSet.inventoryitem);
			
		}
		
		private void frminventoryitem_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void productIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( productIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( productIDTextBox, "The field productID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( productIDTextBox, "" ); } 
		}
		
		private void categoryIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( categoryIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( categoryIDTextBox, "The field categoryID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( categoryIDTextBox, "" ); } 
		}
		
		private void locationIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( locationIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( locationIDTextBox, "The field locationID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( locationIDTextBox, "" ); } 
		}
		
		private void costTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( costTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( costTextBox, "The field cost is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( costTextBox, "" ); } 
		}
		
		private void priceTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( priceTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( priceTextBox, "The field price is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( priceTextBox, "" ); } 
		}
		
		private void isSoldTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( isSoldTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( isSoldTextBox, "The field isSold is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( isSoldTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			inventoryitemBindingSource.AddNew();
		}

        private void AddButton_Click(object sender, EventArgs e)
        {
            inventoryitemBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            inventoryitemBindingSource.RemoveCurrent();
            MessageBox.Show("Please save the changes");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)inventoryitemBindingSource.Current)["dateStamp"] is DBNull)
            {
                ((DataRowView)inventoryitemBindingSource.Current)["dateStamp"] = dateStamp_dateTimePicker.Value;
            }
            if (((DataRowView)inventoryitemBindingSource.Current)["soldDate"] is DBNull)
            {
                ((DataRowView)inventoryitemBindingSource.Current)["soldDate"] = soldDate_dateTimePicker.Value;
            }
            inventoryitemBindingSource.EndEdit();
            ad.Update(this.newDataSet.inventoryitem);
            MessageBox.Show("Record updated successfully");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)inventoryitemBindingSource.Current)["dateStamp"] is DBNull)
            {
                ((DataRowView)inventoryitemBindingSource.Current)["dateStamp"] = dateStamp_dateTimePicker.Value;
            }
            if (((DataRowView)inventoryitemBindingSource.Current)["soldDate"] is DBNull)
            {
                ((DataRowView)inventoryitemBindingSource.Current)["soldDate"] = soldDate_dateTimePicker.Value;
            }
            inventoryitemBindingSource.EndEdit();
            ad.Update(this.newDataSet.inventoryitem);
            MessageBox.Show("Record saved successfully");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
	}
}
