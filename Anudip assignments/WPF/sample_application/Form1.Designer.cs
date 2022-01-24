namespace _24jan_sampleapplcation
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("CheckBox");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listCity = new System.Windows.Forms.ListBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkASP = new System.Windows.Forms.CheckBox();
            this.btnSUBMIT = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER DETAILS";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADDRESS";
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // listCity
            // 
            this.listCity.FormattingEnabled = true;
            this.listCity.Items.AddRange(new object[] {
            "Mumbai",
            "Bangalore ",
            "Hyderabad"});
            this.listCity.Location = new System.Drawing.Point(51, 219);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(214, 134);
            this.listCity.TabIndex = 2;
            this.listCity.SelectedIndexChanged += new System.EventHandler(this.listCity_SelectedIndexChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(428, 73);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 3;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(428, 111);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 4;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(428, 219);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(40, 17);
            this.chkC.TabIndex = 5;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkASP
            // 
            this.chkASP.AutoSize = true;
            this.chkASP.Location = new System.Drawing.Point(428, 258);
            this.chkASP.Name = "chkASP";
            this.chkASP.Size = new System.Drawing.Size(47, 17);
            this.chkASP.TabIndex = 6;
            this.chkASP.Text = "ASP";
            this.chkASP.UseVisualStyleBackColor = true;
            // 
            // btnSUBMIT
            // 
            this.btnSUBMIT.Location = new System.Drawing.Point(416, 329);
            this.btnSUBMIT.Name = "btnSUBMIT";
            this.btnSUBMIT.Size = new System.Drawing.Size(75, 23);
            this.btnSUBMIT.TabIndex = 7;
            this.btnSUBMIT.Text = "SUBMIT";
            this.btnSUBMIT.UseVisualStyleBackColor = true;
            this.btnSUBMIT.Click += new System.EventHandler(this.btnSUBMIT_Click_1);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(599, 58);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Label";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Button";
            treeNode11.Name = "Node3";
            treeNode11.Text = "CheckBox";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 153);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSUBMIT);
            this.Controls.Add(this.chkASP);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.listCity);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCity;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkASP;
        private System.Windows.Forms.Button btnSUBMIT;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

