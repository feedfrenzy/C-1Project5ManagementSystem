using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManagementSystem;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod()]
        public void addRequestTest()
        {
            TextClear();
            ManagementSystem.ManagementSystem target = new ManagementSystem.ManagementSystem(); // TODO: Initialize to an appropriate value
            // Actual
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "Fix"; // TODO: Initialize to an appropriate value
            string status = "Waiting"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 60; // TODO: Initialize to an appropriate value
            string actual = firstName + ";" + lastName + ";" + request + ";" + status + ";" + assignment + ";" + grade + ";";
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            // Expected
            using (StreamWriter writer = new StreamWriter("../../Text/UnitTest.txt", true))
            {
                writer.Write(ri.firstName + ";" + ri.lastName + ";" + ri.request + ";" + ri.status + ";" + ri.assignment + ";" + ri.grade + ";");
            }
            using (StreamReader reader = new StreamReader("../../Text/UnitTest.txt"))
            {
                string expected = reader.ReadLine();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for deleteAssignment
        ///</summary>
        [TestMethod()]
        public void deleteAssignmentTest()
        {
            TextClear();
            // Actual
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "Fix"; // TODO: Initialize to an appropriate value
            string status = "Waiting"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 60; // TODO: Initialize to an appropriate value
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            // Expected
            using (StreamWriter writer = new StreamWriter("../../Text/UnitTest.txt", true))
            {
                writer.Write(ri.firstName + ";" + ri.lastName + ";" + ri.request + ";" + ri.status + ";" + ri.assignment + ";" + ri.grade + ";");
            }
            var file = new List<string>(System.IO.File.ReadAllLines("../../Text/UnitTest.txt"));
            file.RemoveAt(0);
            File.WriteAllLines("../../Text/UnitTest.txt", file.ToArray());
            string actual = null;
            using (StreamReader reader = new StreamReader("../../Text/UnitTest.txt"))
            {
                string expected = reader.ReadLine();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for deleteRequest
        ///</summary>
        [TestMethod()]
        public void deleteRequestTest()
        {
            TextClear();
            // Actual
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "Fix"; // TODO: Initialize to an appropriate value
            string status = "Waiting"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 60; // TODO: Initialize to an appropriate value
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            // Expected
            using (StreamWriter writer = new StreamWriter("../../Text/UnitTest.txt", true))
            {
                writer.Write(ri.firstName + ";" + ri.lastName + ";" + ri.request + ";" + ri.status + ";" + ri.assignment + ";" + ri.grade + ";");
            }
            var file = new List<string>(System.IO.File.ReadAllLines("../../Text/UnitTest.txt"));
            file.RemoveAt(0);
            File.WriteAllLines("../../Text/UnitTest.txt", file.ToArray());
            string actual = null;
            using (StreamReader reader = new StreamReader("../../Text/UnitTest.txt"))
            {
                string expected = reader.ReadLine();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for modifyAssignment
        ///</summary>
        [TestMethod()]
        public void modifyAssignmentTest()
        {
            TextClear();
            string actual = "Seol;Son;request;Completing;Jie;10;";
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "Fix"; // TODO: Initialize to an appropriate value
            string status = "Waiting"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 60; // TODO: Initialize to an appropriate value
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            // Expected
            using (StreamWriter writer = new StreamWriter("../../Text/UnitTest.txt", true))
            {
                writer.Write(ri.firstName + ";" + ri.lastName + ";" + ri.request + ";" + ri.status + ";" + ri.assignment + ";" + ri.grade + ";");
            }
            int path = 0; // TODO: Initialize to an appropriate value
            string nfirstName = "Seol"; // TODO: Initialize to an appropriate value
            string nlastName = "Son"; // TODO: Initialize to an appropriate value
            string nrequest = "request"; // TODO: Initialize to an appropriate value
            string nstatus = "Completing"; // TODO: Initialize to an appropriate value
            string nassignment = "Jie"; // TODO: Initialize to an appropriate value
            double ngrade = 10; // TODO: Initialize to an appropriate value
            string[] linesList = File.ReadAllLines("../../Text/UnitTest.txt");
            linesList[path] = nfirstName + ";" + nlastName + ";" + nrequest + ";" + nstatus + ";" + nassignment + ";" + ngrade + ";";
            File.WriteAllLines("../../Text/UnitTest.txt", linesList);
            using (StreamReader reader = new StreamReader("../../Text/UnitTest.txt"))
            {
                string expected = reader.ReadLine();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for modifyRequest
        ///</summary>
        [TestMethod()]
        public void modifyRequestTest() // this is same as modifyAssignmentTest.
        {
            TextClear();
            string actual = "Seol;Son;request;Completing;Jie;10;";
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "Fix"; // TODO: Initialize to an appropriate value
            string status = "Waiting"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 60; // TODO: Initialize to an appropriate value
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            // Expected
            using (StreamWriter writer = new StreamWriter("../../Text/UnitTest.txt", true))
            {
                writer.Write(ri.firstName + ";" + ri.lastName + ";" + ri.request + ";" + ri.status + ";" + ri.assignment + ";" + ri.grade + ";");
            }
            int path = 0; // TODO: Initialize to an appropriate value
            string nfirstName = "Seol"; // TODO: Initialize to an appropriate value
            string nlastName = "Son"; // TODO: Initialize to an appropriate value
            string nrequest = "request"; // TODO: Initialize to an appropriate value
            string nstatus = "Completing"; // TODO: Initialize to an appropriate value
            string nassignment = "Jie"; // TODO: Initialize to an appropriate value
            double ngrade = 10; // TODO: Initialize to an appropriate value
            string[] linesList = File.ReadAllLines("../../Text/UnitTest.txt");
            linesList[path] = nfirstName + ";" + nlastName + ";" + nrequest + ";" + nstatus + ";" + nassignment + ";" + ngrade + ";";
            File.WriteAllLines("../../Text/UnitTest.txt", linesList);
            using (StreamReader reader = new StreamReader("../../Text/UnitTest.txt"))
            {
                string expected = reader.ReadLine();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for readRequest
        ///</summary>
        [TestMethod()]
        public void readRequestTest()
        {
            TextClear();
            // Actual
            string firstName = "Taekyu"; // TODO: Initialize to an appropriate value
            string lastName = "Kim"; // TODO: Initialize to an appropriate value
            string request = "Fix"; // TODO: Initialize to an appropriate value
            string status = "Waiting"; // TODO: Initialize to an appropriate value
            string assignment = "Jhon"; // TODO: Initialize to an appropriate value
            double grade = 60; // TODO: Initialize to an appropriate value
            string actual = "Taekyu;Kim;Fix;Waiting;Jhon;60;";
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            ManagementSystem.ManagementSystem target = new ManagementSystem.ManagementSystem(); // TODO: Initialize to an appropriate value
            // Expected
            using (StreamWriter writer = new StreamWriter("../../Text/UnitTest.txt", true))
            {
                writer.Write(ri.firstName + ";" + ri.lastName + ";" + ri.request + ";" + ri.status + ";" + ri.assignment + ";" + ri.grade + ";");
            }
            using (StreamReader reader = new StreamReader("../../Text/UnitTest.txt"))
            {
                string expected = reader.ReadLine();
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TextClear()
        {
            string actual = null;
            string expected;
            File.WriteAllText("../../Text/UnitTest.txt", String.Empty);
            using (StreamReader reader = new StreamReader("../../Text/UnitTest.txt"))
            {
                expected = reader.ReadLine();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
