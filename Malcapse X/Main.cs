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
using System.Threading;
using WeAreDevs_API;

namespace Malcapse_X {
    public partial class Main : Form {
        Point lastPoint;
        ExploitAPI api = new ExploitAPI();
        Thread t;

        public Main() {
            InitializeComponent();
        }

        private void FillScriptBox(object sender, EventArgs e) {
            scriptSelect.Items.Clear();
            FillScriptBoxUtill(scriptSelect, "*.lua");
            FillScriptBoxUtill(scriptSelect, "*.txt");
        }

        void FillScriptBoxUtill(ListBox scriptBox, string fileType) {
            DirectoryInfo dirInfo = new DirectoryInfo("./scripts");
            FileInfo[] files = dirInfo.GetFiles(fileType);

            foreach (FileInfo file in files) {
                scriptBox.Items.Add(file.Name);
            }
        }

        private void DragDown(object sender, MouseEventArgs e) {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DragMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e) {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnMin_MouseClick(object sender, MouseEventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExecute_MouseClick(object sender, MouseEventArgs e) {
            api.SendLuaScript(codeBox.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e) {
            codeBox.Clear();
        }

        private void btnOpenFile_MouseClick(object sender, MouseEventArgs e) {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";

            if (file.ShowDialog() == DialogResult.OK) {
                file.Title = "Open";
                codeBox.Text = File.ReadAllText(file.FileName);
            }
        }

        private void btnSaveFile_MouseClick(object sender, MouseEventArgs e) {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";

            if (file.ShowDialog() == DialogResult.OK) {
                file.Title = "Open";
                File.WriteAllText(file.FileName, codeBox.Text);
            }
        }

        private void btnAttach_MouseClick(object sender, MouseEventArgs e) {
            api.LaunchExploit();
        }

        private void btnScriptHub_MouseClick(object sender, MouseEventArgs e) {
            // fill out later
        }

        private void scriptSelect_SelectedIndexChanged(object sender, EventArgs e) {
            codeBox.Text = File.ReadAllText($"./scripts/{scriptSelect.SelectedItem}");
        }
    }
}
