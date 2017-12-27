namespace Agent
{
    partial class SystemInformation
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
            this.Lbl_Make = new System.Windows.Forms.Label();
            this.Btn_FindManufacturer = new System.Windows.Forms.Button();
            this.Btn_Category = new System.Windows.Forms.Button();
            this.Lbl_category = new System.Windows.Forms.Label();
            this.Btn_Company = new System.Windows.Forms.Button();
            this.Lbl_Company = new System.Windows.Forms.Label();
            this.Btn_Model = new System.Windows.Forms.Button();
            this.Lbl_Model = new System.Windows.Forms.Label();
            this.Btn_Asset = new System.Windows.Forms.Button();
            this.Lbl_Asset = new System.Windows.Forms.Label();
            this.Btn_Upload = new System.Windows.Forms.Button();
            this.Btn_GetData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Make
            // 
            this.Lbl_Make.AutoSize = true;
            this.Lbl_Make.Location = new System.Drawing.Point(12, 71);
            this.Lbl_Make.Name = "Lbl_Make";
            this.Lbl_Make.Size = new System.Drawing.Size(83, 17);
            this.Lbl_Make.TabIndex = 0;
            this.Lbl_Make.Text = "Make Name";
            // 
            // Btn_FindManufacturer
            // 
            this.Btn_FindManufacturer.Location = new System.Drawing.Point(308, 64);
            this.Btn_FindManufacturer.Name = "Btn_FindManufacturer";
            this.Btn_FindManufacturer.Size = new System.Drawing.Size(178, 31);
            this.Btn_FindManufacturer.TabIndex = 1;
            this.Btn_FindManufacturer.Text = "Find Manufacturer";
            this.Btn_FindManufacturer.UseVisualStyleBackColor = true;
            this.Btn_FindManufacturer.Click += new System.EventHandler(this.Btn_FindManufacturer_Click);
            // 
            // Btn_Category
            // 
            this.Btn_Category.Location = new System.Drawing.Point(308, 125);
            this.Btn_Category.Name = "Btn_Category";
            this.Btn_Category.Size = new System.Drawing.Size(178, 31);
            this.Btn_Category.TabIndex = 3;
            this.Btn_Category.Text = "Find Category";
            this.Btn_Category.UseVisualStyleBackColor = true;
            this.Btn_Category.Click += new System.EventHandler(this.Btn_Category_Click);
            // 
            // Lbl_category
            // 
            this.Lbl_category.AutoSize = true;
            this.Lbl_category.Location = new System.Drawing.Point(12, 132);
            this.Lbl_category.Name = "Lbl_category";
            this.Lbl_category.Size = new System.Drawing.Size(106, 17);
            this.Lbl_category.TabIndex = 2;
            this.Lbl_category.Text = "Category Name";
            // 
            // Btn_Company
            // 
            this.Btn_Company.Location = new System.Drawing.Point(308, 247);
            this.Btn_Company.Name = "Btn_Company";
            this.Btn_Company.Size = new System.Drawing.Size(178, 31);
            this.Btn_Company.TabIndex = 7;
            this.Btn_Company.Text = "Find Company";
            this.Btn_Company.UseVisualStyleBackColor = true;
            this.Btn_Company.Click += new System.EventHandler(this.Btn_Company_Click);
            // 
            // Lbl_Company
            // 
            this.Lbl_Company.AutoSize = true;
            this.Lbl_Company.Location = new System.Drawing.Point(12, 254);
            this.Lbl_Company.Name = "Lbl_Company";
            this.Lbl_Company.Size = new System.Drawing.Size(108, 17);
            this.Lbl_Company.TabIndex = 6;
            this.Lbl_Company.Text = "Company Name";
            // 
            // Btn_Model
            // 
            this.Btn_Model.Location = new System.Drawing.Point(308, 186);
            this.Btn_Model.Name = "Btn_Model";
            this.Btn_Model.Size = new System.Drawing.Size(178, 31);
            this.Btn_Model.TabIndex = 5;
            this.Btn_Model.Text = "Find Model";
            this.Btn_Model.UseVisualStyleBackColor = true;
            this.Btn_Model.Click += new System.EventHandler(this.Btn_Model_Click);
            // 
            // Lbl_Model
            // 
            this.Lbl_Model.AutoSize = true;
            this.Lbl_Model.Location = new System.Drawing.Point(12, 193);
            this.Lbl_Model.Name = "Lbl_Model";
            this.Lbl_Model.Size = new System.Drawing.Size(87, 17);
            this.Lbl_Model.TabIndex = 4;
            this.Lbl_Model.Text = "Model Name";
            // 
            // Btn_Asset
            // 
            this.Btn_Asset.Location = new System.Drawing.Point(308, 311);
            this.Btn_Asset.Name = "Btn_Asset";
            this.Btn_Asset.Size = new System.Drawing.Size(178, 31);
            this.Btn_Asset.TabIndex = 9;
            this.Btn_Asset.Text = "Find Asset";
            this.Btn_Asset.UseVisualStyleBackColor = true;
            this.Btn_Asset.Click += new System.EventHandler(this.Btn_Asset_Click);
            // 
            // Lbl_Asset
            // 
            this.Lbl_Asset.AutoSize = true;
            this.Lbl_Asset.Location = new System.Drawing.Point(12, 318);
            this.Lbl_Asset.Name = "Lbl_Asset";
            this.Lbl_Asset.Size = new System.Drawing.Size(84, 17);
            this.Lbl_Asset.TabIndex = 8;
            this.Lbl_Asset.Text = "Asset Name";
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Location = new System.Drawing.Point(124, 358);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(178, 31);
            this.Btn_Upload.TabIndex = 10;
            this.Btn_Upload.Text = "Upload Data";
            this.Btn_Upload.UseVisualStyleBackColor = true;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            // 
            // Btn_GetData
            // 
            this.Btn_GetData.Location = new System.Drawing.Point(308, 358);
            this.Btn_GetData.Name = "Btn_GetData";
            this.Btn_GetData.Size = new System.Drawing.Size(178, 31);
            this.Btn_GetData.TabIndex = 11;
            this.Btn_GetData.Text = "Get Data";
            this.Btn_GetData.UseVisualStyleBackColor = true;
            this.Btn_GetData.Click += new System.EventHandler(this.Btn_GetData_Click);
            // 
            // SystemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 421);
            this.Controls.Add(this.Btn_GetData);
            this.Controls.Add(this.Btn_Upload);
            this.Controls.Add(this.Btn_Asset);
            this.Controls.Add(this.Lbl_Asset);
            this.Controls.Add(this.Btn_Company);
            this.Controls.Add(this.Lbl_Company);
            this.Controls.Add(this.Btn_Model);
            this.Controls.Add(this.Lbl_Model);
            this.Controls.Add(this.Btn_Category);
            this.Controls.Add(this.Lbl_category);
            this.Controls.Add(this.Btn_FindManufacturer);
            this.Controls.Add(this.Lbl_Make);
            this.Name = "SystemInformation";
            this.Text = "SystemInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Make;
        private System.Windows.Forms.Button Btn_FindManufacturer;
        private System.Windows.Forms.Button Btn_Category;
        private System.Windows.Forms.Label Lbl_category;
        private System.Windows.Forms.Button Btn_Company;
        private System.Windows.Forms.Label Lbl_Company;
        private System.Windows.Forms.Button Btn_Model;
        private System.Windows.Forms.Label Lbl_Model;
        private System.Windows.Forms.Button Btn_Asset;
        private System.Windows.Forms.Label Lbl_Asset;
        private System.Windows.Forms.Button Btn_Upload;
        private System.Windows.Forms.Button Btn_GetData;
    }
}