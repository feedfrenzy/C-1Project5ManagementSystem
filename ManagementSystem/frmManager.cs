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
using System.Collections;
using System.Globalization;
using System.Threading;



namespace ManagementSystem
{
    public partial class frmManager : Form
    {
        string firstName, lastName, request, statu, assignment;
        double grade = 0;
        ManagementSystem ms = new ManagementSystem();
        
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            request = txtRequest.Text;
            statu = cobStatus.Text;
            assignment = txtAssignment.Text;
            if (txtGrade.Text == "")
            {
                txtGrade.Text = "0";
            }
            grade = double.Parse(txtGrade.Text);
            if (firstName.Equals("") || lastName.Equals("") || request.Equals("") || statu.Equals("") || assignment.Equals("") || grade > 100)
            {
                MessageBox.Show("Please fill out all text boxes or grade should be 0~100");
            }
            else
            {
                RequestInformation ri = new RequestInformation(firstName, lastName, request, statu, assignment, grade);
                ms.addRequest(firstName, lastName, request, statu, assignment, grade);
                submit(ri.getFirstName, ri.getLastName, ri.getRequest, ri.getStatus, ri.getAssignment, ri.getGrade);
            }

        }

        private void submit(string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            if (status == "Completing")
            {
                string[] info2 = { firstName, lastName, request, status, assignment, grade.ToString() };
                ListViewItem item2 = new ListViewItem(info2);
                lviCompleting.Items.Add(item2);
            }
            else
            {
                string[] info = { firstName, lastName, request, status, assignment, grade.ToString() };
                ListViewItem item = new ListViewItem(info);
                lviInfo.Items.Add(item);
            }

        }

