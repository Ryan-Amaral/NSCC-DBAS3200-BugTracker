using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataLayer = RyanAmaral_DBAS3200_BugTracker_DataLayer;

namespace RyanAmaral_DBAS3200_BugTracker
{
    public partial class FormBugTracker : Form
    {
        const string FORM_TITLE = "Bug Tracker";

        private int loggedInUser; // the id of the user

        public FormBugTracker()
        {
            InitializeComponent();
        }

        private void FormBugTracker_Load(object sender, EventArgs e)
        {
            // on load, disable all tabs except for Identify
            tabsBugTracker.TabPages.Remove(tabPageApplications);
            tabsBugTracker.TabPages.Remove(tabPageBugs);
            tabsBugTracker.TabPages.Remove(tabPageUsers);

            PopulateApplicationPage(); // fill in data for applications
            PopulateBugPage(); // fill in data for bugs
            PopulateUserPage(); // fill in data for users

            dataGridViewBugActivityLog.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Call this when user identifies self. Shows tabs that are appropriate for user.
        /// </summary>
        /// <param name="isAdmin"></param>
        private void UserSignOn(bool isAdmin)
        {
            // enable other tabs for anyone else

            tabsBugTracker.TabPages.Add(tabPageApplications);

            tabsBugTracker.TabPages.Add(tabPageBugs);

            // enable user tab if admin
            if (isAdmin)
            {
                tabsBugTracker.TabPages.Add(tabPageUsers);
            }
        }

        /// <summary>
        /// Fills the application page/tab with data
        /// </summary>
        private void PopulateApplicationPage()
        {
            // get all apps
            List<dataLayer.Application> apps = dataLayer.Applications.GetAllApplications();
            dataLayer.Application newApp = new dataLayer.Application();
            newApp.AppName = " < Add New > ";
            apps.Insert(0, newApp);

            listBox1Applications.DataSource = apps;
            listBox1Applications.DisplayMember = "AppName";
        }

        /// <summary>
        /// Fills the bug page/tab with data
        /// </summary>
        private void PopulateBugPage()
        {
            UpdateAppComboBox(); // fill the app bar

            // fill in the statuses
            // status just for select status
            dataLayer.StatusCode selStat = new dataLayer.StatusCode();
            selStat.StatusCodeDesc = "<Select Status>";
            dataLayer.StatusCode allStat = new dataLayer.StatusCode();
            allStat.StatusCodeDesc = "All Statuses";
            List<dataLayer.StatusCode> statuses = dataLayer.StatusCodes.GetAllStatusCodes();
            statuses.Insert(0, selStat);
            statuses.Insert(1, allStat);
            comboBox2StatusFilter.DataSource = statuses;
            comboBox2StatusFilter.DisplayMember = "StatusCodeDesc";

            // fill in the options for user to choose status
            List<dataLayer.StatusCode> statuses2 = dataLayer.StatusCodes.GetAllStatusCodes();
            comboBox2Status.DataSource = statuses2;
            comboBox2Status.DisplayMember = "StatusCodeDesc";
        }

        public void UpdateAppComboBox()
        {
            // get all apps
            List<dataLayer.Application> apps = dataLayer.Applications.GetAllApplications();
            dataLayer.Application newApp = new dataLayer.Application();
            newApp.AppName = "<Select Application>";
            apps.Insert(0, newApp);

            comboBox2SelectApplication.DataSource = apps;
            comboBox2SelectApplication.DisplayMember = "AppName";
        }

        /// <summary>
        /// Updates the list of bugs on the bug page when index of either combo box changes.
        /// </summary>
        public void UpdateBugList()
        {
            List<dataLayer.Bug> bugs;

            if (comboBox2SelectApplication.SelectedIndex != 0 
                && comboBox2StatusFilter.SelectedIndex != 0)
            {
                // show the bugs
                int appId = ((dataLayer.Application)comboBox2SelectApplication.SelectedItem).AppID;

                // show all status or just one
                if (comboBox2StatusFilter.SelectedIndex == 1)
                {
                    bugs = dataLayer.Bugs.GetAllBugsFromApp(appId);
                }
                else
                {
                    int statusId = ((dataLayer.StatusCode)comboBox2StatusFilter.SelectedItem).StatusCodeId;
                    bugs = dataLayer.Bugs.GetAllBugsFromAppWithStatCode(appId, statusId);
                }

                // insert the add new bug
                dataLayer.Bug newBug = new dataLayer.Bug();
                newBug.BugDesc = "<Add New>";
                bugs.Insert(0, newBug);

                listBox2BugList.DataSource = bugs;
                listBox2BugList.DisplayMember = "BugDesc";
            }
            // take out bug entries
            else if(comboBox2SelectApplication.SelectedIndex != 0)
            {
                // call method to clear bug page
                ClearBugPage();
                bugs = new List<dataLayer.Bug>();

                // insert the add new bug
                dataLayer.Bug newBug = new dataLayer.Bug();
                newBug.BugDesc = "<Add New>";
                bugs.Insert(0, newBug);

                listBox2BugList.DataSource = bugs;
                listBox2BugList.DisplayMember = "BugDesc";
            }
            else
            {
                listBox2BugList.DataSource = null;
            }
        }

        public void ClearBugPage()
        {
            //listBox2BugList.DataSource = null;
            labelVal2BugId.Text = "";
            labelVal2SubmitDate.Text = "";
            textBox2Description.Text = "";
            textBox2Details.Text = "";
            textBox2RepSteps.Text = "";
            labelVal2FixDate.Text = "";
            dataGridViewBugActivityLog.DataSource = null;
            textBox2UpdateComments.Text = null;
            textBox2UpdateComments.Enabled = false;
            comboBox2Status.Enabled = false;
            comboBox2Status.SelectedIndex = 0;
        }

        /// <summary>
        /// Fills the user page/tab with data
        /// </summary>
        private void PopulateUserPage()
        {
            // clear
            labelVal3UserId.Text = "";
            textBox3UserName.Text = "";
            textBox3Email.Text = "";
            textBox3PhoneNum.Text = "";

            // put users in box
            List<dataLayer.User> users = dataLayer.Users.GetAllUsers();
            dataLayer.User newUser = new dataLayer.User();
            newUser.UserName = "< Add New >";
            users.Insert(0, newUser);
            listBox3Users.DataSource = users;
            listBox3Users.DisplayMember = "UserName";
        }

        /// <summary>
        /// Click this button to sign the user in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0Go_Click(object sender, EventArgs e)
        {
            // make sure all tabs are removed
            if (tabsBugTracker.TabPages.Contains(tabPageApplications))
            {
                tabsBugTracker.TabPages.Remove(tabPageApplications);
            }
            if (tabsBugTracker.TabPages.Contains(tabPageBugs))
            {
                tabsBugTracker.TabPages.Remove(tabPageBugs);
            }
            if (tabsBugTracker.TabPages.Contains(tabPageUsers))
            {
                tabsBugTracker.TabPages.Remove(tabPageUsers);
            }

            string inputName = textBox0UserName.Text;
            bool isAdmin = (inputName.Equals("admin")); // flag for admin

            // look for user in database
            dataLayer.User user = dataLayer.Users.GetUserByUserName(inputName);

            // if user is in database, sign in
            if (user != null)
            {
                this.Text = FORM_TITLE + " - " + inputName;
                UserSignOn(isAdmin); // sign on user
                tabsBugTracker.SelectTab(1); // move focus to next tab
                loggedInUser = user.UserId;
            }
            // else show pop up
            else
            {
                MessageBox.Show(this, "The user '" + inputName + "' was not found in the system.", "User Not Found");
            }
        }

        /// <summary>
        /// Update the data that is shown in the other controls on the tab page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1Applications_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if first item, make new
            if (listBox1Applications.SelectedIndex == 0)
            {
                labelVal1ApplicationId.Text = "";
                textBox1ApplicationName.Text = "";
                textBox1CurrentVersion.Text = "";
                textBox1Description.Text = "";
            }
            // else show existing data
            else
            {
                labelVal1ApplicationId.Text = ((dataLayer.Application)listBox1Applications.SelectedItem).AppID.ToString();
                textBox1ApplicationName.Text = ((dataLayer.Application)listBox1Applications.SelectedItem).AppName;
                textBox1CurrentVersion.Text = ((dataLayer.Application)listBox1Applications.SelectedItem).AppVersion;
                textBox1Description.Text = ((dataLayer.Application)listBox1Applications.SelectedItem).AppDesc;
            }
            
        }

