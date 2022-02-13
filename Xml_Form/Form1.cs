using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using Xml_Form.Classes;

namespace Xml_Form
{
    public partial class Form1 : MaterialForm
    {
        private readonly BindingList<User> users = new();
        private readonly XmlDocument xDoc = new();
       // private readonly XmlDocument settingsDoc = new();
        readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private Settings settings;
        public Form1()
        {
            InitializeComponent();
            InitializeVariables();
            LoadXml();
            LoadSettings();
            materialSkinManager.AddFormToManage(this);
        }
        public void InitializeVariables()
        {
            user_listbox1.DisplayMember = "FullInfo";
            user_listbox1.DataSource = users;
            settings = new(@"D:\KPYP_LECTION\Xml_Form\XML\XMLFile1.xml");
        }
        private void LoadSettings()
        {
            XmlElement? xRoot = settings.XmlSettings.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    XmlNode? attr = xnode.Attributes.GetNamedItem("theme");
                    settings.Theme = attr.Value;
                    XmlNode? sch = xnode.Attributes.GetNamedItem("colorscheme");
                    settings.ColorScheme = sch.Value;
                }
            }
            if (settings.Theme == "DARK")
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSwitch1.Checked = true;
            }
            switch (settings.ColorScheme)
            {
                case "ORANGE":
                    {
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange200, Primary.Orange100, Accent.Orange400, TextShade.BLACK);
                        materialRadioButton2.Checked = true;
                    }
                    break;
                case "BLUE":
                    {
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue100, Primary.Blue200, Primary.Blue300, Accent.Blue400, TextShade.BLACK);
                        materialRadioButton1.Checked = true;
                    }
                    break;
                case "GREEN":
                    {
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Green100, Primary.Green200, Primary.Green300, Accent.Green400, TextShade.BLACK);
                        materialRadioButton3.Checked = true;
                    }
                    break;
            }
        }
        private void LoadXml()
        {
            xDoc.Load(@"D:\KPYP_LECTION\Xml_Form\XML\Workers.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    User user = new();
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");
                    user.Name = attr.Value;
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "company")
                            user.Company = childnode.InnerText;
                        if (childnode.Name == "age")
                            user.Age = int.Parse(childnode.InnerText);
                    }
                    users.Add(user);
                }
            }
        }
        private void SaveXml(string name, string company, string age)
        {
            XmlElement? xRoot = xDoc.DocumentElement;
            XmlElement userElem = xDoc.CreateElement("user");
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            XmlElement companyElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");
            XmlText nameText = xDoc.CreateTextNode(name);
            XmlText companyText = xDoc.CreateTextNode(company);
            XmlText ageText = xDoc.CreateTextNode(age);
            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(companyElem);
            userElem.AppendChild(ageElem);
            xRoot?.AppendChild(userElem);
            xDoc.Save(@"D:\KPYP_LECTION\Xml_Form\XML\Workers.xml");
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            if (name_field.Text == string.Empty || company_field.Text == string.Empty || age_field.Text == string.Empty)
            {
                MessageBox.Show("Ошибка добавления!", "Состояние", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveXml(name_field.Text, company_field.Text, age_field.Text);
                User user = new(name_field.Text, Convert.ToInt32(age_field.Text), company_field.Text);
                users.Add(user);
            }
        }
        private void Age_field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void Delete_user_Click(object sender, EventArgs e)
        {
            XmlElement? xRoot = xDoc.DocumentElement;
            if (user_listbox1.SelectedIndex >= 0)
            {
                XmlNode? xmlNode = xRoot?.SelectSingleNode($"//user[@name='{users[user_listbox1.SelectedIndex].Name}']");
                xmlNode?.ParentNode?.RemoveChild(xmlNode);
                xDoc.Save(@"D:\KPYP_LECTION\Xml_Form\XML\Workers.xml");
                users.RemoveAt(user_listbox1.SelectedIndex);
            }
        }
        private void Restart_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
        private void MaterialSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!materialSwitch1.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSwitch1.Text = "LIGHT";
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSwitch1.Text = "DARK";
            }
        }
        private void MaterialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton1.Checked)
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue100, Primary.Blue200, Primary.Blue300, Accent.Blue400, TextShade.BLACK);
        }
        private void MaterialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked)
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange200, Primary.Orange100, Accent.Orange400, TextShade.BLACK);
        }
        private void MaterialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton3.Checked)
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green100, Primary.Green200, Primary.Green300, Accent.Green400, TextShade.BLACK);
        }
        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            XmlElement? xRoot = settings.XmlSettings.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    xnode.Attributes["theme"].Value = materialSwitch1.Text;
                    if (materialRadioButton1.Checked)
                    {
                        xnode.Attributes["colorscheme"].Value = materialRadioButton1.Text;
                    }
                    else if (materialRadioButton2.Checked)
                    {
                        xnode.Attributes["colorscheme"].Value = materialRadioButton2.Text;
                    }
                    else if (materialRadioButton3.Checked)
                    {
                        xnode.Attributes["colorscheme"].Value = materialRadioButton3.Text;
                    }
                }
            }
            settings.XmlSettings.Save(@"D:\KPYP_LECTION\Xml_Form\XML\XMLFile1.xml");
        }
    }
}