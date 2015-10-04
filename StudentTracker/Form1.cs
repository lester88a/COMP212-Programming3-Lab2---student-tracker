using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class MainForm : Form
    {
        //define my dictionary object
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (studentIDTextBox.Text == "" && studentNameTextBox.Text =="")
            {
                displayTextBox.Text = "Please enter student ID and Name!";
                MessageBox.Show("Please enter student ID and Name!");
            }
            else if (studentIDTextBox.Text == "")
            {
                displayTextBox.Text = "Please enter student ID!";
                MessageBox.Show("Please enter student ID!");
            }
            else if (studentNameTextBox.Text == "")
            {
                displayTextBox.Text = "Please enter student name!";
                MessageBox.Show("Please enter student name!");
            }
            else if (studentIDTextBox.Text != "" && studentNameTextBox.Text !="")
            {
                try
                {
                    myDictionary.Add(Convert.ToInt32(studentIDTextBox.Text), studentNameTextBox.Text);
                    MessageBox.Show("Added Successfully.");
                    studentIDTextBox.Clear();
                    studentNameTextBox.Clear();
                    //showing the added records
                    foreach (KeyValuePair<int, string> pair in myDictionary)
                    {
                        displayTextBox.Clear();
                        displayTextBox.AppendText("Student ID: " + pair.Key + " ," + "Student Name: " + pair.Value + "\n");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Must input numbers for student ID\n"+Convert.ToString(ee));
                }
            }
        }

        //display all the stored recoards
        private void displayAllButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            foreach (KeyValuePair<int,string> pair in myDictionary)
            {
                displayTextBox.AppendText("Student ID: " + pair.Key + " ," + "Student Name: " + pair.Value + "\n");
            }
        }

        //delete a student record
        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            if (myDictionary.Count > 0)
            {
                if (studentIDTextBox.Text != "")
                {
                    try
                    {
                        foreach (KeyValuePair<int, string> pair in myDictionary)
                    {

                        if (pair.Key == Convert.ToInt32(studentIDTextBox.Text))
                        {
                            myDictionary.Remove(pair.Key);
                        }
                    }
                    }
                    catch (Exception)
                    {
                        
                        MessageBox.Show("Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Student ID cannot empty!");
                }
            }
            else
            {
                MessageBox.Show("No records have been added!");
                displayTextBox.Text = "No records have been added!";
            }
        }

        //delete all the records
        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();

            if (myDictionary.Count > 0)
            {
                myDictionary.Clear();
                MessageBox.Show("Deleted Successfully!");
                displayTextBox.Text = "Deleted Successfully!";
            }
            else
            {
                MessageBox.Show("No records have been added!");
                displayTextBox.Text = "No records have been added!";
            }
        }

        //clear the display screen
        private void clearButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            MessageBox.Show("The display screen cleared!");
        }

        //search a student by ID
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //clear the display screen first
            displayTextBox.Clear();

            //make sure the records have been added
            if (myDictionary.Count > 0)
            {
                //make sure the student id is inputed
                if (studentIDTextBox.Text != "")
                {
                    try
                    {
                        foreach (KeyValuePair<int, string> pair in myDictionary)
                        {
                            //if the id matched the record then show the results 
                            if (pair.Key == Convert.ToInt32(studentIDTextBox.Text))
                            {
                                displayTextBox.AppendText("Student ID: "+pair.Key + " ," + "Student Name: "+pair.Value + "\n");
                            }
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Student ID cannot empty!");
                }
            }
            else
            {
                MessageBox.Show("No records have been added!");
                displayTextBox.Text = "No records have been added!";
            }
        }

        //exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
