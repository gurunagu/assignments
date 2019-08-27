namespace App3tier
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
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.GroupBox();
            this.delid = new System.Windows.Forms.Label();
            this.IdDel = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Display = new System.Windows.Forms.Button();
            this.details.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(35, 38);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(35, 72);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 1;
            this.id.Text = "id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(110, 124);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // details
            // 
            this.details.Controls.Add(this.submit);
            this.details.Controls.Add(this.textBox2);
            this.details.Controls.Add(this.textBox1);
            this.details.Controls.Add(this.id);
            this.details.Controls.Add(this.name);
            this.details.Location = new System.Drawing.Point(38, 41);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(288, 184);
            this.details.TabIndex = 5;
            this.details.TabStop = false;
            this.details.Text = "Enter details";
            // 
            // delid
            // 
            this.delid.AutoSize = true;
            this.delid.Location = new System.Drawing.Point(46, 55);
            this.delid.Name = "delid";
            this.delid.Size = new System.Drawing.Size(15, 13);
            this.delid.TabIndex = 6;
            this.delid.Text = "id";
            // 
            // IdDel
            // 
            this.IdDel.Location = new System.Drawing.Point(101, 52);
            this.IdDel.Name = "IdDel";
            this.IdDel.Size = new System.Drawing.Size(146, 20);
            this.IdDel.TabIndex = 5;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(114, 102);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.IdDel);
            this.groupBox1.Controls.Add(this.delid);
            this.groupBox1.Location = new System.Drawing.Point(355, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // empDataBindingSource
            // 
            this.empDataBindingSource.DataMember = "EmpData";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(266, 261);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(167, 57);
            this.Display.TabIndex = 8;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 376);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.details);
            this.Name = "Form1";
            this.Text = "data";
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.GroupBox details;
        private System.Windows.Forms.Label delid;
        private System.Windows.Forms.TextBox IdDel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource empDataBindingSource;
        private System.Windows.Forms.Button Display;
    }
}

