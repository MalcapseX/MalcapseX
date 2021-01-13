namespace Malcapse_X {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.TopBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.scriptSelect = new System.Windows.Forms.ListBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnScriptHub = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TopBar.Controls.Add(this.btnMin);
            this.TopBar.Controls.Add(this.btnExit);
            this.TopBar.Controls.Add(this.mainLabel);
            this.TopBar.Controls.Add(this.logoBox);
            this.TopBar.Location = new System.Drawing.Point(0, 1);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(552, 39);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(480, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(27, 27);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMin_MouseClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(513, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseClick);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainLabel.Location = new System.Drawing.Point(208, 8);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(126, 26);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Malcapse X";
            this.mainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragDown);
            this.mainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBox.BackgroundImage")));
            this.logoBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logoBox.ErrorImage")));
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoBox.InitialImage")));
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(39, 36);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.logoBox.WaitOnLoad = true;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // codeBox
            // 
            this.codeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.codeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBox.ForeColor = System.Drawing.SystemColors.Window;
            this.codeBox.Location = new System.Drawing.Point(12, 46);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(407, 160);
            this.codeBox.TabIndex = 1;
            this.codeBox.Text = "";
            this.codeBox.WordWrap = false;
            // 
            // scriptSelect
            // 
            this.scriptSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.scriptSelect.ForeColor = System.Drawing.SystemColors.Window;
            this.scriptSelect.FormattingEnabled = true;
            this.scriptSelect.Location = new System.Drawing.Point(425, 46);
            this.scriptSelect.Name = "scriptSelect";
            this.scriptSelect.Size = new System.Drawing.Size(114, 160);
            this.scriptSelect.TabIndex = 2;
            this.scriptSelect.SelectedIndexChanged += new System.EventHandler(this.scriptSelect_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(11, 212);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(66, 21);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExecute_MouseClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(83, 212);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(66, 21);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(155, 212);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(66, 21);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOpenFile_MouseClick);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Location = new System.Drawing.Point(227, 212);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(66, 21);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSaveFile_MouseClick);
            // 
            // btnScriptHub
            // 
            this.btnScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnScriptHub.ForeColor = System.Drawing.Color.White;
            this.btnScriptHub.Location = new System.Drawing.Point(299, 212);
            this.btnScriptHub.Name = "btnScriptHub";
            this.btnScriptHub.Size = new System.Drawing.Size(66, 21);
            this.btnScriptHub.TabIndex = 7;
            this.btnScriptHub.Text = "Script Hub";
            this.btnScriptHub.UseVisualStyleBackColor = false;
            this.btnScriptHub.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnScriptHub_MouseClick);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(401, 212);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(66, 21);
            this.btnAttach.TabIndex = 8;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAttach_MouseClick);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(473, 212);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(66, 21);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FillScriptBox);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(552, 239);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnScriptHub);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.scriptSelect);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.TopBar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Malcapse X";
            this.Load += new System.EventHandler(this.FillScriptBox);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel TopBar;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnScriptHub;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox scriptSelect;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReload;
    }
}

