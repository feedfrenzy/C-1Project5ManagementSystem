namespace ManagementSystem
{
    partial class frmManagementSystem
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
            this.pibManager = new System.Windows.Forms.PictureBox();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pibEmployee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pibManager
            // 
            this.pibManager.Image = global::ManagementSystem.Properties.Resources.employee;
            this.pibManager.Location = new System.Drawing.Point(48, 30);
            this.pibManager.Name = "pibManager";
            this.pibManager.Size = new System.Drawing.Size(143, 161);
            this.pibManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibManager.TabIndex = 0;
            this.pibManager.TabStop = false;
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(79, 206);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(75, 23);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(261, 206);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pibEmployee
            // 
            this.pibEmployee.Image = global::ManagementSystem.Properties.Resources.manager;
            this.pibEmployee.Location = new System.Drawing.Point(224, 30);
            this.pibEmployee.Name = "pibEmployee";
            this.pibEmployee.Size = new System.Drawing.Size(143, 161);
            this.pibEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibEmployee.TabIndex = 4;
            this.pibEmployee.TabStop = false;
            // 
            // frmManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(436, 280);
            this.Controls.Add(this.pibEmployee);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.pibManager);
            this.Name = "frmManagementSystem";
            this.Text = "Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pibManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibManager;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.PictureBox pibEmployee;
    }
}

