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
        private XmlDocument gamesDoc;
        public ManagerScreen(XmlNode xmlNode)
        {
            InitializeComponent();
            managerNode = xmlNode;
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            gamesDoc = new XmlDocument();
            gamesDoc.Load("C:\\Users\\zacha\\Desktop\\StoreFront App\\Storefront Management System\\Games.xml");
            XmlNodeList allGames = gamesDoc.SelectNodes("VideoGames/Game");



            manager = new Employee( managerNode);
            this.Text = manager.Name + " Management System";

            foreach (XmlNode game in allGames)
            {
                string title = game["Title"].InnerText;
                string releaseDate = game["ReleaseDate"].InnerText;
                string esrb = game["ESRB"].InnerText;
                string stock = game["Stock"].InnerText;
                string price = game["Price"].InnerText;
                string ageVerify = game["IDVerification"].InnerText;
                string[] row = { title, releaseDate, esrb, stock, price, ageVerify };
                dgvGameList.Rows.Add(row);
            }
        }

        
    }
}
