using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Storefront_Management_System
{
    class Employee
    {
        private string name;
        private int employeeNumber;
        private bool isManager;
        private bool isOwner;
        private bool isEmployee;
        private DateTime lastLoginDate;
        private bool isLoggedIn;
        private DateTime hireDate;
        private DateTime birthday;
        private XmlNode employeeDetails;
        private string totalSales;
        public string Name { 
            get { return name; } 
            set { name = value; }
        }
        public int EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
        }

        public Employee(string mpName, bool manager, bool owner, int empNo, DateTime hired, DateTime birth, bool loggedIn, XmlNode employee)
        {
            name = mpName;
            employeeNumber = empNo;
            isManager = manager;
            isOwner = owner;
            isEmployee = (!isManager && !isOwner);
            hireDate = hired;
            birthday = birth;
            isLoggedIn = loggedIn;
            employeeDetails = employee;
            totalSales = employee["TotalNumberOfSales"].InnerText.ToString();
            employeeDetails = employee;
        }

        public bool isEmployeeOwner()
        {
            return isOwner;
        }

        public bool isEmployeeManager()
        {
            return isManager;
        }

        public bool isEmployeeRegular()
        {
            return (!isOwner && isManager);
        }
        public string getTotalSales()
        {
            string totalSalesStatement = "Total Number of Sales Made by " + name + " is: " + totalSales;
            return totalSalesStatement;
        }

        public void makeSale(int numberOfItemsSold)
        {
            int totalSales = Convert.ToInt32(employeeDetails["TotalNumberOfSales"].InnerText);
            totalSales += numberOfItemsSold;
            employeeDetails["TotalNumberOfSales"].InnerText = totalSales.ToString();
        }
        ~Employee()
        {

        }
    }
}
