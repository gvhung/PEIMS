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
	public partial class frmShipping : Form
	{
		private MySqlDataAdapter ad;
		
		public frmShipping()
		{
			InitializeComponent();
		}
		
		private void frmshipping_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `shipping`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.shipping);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			shippingBindingSource.EndEdit();
			ad.Update(this.newDataSet.shipping);
			
		}
		
		private void frmshipping_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void shippingIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( shippingIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( shippingIDTextBox, "The field shippingID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( shippingIDTextBox, "" ); } 
		}
		
		private void fromLocationIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( fromLocationIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( fromLocationIDTextBox, "The field fromLocationID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( fromLocationIDTextBox, "" ); } 
		}
		
		private void toLocationIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( toLocationIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( toLocationIDTextBox, "The field toLocationID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( toLocationIDTextBox, "" ); } 
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
		
		private void packagingCategoryIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( packagingCategoryIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( packagingCategoryIDTextBox, "The field packagingCategoryID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( packagingCategoryIDTextBox, "" ); } 
		}
		
		private void quantityTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( quantityTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( quantityTextBox, "The field quantity is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( quantityTextBox, "" ); } 
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
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			shippingBindingSource.AddNew();
		}
	}
}