        /// <summary>
        /// Updates or inserts an Application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Save_Click(object sender, EventArgs e)
        {
            // all boxes must be filled in
            if (!textBox1ApplicationName.Text.Equals("")
                && !textBox1CurrentVersion.Text.Equals("")
                && !textBox1Description.Text.Equals(""))
            {
                dataLayer.Application curApp = (dataLayer.Application)listBox1Applications.SelectedItem;
                curApp.AppName = textBox1ApplicationName.Text;
                curApp.AppVersion = textBox1CurrentVersion.Text;
                curApp.AppDesc = textBox1Description.Text;

                curApp.Save();

                PopulateApplicationPage(); // update the list
                UpdateAppComboBox(); // udpate combo box on bug page

                MessageBox.Show(this, "App saved.", "Success");
            }
            // else pop up
            else
            {
                MessageBox.Show(this, "No field Can be left blank.", "Form Error");
            }
        }

        /// <summary>
        /// Deletes an app from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Delete_Click(object sender, EventArgs e)
        {
            if (listBox1Applications.SelectedIndex > 0)
            {
                dataLayer.Application app = (dataLayer.Application)listBox1Applications.SelectedItem;
                
                if (app.Delete())
                {
                    MessageBox.Show(this, "App Deleted.", "Success");
                    PopulateApplicationPage();
                    // clear controls
                    labelVal1ApplicationId.Text = "";
                    textBox1ApplicationName.Text = "";
                    textBox1CurrentVersion.Text = "";
                    textBox1Description.Text = "";
                    UpdateBugList(); // update bug list to not show this app
                }
                else
                {
                    MessageBox.Show(this, "Cannot delete app, bug data exists.", "Error");
                }
            }
        }

