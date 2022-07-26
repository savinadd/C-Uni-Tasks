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
namespace PE4
{
    public partial class Form1 : Form

    {
        private StreamWriter fil;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            string employeeName = txtBxFName.Text + ", " + txtBxLName.Text;
            string employeeNumber = txtBxEmployeeNumber.Text;

            double payRate, hours = 0;

            Double.TryParse(txtBxPayRate.Text, out payRate);
            Double.TryParse(txtBxHours.Text, out hours);
            double overtimeHours = hours - 40;
            double nonOvertimeHours = hours - overtimeHours;
            double totalpay = 0;
            if (overtimeHours > 0)
            {
                totalpay = (overtimeHours * payRate * 1.5) + (nonOvertimeHours * payRate);
            }
            else
            {
                totalpay = hours * payRate;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "employee";
            saveFileDialog.ShowDialog();



        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        /* ask traykov how tf to do the open dialog 
         * need to add save dialog file and title nd filter in order for this to work 
         * 
         * btn.Title will always only return the file name
         * need to use .Filter in order to specify 
         * the type of file necessary for the program to execute
         * 
         */

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                lblRetrieveText.Text = File.ReadAllText(file);
            }
        }
            

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

     
        


    

