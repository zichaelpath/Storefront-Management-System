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
            XmlNode loggedInValue = null;

            XmlNodeList employees = document.SelectNodes("Staff/Employee");
            EmployeeDataSet employeeData = new EmployeeDataSet();

            for (int i = 0; i < employees.Count; i++)
            { 
                storedUsername = employees[i]["UserName"].InnerText.ToString();
                storedPassword = employees[i]["PassWord"].InnerText.ToString();
                storedName = employees[i]["Name"].InnerText.ToString();
                isOwner = employees[i]["IsOwner"].InnerText.ToString() == "True" ? true : false;
                isManager = employees[i]["IsManager"].InnerText.ToString() == "True" ? true : false;
                isEmployee = !isOwner && !isManager;
                employeeData.ReadXml("C:\\Users\\zacha\\Desktop\\StoreFront App\\Storefront Management System\\Employee.xml");
                if (userName == storedUsername && password == storedPassword)
                {
                    MessageBox.Show(String.Format("Hello {0}, taking you to your page", storedName));
                    employees[i]["IsLoggedIn"].InnerXml = "True";
                    document.Save("C:\\Users\\zacha\\Desktop\\StoreFront App\\Storefront Management System\\Employee.xml");
                    loggedInValue = employees[i];
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
                ManagerScreen managerScreen = new ManagerScreen(loggedInValue);
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
