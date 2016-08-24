using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
namespace ManagementSystem
{
    public class ManagementSystem
    {
        ArrayList list = new ArrayList();

        public void addRequest(string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            if (status.Equals("Waiting"))
            {
                using (StreamWriter writer = new StreamWriter("../../Text/RequestItem.txt", true))
                {
                    writer.Write(firstName + ";");
                    writer.Write(lastName + ";");
                    writer.Write(request + ";");
                    writer.Write(status + ";");
                    writer.Write(assignment + ";");
                    writer.Write(grade + ";");
                    writer.Write("\n");
                }
            }
            else if (status.Equals("Completing"))
            {
                using (StreamWriter writer = new StreamWriter("../../Text/Assignment.txt", true))
                {
                    writer.Write(firstName + ";");
                    writer.Write(lastName + ";");
                    writer.Write(request + ";");
                    writer.Write(status + ";");
                    writer.Write(assignment + ";");
                    writer.Write(grade + ";");
                    writer.Write("\n");
                }
            }
        }

        public void readRequest(string search)
        {
            string currentLine;
            string[] requestData;
            string[] separator = { ";" };
            using (StreamReader reader = new StreamReader("../../Text/RequestItem.txt"))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    if (currentLine.Contains(search))
                    {
                        requestData = currentLine.Split(separator, StringSplitOptions.None);
                        RequestInformation ri = new RequestInformation(requestData[0], requestData[1], requestData[2], requestData[3], requestData[4], double.Parse(requestData[5]));
                        list.Add(ri);
                    }
                }
            }
        }

        public void modifyRequest(int path, string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            if (status.Equals("Completing"))
            {
                string[] linesList = File.ReadAllLines("../../Text/Assignment.txt");
                using (StreamWriter writer = new StreamWriter("../../Text/Assignment.txt", true))
                {
                    writer.Write(firstName + ";" + lastName + ";" + request + ";" + status + ";" + assignment + ";" + grade + ";");
                    writer.Write("\n");
                }
                var file = new List<string>(System.IO.File.ReadAllLines("../../Text/RequestItem.txt"));
                file.RemoveAt(path);
                File.WriteAllLines("../../Text/RequestItem.txt", file.ToArray());
            }
            else if (status.Equals("Waiting"))
            {
                string[] linesList = File.ReadAllLines("../../Text/RequestItem.txt");
                linesList[path] = firstName + ";" + lastName + ";" + request + ";" + status + ";" + assignment + ";" + grade + ";";
                File.WriteAllLines("../../Text/RequestItem.txt", linesList);
            }  
        }

        public void modifyAssignment(int path, string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            if (status.Equals("Completing"))
            {
                string[] linesList = File.ReadAllLines("../../Text/Assignment.txt");
                linesList[path] = firstName + ";" + lastName + ";" + request + ";" + status + ";" + assignment + ";" + grade + ";";
                File.WriteAllLines("../../Text/Assignment.txt", linesList);
            }
            else if (status.Equals("Waiting"))
            {
                string[] linesList = File.ReadAllLines("../../Text/RequestItem.txt");
                using (StreamWriter writer = new StreamWriter("../../Text/RequestItem.txt", true))
                {
                    writer.Write(firstName + ";" + lastName + ";" + request + ";" + status + ";" + assignment + ";" + grade + ";");
                    writer.Write("\n");
                }
                var file = new List<string>(System.IO.File.ReadAllLines("../../Text/Assignment.txt"));
                file.RemoveAt(path);
                File.WriteAllLines("../../Text/Assignment.txt", file.ToArray());
            }
        }

        public void deleteRequest(int lineNumber)
        {
            var file = new List<string>(System.IO.File.ReadAllLines("../../Text/RequestItem.txt"));
            file.RemoveAt(lineNumber);
            File.WriteAllLines("../../Text/RequestItem.txt", file.ToArray());
        }
        public void deleteAssignment(int lineNumber)
        {
            var file = new List<string>(System.IO.File.ReadAllLines("../../Text/Assignment.txt"));
            file.RemoveAt(lineNumber);
            File.WriteAllLines("../../Text/Assignment.txt", file.ToArray());
        }
    }
}
