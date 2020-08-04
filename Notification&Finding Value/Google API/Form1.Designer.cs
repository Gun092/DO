namespace Google_API
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.search_data = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_zip = new System.Windows.Forms.TextBox();
            this.text_state = new System.Windows.Forms.TextBox();
            this.text_city = new System.Windows.Forms.TextBox();
            this.text_street = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.search_data);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.text_zip);
            this.splitContainer1.Panel1.Controls.Add(this.text_state);
            this.splitContainer1.Panel1.Controls.Add(this.text_city);
            this.splitContainer1.Panel1.Controls.Add(this.text_street);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1434, 644);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 95);
            this.button1.TabIndex = 9;
            this.button1.Text = "Go to Web";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_data
            // 
            this.search_data.Location = new System.Drawing.Point(43, 219);
            this.search_data.Name = "search_data";
            this.search_data.Size = new System.Drawing.Size(274, 101);
            this.search_data.TabIndex = 8;
            this.search_data.Text = "Go to Google Map";
            this.search_data.UseVisualStyleBackColor = true;
            this.search_data.Click += new System.EventHandler(this.search_data_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Street";
            // 
            // text_zip
            // 
            this.text_zip.Location = new System.Drawing.Point(142, 176);
            this.text_zip.Name = "text_zip";
            this.text_zip.Size = new System.Drawing.Size(100, 20);
            this.text_zip.TabIndex = 3;
            // 
            // text_state
            // 
            this.text_state.Location = new System.Drawing.Point(142, 138);
            this.text_state.Name = "text_state";
            this.text_state.Size = new System.Drawing.Size(100, 20);
            this.text_state.TabIndex = 2;
            // 
            // text_city
            // 
            this.text_city.Location = new System.Drawing.Point(142, 94);
            this.text_city.Name = "text_city";
            this.text_city.Size = new System.Drawing.Size(100, 20);
            this.text_city.TabIndex = 1;
            // 
            // text_street
            // 
            this.text_street.Location = new System.Drawing.Point(142, 51);
            this.text_street.Name = "text_street";
            this.text_street.Size = new System.Drawing.Size(100, 20);
            this.text_street.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(998, 644);
            this.webBrowser1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 95);
            this.button2.TabIndex = 10;
            this.button2.Text = "Go to google";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 644);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button search_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_zip;
        private System.Windows.Forms.TextBox text_state;
        private System.Windows.Forms.TextBox text_city;
        private System.Windows.Forms.TextBox text_street;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

