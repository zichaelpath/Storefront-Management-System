using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Storefront_Management_System
{
    public partial class BEGamesLogin : Form
    {
        public BEGamesLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string storedUsername = "";
            string storedPassword = "";
            string storedName = "";
            bool isOwner = false;
            bool isManager = false;
            bool isEmployee = false;

            XmlDocument document = new XmlDocument();
            document.Load("C:\\Users\\zacha\\Desktop\\StoreFront App\\Storefront Management System\\Employee.xml");
            XmlNodeList employeeUserNames = document.GetElementsByTagName("UserName");
            XmlNodeList employeePasswords = document.GetElementsByTagName("PassWord");
            XmlNodeList employeeName = document.GetElementsByTagName("Name");
            XmlNodeList employeeRoleManager = document.GetElementsByTagName("IsManager");
            XmlNodeList employeeRoleOwner = document.GetElementsByTagName("IsOwner");
            XmlNode loggedInValue;
             

            for (int i = 0; i < employeeUserNames.Count; i++)
            {
                storedUsername = employeeUserNames[i].InnerText.ToString();
                storedPassword = employeePasswords[i].InnerText.ToString();
                storedName = employeeName[i].InnerText.ToString();
                isOwner = employeeRoleOwner[i].InnerText.ToString() == "True" ? true : false;
                isManager = employeeRoleManager[i].InnerText.ToString() == "True" ? true : false;
                isEmployee = !isOwner && !isManager;
                
                if (userName == storedUsername && password == storedPassword)
                {
                    MessageBox.Show(String.Format("Hello {0}, taking you to your page", storedName));
                    loggedInValue = document.SelectSingleNode(String.Format("Staff/Employee{0}/IsLoggedIn", i.ToString()));
                    loggedInValue.InnerXml = "True";
                    document.Save("C:\\Users\\zacha\\Desktop\\StoreFront App\\Storefront Management System\\Employee.xml");
                    break;
                }
            }
            if (isOwner)
            {
                OwnerScreen ownerScreen = new OwnerScreen();
                ownerScreen.Show();
                this.Hide();
            }
            if (isManager)
            {
                ManagerScreen managerScreen = new ManagerScreen();
                managerScreen.Show();
                this.Hide();
            }
            if (isEmployee)
            {
                EmployeeScreen employeeScreen = new EmployeeScreen();
                employeeScreen.Show();
                this.Hide();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
