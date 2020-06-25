namespace Network_Proj_5
{
    partial class WeatherAppForm
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
            System.Windows.Forms.Label WR_Lbl;
            this.ZC_Lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.GWBZ_Button = new System.Windows.Forms.Button();
            this.GWBN_Button = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ZCBox = new System.Windows.Forms.TextBox();
            this.WRBox = new System.Windows.Forms.TextBox();
            WR_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WR_Lbl
            // 
            WR_Lbl.AutoSize = true;
            WR_Lbl.Location = new System.Drawing.Point(39, 119);
            WR_Lbl.Name = "WR_Lbl";
            WR_Lbl.Size = new System.Drawing.Size(92, 13);
            WR_Lbl.TabIndex = 7;
            WR_Lbl.Text = "Weather Results: ";
            // 
            // ZC_Lbl
            // 
            this.ZC_Lbl.AutoSize = true;
            this.ZC_Lbl.Location = new System.Drawing.Point(39, 80);
            this.ZC_Lbl.Name = "ZC_Lbl";
            this.ZC_Lbl.Size = new System.Drawing.Size(50, 13);
            this.ZC_Lbl.TabIndex = 0;
            this.ZC_Lbl.Text = "Zip Code";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Location = new System.Drawing.Point(12, 35);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(79, 13);
            this.Name_Lbl.TabIndex = 1;
            this.Name_Lbl.Text = "Location Name";
            // 
            // GWBZ_Button
            // 
            this.GWBZ_Button.Location = new System.Drawing.Point(232, 69);
            this.GWBZ_Button.Name = "GWBZ_Button";
            this.GWBZ_Button.Size = new System.Drawing.Size(126, 34);
            this.GWBZ_Button.TabIndex = 2;
            this.GWBZ_Button.Text = "Get Weather By Zip Code";
            this.GWBZ_Button.UseVisualStyleBackColor = true;
            this.GWBZ_Button.Click += new System.EventHandler(this.GWBZ_Button_Click);
            // 
            // GWBN_Button
            // 
            this.GWBN_Button.Location = new System.Drawing.Point(232, 19);
            this.GWBN_Button.Name = "GWBN_Button";
            this.GWBN_Button.Size = new System.Drawing.Size(126, 44);
            this.GWBN_Button.TabIndex = 3;
            this.GWBN_Button.Text = "Get Weather By Name";
            this.GWBN_Button.UseVisualStyleBackColor = true;
            this.GWBN_Button.Click += new System.EventHandler(this.GWBN_Button_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.Maroon;
            this.NameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.NameBox.Location = new System.Drawing.Point(95, 19);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(135, 44);
            this.NameBox.TabIndex = 4;
            // 
            // ZCBox
            // 
            this.ZCBox.BackColor = System.Drawing.Color.Maroon;
            this.ZCBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ZCBox.Location = new System.Drawing.Point(95, 69);
            this.ZCBox.Multiline = true;
            this.ZCBox.Name = "ZCBox";
            this.ZCBox.Size = new System.Drawing.Size(135, 34);
            this.ZCBox.TabIndex = 5;
            this.ZCBox.Text = "24060";
            // 
            // WRBox
            // 
            this.WRBox.Location = new System.Drawing.Point(30, 135);
            this.WRBox.Multiline = true;
            this.WRBox.Name = "WRBox";
            this.WRBox.Size = new System.Drawing.Size(328, 219);
            this.WRBox.TabIndex = 6;
            // 
            // WeatherAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(388, 372);
            this.Controls.Add(WR_Lbl);
            this.Controls.Add(this.WRBox);
            this.Controls.Add(this.ZCBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.GWBN_Button);
            this.Controls.Add(this.GWBZ_Button);
            this.Controls.Add(this.Name_Lbl);
            this.Controls.Add(this.ZC_Lbl);
            this.Name = "WeatherAppForm";
            this.Text = "Weather Application (Project 5)";
            this.Load += new System.EventHandler(this.WeatherAppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ZC_Lbl;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.Button GWBZ_Button;
        private System.Windows.Forms.Button GWBN_Button;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox ZCBox;
        private System.Windows.Forms.TextBox WRBox;
    }
}

