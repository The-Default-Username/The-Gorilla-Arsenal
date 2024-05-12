
namespace The_Gorilla_Arsenal
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Arsenal = new System.Windows.Forms.TabPage();
            this.pluginwarning = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.refresh = new System.Windows.Forms.Button();
            this.Management = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.browseFiles = new System.Windows.Forms.Button();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.installwarning = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Arsenal.SuspendLayout();
            this.Management.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Arsenal);
            this.tabControl1.Controls.Add(this.Management);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(749, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // Arsenal
            // 
            this.Arsenal.Controls.Add(this.installwarning);
            this.Arsenal.Controls.Add(this.pluginwarning);
            this.Arsenal.Controls.Add(this.checkedListBox1);
            this.Arsenal.Controls.Add(this.refresh);
            this.Arsenal.Font = new System.Drawing.Font("Segoe UI Variable Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arsenal.Location = new System.Drawing.Point(4, 25);
            this.Arsenal.Name = "Arsenal";
            this.Arsenal.Padding = new System.Windows.Forms.Padding(3);
            this.Arsenal.Size = new System.Drawing.Size(741, 449);
            this.Arsenal.TabIndex = 0;
            this.Arsenal.Text = "Arsenal";
            this.Arsenal.UseVisualStyleBackColor = true;
            // 
            // pluginwarning
            // 
            this.pluginwarning.AutoSize = true;
            this.pluginwarning.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluginwarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pluginwarning.Location = new System.Drawing.Point(189, 185);
            this.pluginwarning.Name = "pluginwarning";
            this.pluginwarning.Size = new System.Drawing.Size(355, 21);
            this.pluginwarning.TabIndex = 4;
            this.pluginwarning.Text = "Please install bepinEx before you manage plugins.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "BepinEx"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(735, 384);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.Control;
            this.refresh.Font = new System.Drawing.Font("Segoe UI Variable Display", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refresh.Location = new System.Drawing.Point(645, 410);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(90, 27);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Management
            // 
            this.Management.Controls.Add(this.label1);
            this.Management.Controls.Add(this.browseFiles);
            this.Management.Controls.Add(this.fileLocation);
            this.Management.Location = new System.Drawing.Point(4, 25);
            this.Management.Name = "Management";
            this.Management.Padding = new System.Windows.Forms.Padding(3);
            this.Management.Size = new System.Drawing.Size(741, 449);
            this.Management.TabIndex = 1;
            this.Management.Text = "Management";
            this.Management.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gorilla Tag Folder Path:";
            // 
            // browseFiles
            // 
            this.browseFiles.BackColor = System.Drawing.SystemColors.Control;
            this.browseFiles.Font = new System.Drawing.Font("Segoe UI Variable Display", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseFiles.Location = new System.Drawing.Point(645, 35);
            this.browseFiles.Name = "browseFiles";
            this.browseFiles.Size = new System.Drawing.Size(90, 27);
            this.browseFiles.TabIndex = 1;
            this.browseFiles.Text = "Browse Folders";
            this.browseFiles.UseVisualStyleBackColor = false;
            this.browseFiles.Click += new System.EventHandler(this.browseFiles_Click);
            // 
            // fileLocation
            // 
            this.fileLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileLocation.Location = new System.Drawing.Point(6, 35);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(633, 23);
            this.fileLocation.TabIndex = 0;
            // 
            // installwarning
            // 
            this.installwarning.AutoSize = true;
            this.installwarning.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installwarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.installwarning.Location = new System.Drawing.Point(170, 185);
            this.installwarning.Name = "installwarning";
            this.installwarning.Size = new System.Drawing.Size(394, 21);
            this.installwarning.TabIndex = 5;
            this.installwarning.Text = "Please run the game to finish the intallation of BepinEx.";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 478);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Gorilla Arsenal";
            this.tabControl1.ResumeLayout(false);
            this.Arsenal.ResumeLayout(false);
            this.Arsenal.PerformLayout();
            this.Management.ResumeLayout(false);
            this.Management.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Arsenal;
        private System.Windows.Forms.TabPage Management;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.Button browseFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label pluginwarning;
        private System.Windows.Forms.Label installwarning;
    }
}

