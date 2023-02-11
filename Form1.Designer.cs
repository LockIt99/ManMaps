namespace ManMaps
{
    partial class frm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.pinziplbl = new System.Windows.Forms.Label();
            this.stlbl = new System.Windows.Forms.Label();
            this.citylbl = new System.Windows.Forms.Label();
            this.strlbl = new System.Windows.Forms.Label();
            this.txtBoxPin = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxstrt = new System.Windows.Forms.TextBox();
            this.webbr = new System.Windows.Forms.WebBrowser();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Wheat;
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.pinziplbl);
            this.splitContainer1.Panel1.Controls.Add(this.stlbl);
            this.splitContainer1.Panel1.Controls.Add(this.citylbl);
            this.splitContainer1.Panel1.Controls.Add(this.strlbl);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxPin);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxState);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxCity);
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxstrt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webbr);
            this.splitContainer1.Size = new System.Drawing.Size(1219, 739);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(112, 354);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pinziplbl
            // 
            this.pinziplbl.AutoSize = true;
            this.pinziplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinziplbl.Location = new System.Drawing.Point(12, 260);
            this.pinziplbl.Name = "pinziplbl";
            this.pinziplbl.Size = new System.Drawing.Size(111, 20);
            this.pinziplbl.TabIndex = 7;
            this.pinziplbl.Text = "Pin / Zip code";
            // 
            // stlbl
            // 
            this.stlbl.AutoSize = true;
            this.stlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlbl.Location = new System.Drawing.Point(38, 205);
            this.stlbl.Name = "stlbl";
            this.stlbl.Size = new System.Drawing.Size(48, 20);
            this.stlbl.TabIndex = 6;
            this.stlbl.Text = "State";
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylbl.Location = new System.Drawing.Point(38, 142);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(38, 20);
            this.citylbl.TabIndex = 5;
            this.citylbl.Text = "City";
            // 
            // strlbl
            // 
            this.strlbl.AutoSize = true;
            this.strlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strlbl.Location = new System.Drawing.Point(38, 68);
            this.strlbl.Name = "strlbl";
            this.strlbl.Size = new System.Drawing.Size(54, 20);
            this.strlbl.TabIndex = 4;
            this.strlbl.Text = "Street";
            // 
            // txtBoxPin
            // 
            this.txtBoxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPin.Location = new System.Drawing.Point(144, 248);
            this.txtBoxPin.Multiline = true;
            this.txtBoxPin.Name = "txtBoxPin";
            this.txtBoxPin.Size = new System.Drawing.Size(159, 32);
            this.txtBoxPin.TabIndex = 3;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxState.Location = new System.Drawing.Point(112, 191);
            this.txtBoxState.Multiline = true;
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(191, 33);
            this.txtBoxState.TabIndex = 2;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(112, 132);
            this.txtBoxCity.Multiline = true;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(191, 32);
            this.txtBoxCity.TabIndex = 1;
            // 
            // txtBoxstrt
            // 
            this.txtBoxstrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxstrt.Location = new System.Drawing.Point(112, 62);
            this.txtBoxstrt.Multiline = true;
            this.txtBoxstrt.Name = "txtBoxstrt";
            this.txtBoxstrt.Size = new System.Drawing.Size(191, 30);
            this.txtBoxstrt.TabIndex = 0;
            // 
            // webbr
            // 
            this.webbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbr.Location = new System.Drawing.Point(0, 0);
            this.webbr.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbr.Name = "webbr";
            this.webbr.ScriptErrorsSuppressed = true;
            this.webbr.Size = new System.Drawing.Size(897, 739);
            this.webbr.TabIndex = 0;
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.splitContainer1);
            this.HelpButton = true;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Man Maps";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label pinziplbl;
        private System.Windows.Forms.Label stlbl;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.Label strlbl;
        private System.Windows.Forms.TextBox txtBoxPin;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxstrt;
        private System.Windows.Forms.WebBrowser webbr;
    }
}

