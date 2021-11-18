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

        public Employee(XmlNode employee)
        {
            employeeDetails = employee;
            name = employeeDetails["Name"].InnerText;
            employeeNumber = Convert.ToInt32(employeeDetails["EmployeeNumber"].InnerText);
            isManager = employeeDetails["IsManager"].InnerText == "True" ? true : false;
            isOwner = employeeDetails["IsOwner"].InnerText == "True" ? true : false;
            isEmployee = (!isManager && !isOwner);
            lastLoginDate = DateTime.Today;
            isLoggedIn = employeeDetails["IsLoggedIn"].InnerText == "True" ? true : false;
            hireDate = DateTime.Parse(employeeDetails["HireDate"].InnerText);
            birthday = DateTime.Parse(employeeDetails["DateOfBirth"].InnerText);
            totalSales = employeeDetails["TotalNumberOfSales"].InnerText;
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
