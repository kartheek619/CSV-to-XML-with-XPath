namespace Week2Question
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.showXML = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.validateResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert to XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showXML
            // 
            this.showXML.BackColor = System.Drawing.SystemColors.Window;
            this.showXML.Location = new System.Drawing.Point(25, 82);
            this.showXML.Name = "showXML";
            this.showXML.ReadOnly = true;
            this.showXML.Size = new System.Drawing.Size(323, 378);
            this.showXML.TabIndex = 1;
            this.showXML.Text = "";
            this.showXML.TextChanged += new System.EventHandler(this.showXML_TextChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(393, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Validate XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // validateResult
            // 
            this.validateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateResult.Location = new System.Drawing.Point(393, 82);
            this.validateResult.Name = "validateResult";
            this.validateResult.ReadOnly = true;
            this.validateResult.Size = new System.Drawing.Size(206, 91);
            this.validateResult.TabIndex = 3;
            this.validateResult.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conversion Completed. XML file saved";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 69);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click on \"Validate XML\" button to check if it matches with schema";
            this.label2.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(393, 276);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(202, 69);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to open folder containing XML file that is created";
            this.linkLabel1.Visible = false;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 488);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validateResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showXML);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CSV to XML Convertor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox showXML;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox validateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