        private void modify(string firstName, string lastName, string request, string status, string assignment, double grade)
        {
            if (lviInfo.SelectedItems.Count == 0 && lviCompleting.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Choose A list");
            }
            else if (lviInfo.SelectedItems.Count == 1)
            {
                if (status == "Completing")
                {
                    string[] info3 = { firstName, lastName, request, status, assignment, grade.ToString() };
                    ListViewItem item3 = new ListViewItem(info3);
                    lviCompleting.Items.Add(item3);
                    int line = lviInfo.FocusedItem.Index;
                    ms.modifyRequest(line, firstName, lastName, request, status, assignment, grade);
                    lviInfo.Items.RemoveAt(line);
                }
                else if (statu == "Waiting")
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
            }
            else if (lviCompleting.SelectedItems.Count == 1)
            {
                if (status == "Waiting")
                {
                    string[] info3 = { firstName, lastName, request, status, assignment, grade.ToString() };
                    ListViewItem item3 = new ListViewItem(info3);
                    lviInfo.Items.Add(item3);
                    int line = lviCompleting.FocusedItem.Index;
                    ms.modifyAssignment(line, firstName, lastName, request, status, assignment, grade);
                    lviCompleting.Items.RemoveAt(line);
                }
                else if (status == "Completing")
                {
                    lviCompleting.SelectedItems[0].SubItems[0].Text = firstName;
                    lviCompleting.SelectedItems[0].SubItems[1].Text = lastName;
                    lviCompleting.SelectedItems[0].SubItems[2].Text = request;
                    lviCompleting.SelectedItems[0].SubItems[3].Text = status;
                    lviCompleting.SelectedItems[0].SubItems[4].Text = assignment;
                    lviCompleting.SelectedItems[0].SubItems[5].Text = grade.ToString();
                    int line = lviCompleting.FocusedItem.Index;
                    ms.modifyAssignment(line, firstName, lastName, request, status, assignment, grade);
                }
            }
        }
        private void frmManager_Load(object sender, EventArgs e)
        {
            string line;
            string[] info;
            string[] semi = { ";" };
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
            string line2;
            string[] info2;
            string[] semi2 = { ";" };
            using (StreamReader reader = new StreamReader("../../Text/Assignment.txt"))
            {
                while ((line2 = reader.ReadLine()) != null)
                {
                    info2 = line2.Split(semi2, StringSplitOptions.None);
                    ListViewItem item2 = new ListViewItem(info2[0]);
                    item2.SubItems.Add(info2[1]);
                    item2.SubItems.Add(info2[2]);
                    item2.SubItems.Add(info2[3]);
                    item2.SubItems.Add(info2[4]);
                    item2.SubItems.Add(info2[5]);
                    lviCompleting.Items.Add(item2);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lviInfo.SelectedItems.Count == 0 && lviCompleting.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Choose A list");
            }
            else if (lviInfo.SelectedItems.Count == 1)
            {
                ms.deleteRequest(lviInfo.FocusedItem.Index);
                lviInfo.Items.RemoveAt(lviInfo.SelectedIndices[0]);
            }
            else if (lviCompleting.SelectedItems.Count == 1)
            {
                ms.deleteAssignment(lviCompleting.FocusedItem.Index);
                lviCompleting.Items.RemoveAt(lviCompleting.SelectedIndices[0]);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            request = txtRequest.Text;
            statu = cobStatus.Text;
            assignment = txtAssignment.Text;
            if (txtGrade.Text == "")
            {
                txtGrade.Text = "0";
            }
            grade = double.Parse(txtGrade.Text);
            if (firstName.Equals("") || lastName.Equals("") || request.Equals("") || statu.Equals("") || assignment.Equals("") || grade > 100)
            {
                MessageBox.Show("Please fill out all text boxes or grade should be 0~100");
            }
            else
            {
                RequestInformation ri = new RequestInformation(firstName, lastName, request, statu, assignment, grade);
                modify(ri.getFirstName, ri.getLastName, ri.getRequest, ri.getStatus, ri.getAssignment, ri.getGrade);
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtAssignment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lviInfo.Items.Clear();
            ArrayList list = new ArrayList();
            string currentLine;
            string[] requestData;
            string[] separator = { ";" };
            using (StreamReader reader = new StreamReader("../../Text/RequestItem.txt"))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    requestData = currentLine.Split(separator, StringSplitOptions.None);
                    if (cobSearchW.SelectedIndex == 0)
                    {
                        if (requestData[0].IndexOf(txtSearchW.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviInfo.Items.Add(item3);
                        }                        
                    }
                    else if (cobSearchW.SelectedIndex == 1)
                    {
                        if (requestData[1].IndexOf(txtSearchW.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {                    
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviInfo.Items.Add(item3);
                        }
                    }
                    else if(cobSearchW.SelectedIndex == 2)
                    {
                        if (requestData[2].IndexOf(txtSearchW.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviInfo.Items.Add(item3);
                        }
                    }
                    else if (cobSearchW.SelectedIndex == 3)
                    {
                        if (requestData[3].IndexOf(txtSearchW.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviInfo.Items.Add(item3);
                        }
                    }
                    else if (cobSearchW.SelectedIndex == 4)
                    {
                        if (requestData[4].IndexOf(txtSearchW.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviInfo.Items.Add(item3);
                        }
                    }
                    else
                    {
                        if (requestData[5].IndexOf(txtSearchW.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviInfo.Items.Add(item3);
                        }
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lviInfo.Items.Clear();
            string line;
            string[] info;
            string[] semi = { ";" };
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

        private void btnLoadC_Click(object sender, EventArgs e)
        {
            lviCompleting.Items.Clear();
            string line;
            string[] info;
            string[] semi = { ";" };
            using (StreamReader reader = new StreamReader("../../Text/Assignment.txt"))
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
                    lviCompleting.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lviCompleting.Items.Clear();
            ArrayList list = new ArrayList();
            string currentLine;
            string[] requestData;
            string[] separator = { ";" };
            using (StreamReader reader = new StreamReader("../../Text/Assignment.txt"))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    requestData = currentLine.Split(separator, StringSplitOptions.None);
                    if (cobSearchC.SelectedIndex == 0)
                    {
                        if (requestData[0].IndexOf(txtSearchC.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviCompleting.Items.Add(item3);
                        }
                    }
                    else if (cobSearchC.SelectedIndex == 1)
                    {
                        if (requestData[1].IndexOf(txtSearchC.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviCompleting.Items.Add(item3);
                        }
                    }
                    else if (cobSearchC.SelectedIndex == 2)
                    {
                        if (requestData[2].IndexOf(txtSearchC.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviCompleting.Items.Add(item3);
                        }
                    }
                    else if (cobSearchC.SelectedIndex == 3)
                    {
                        if (requestData[3].IndexOf(txtSearchC.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviCompleting.Items.Add(item3);
                        }
                    }
                    else if (cobSearchC.SelectedIndex == 4)
                    {
                        if (requestData[4].IndexOf(txtSearchC.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviCompleting.Items.Add(item3);
                        }
                    }
                    else
                    {
                        if (requestData[5].IndexOf(txtSearchC.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            ListViewItem item3 = new ListViewItem(requestData[0]);
                            item3.SubItems.Add(requestData[1]);
                            item3.SubItems.Add(requestData[2]);
                            item3.SubItems.Add(requestData[3]);
                            item3.SubItems.Add(requestData[4]);
                            item3.SubItems.Add(requestData[5]);
                            lviCompleting.Items.Add(item3);
                        }
                    }
                }
            }
        }
    }
}
