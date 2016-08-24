using ManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    
    
    /// <summary>
    ///This is a test class for RequestInformationTest and is intended
    ///to contain all RequestInformationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RequestInformationTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for RequestInformation Constructor
        ///</summary>
        [TestMethod()]
        public void RequestInformationConstructorTest()
        {
            string expected = "TaekyuKimrequeststatusJhon50";
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "request"; // TODO: Initialize to an appropriate value
            string status = "status"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 50; // TODO: Initialize to an appropriate value
            RequestInformation target = new RequestInformation(firstName, lastName, request, status, assignment, grade); // TODO: Initialize to an appropriate value
            string b = target.getFirstName;
            string c = target.getLastName;
            string d = target.getRequest;
            string e = target.getStatus;
            string a = target.getAssignment;
            string f = target.getGrade.ToString();
            string actual = b + c + d + e + a + f;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getAssignment
        ///</summary>
        [TestMethod()]
        public void getAssignmentTest()
        {
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "request"; // TODO: Initialize to an appropriate value
            string status = "status"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 50; // TODO: Initialize to an appropriate value
            RequestInformation target = new RequestInformation(firstName, lastName, request, status, assignment, grade); // TODO: Initialize to an appropriate value
            string expected = assignment; // TODO: Initialize to an appropriate value
            string actual = target.getAssignment;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getFirstName
        ///</summary>
        [TestMethod()]
        public void getFirstNameTest()
        {
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "request"; // TODO: Initialize to an appropriate value
            string status = "status"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 50; // TODO: Initialize to an appropriate value
            RequestInformation target = new RequestInformation(firstName, lastName, request, status, assignment, grade); // TODO: Initialize to an appropriate value
            string expected = firstName; // TODO: Initialize to an appropriate value
            string actual = target.getFirstName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getGrade
        ///</summary>
        [TestMethod()]
        public void getGradeTest()
        {
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "request"; // TODO: Initialize to an appropriate value
            string status = "status"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 50; // TODO: Initialize to an appropriate value
            RequestInformation target = new RequestInformation(firstName, lastName, request, status, assignment, grade); // TODO: Initialize to an appropriate value
            string expected = grade.ToString(); // TODO: Initialize to an appropriate value
            string actual = target.getGrade.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getLastName
        ///</summary>
        [TestMethod()]
        public void getLastNameTest()
        {
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "request"; // TODO: Initialize to an appropriate value
            string status = "status"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 50; // TODO: Initialize to an appropriate value
            RequestInformation target = new RequestInformation(firstName, lastName, request, status, assignment, grade); // TODO: Initialize to an appropriate value
            string expected = lastName; // TODO: Initialize to an appropriate value
            string actual = target.getLastName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getRequest
        ///</summary>
        [TestMethod()]
        public void getRequestTest()
        {
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "request"; // TODO: Initialize to an appropriate value
            string status = "status"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 50; // TODO: Initialize to an appropriate value
            RequestInformation target = new RequestInformation(firstName, lastName, request, status, assignment, grade); // TODO: Initialize to an appropriate value
            string expected = request; // TODO: Initialize to an appropriate value
            string actual = target.getRequest;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getStatus
        ///</summary>
        [TestMethod()]
        public void getStatusTest()
        {
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "request"; // TODO: Initialize to an appropriate value
            string status = "status"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 50; // TODO: Initialize to an appropriate value
            RequestInformation target = new RequestInformation(firstName, lastName, request, status, assignment, grade); // TODO: Initialize to an appropriate value
            string expected = status; // TODO: Initialize to an appropriate value
            string actual = target.getStatus;
            Assert.AreEqual(expected, actual);
        }
    }
}
