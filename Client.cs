using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casaApplication
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

        }
        myADO ado = new myADO();

        int id;

        public void StreamClient()
        {
            ListViewItem li;
            // SqlDataReader =>
            //.Read() true if there are more rows; otherwise false.
            while (ado.myDataReader.Read())
            {
                li = new ListViewItem();

                li.Text = ado.myDataReader.GetInt32(0).ToString();
                for (int i = 1; i < 11; i++)
                {
                    li.SubItems.Add(ado.myDataReader.GetString(i).ToString());
                }
                LVClient.Items.Add(li);
            }
            ado.myDataReader.Close();
        }

        private void clientPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
         

          
        }

        private void idInput_Enter(object sender, EventArgs e)
        {
            if (idInput.text == "id")
            {
                idInput.text = "";
            }
        }

        private void idInput_Leave(object sender, EventArgs e)
        {
            if (idInput.text == "")
            {
                idInput.text = "id";
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (nameInput.text == "name")
            {
                nameInput.text = "";
            }
        }

        private void nameInput_Leave(object sender, EventArgs e)
        {
            if (nameInput.text == "")
            {
                nameInput.text = "name";
            }
        }

        private void surnameInput_Enter(object sender, EventArgs e)
        {
            if (surnameInput.text == "surname")
            {
                surnameInput.text = "";
            }
        }

        private void surnameInput_Leave(object sender, EventArgs e)
        {
            if (surnameInput.text == "")
            {
                surnameInput.text = "surname";
            }
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox3_OnTextChange(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
            civilityBox.SelectedIndex = 0;
            if (!ado.connect())
            {
                if (!ado.connect()) ;

            }

            if (ado.selectClient())
            {
                StreamClient();
            }
        }

        private void name_OnTextChange(object sender, EventArgs e)
        {

        }

        private void addClient_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                ado.addClient(name.text, surname.text, civilityBox.SelectedItem.ToString(), socialReason.text, adresse.text, city.text, zipCode.text, mobilePhone.text, fixPhone.text, email.text);
                if (ado.selectClient())
                {
                    LVClient.Items.Clear();
                    StreamClient();
                }

            } else
            {
                MessageBox.Show("Please sir we need all data to add this client");
            }
        }

        private void LVClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVClient.SelectedItems.Count > 0)
            {
                editButton.Visible = true;
                deleteButton.Visible = true;

            } else
            {
                editButton.Visible = false;
                deleteButton.Visible = false;
            }
        }

        private bool checkInputs()
        {
            return name.text != "name" && surname.text != "surname" && email.text != "email" && zipCode.text != "zip code" && city.text != "city" && fixPhone.text != "fixed phone" && mobilePhone.text != "mobile phone" && adresse.text != "adresse" && socialReason.text != "social reason";
        }

        private void LVClient_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (LVClient.FocusedItem.Bounds.Contains(e.Location))
                {
                    LVClientMenu.Show(Cursor.Position);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (LVClient.SelectedItems.Count != 0)
            {

            }
          

            if (LVClient.SelectedItems.Count == 0)
            {
                return;

            } else
            {

                ListViewItem item = LVClient.SelectedItems[0];
                id = Int32.Parse(item.SubItems[0].Text);
                nameEdit.text = item.SubItems[1].Text;
                surnameEdit.text = item.SubItems[2].Text;
                civilityBoxEdit.SelectedItem = item.SubItems[3].Text;
                socialReasonEdit.text = item.SubItems[4].Text;
                adresseEdit.text = item.SubItems[5].Text;
                cityEdit.text = item.SubItems[6].Text;
                zipCodeEdit.text = item.SubItems[7].Text;
                mobilePhoneEdit.text = item.SubItems[8].Text;
                fixedPhoneEdit.text = item.SubItems[9].Text;
                emailEdit.text = item.SubItems[10].Text;
                editClientBox.Visible = true;
                addClientBox.Visible = false;
            }





        }

        private void name_Enter_1(object sender, EventArgs e)
        {
            if (name.text == "name")
            {
                name.text = "";
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.text == "")
            {
                name.text = "name";
            }
        }

        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.text == "surname")
            {
                surname.text = "";
            }
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.text == "")
            {
                surname.text = "surname";
            }
        }

        private void socialReason_Enter(object sender, EventArgs e)
        {
            if (socialReason.text == "social reason")
            {
                socialReason.text = "";
            }
        }

        private void socialReason_Leave(object sender, EventArgs e)
        {
            if (socialReason.text == "")
            {
                socialReason.text = "social reason";
            }
        }

        private void adresse_Enter(object sender, EventArgs e)
        {
            if (adresse.text == "adresse")
            {
                adresse.text = "";
            }
        }

        private void adresse_Leave(object sender, EventArgs e)
        {
            if (adresse.text == "")
            {
                adresse.text = "adresse";
            }
        }

        private void city_Enter(object sender, EventArgs e)
        {
            if (city.text == "city")
            {
                city.text = "";
            }
        }

        private void city_Leave(object sender, EventArgs e)
        {
            if (city.text == "")
            {
                city.text = "city";
            }
        }

        private void zipCode_Enter(object sender, EventArgs e)
        {
            if (zipCode.text == "zip code")
            {
                zipCode.text = "";
            }
        }

        private void zipCode_Leave(object sender, EventArgs e)
        {
            if (zipCode.text == "")
            {
                zipCode.text = "zip code";
            }
        }

        private void mobilePhone_Enter(object sender, EventArgs e)
        {
            if (mobilePhone.text == "mobile phone")
            {
                mobilePhone.text = "";
            }
        }

        private void mobilePhone_Leave(object sender, EventArgs e)
        {
            if (mobilePhone.text == "")
            {
                mobilePhone.text = "mobile phone";
            }
        }

        private void fixPhone_Enter(object sender, EventArgs e)
        {
            if (fixPhone.text == "fixed phone")
            {
                fixPhone.text = "";
            }
        }

        private void fixPhone_Leave(object sender, EventArgs e)
        {
            if (fixPhone.text == "")
            {
                fixPhone.text = "fixed phone";
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.text == "email")
            {
                email.text = "";
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.text == "")
            {
                email.text = "email";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = LVClient.SelectedItems[0];

            int id = Int32.Parse(item.SubItems[0].Text);

            ado.deleteClient(id);

            if (ado.selectClient())
            {
                LVClient.Items.Clear();
                StreamClient();
            }

            editButton.Visible = false;
            deleteButton.Visible = false;
        }

        private void addClientBox_Enter(object sender, EventArgs e)
        {

        }

        private void editClient_Click(object sender, EventArgs e)
        {
            this.LVClient.Items.Clear();
            

            if (ado.updateClient(id, nameEdit.text, surnameEdit.text, civilityBoxEdit.SelectedItem.ToString(), socialReasonEdit.text, adresseEdit.text, cityEdit.text, zipCodeEdit.text, mobilePhoneEdit.text, fixedPhoneEdit.text, emailEdit.text))
            {
                if (ado.selectClient())
                {
                    StreamClient();
                }
            }

            editButton.Visible = false;
            deleteButton.Visible = false;

            editClientBox.Visible = false;
            addClientBox.Visible = true;

        }

        public void find()
        {
            int parsedValue;
            bool isNum = int.TryParse(idInput.text, out parsedValue);
            if (isNum == false && idInput.text != "id" && idInput.text != "")
            {
                MessageBox.Show("we need a numeric id.");
                return;
            }

                if (idInput.text != "id" && idInput.text != "")
            {

                ListViewItem LI;
                LI = new ListViewItem();
                this.LVClient.Items.Clear();
                int id = Int32.Parse(idInput.text);

                if (ado.findClient(id))
                {
                    StreamClient();
                }
            } else 
            {

                this.LVClient.Items.Clear();

                if (ado.selectClient())
                {
                    StreamClient();
                }
            }
            return;

        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            find();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editClientBox_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            editClientBox.Visible = false;
            addClientBox.Visible = true;

            editButton.Visible = false;
            deleteButton.Visible = false;
        }

       
    }
}
