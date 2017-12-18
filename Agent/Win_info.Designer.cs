namespace Agent
{
    partial class Win_info
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
            this.LBL_CompName = new System.Windows.Forms.Label();
            this.Btn_SendData = new System.Windows.Forms.Button();
            this.Btn_GetData = new System.Windows.Forms.Button();
            this.Btn_UpdateData = new System.Windows.Forms.Button();
            this.LBL_Serial = new System.Windows.Forms.Label();
            this.LBL_Asset = new System.Windows.Forms.Label();
            this.LBL_Make = new System.Windows.Forms.Label();
            this.LBL_Model = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_CompName
            // 
            this.LBL_CompName.AutoSize = true;
            this.LBL_CompName.Location = new System.Drawing.Point(13, 13);
            this.LBL_CompName.Name = "LBL_CompName";
            this.LBL_CompName.Size = new System.Drawing.Size(145, 25);
            this.LBL_CompName.TabIndex = 0;
            this.LBL_CompName.Text = "SystemName";
            // 
            // Btn_SendData
            // 
            this.Btn_SendData.Location = new System.Drawing.Point(12, 349);
            this.Btn_SendData.Name = "Btn_SendData";
            this.Btn_SendData.Size = new System.Drawing.Size(116, 34);
            this.Btn_SendData.TabIndex = 1;
            this.Btn_SendData.Text = "Send Data";
            this.Btn_SendData.UseVisualStyleBackColor = true;
            this.Btn_SendData.Click += new System.EventHandler(this.Btn_SendData_Click);
            // 
            // Btn_GetData
            // 
            this.Btn_GetData.Location = new System.Drawing.Point(134, 349);
            this.Btn_GetData.Name = "Btn_GetData";
            this.Btn_GetData.Size = new System.Drawing.Size(116, 34);
            this.Btn_GetData.TabIndex = 2;
            this.Btn_GetData.Text = "Get Data";
            this.Btn_GetData.UseVisualStyleBackColor = true;
            this.Btn_GetData.Click += new System.EventHandler(this.Btn_GetData_Click);
            // 
            // Btn_UpdateData
            // 
            this.Btn_UpdateData.Location = new System.Drawing.Point(256, 349);
            this.Btn_UpdateData.Name = "Btn_UpdateData";
            this.Btn_UpdateData.Size = new System.Drawing.Size(148, 34);
            this.Btn_UpdateData.TabIndex = 3;
            this.Btn_UpdateData.Text = "Update Data";
            this.Btn_UpdateData.UseVisualStyleBackColor = true;
            this.Btn_UpdateData.Click += new System.EventHandler(this.Btn_UpdateData_Click);
            // 
            // LBL_Serial
            // 
            this.LBL_Serial.AutoSize = true;
            this.LBL_Serial.Location = new System.Drawing.Point(13, 55);
            this.LBL_Serial.Name = "LBL_Serial";
            this.LBL_Serial.Size = new System.Drawing.Size(158, 25);
            this.LBL_Serial.TabIndex = 4;
            this.LBL_Serial.Text = "Serial Number";
            // 
            // LBL_Asset
            // 
            this.LBL_Asset.AutoSize = true;
            this.LBL_Asset.Location = new System.Drawing.Point(13, 210);
            this.LBL_Asset.Name = "LBL_Asset";
            this.LBL_Asset.Size = new System.Drawing.Size(153, 25);
            this.LBL_Asset.TabIndex = 5;
            this.LBL_Asset.Text = "Asset Number";
            // 
            // LBL_Make
            // 
            this.LBL_Make.AutoSize = true;
            this.LBL_Make.Location = new System.Drawing.Point(13, 97);
            this.LBL_Make.Name = "LBL_Make";
            this.LBL_Make.Size = new System.Drawing.Size(65, 25);
            this.LBL_Make.TabIndex = 6;
            this.LBL_Make.Text = "Make";
            // 
            // LBL_Model
            // 
            this.LBL_Model.AutoSize = true;
            this.LBL_Model.Location = new System.Drawing.Point(13, 139);
            this.LBL_Model.Name = "LBL_Model";
            this.LBL_Model.Size = new System.Drawing.Size(71, 25);
            this.LBL_Model.TabIndex = 7;
            this.LBL_Model.Text = "Model";
            // 
            // Win_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 395);
            this.Controls.Add(this.LBL_Model);
            this.Controls.Add(this.LBL_Make);
            this.Controls.Add(this.LBL_Asset);
            this.Controls.Add(this.LBL_Serial);
            this.Controls.Add(this.Btn_UpdateData);
            this.Controls.Add(this.Btn_GetData);
            this.Controls.Add(this.Btn_SendData);
            this.Controls.Add(this.LBL_CompName);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Win_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Information";
            this.Load += new System.EventHandler(this.Win_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_CompName;
        private System.Windows.Forms.Button Btn_SendData;
        private System.Windows.Forms.Button Btn_GetData;
        private System.Windows.Forms.Button Btn_UpdateData;
        private System.Windows.Forms.Label LBL_Serial;
        private System.Windows.Forms.Label LBL_Asset;
        private System.Windows.Forms.Label LBL_Make;
        private System.Windows.Forms.Label LBL_Model;
    }
}