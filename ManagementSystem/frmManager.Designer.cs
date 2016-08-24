namespace ManagementSystem
{
    partial class frmManager
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
            this.grbManagerInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearchC = new System.Windows.Forms.Label();
            this.txtSearchC = new System.Windows.Forms.TextBox();
            this.cobSearchC = new System.Windows.Forms.ComboBox();
            this.btnSearchC = new System.Windows.Forms.Button();
            this.btnLoadC = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSearchW = new System.Windows.Forms.Label();
            this.txtSearchW = new System.Windows.Forms.TextBox();
            this.cobSearchW = new System.Windows.Forms.ComboBox();
            this.btnLoadA = new System.Windows.Forms.Button();
            this.cobStatus = new System.Windows.Forms.ComboBox();
            this.lblCompleting = new System.Windows.Forms.Label();
            this.lblWaitingAssignment = new System.Windows.Forms.Label();
            this.lviCompleting = new System.Windows.Forms.ListView();
            this.cFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRequest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAssignment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAssignment = new System.Windows.Forms.Label();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearchW = new System.Windows.Forms.Button();
            this.lviInfo = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Request = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assignment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbManagerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbManagerInfo
            // 
            this.grbManagerInfo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.grbManagerInfo.Controls.Add(this.pictureBox2);
            this.grbManagerInfo.Controls.Add(this.pictureBox1);
            this.grbManagerInfo.Controls.Add(this.lblSearchC);
            this.grbManagerInfo.Controls.Add(this.txtSearchC);
            this.grbManagerInfo.Controls.Add(this.cobSearchC);
            this.grbManagerInfo.Controls.Add(this.btnSearchC);
            this.grbManagerInfo.Controls.Add(this.btnLoadC);
            this.grbManagerInfo.Controls.Add(this.txtGrade);
            this.grbManagerInfo.Controls.Add(this.lblGrade);
            this.grbManagerInfo.Controls.Add(this.lblSearchW);
            this.grbManagerInfo.Controls.Add(this.txtSearchW);
            this.grbManagerInfo.Controls.Add(this.cobSearchW);
            this.grbManagerInfo.Controls.Add(this.btnLoadA);
            this.grbManagerInfo.Controls.Add(this.cobStatus);
            this.grbManagerInfo.Controls.Add(this.lblCompleting);
            this.grbManagerInfo.Controls.Add(this.lblWaitingAssignment);
            this.grbManagerInfo.Controls.Add(this.lviCompleting);
            this.grbManagerInfo.Controls.Add(this.lblAssignment);
            this.grbManagerInfo.Controls.Add(this.txtAssignment);
            this.grbManagerInfo.Controls.Add(this.lblStatus);
            this.grbManagerInfo.Controls.Add(this.btnSearchW);
            this.grbManagerInfo.Controls.Add(this.lviInfo);
            this.grbManagerInfo.Controls.Add(this.btnDelete);
            this.grbManagerInfo.Controls.Add(this.btnAdd);
            this.grbManagerInfo.Controls.Add(this.btnModify);
            this.grbManagerInfo.Controls.Add(this.txtRequest);
            this.grbManagerInfo.Controls.Add(this.lblRequest);
            this.grbManagerInfo.Controls.Add(this.txtLastName);
            this.grbManagerInfo.Controls.Add(this.lblLastName);
            this.grbManagerInfo.Controls.Add(this.txtFirstName);
            this.grbManagerInfo.Controls.Add(this.lblFirstName);
            this.grbManagerInfo.Location = new System.Drawing.Point(12, 12);
            this.grbManagerInfo.Name = "grbManagerInfo";
            this.grbManagerInfo.Size = new System.Drawing.Size(1258, 529);
            this.grbManagerInfo.TabIndex = 0;
            this.grbManagerInfo.TabStop = false;
            this.grbManagerInfo.Text = "Manager Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ManagementSystem.Properties.Resources.complete;
            this.pictureBox2.Location = new System.Drawing.Point(633, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManagementSystem.Properties.Resources.wait;
            this.pictureBox1.Location = new System.Drawing.Point(31, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearchC
            // 
            this.lblSearchC.AutoSize = true;
            this.lblSearchC.Location = new System.Drawing.Point(979, 125);
            this.lblSearchC.Name = "lblSearchC";
            this.lblSearchC.Size = new System.Drawing.Size(145, 13);
            this.lblSearchC.TabIndex = 44;
            this.lblSearchC.Text = "Complete Assignment Search";
            // 
            // txtSearchC
            // 
            this.txtSearchC.Location = new System.Drawing.Point(982, 167);
            this.txtSearchC.Name = "txtSearchC";
            this.txtSearchC.Size = new System.Drawing.Size(86, 20);
            this.txtSearchC.TabIndex = 43;
            // 
            // cobSearchC
            // 
            this.cobSearchC.FormattingEnabled = true;
            this.cobSearchC.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Request",
            "Status",
            "Assignment",
            "Grade"});
            this.cobSearchC.Location = new System.Drawing.Point(982, 141);
            this.cobSearchC.Name = "cobSearchC";
            this.cobSearchC.Size = new System.Drawing.Size(104, 21);
            this.cobSearchC.TabIndex = 42;
            // 
            // btnSearchC
            // 
            this.btnSearchC.Location = new System.Drawing.Point(982, 196);
            this.btnSearchC.Name = "btnSearchC";
            this.btnSearchC.Size = new System.Drawing.Size(75, 23);
            this.btnSearchC.TabIndex = 41;
            this.btnSearchC.Text = "Search";
            this.btnSearchC.UseVisualStyleBackColor = true;
            this.btnSearchC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadC
            // 
            this.btnLoadC.Location = new System.Drawing.Point(766, 202);
            this.btnLoadC.Name = "btnLoadC";
            this.btnLoadC.Size = new System.Drawing.Size(169, 23);
            this.btnLoadC.TabIndex = 40;
            this.btnLoadC.Text = "Load All Complete Assignment";
            this.btnLoadC.UseVisualStyleBackColor = true;
            this.btnLoadC.Click += new System.EventHandler(this.btnLoadC_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(805, 67);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(86, 20);
            this.txtGrade.TabIndex = 39;
            this.txtGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrade_KeyPress);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(802, 34);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(73, 13);
            this.lblGrade.TabIndex = 38;
            this.lblGrade.Text = "Grade(0~100)";
            // 
            // lblSearchW
            // 
            this.lblSearchW.AutoSize = true;
            this.lblSearchW.Location = new System.Drawing.Point(388, 125);
            this.lblSearchW.Name = "lblSearchW";
            this.lblSearchW.Size = new System.Drawing.Size(137, 13);
            this.lblSearchW.TabIndex = 37;
            this.lblSearchW.Text = "Waiting Assignment Search";
            // 
            // txtSearchW
            // 
            this.txtSearchW.Location = new System.Drawing.Point(391, 167);
            this.txtSearchW.Name = "txtSearchW";
            this.txtSearchW.Size = new System.Drawing.Size(86, 20);
            this.txtSearchW.TabIndex = 36;
            // 
            // cobSearchW
            // 
            this.cobSearchW.FormattingEnabled = true;
            this.cobSearchW.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Request",
            "Status",
            "Assignment",
            "Grade"});
            this.cobSearchW.Location = new System.Drawing.Point(391, 141);
            this.cobSearchW.Name = "cobSearchW";
            this.cobSearchW.Size = new System.Drawing.Size(104, 21);
            this.cobSearchW.TabIndex = 35;
            // 
            // btnLoadA
            // 
            this.btnLoadA.Location = new System.Drawing.Point(150, 195);
            this.btnLoadA.Name = "btnLoadA";
            this.btnLoadA.Size = new System.Drawing.Size(163, 25);
            this.btnLoadA.TabIndex = 34;
            this.btnLoadA.Text = "Load All Waiting Assignment";
            this.btnLoadA.UseVisualStyleBackColor = true;
            this.btnLoadA.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cobStatus
            // 
            this.cobStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobStatus.FormattingEnabled = true;
            this.cobStatus.Items.AddRange(new object[] {
            "Waiting",
            "Completing"});
            this.cobStatus.Location = new System.Drawing.Point(444, 67);
            this.cobStatus.Name = "cobStatus";
            this.cobStatus.Size = new System.Drawing.Size(146, 21);
            this.cobStatus.TabIndex = 32;
            // 
            // lblCompleting
            // 
            this.lblCompleting.AutoSize = true;
            this.lblCompleting.Location = new System.Drawing.Point(630, 207);
            this.lblCompleting.Name = "lblCompleting";
            this.lblCompleting.Size = new System.Drawing.Size(108, 13);
            this.lblCompleting.TabIndex = 31;
            this.lblCompleting.Text = "Complete Assignment";
            // 
            // lblWaitingAssignment
            // 
            this.lblWaitingAssignment.AutoSize = true;
            this.lblWaitingAssignment.Location = new System.Drawing.Point(26, 207);
            this.lblWaitingAssignment.Name = "lblWaitingAssignment";
            this.lblWaitingAssignment.Size = new System.Drawing.Size(100, 13);
            this.lblWaitingAssignment.TabIndex = 30;
            this.lblWaitingAssignment.Text = "Waiting Assignment";
            // 
            // lviCompleting
            // 
            this.lviCompleting.BackColor = System.Drawing.Color.MediumPurple;
            this.lviCompleting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cFirstName,
            this.cLastName,
            this.cRequest,
            this.cStatus,
            this.cAssignment,
            this.cGrade});
            this.lviCompleting.GridLines = true;
            this.lviCompleting.Location = new System.Drawing.Point(633, 234);
            this.lviCompleting.Name = "lviCompleting";
            this.lviCompleting.Size = new System.Drawing.Size(601, 282);
            this.lviCompleting.TabIndex = 29;
            this.lviCompleting.UseCompatibleStateImageBehavior = false;
            this.lviCompleting.View = System.Windows.Forms.View.Details;
            // 
            // cFirstName
            // 
            this.cFirstName.Text = "First Name";
            this.cFirstName.Width = 99;
            // 
            // cLastName
            // 
            this.cLastName.Text = "Last Name";
            this.cLastName.Width = 102;
            // 
            // cRequest
            // 
            this.cRequest.Text = "Request";
            this.cRequest.Width = 118;
            // 
            // cStatus
            // 
            this.cStatus.Text = "Status";
            this.cStatus.Width = 80;
            // 
            // cAssignment
            // 
            this.cAssignment.Text = "Assignment";
            this.cAssignment.Width = 128;
            // 
            // cGrade
            // 
            this.cGrade.Text = "Grade";
            this.cGrade.Width = 65;
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Location = new System.Drawing.Point(660, 34);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(61, 13);
            this.lblAssignment.TabIndex = 28;
            this.lblAssignment.Text = "Assignment";
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(633, 67);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(141, 20);
            this.txtAssignment.TabIndex = 27;
            this.txtAssignment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAssignment_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(441, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(149, 13);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status (Waiting or Completing)";
            // 
            // btnSearchW
            // 
            this.btnSearchW.Location = new System.Drawing.Point(391, 196);
            this.btnSearchW.Name = "btnSearchW";
            this.btnSearchW.Size = new System.Drawing.Size(75, 23);
            this.btnSearchW.TabIndex = 24;
            this.btnSearchW.Text = "Search";
            this.btnSearchW.UseVisualStyleBackColor = true;
            this.btnSearchW.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lviInfo
            // 
            this.lviInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lviInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Request,
            this.status,
            this.Assignment,
            this.Grade});
            this.lviInfo.GridLines = true;
            this.lviInfo.Location = new System.Drawing.Point(25, 234);
            this.lviInfo.Name = "lviInfo";
            this.lviInfo.Size = new System.Drawing.Size(595, 282);
            this.lviInfo.TabIndex = 22;
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
            this.Request.Width = 118;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 80;
            // 
            // Assignment
            // 
            this.Assignment.Text = "Assignment";
            this.Assignment.Width = 128;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.Width = 62;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1094, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1013, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(932, 64);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(279, 67);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(141, 20);
            this.txtRequest.TabIndex = 17;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(328, 34);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(47, 13);
            this.lblRequest.TabIndex = 16;
            this.lblRequest.Text = "Request";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(152, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 15;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(171, 34);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(31, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 13;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(51, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 548);
            this.Controls.Add(this.grbManagerInfo);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.grbManagerInfo.ResumeLayout(false);
            this.grbManagerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbManagerInfo;
        private System.Windows.Forms.ListView lviInfo;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Request;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSearchW;
        private System.Windows.Forms.ColumnHeader Assignment;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.ListView lviCompleting;
        private System.Windows.Forms.ColumnHeader cFirstName;
        private System.Windows.Forms.ColumnHeader cLastName;
        private System.Windows.Forms.ColumnHeader cRequest;
        private System.Windows.Forms.ColumnHeader cStatus;
        private System.Windows.Forms.ColumnHeader cAssignment;
        private System.Windows.Forms.Label lblCompleting;
        private System.Windows.Forms.Label lblWaitingAssignment;
        private System.Windows.Forms.ComboBox cobStatus;
        private System.Windows.Forms.Button btnLoadA;
        private System.Windows.Forms.Label lblSearchW;
        private System.Windows.Forms.TextBox txtSearchW;
        private System.Windows.Forms.ComboBox cobSearchW;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ColumnHeader cGrade;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.Button btnLoadC;
        private System.Windows.Forms.Label lblSearchC;
        private System.Windows.Forms.TextBox txtSearchC;
        private System.Windows.Forms.ComboBox cobSearchC;
        private System.Windows.Forms.Button btnSearchC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}