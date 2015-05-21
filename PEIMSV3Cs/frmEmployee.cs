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
	public partial class frmEmployee : Form
	{
		private MySqlDataAdapter ad;
		
		public frmEmployee()
		{
			InitializeComponent();
		}
		
		private void frmemployees_Load(object sender, EventArgs e)
		{
            
            string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `employees`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.employees);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			if( (( DataRowView )employeesBindingSource.Current )[ "dateOfBirth" ] is DBNull )
			{
				((DataRowView)employeesBindingSource.Current)["dateOfBirth"] = dateOfBirth_dateTimePicker.Value;
			}
			employeesBindingSource.EndEdit();
			ad.Update(this.newDataSet.employees);
			
		}
		
		private void frmemployees_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void employeeIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employeeIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employeeIDTextBox, "The field employeeID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employeeIDTextBox, "" ); } 
		}
		
		private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( firstNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( firstNameTextBox, "The field firstName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( firstNameTextBox, "" ); } 
		}
		
		private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( lastNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( lastNameTextBox, "The field lastName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( lastNameTextBox, "" ); } 
		}
		
		private void middleNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( middleNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( middleNameTextBox, "The field middleName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( middleNameTextBox, "" ); } 
		}
		
		private void departmentIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( departmentIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( departmentIDTextBox, "The field departmentID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( departmentIDTextBox, "" ); } 
		}
		
		private void designationTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( designationTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( designationTextBox, "The field designation is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( designationTextBox, "" ); } 
		}
		
		private void emailTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( emailTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( emailTextBox, "The field email is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( emailTextBox, "" ); } 
		}
		
		private void addressTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( addressTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( addressTextBox, "The field address is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( addressTextBox, "" ); } 
		}
		
		private void mobileNoTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( mobileNoTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( mobileNoTextBox, "The field mobileNo is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( mobileNoTextBox, "" ); } 
		}
		
		private void extensionNoTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( extensionNoTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( extensionNoTextBox, "The field extensionNo is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( extensionNoTextBox, "" ); } 
		}
		
		private void nextOfKinTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( nextOfKinTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( nextOfKinTextBox, "The field nextOfKin is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( nextOfKinTextBox, "" ); } 
		}
		
		private void genderTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( genderTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( genderTextBox, "The field gender is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( genderTextBox, "" ); } 
		}
		
		private void ageTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( ageTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( ageTextBox, "The field age is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( ageTextBox, "" ); } 
		}
		
		private void maritalStatusTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( maritalStatusTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( maritalStatusTextBox, "The field maritalStatus is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( maritalStatusTextBox, "" ); } 
		}

        private void degreeAttainedTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(degreeAttainedTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(degreeAttainedTextBox, "The field degreeAttained is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(degreeAttainedTextBox, ""); }
        }

        private void passportPicPictureBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
            if (string.IsNullOrEmpty(passportPicPictureBox.Text))
			{
				e.Cancel = true;
                errorProvider1.SetError(passportPicPictureBox, "The field passportPic is required"); 
			}
            if (!e.Cancel) { errorProvider1.SetError(passportPicPictureBox, ""); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			employeesBindingSource.AddNew();
		}

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string constring = "Datasource=localhost;Database=pharma;Uid=root;Pwd=;";
            string Query = "insert into pharma.employees (employeeID,firstName,lastName,middleName,dateOfBirth,departmentID,designation,email,address,mobileNo,extensionNo,nextOfKin,genger,age,maritalStatus,passportPic,degreeAttained) values ('" + this.employeeIDTextBox.Text + "','" + this.firstNameTextBox.Text + "','" + this.lastNameTextBox.Text + "','" + this.dateOfBirth_dateTimePicker.Text + "', '" + this.departmentIDTextBox.Text + "','" + this.designationTextBox.Text + "','" + this.emailTextBox.Text + "','" + this.addressTextBox.Text + "','" + this.mobileNoTextBox.Text + "','" + this.extensionNoTextBox.Text + "','" + this.nextOfKinTextBox.Text + "','" + this.genderTextBox.Text + "','" + this.ageTextBox.Text + "','" + this.maritalStatusTextBox.Text + "','" + this.passportPicPictureBox.Text + "','" + this.degreeAttainedTextBox.Text + "') ;";
            MySqlConnection conDb = new MySqlConnection(constring);
            MySqlCommand cmdDb = new MySqlCommand(Query, conDb);
            MySqlDataReader myReader;
            try
            {
                conDb.Open();
                myReader = cmdDb.ExecuteReader();
                MessageBox.Show("Record Saved");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadImagButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textBoxImagePath.Text = picPath;
                passportPicPictureBox.ImageLocation = picPath;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.RemoveCurrent();
            MessageBox.Show("Please save the changes");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)employeesBindingSource.Current)["dateOfBirth"] is DBNull)
            {
                ((DataRowView)employeesBindingSource.Current)["dateOfBirth"] = dateOfBirth_dateTimePicker.Value;
            }
            employeesBindingSource.EndEdit();
            ad.Update(this.newDataSet.employees);
            MessageBox.Show("Record updated successfully");
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            if (((DataRowView)employeesBindingSource.Current)["dateOfBirth"] is DBNull)
            {
                ((DataRowView)employeesBindingSource.Current)["dateOfBirth"] = dateOfBirth_dateTimePicker.Value;
            }
            employeesBindingSource.EndEdit();
            ad.Update(this.newDataSet.employees);
            MessageBox.Show("Record saved successfully");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

	}
}
