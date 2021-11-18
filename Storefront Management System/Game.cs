using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Storefront_Management_System
{
    class Game
    {
        private string title;
        private string esrb;
        private short releaseDate;
        string[] platforms;
        private bool IDRequired;
        private string publisher;
        private short stock;
        private double price;
        XmlNode gameNode;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string ESRB
        {
            get { return esrb; }
            set { esrb = value; }
        }
        public short ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public Game(XmlNode xmlNode)
        {
            gameNode = xmlNode;
            title = gameNode["Title"].InnerText;
            esrb = gameNode["ESRB"].InnerText;
            releaseDate = Convert.ToInt16(gameNode["ReleaseDate"].InnerText);
            platforms = gameNode["Platforms"].InnerText.Split(",");
            IDRequired = gameNode["IDVerification"].InnerText == "Yes" ? true : false;
            publisher = gameNode["Publisher"].InnerText;
            stock = Convert.ToInt16(gameNode["Stock"].InnerText);
            price = Convert.ToDouble(gameNode["Price"].InnerText);
        }
        ~Game()
        {

        }
    }
}
