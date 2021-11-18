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
    public partial class ManagerScreen : Form
    {
        private XmlNode managerNode;
        private Employee manager;
        public ManagerScreen(XmlNode xmlNode)
        {
            InitializeComponent();
            managerNode = xmlNode;
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            XmlDocument gamesDoc = new XmlDocument();
            gamesDoc.Load("C:\\Users\\zacha\\Desktop\\StoreFront App\\Storefront Management System\\Games.xml");
            XmlNodeList gameTitles = gamesDoc.GetElementsByTagName("Title");
            XmlNodeList gameRatings = gamesDoc.GetElementsByTagName("ESRB");
            XmlNodeList gameReleaseDates = gamesDoc.GetElementsByTagName("ReleaseDate");
            XmlNodeList gamePlatforms = gamesDoc.GetElementsByTagName("Platforms");

            string empName = managerNode["Name"].InnerText;
            bool isManager = managerNode["IsManager"].InnerText == "True" ? true : false;
            bool isOwner = managerNode["IsOwner"].InnerText == "True" ? true : false;
            DateTime hired = DateTime.Parse(managerNode["HireDate"].InnerText);
            DateTime birth = DateTime.Parse(managerNode["DateOfBirth"].InnerText);
            int empNumber = Convert.ToInt32(managerNode["EmployeeNumber"].InnerText);
            bool loggedIn = managerNode["IsLoggedIn"].InnerText == "True" ? true : false;

            manager = new Employee(empName, isManager, isOwner, empNumber, hired, birth, loggedIn, managerNode);
        }
    }
}
