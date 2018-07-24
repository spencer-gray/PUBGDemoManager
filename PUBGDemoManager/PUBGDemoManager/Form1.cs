using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUBGDemoManager.Properties;


namespace PUBGDemoManager
{
    public partial class Form1 : Form
    {
        private static string ReplaysFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TslGame\\Saved\\Demos\\";
        private static string BackupsFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\PUBGDemoManager_Backups\\";
        int ReplaysDirectoryCount = Directory.GetDirectories(ReplaysFolder).Length;
        int BackupsDirectoryCount = Directory.GetDirectories(BackupsFolder).Length;


        public Form1()
        {
            InitializeComponent();

            // Create files if they do not exist
            Directory.CreateDirectory(BackupsFolder);

            // Check for the existence of the ReplaysFolder EDIT
            if (!Directory.Exists(ReplaysFolder))
            {
                // If ReplaysFolder does not exist, have the user search for a new one, or close
                if (MessageBox.Show(
                        @"PUBG replays folder does not exist in default location, would you like to manually find the folder?",
                        @"Replay Folder missing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FolderBrowserDialog replayBrowser = new FolderBrowserDialog();
                    if (replayBrowser.ShowDialog() == DialogResult.OK)
                    {
                        ReplaysFolder = replayBrowser.SelectedPath;
                    }
                    else Close();
                }
                else Close();
            }

            LoadReplays();
            DirectoryCount();

        }

        private void LoadReplays()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            Replay[] replay2DIR = new Replay[ReplaysFolder.Length];
            Replay[] backup2DIR = new Replay[BackupsFolder.Length];

            int i = 0;
            foreach (var replay in Directory.GetDirectories(ReplaysFolder))
            {
                //Check for the replay info file to make sure this is a real replay folder
                if (Directory.Exists(replay))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    replay2DIR[i] = new Replay(replay); //

                    row.CreateCells(dataGridView1);
                    row.Cells[1].Value = replay2DIR[i].dir;
                    row.Cells[2].Value = replay2DIR[i].timestamp;
                    row.Cells[3].Value = replay2DIR[i].lengthMIN.ToString() + " Min.";
                    row.Cells[4].Value = replay2DIR[i].map;
                    row.Cells[5].Value = replay2DIR[i].mode;

                    dataGridView1.Rows.Add(row);
                }

                i++;
            }
            i = 0;

            // Enumerate Backups
            foreach (var replay in Directory.GetDirectories(BackupsFolder))
            {
                //Check for the replay info file to make sure this is a real replay folder
                if (Directory.Exists(replay))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    backup2DIR[i] = new Replay(replay);

                    row.CreateCells(dataGridView2);
                    row.Cells[1].Value = backup2DIR[i].dir;
                    row.Cells[2].Value = backup2DIR[i].timestamp;
                    row.Cells[3].Value = backup2DIR[i].lengthMIN.ToString() + " Min.";
                    row.Cells[4].Value = backup2DIR[i].map;
                    row.Cells[5].Value = backup2DIR[i].mode;

                    dataGridView2.Rows.Add(row);
                }

                i++;
            }
        }

        private void DirectoryCount()
        {
            ReplaysDirectoryCount = Directory.GetDirectories(ReplaysFolder).Length;
            BackupsDirectoryCount = Directory.GetDirectories(BackupsFolder).Length;

            labelReplays.Text = @"Replays: " + ReplaysDirectoryCount.ToString() + "/20";
            labelBackups.Text = @"Backups: " + BackupsDirectoryCount.ToString();
        }


        //private void LoadTable(int)

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadReplays();
            DirectoryCount();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            //int count = Directory.GetFiles(BackupsFolder, "*", SearchOption.TopDirectoryOnly).Length;
            string name;
            string source;
            string dest;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                name = r.Cells["ColumnDIR"].Value.ToString();

                source = ReplaysFolder + name;
                dest = BackupsFolder + name;

                if (Convert.ToBoolean(r.Cells["ColumnSelected"].Value))
                {

                    if (Directory.Exists(dest))
                    {
                        MessageBox.Show(dest + @" File has already been backed up", @"Directory Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(source, "*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(source, dest));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(source, "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(source, dest), true);
                }

            }
            LoadReplays();
            DirectoryCount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDlt_Click(object sender, EventArgs e)
        {
            string name;
            string source;
            string dest;

            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                name = r.Cells["ColumnDIR2"].Value.ToString();

                source = ReplaysFolder + name;
                dest = BackupsFolder + name;

                if (Convert.ToBoolean(r.Cells["ColumnSelected2"].Value))
                {
                    
                    Directory.Delete(dest, true);
                }

            }

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                name = r.Cells["ColumnDIR"].Value.ToString();

                source = ReplaysFolder + name;
                dest = BackupsFolder + name;   

                if (Convert.ToBoolean(r.Cells["ColumnSelected"].Value))
                {

                    Directory.Delete(source, true);
                }

            }
            LoadReplays();
            DirectoryCount();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (ReplaysDirectoryCount >= 20)
            {
                MessageBox.Show(@" PUBG demo folder contains the maximum 20 replays. Allocate space.", @"PUBG Directory Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name;
                string source;
                string dest;

                foreach (DataGridViewRow r in dataGridView2.Rows)
                {
                    name = r.Cells["ColumnDIR2"].Value.ToString();

                    dest = ReplaysFolder + name;
                    source = BackupsFolder + name;

                    if (Convert.ToBoolean(r.Cells["ColumnSelected2"].Value))
                    {

                        if (Directory.Exists(dest))
                        {
                            MessageBox.Show(dest + @" Directory has already been loaded and is ready to be watched.", @"Directory Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //Create all of the directories
                        foreach (string dirPath in Directory.GetDirectories(source, "*",
                            SearchOption.AllDirectories))
                            Directory.CreateDirectory(dirPath.Replace(source, dest));

                        //Copy all the files & Replaces any files with the same name
                        foreach (string newPath in Directory.GetFiles(source, "*.*",
                            SearchOption.AllDirectories))
                            File.Copy(newPath, newPath.Replace(source, dest), true);
                    }

                }
                LoadReplays();
                DirectoryCount();
            }
        }
    }
    
}
