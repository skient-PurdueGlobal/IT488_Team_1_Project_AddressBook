using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IT488_Team_1_Project_AddressBook.DAL;

namespace IT488_Team_1_Project_AddressBook.PLL
{
    public partial class AddEditContact : Form
    {
        //Global Form Variables
        public string addOrEdit = "";
        public int selectedContact = -1;

        public AddEditContact(string butText, int contact)
        {
            InitializeComponent();

            addOrEdit = butText;
            selectedContact = contact;
        }

        #region Button Events
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool errors = false;

            //Data Validation
            #region Data Validation
            if (!firstNameTextBox.Text.All(c => Char.IsLetter(c)) || firstNameTextBox.Text.Length == 0)
            {
                firstNameLabel.ForeColor = Color.Red;
                errors = true;
            }
            else firstNameLabel.ForeColor = Color.Black;
            if (!lastNameTextBox.Text.All(c => Char.IsLetter(c)) || lastNameTextBox.Text.Length == 0)
            {
                lastNameLabel.ForeColor = Color.Red;
                errors = true;
            }
            else lastNameLabel.ForeColor = Color.Black;
            if (address1TextBox.Text.Length == 0)
            {
                address1Label.ForeColor = Color.Red;
                errors = true;
            }
            else address1Label.ForeColor = Color.Black;
            if (!cityTextBox.Text.All(c => Char.IsLetter(c)) || cityTextBox.Text.Length == 0)
            {
                cityLabel.ForeColor = Color.Red;
                errors = true;
            }
            else cityLabel.ForeColor = Color.Black;
            if (!stateTextBox.Text.All(c => Char.IsLetter(c)) || stateTextBox.Text.Length != 2 || stateTextBox.Text.Length == 0)
            {
                stateLabel.ForeColor = Color.Red;
                errors = true;
            }
            else stateLabel.ForeColor = Color.Black;
            if (!zipTextBox.Text.All(c => Char.IsNumber(c)) || zipTextBox.Text.Length != 5 || zipTextBox.Text.Length == 0)
            {
                zipLabel.ForeColor = Color.Red;
                errors = true;
            }
            else zipLabel.ForeColor = Color.Black;
            if (!phoneTextBox.Text.All(c => Char.IsNumber(c)) || phoneTextBox.Text.Length != 10 || phoneTextBox.Text.Length == 0)
            {
                phoneLabel.ForeColor = Color.Red;
                errors = true;
            }
            else phoneLabel.ForeColor = Color.Black;
            if (!IsValidEmail(emailTextBox.Text) || emailTextBox.Text.Length == 0)
            {
                emailLabel.ForeColor = Color.Red;
                errors = true;
            }
            else emailLabel.ForeColor = Color.Black;
            //Comments box does not require validation.
            #endregion

