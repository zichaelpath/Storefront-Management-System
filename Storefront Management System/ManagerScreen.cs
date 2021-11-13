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
        public ManagerScreen()
        {
            InitializeComponent();
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            XmlDocument gamesDoc = new XmlDocument();
            gamesDoc.Load("C:\\Users\\zacha\\Desktop\\StoreFront App\\Storefront Management System\\Games.xml");
            XmlNodeList gameTitles = gamesDoc.GetElementsByTagName("Title");
            XmlNodeList gameRatings = gamesDoc.GetElementsByTagName("ESRB");
            XmlNodeList gameReleaseDates = gamesDoc.GetElementsByTagName("ReleaseDate");
            XmlNodeList gamePlatforms = gamesDoc.GetElementsByTagName("Platforms");
        }
    }
}