        private void comboBox2StatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBugList();
        }

        private void comboBox2SelectApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBugList();
        }

        private void listBox2BugList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2BugList.SelectedIndex != 0 && (dataLayer.Bug)listBox2BugList.SelectedItem != null) {
                dataLayer.Bug bug = (dataLayer.Bug)listBox2BugList.SelectedItem; // get the bug
                // Fill the display
                labelVal2BugId.Text = bug.BugId.ToString();
                labelVal2SubmitDate.Text = bug.BugDate.ToString();
                textBox2Description.Text = bug.BugDesc;
                textBox2Details.Text = bug.BugDetails;
                textBox2RepSteps.Text = bug.RepSteps;
                comboBox2Status.SelectedIndex = bug.CurStatus.StatusCodeId - 1;

                // get newest bug log data to get status
                comboBox2Status.Enabled = true;

                // show fix date if not null
                if (bug.FixDate != null)
                {
                    labelVal2FixDate.Text = bug.FixDate.ToString();
                }
                else
                {
                    labelVal2FixDate.Text = "";
                }

                // fill activity log with all logs of this bug
                FillBugActivityLog(bug.BugId);

                textBox2UpdateComments.Enabled = true;
                textBox2UpdateComments.Text = "";
            }
            else
            {
                ClearBugPage();
                labelVal2BugId.Text = "New";
            }
        }

        /// <summary>
        /// Fills the bug activity log with the logs of the current bug.
        /// </summary>
        void FillBugActivityLog(int bugId)
        {
            // get all logs for this bug
            List<dataLayer.BugLog> bugLogs = dataLayer.BugLogs.GetBugLogsByBugId(bugId);
            dataGridViewBugActivityLog.DataSource = bugLogs;
            DataGridView2ColumnDate.DataPropertyName = "BugLogDate";
            DataGridView2ColumnStatus.DataPropertyName = "StatusCodeName";
            DataGridView2ColumnUpdatedBy.DataPropertyName = "UserName";
            DataGridView2ColumnComments.DataPropertyName = "BugLogDesc";
        }

        /// <summary>
        /// Updates and existing bug or makes a new one. If bug is existing, update bug log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2Save_Click(object sender, EventArgs e)
        {
            dataLayer.Bug bug;
            // check if new bug
            if (listBox2BugList.SelectedIndex == 0)
            {
                // check if values are filled in
                if (textBox2Description.Text != "" &&
                    textBox2Details.Text != "" &&
                    textBox2RepSteps.Text != "")
                {
                    bug = new dataLayer.Bug();
                    bug.AppId = ((dataLayer.Application)comboBox2SelectApplication.SelectedItem).AppID;
                    bug.UserId = loggedInUser;
                    bug.BugSignOff = null;
                    bug.BugDate = DateTime.Now;
                    bug.BugDesc = textBox2Description.Text;
                    bug.BugDetails = textBox2Details.Text;
                    bug.RepSteps = textBox2RepSteps.Text;
                    bug.FixDate = null;

                    bug.Save(); // save the bug to db

                    // add new bug logalogalogalogalogalogalogalogalogalogalogalogalogalogalogalogalogalog
                    dataLayer.BugLog log = new dataLayer.BugLog();
                    log.BugLogDate = DateTime.Now;
                    log.StatusCodeId = ((dataLayer.StatusCode)comboBox2Status.SelectedItem).StatusCodeId;
                    log.UserId = loggedInUser;
                    log.BugLogDesc = textBox2UpdateComments.Text;
                    log.BugId = bug.BugId;

                    log.Save(); // save the log to db

                    FillBugActivityLog(bug.BugId);
                    MessageBox.Show(this, "Bug saved.", "Success");
                }
                else
                {
                    MessageBox.Show(this, "No field Can be left blank.", "Form Error");
                }
            }
            // old bug
            else
            {
                // check if values are filled in
                if (textBox2Description.Text != "" &&
                    textBox2Details.Text != "" &&
                    textBox2RepSteps.Text != "" &&
                    textBox2UpdateComments.Text != "")
                {
                    bug = (dataLayer.Bug)listBox2BugList.SelectedItem;
                    // apply sign off if status set to closed
                    if (((dataLayer.StatusCode)comboBox2Status.SelectedItem).StatusCodeId == (int)dataLayer.StatusCode.Codes.Closed &&
                        bug.BugSignOff == null)
                    {
                        bug.BugSignOff = loggedInUser;
                        bug.FixDate = DateTime.Now;
                        labelVal2FixDate.Text = bug.FixDate.ToString();
                    }
                    bug.BugDesc = textBox2Description.Text;
                    bug.BugDetails = textBox2Details.Text;
                    bug.RepSteps = textBox2RepSteps.Text;

                    bug.Save(); // save the bug to db

                    // add new bug logalogalogalogalogalogalogalogalogalogalogalogalogalogalogalogalogalog
                    dataLayer.BugLog log = new dataLayer.BugLog();
                    log.BugLogDate = DateTime.Now;
                    log.StatusCodeId = ((dataLayer.StatusCode)comboBox2Status.SelectedItem).StatusCodeId;
                    log.UserId = loggedInUser;
                    log.BugLogDesc = textBox2UpdateComments.Text;
                    log.BugId = ((dataLayer.Bug)listBox2BugList.SelectedItem).BugId;

                    log.Save(); // save the log to db

                    FillBugActivityLog(bug.BugId);
                    textBox2UpdateComments.Text = "";
                    MessageBox.Show(this, "Bug saved.", "Success");
                }
                else
                {
                    MessageBox.Show(this, "No field Can be left blank.", "Form Error");
                }
            }

            UpdateBugList();
        }

        private void listBox3Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show user info
            if (listBox3Users.SelectedIndex != 0)
            {
                dataLayer.User user = ((dataLayer.User)listBox3Users.SelectedItem);

                labelVal3UserId.Text = user.UserId.ToString();
                textBox3UserName.Text = user.UserName;
                textBox3Email.Text = user.UserEmail;
                textBox3PhoneNum.Text = user.UserTel;
            }
            //blank
            else
            {
                labelVal3UserId.Text = "";
                textBox3UserName.Text = "";
                textBox3Email.Text = "";
                textBox3PhoneNum.Text = "";
            }
        }

        private void button3Save_Click(object sender, EventArgs e)
        {
            // save or update user
            dataLayer.User user;

            // new user
            if (listBox3Users.SelectedIndex == 0)
            {
                user = new dataLayer.User();
            }
            // old user
            else
            {
                user = (dataLayer.User)listBox3Users.SelectedItem;
            }

            if (textBox3UserName.Text != "" &&
                    textBox3Email.Text != "" &&
                    textBox3PhoneNum.Text != "")
            {
                user.UserName = textBox3UserName.Text;
                user.UserEmail = textBox3Email.Text;
                user.UserTel = textBox3PhoneNum.Text;
                user.Save();
                PopulateUserPage();
                MessageBox.Show(this, "User saved.", "Success");
            }
            else
            {
                MessageBox.Show(this, "No field Can be left blank.", "Form Error");
            }
        }

        /// <summary>
        /// Delete a bug from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2DeleteBug_Click(object sender, EventArgs e)
        {
            if (listBox2BugList.SelectedIndex >= 1)
            {
                ((dataLayer.Bug)listBox2BugList.SelectedItem).Delete();
                ClearBugPage();
                UpdateBugList();
                MessageBox.Show(this, "Bug Deleted.", "Success");
            }
        }

        private void button3Delete_Click(object sender, EventArgs e)
        {
            if (listBox3Users.SelectedIndex > 0)
            {
                dataLayer.User user = (dataLayer.User)listBox3Users.SelectedItem;
                // no delete admin
                if (user.UserId == 1)
                {
                    MessageBox.Show(this, "Cannot delete admin.", "Error");
                }
                else
                {
                    if (user.Delete())
                    {
                        MessageBox.Show(this, "User Deleted.", "Success");
                        PopulateUserPage();
                    }
                    else
                    {
                        MessageBox.Show(this, "Cannot delete user.", "Error");
                    }
                }
            }
        }
    }
}
