namespace CosmosDBApp
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ConnectToCosmosDB = new System.Windows.Forms.Button();
            this.ConfigSetting = new System.Windows.Forms.TextBox();
            this.GetFromConfigrations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(81, 160);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // ConnectToCosmosDB
            // 
            this.ConnectToCosmosDB.Location = new System.Drawing.Point(81, 97);
            this.ConnectToCosmosDB.Name = "ConnectToCosmosDB";
            this.ConnectToCosmosDB.Size = new System.Drawing.Size(128, 23);
            this.ConnectToCosmosDB.TabIndex = 1;
            this.ConnectToCosmosDB.Text = "Connect to Cosmos DB";
            this.ConnectToCosmosDB.UseVisualStyleBackColor = true;
            this.ConnectToCosmosDB.Click += new System.EventHandler(this.ConnectToCosmosDB_Click);
            // 
            // ConfigSetting
            // 
            this.ConfigSetting.AllowDrop = true;
            this.ConfigSetting.Location = new System.Drawing.Point(81, 42);
            this.ConfigSetting.Multiline = true;
            this.ConfigSetting.Name = "ConfigSetting";
            this.ConfigSetting.Size = new System.Drawing.Size(397, 49);
            this.ConfigSetting.TabIndex = 2;
            // 
            // GetFromConfigrations
            // 
            this.GetFromConfigrations.Location = new System.Drawing.Point(484, 42);
            this.GetFromConfigrations.Name = "GetFromConfigrations";
            this.GetFromConfigrations.Size = new System.Drawing.Size(89, 49);
            this.GetFromConfigrations.TabIndex = 3;
            this.GetFromConfigrations.Text = "Get From Configrations";
            this.GetFromConfigrations.UseVisualStyleBackColor = true;
            this.GetFromConfigrations.Click += new System.EventHandler(this.GetFromConfigrations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 407);
            this.Controls.Add(this.GetFromConfigrations);
            this.Controls.Add(this.ConfigSetting);
            this.Controls.Add(this.ConnectToCosmosDB);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button ConnectToCosmosDB;
        private System.Windows.Forms.TextBox ConfigSetting;
        private System.Windows.Forms.Button GetFromConfigrations;
    }
}

