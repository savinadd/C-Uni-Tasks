
namespace PE4
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtBxHours = new System.Windows.Forms.TextBox();
            this.txtBxPayRate = new System.Windows.Forms.TextBox();
            this.txtBxEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtBxLName = new System.Windows.Forms.TextBox();
            this.txtBxFName = new System.Windows.Forms.TextBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRetrieveText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(26, 51);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(27, 87);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(143, 20);
            this.lblEmployeeNumber.TabIndex = 2;
            this.lblEmployeeNumber.Text = "Employee Number:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(27, 126);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(78, 20);
            this.lblPayRate.TabIndex = 3;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(27, 164);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(56, 20);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours:";
            // 
            // txtBxHours
            // 
            this.txtBxHours.Location = new System.Drawing.Point(89, 164);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(100, 20);
            this.txtBxHours.TabIndex = 5;
            // 
            // txtBxPayRate
            // 
            this.txtBxPayRate.Location = new System.Drawing.Point(111, 126);
            this.txtBxPayRate.Name = "txtBxPayRate";
            this.txtBxPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtBxPayRate.TabIndex = 6;
            // 
            // txtBxEmployeeNumber
            // 
            this.txtBxEmployeeNumber.Location = new System.Drawing.Point(176, 89);
            this.txtBxEmployeeNumber.Name = "txtBxEmployeeNumber";
            this.txtBxEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmployeeNumber.TabIndex = 7;
            // 
            // txtBxLName
            // 
            this.txtBxLName.Location = new System.Drawing.Point(117, 53);
            this.txtBxLName.Name = "txtBxLName";
            this.txtBxLName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLName.TabIndex = 8;
            // 
            // txtBxFName
            // 
            this.txtBxFName.Location = new System.Drawing.Point(117, 20);
            this.txtBxFName.Name = "txtBxFName";
            this.txtBxFName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFName.TabIndex = 9;
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Location = new System.Drawing.Point(30, 220);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(140, 34);
            this.btnStore.TabIndex = 10;
            this.btnStore.Text = "Store Record";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "employee";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.Location = new System.Drawing.Point(31, 260);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(101, 34);
            this.btnRetrieve.TabIndex = 11;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblRetrieveText
            // 
            this.lblRetrieveText.AutoSize = true;
            this.lblRetrieveText.Location = new System.Drawing.Point(317, 131);
            this.lblRetrieveText.Name = "lblRetrieveText";
            this.lblRetrieveText.Size = new System.Drawing.Size(0, 13);
            this.lblRetrieveText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.lblRetrieveText);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.txtBxFName);
            this.Controls.Add(this.txtBxLName);
            this.Controls.Add(this.txtBxEmployeeNumber);
            this.Controls.Add(this.txtBxPayRate);
            this.Controls.Add(this.txtBxHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Employee Pay App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtBxHours;
        private System.Windows.Forms.TextBox txtBxPayRate;
        private System.Windows.Forms.TextBox txtBxEmployeeNumber;
        private System.Windows.Forms.TextBox txtBxLName;
        private System.Windows.Forms.TextBox txtBxFName;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRetrieveText;
    }
}

