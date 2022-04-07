namespace KuzaNetObfuscator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_select = new System.Windows.Forms.Button();
            this.box_numberofjunk = new System.Windows.Forms.TextBox();
            this.checkjunk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkname = new System.Windows.Forms.CheckBox();
            this.checkstrings = new System.Windows.Forms.CheckBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.box_file = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_newname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(201, 12);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(153, 51);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "select File";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // box_numberofjunk
            // 
            this.box_numberofjunk.Location = new System.Drawing.Point(98, 29);
            this.box_numberofjunk.Name = "box_numberofjunk";
            this.box_numberofjunk.Size = new System.Drawing.Size(83, 21);
            this.box_numberofjunk.TabIndex = 1;
            this.box_numberofjunk.Text = "75";
            this.box_numberofjunk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkjunk
            // 
            this.checkjunk.AutoSize = true;
            this.checkjunk.Checked = true;
            this.checkjunk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkjunk.Location = new System.Drawing.Point(12, 12);
            this.checkjunk.Name = "checkjunk";
            this.checkjunk.Size = new System.Drawing.Size(66, 17);
            this.checkjunk.TabIndex = 2;
            this.checkjunk.Text = "add junk";
            this.checkjunk.UseVisualStyleBackColor = true;
            this.checkjunk.CheckedChanged += new System.EventHandler(this.checkjunk_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "number of junk:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkname
            // 
            this.checkname.AutoSize = true;
            this.checkname.Checked = true;
            this.checkname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkname.Location = new System.Drawing.Point(12, 56);
            this.checkname.Name = "checkname";
            this.checkname.Size = new System.Drawing.Size(90, 17);
            this.checkname.TabIndex = 4;
            this.checkname.Text = "protect name";
            this.checkname.UseVisualStyleBackColor = true;
            this.checkname.CheckedChanged += new System.EventHandler(this.checkname_CheckedChanged);
            // 
            // checkstrings
            // 
            this.checkstrings.AutoSize = true;
            this.checkstrings.Checked = true;
            this.checkstrings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkstrings.Location = new System.Drawing.Point(12, 79);
            this.checkstrings.Name = "checkstrings";
            this.checkstrings.Size = new System.Drawing.Size(96, 17);
            this.checkstrings.TabIndex = 5;
            this.checkstrings.Text = "encrypt strings";
            this.checkstrings.UseVisualStyleBackColor = true;
            this.checkstrings.CheckedChanged += new System.EventHandler(this.checkstrings_CheckedChanged);
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(201, 79);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(153, 51);
            this.btn_go.TabIndex = 6;
            this.btn_go.Text = "obfuscate";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "file:";
            // 
            // box_file
            // 
            this.box_file.Location = new System.Drawing.Point(40, 147);
            this.box_file.Name = "box_file";
            this.box_file.Size = new System.Drawing.Size(314, 21);
            this.box_file.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "new name:";
            // 
            // text_newname
            // 
            this.text_newname.Location = new System.Drawing.Point(98, 105);
            this.text_newname.Name = "text_newname";
            this.text_newname.Size = new System.Drawing.Size(83, 21);
            this.text_newname.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 172);
            this.Controls.Add(this.text_newname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.checkstrings);
            this.Controls.Add(this.checkname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkjunk);
            this.Controls.Add(this.box_numberofjunk);
            this.Controls.Add(this.btn_select);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "KuzaNetObfuscator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox box_numberofjunk;
        private System.Windows.Forms.CheckBox checkjunk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkname;
        private System.Windows.Forms.CheckBox checkstrings;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_newname;
    }
}

