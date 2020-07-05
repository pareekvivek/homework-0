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
            this.tvEntities = new System.Windows.Forms.TreeView();
            this.ConnectToCosmosDB = new System.Windows.Forms.Button();
            this.txtConfigSetting = new System.Windows.Forms.TextBox();
            this.GetFromConfigrations = new System.Windows.Forms.Button();
            this.btnAddEntity = new System.Windows.Forms.Button();
            this.txtNewEntity = new System.Windows.Forms.TextBox();
            this.lblEntities = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvEntities
            // 
            this.tvEntities.Location = new System.Drawing.Point(88, 149);
            this.tvEntities.Name = "tvEntities";
            this.tvEntities.Size = new System.Drawing.Size(121, 97);
            this.tvEntities.TabIndex = 0;
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
            // txtConfigSetting
            // 
            this.txtConfigSetting.AllowDrop = true;
            this.txtConfigSetting.Location = new System.Drawing.Point(81, 42);
            this.txtConfigSetting.Multiline = true;
            this.txtConfigSetting.Name = "txtConfigSetting";
            this.txtConfigSetting.Size = new System.Drawing.Size(397, 49);
            this.txtConfigSetting.TabIndex = 2;
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
            // btnAddEntity
            // 
            this.btnAddEntity.Location = new System.Drawing.Point(236, 196);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(152, 23);
            this.btnAddEntity.TabIndex = 4;
            this.btnAddEntity.Text = "Add Entity";
            this.btnAddEntity.UseVisualStyleBackColor = true;
            this.btnAddEntity.Click += new System.EventHandler(this.btnAddEntity_Click);
            // 
            // txtNewEntity
            // 
            this.txtNewEntity.AllowDrop = true;
            this.txtNewEntity.Location = new System.Drawing.Point(236, 164);
            this.txtNewEntity.Multiline = true;
            this.txtNewEntity.Name = "txtNewEntity";
            this.txtNewEntity.Size = new System.Drawing.Size(152, 26);
            this.txtNewEntity.TabIndex = 5;
            // 
            // lblEntities
            // 
            this.lblEntities.AutoSize = true;
            this.lblEntities.Location = new System.Drawing.Point(88, 130);
            this.lblEntities.Name = "lblEntities";
            this.lblEntities.Size = new System.Drawing.Size(41, 13);
            this.lblEntities.TabIndex = 6;
            this.lblEntities.Text = "Entities";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 297);
            this.Controls.Add(this.lblEntities);
            this.Controls.Add(this.txtNewEntity);
            this.Controls.Add(this.btnAddEntity);
            this.Controls.Add(this.GetFromConfigrations);
            this.Controls.Add(this.txtConfigSetting);
            this.Controls.Add(this.ConnectToCosmosDB);
            this.Controls.Add(this.tvEntities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvEntities;
        private System.Windows.Forms.Button ConnectToCosmosDB;
        private System.Windows.Forms.TextBox txtConfigSetting;
        private System.Windows.Forms.Button GetFromConfigrations;
        private System.Windows.Forms.Button btnAddEntity;
        private System.Windows.Forms.TextBox txtNewEntity;
        private System.Windows.Forms.Label lblEntities;
    }
}

