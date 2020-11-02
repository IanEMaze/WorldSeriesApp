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

namespace WorldSeriesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            //Resetting texboxes 
            teamNameBox.Text = "";
            hasTeamWonBox.Text = "";
            numWinsBox.Text = "";

            //Removing selecttion from team list
            teamListBox.ClearSelected();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            //Closes window
            this.Close();
        }

        private void getSummary_Click(object sender, EventArgs e)
        {
            //get summary method
            showSummaryInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets textboxes to readonly
            //reads team text file into listbox
            startProgram();
            readTeamFile();
        }

        private void startProgram() {
            //setting textboxes to read-only
            teamNameBox.ReadOnly = true;
            hasTeamWonBox.ReadOnly = true;
            numWinsBox.ReadOnly = true;
        }

        private void readTeamFile() {
            //Opening Teams text file to be read into teams array
            StreamReader inputFile;
            inputFile = File.OpenText("Teams.txt");

            //Creating teams array
            string[] teamsArray = new string[99];

            //Creating loop to read text file and place into array
            //Then place in team list box
            for (int index = 0; !inputFile.EndOfStream; index++) {
                teamsArray[index] = inputFile.ReadLine();
                teamListBox.Items.Add(teamsArray[index]);
            }
        }

        private void showSummaryInfo() {

            //creating count variable to count wins
            int winCount = 0;

            //Grabbing selected team from user input
            string teamSelect = "";
            teamSelect = teamListBox.GetItemText(teamListBox.SelectedItem);
            teamNameBox.Text = teamSelect;

            //Reading worldseries text file and comapring selected team
            //Showing if team has won world series and how many wins they have
            StreamReader inputFile;
            inputFile = File.OpenText("WorldSeries.txt");

            //Creating loop to read through text file and compare with selected item
            for (int i = 0; !inputFile.EndOfStream; i++) {

                //Creating temp variable to hold read line
                string temp = "";

                //reading into temp variable
                temp = inputFile.ReadLine();

                //Validating if selected team has won
                if (temp == teamSelect)
                {
                    //indicating team has won world series and incrementing win count
                    hasTeamWonBox.Text = "Yes";
                    winCount++;
                }
                else {
                    //team not found in loop
                    continue;
                }
                
                //Shows num of wins for selected team
                numWinsBox.Text = "" + winCount;

            }
        }
    }
}
