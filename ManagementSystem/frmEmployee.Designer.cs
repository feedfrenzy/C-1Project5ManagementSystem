namespace ManagementSystem
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.lviInfo = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Request = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assignmen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grbEmployeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEmployeeInfo
            // 
            this.grbEmployeeInfo.Controls.Add(this.lviInfo);
            this.grbEmployeeInfo.Controls.Add(this.btnDelete);
            this.grbEmployeeInfo.Controls.Add(this.btnModify);
            this.grbEmployeeInfo.Controls.Add(this.btnSubmit);
            this.grbEmployeeInfo.Controls.Add(this.txtRequest);
            this.grbEmployeeInfo.Controls.Add(this.lblRequest);
            this.grbEmployeeInfo.Controls.Add(this.txtLastName);
            this.grbEmployeeInfo.Controls.Add(this.lblLastName);
            this.grbEmployeeInfo.Controls.Add(this.txtFirstName);
            this.grbEmployeeInfo.Controls.Add(this.lblFirstName);
            this.grbEmployeeInfo.Location = new System.Drawing.Point(41, 33);
            this.grbEmployeeInfo.Name = "grbEmployeeInfo";
            this.grbEmployeeInfo.Size = new System.Drawing.Size(682, 471);
            this.grbEmployeeInfo.TabIndex = 1;
            this.grbEmployeeInfo.TabStop = false;
            this.grbEmployeeInfo.Text = "Employee Information";
            // 
            // lviInfo
            // 
            this.lviInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lviInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Request,
            this.statu,
            this.Assignmen,
            this.Grade});
            this.lviInfo.GridLines = true;
            this.lviInfo.Location = new System.Drawing.Point(27, 183);
            this.lviInfo.Name = "lviInfo";
            this.lviInfo.Size = new System.Drawing.Size(621, 272);
            this.lviInfo.TabIndex = 10;
            this.lviInfo.UseCompatibleStateImageBehavior = false;
            this.lviInfo.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 99;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 102;
            // 
            // Request
            // 
            this.Request.Text = "Request";
            this.Request.Width = 134;
            // 
            // statu
            // 
            this.statu.Text = "Status";
            this.statu.Width = 102;
            // 
            // Assignmen
            // 
            this.Assignmen.Text = "Assignment";
            this.Assignmen.Width = 112;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(573, 109);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(573, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(288, 78);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(229, 20);
            this.txtRequest.TabIndex = 5;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(365, 46);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(47, 13);
            this.lblRequest.TabIndex = 4;
            this.lblRequest.Text = "Request";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(161, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(180, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(40, 78);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(62, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(769, 531);
            this.Controls.Add(this.grbEmployeeInfo);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.grbEmployeeInfo.ResumeLayout(false);
            this.grbEmployeeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEmployeeInfo;
        private System.Windows.Forms.ListView lviInfo;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Request;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ColumnHeader statu;
        private System.Windows.Forms.ColumnHeader Assignmen;
        private System.Windows.Forms.ColumnHeader Grade;
    }
}