            //Check for errors and display message dialog.
            if (errors)
            {
                MessageBox.Show("Input Errors", "Please correct input errors.");
            }
            else
            {
                if (addOrEdit == "Edit Contact")
                    UpdateDataSet();
                else
                    AddDataSet();
                Connection.Update_Database();
                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Data Validation Functions
        //Data Validation Functions
        private bool IsValidEmail(string e)
        {
            bool result = false;

            try
            {
                var validator = new System.Net.Mail.MailAddress(e);
                result = (e.LastIndexOf(".") > e.LastIndexOf("@"));
            }
            catch
            {
                result = false;
            }

            return result;
        }
        #endregion

        #region DataSet Functions
        //DataSet Functions
        private void AddDataSet()
        {
            int maxNameId = 0;
            int maxAddressId = 0;
            int maxOtherId = 0;

            //Update contactName Table
            projectDataSet.contactNameRow nameRow = Connection.dbDataSet.contactName.NewcontactNameRow();
            foreach (projectDataSet.contactNameRow r in Connection.dbDataSet.contactName)
            {
                if (r.id > maxNameId)
                    maxNameId = r.id;
            }
            nameRow.id = maxNameId + 1;
            nameRow.firstName = firstNameTextBox.Text;
            nameRow.lastName = lastNameTextBox.Text;

            //Update contactAddress Table
            projectDataSet.contactAddressRow addressRow = Connection.dbDataSet.contactAddress.NewcontactAddressRow();
            foreach (projectDataSet.contactAddressRow r in Connection.dbDataSet.contactAddress)
            {
                if (r.id > maxAddressId)
                    maxAddressId = r.id;
            }
            addressRow.id = maxAddressId + 1;
            addressRow.addressLine1 = address1TextBox.Text;
            addressRow.addressLine2 = address2TextBox.Text;
            addressRow.city = cityTextBox.Text;
            addressRow.state = stateTextBox.Text;
            addressRow.zip = Convert.ToInt32(zipTextBox.Text);
            addressRow.contactId = maxNameId + 1;

            //Update contactOther Table
            projectDataSet.contactOtherRow otherRow = Connection.dbDataSet.contactOther.NewcontactOtherRow();
            foreach (projectDataSet.contactOtherRow r in Connection.dbDataSet.contactOther)
            {
                if (r.id > maxOtherId)
                    maxOtherId = r.id;
            }
            otherRow.id = maxOtherId + 1;
            otherRow.phoneNum = phoneTextBox.Text;
            otherRow.email = emailTextBox.Text;
            otherRow.comments = commentsTextBox.Text;
            otherRow.contactId = maxNameId + 1;

            //Add Rows to DataTables
            Connection.dbDataSet.contactName.Rows.Add(nameRow);
            Connection.dbDataSet.contactAddress.Rows.Add(addressRow);
            Connection.dbDataSet.contactOther.Rows.Add(otherRow);
        }
        private void UpdateDataSet()
        {
            int index = 0;
            foreach (projectDataSet.contactNameRow r in Connection.dbDataSet.contactName.ToList())
            {
                if (r.id == selectedContact)
                {
                    Connection.dbDataSet.contactName[index].BeginEdit();
                    Connection.dbDataSet.contactName[index].firstName = firstNameTextBox.Text;
                    Connection.dbDataSet.contactName[index].lastName = lastNameTextBox.Text;
                    Connection.dbDataSet.contactName[index].EndEdit();
                    break;
                }
                index++;
            }

            index = 0;
            foreach (projectDataSet.contactAddressRow r in Connection.dbDataSet.contactAddress.ToList())
            {
                if (r.contactId == selectedContact)
                {
                    Connection.dbDataSet.contactAddress[index].BeginEdit();
                    Connection.dbDataSet.contactAddress[index].addressLine1 = address1TextBox.Text;
                    Connection.dbDataSet.contactAddress[index].addressLine2 = address2TextBox.Text;
                    Connection.dbDataSet.contactAddress[index].city = cityTextBox.Text;
                    Connection.dbDataSet.contactAddress[index].state = stateTextBox.Text;
                    Connection.dbDataSet.contactAddress[index].zip = Convert.ToInt32(zipTextBox.Text);
                    Connection.dbDataSet.contactAddress[index].EndEdit();
                    break;
                }
                index++;
            }

            index = 0;
            foreach (projectDataSet.contactOtherRow r in Connection.dbDataSet.contactOther.ToList())
            {
                if (r.contactId == selectedContact)
                {
                    Connection.dbDataSet.contactOther[index].BeginEdit();
                    Connection.dbDataSet.contactOther[index].phoneNum = phoneTextBox.Text;
                    Connection.dbDataSet.contactOther[index].email = emailTextBox.Text;
                    Connection.dbDataSet.contactOther[index].comments = commentsTextBox.Text;
                    Connection.dbDataSet.contactOther[index].EndEdit();
                    index++;
                }
                index++;
            }
        }
        #endregion
        private void AddEditContact_Load(object sender, EventArgs e)
        {
            if (addOrEdit == "Edit Contact")
            {
                int index = 0;
                foreach (projectDataSet.contactNameRow r in Connection.dbDataSet.contactName.ToList())
                {
                    if (r.id == selectedContact)
                    {
                        firstNameTextBox.Text = Connection.dbDataSet.contactName[index].firstName;
                        lastNameTextBox.Text = Connection.dbDataSet.contactName[index].lastName;
                        break;
                    }

                    index++;
                }

                index = 0;
                foreach (projectDataSet.contactAddressRow r in Connection.dbDataSet.contactAddress.ToList())
                {
                    if (r.contactId == selectedContact)
                    {
                        address1TextBox.Text = Connection.dbDataSet.contactAddress[index].addressLine1;
                        address2TextBox.Text = Connection.dbDataSet.contactAddress[index].addressLine2;
                        cityTextBox.Text = Connection.dbDataSet.contactAddress[index].city;
                        stateTextBox.Text = Connection.dbDataSet.contactAddress[index].state;
                        zipTextBox.Text = Connection.dbDataSet.contactAddress[index].zip.ToString();
                        break;
                    }

                    index++;
                }
                
                index = 0;
                foreach (projectDataSet.contactOtherRow r in Connection.dbDataSet.contactOther.ToList())
                {
                    if (r.contactId == selectedContact)
                    {
                        phoneTextBox.Text = Connection.dbDataSet.contactOther[index].phoneNum;
                        emailTextBox.Text = Connection.dbDataSet.contactOther[index].email;
                        commentsTextBox.Text = Connection.dbDataSet.contactOther[index].comments;
                        break;
                    }
                    
                    index++;
                }
            }
        }
    }
}
