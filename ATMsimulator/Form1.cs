using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMsimulator
{
    public partial class FormAtm : Form
    {
        JsonProperties jsonProperties = new JsonProperties();
        public FormAtm()
        {
            InitializeComponent();
            if(File.Exists("myJsonPerson.json")){
                JsonProperties jsonProperties = JsonConvert.DeserializeObject<JsonProperties>(File.ReadAllText("myJsonPerson.json"));
                foreach (JsonPropertie jsonPropertie in jsonProperties.PersonList)
                {
                    Add(jsonPropertie);
                }
            }
            button1.Enabled = false;
        }

        private void buttonLaunch_MouseClick(object sender, MouseEventArgs e)
        {
            panelPin.Visible = true;
            panelLaunch.Visible = false;
        }

        private void textBoxPin_TextChanged(object sender, EventArgs e)//textbox_PIN
        {
            JsonPropertie jsonPropertie = (JsonPropertie)listViewPerson.SelectedItems[0].Tag;

            if (textBoxPin.Text== jsonPropertie.pin) 
            {
                panelPin.Visible = false;
                panelStartMenu.Visible = true;
                textBoxPin.Text = "";
            }
        }

        private void FormAtm_Load(object sender, EventArgs e)
        {
            panelLaunch.Visible = true;
            panelPin.Visible = false;
            panelStartMenu.Visible = false;
            panelBalance.Visible = false;
            panelDeposit.Visible = false;
            panelDepositMyBalance.Visible = false;
            panelRegistration.Visible = false;
        }

        private void buttonBackStartMenu_MouseClick(object sender, MouseEventArgs e)//button_StartMenu
        {
            panelLaunch.Visible = true;
            panelStartMenu.Visible = false;
            
        }

        private void buttonBackBalance_MouseDown(object sender, MouseEventArgs e)
        {
            panelStartMenu.Visible = true;
            panelBalance.Visible = false;
        }

        private void buttonBalance_MouseDown(object sender, MouseEventArgs e)
        {
            panelBalance.Visible = true;
            panelStartMenu.Visible = false;
        }

        private void buttonBackDeposit_MouseClick(object sender, MouseEventArgs e)
        {
            panelStartMenu.Visible = true;
            panelDeposit.Visible = false;
        }

        private void buttonDeposit_MouseDown(object sender, MouseEventArgs e)
        {
            panelDeposit.Visible = true;
            panelStartMenu.Visible = false;
        }

        private void buttonDepositMyBalance_MouseDown(object sender, MouseEventArgs e)
        {
            panelDeposit.Visible = true;
            panelDepositMyBalance.Visible = false;
        }

        private void buttonConfirmDeposit_MouseDown(object sender, MouseEventArgs e)
        {
            JsonPropertie jsonPropertie = (JsonPropertie)listViewPerson.SelectedItems[0].Tag;
            labelDepositAmount.Text = $"Částka: {jsonPropertie.money += int.Parse(textBoxDepositMyBalance.Text)}";
            
            textBoxDepositMyBalance.Text = "0";
            foreach (ListViewItem item in listViewPerson.Items)
            {
                if (item.Tag != null)
                {
                    jsonProperties.PersonList.Add((JsonPropertie)item.Tag);
                }
                SerializedJson(jsonProperties);
            }
        }

        private void buttonMyBalance_MouseDown(object sender, MouseEventArgs e)
        {
            panelDepositMyBalance.Visible = true;
            labelDepositAmount.Text = "Zadejte částku.";
            panelDeposit.Visible = false;
        }
        Random random = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "") {
                MessageBox.Show("Enter your name");
            }
            else if (textBoxSecondName.Text == "")
            {
                MessageBox.Show("Enter your second name");
            }
            else if(textBoxDate.Text =="" || textBoxMonth.Text=="" || textBoxYear.Text == "")
            {
                MessageBox.Show("Enter your birthday");
            }
            else
            {
                //date
                string dateCard = textBoxDate.Text.ToString() + "/" + textBoxYear.Text.ToString().Remove(0, 1);
                //pin
                
                //number card
                string numberCard = "5402 21" + random.Next(10, 99) + " " + random.Next(1000, 9999) + " " + random.Next(1000, 9999);

                JsonPropertie jsonPropertie = new JsonPropertie(textBoxName.Text, textBoxSecondName.Text, numberCard, textBoxMyPin.Text, dateCard,numericUpDownMoney.Value);
                Add(jsonPropertie);


                JsonProperties jsonProperties = new JsonProperties();
                foreach (ListViewItem item in listViewPerson.Items)
                {
                    if (item.Tag != null)
                    {
                        jsonProperties.PersonList.Add((JsonPropertie)item.Tag);
                    }
                    SerializedJson(jsonProperties);
                }
                panelRegistration.Visible = false;
                panelPin.Visible = true;
            }
        }
        
        private void Add(JsonPropertie jsonPropertie)
        {
            ListViewItem listViewItem = new ListViewItem(jsonPropertie.name);
            listViewItem.Tag = jsonPropertie;
            listViewPerson.Items.Add(listViewItem);
        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string randomPin = (random.Next(100, 999)).ToString();
            textBoxMyPin.Text = randomPin;
            textBoxMyPin.ReadOnly = true;
            panelStartMenu.Visible = false;
            panelRegistration.Visible = true;
        }

        private void SerializedJson(JsonProperties personList)
        {
            File.WriteAllText("myJsonPerson.json", JsonConvert.SerializeObject(personList));
        }
        private void buttonBackRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            panelRegistration.Visible = false;
            panelLaunch.Visible = true;
        }

        private void comboBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panelBalance_Paint(object sender, PaintEventArgs e)
        {
            if (listViewPerson.SelectedItems.Count == 1)
            {
                JsonPropertie jsonPropertie = (JsonPropertie)listViewPerson.SelectedItems[0].Tag;
                if (jsonProperties != null)
                {
                    textMoney.Text = $"Na kartě máte {jsonPropertie.money} czk";
                }
            }
        }

        private void buttonConfirmTheDeposit_Click(object sender, EventArgs e)
        {

        }

        private void listViewPerson_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            textBoxDate.MaxLength = 2;
        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {
            textBoxMonth.MaxLength = 2;
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            textBoxYear.MaxLength = 2;
        }
    }
}
