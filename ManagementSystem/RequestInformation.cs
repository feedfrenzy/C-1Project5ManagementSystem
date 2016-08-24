using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public class RequestInformation
    {
        public string firstName;
        public string lastName;
        public string request;
        public string status;
        public string assignment;
        public double grade;

        public string getFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string getLastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string getRequest
        {
            get { return request; }
            set { request = value; }
        }
        public string getStatus
        {
            get { return status; }
            set { status = value; }
        }
        public string getAssignment
        {
            get { return assignment; }
            set { assignment = value; }
        }
        public double getGrade
        {
            get { return grade; }
            set { grade = value; }
        }
        public RequestInformation(string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            this.getFirstName = firstName;
            this.getLastName = lastName;
            this.getRequest = request;
            this.getStatus = status;
            this.getAssignment = assignment;
            this.getGrade = grade;
        }
    }
}
