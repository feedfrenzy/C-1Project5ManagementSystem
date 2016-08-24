using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManagementSystem
{
    public partial class frmEmployee : Form
    {
        string firstName, lastName, request, status, assignment;
        double grade;
        ManagementSystem ms = new ManagementSystem();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            assignment = "Not Sure Yet";
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            request = txtRequest.Text;
            status = "Waiting";
            grade = 0;
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            ms.addRequest(firstName, lastName, request, status, assignment, grade);
            submit(ri.getFirstName,ri.getLastName,ri.getRequest,ri.getStatus, ri.getAssignment, ri.getGrade);
            
        }

        private void submit(string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            string[] info = { firstName, lastName, request, status, assignment, grade.ToString() };
            ListViewItem item = new ListViewItem(info);
            lviInfo.Items.Add(item);
        }

        private void modify(string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            if (lviInfo.SelectedItems.Count != 0)
            {
                lviInfo.SelectedItems[0].SubItems[0].Text = firstName;
                lviInfo.SelectedItems[0].SubItems[1].Text = lastName;
                lviInfo.SelectedItems[0].SubItems[2].Text = request;
                lviInfo.SelectedItems[0].SubItems[3].Text = status;
                lviInfo.SelectedItems[0].SubItems[4].Text = assignment;
                lviInfo.SelectedItems[0].SubItems[5].Text = grade.ToString();
                int line = lviInfo.FocusedItem.Index;
                ms.modifyRequest(line, firstName, lastName, request, status, assignment, grade);
            }
            else
            {
                MessageBox.Show("Please Choose a list");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            request = txtRequest.Text;
            status = "Waiting";
            assignment = "Not Sure Yet";
            grade = 0;
            RequestInformation ri = new RequestInformation(firstName, lastName, request, status, assignment, grade);
            modify(ri.getFirstName, ri.getLastName, ri.getRequest, ri.getStatus, ri.getAssignment, ri.getGrade);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lviInfo.SelectedItems.Count != 0)
            {
                ms.deleteRequest(lviInfo.FocusedItem.Index);
                lviInfo.Items.RemoveAt(lviInfo.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Please Choose a list");
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string line;
            string[] info;
            string[] semi = {";"};
            using (StreamReader reader = new StreamReader("../../Text/RequestItem.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    info = line.Split(semi, StringSplitOptions.None);
                    ListViewItem item = new ListViewItem(info[0]);
                    item.SubItems.Add(info[1]);
                    item.SubItems.Add(info[2]);
                    item.SubItems.Add(info[3]);
                    item.SubItems.Add(info[4]);
                    item.SubItems.Add(info[5]);
                    lviInfo.Items.Add(item);
                }
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
