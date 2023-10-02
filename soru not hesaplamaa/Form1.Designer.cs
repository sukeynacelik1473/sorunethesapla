namespace soru_not_hesaplamaa
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
            this.btnNet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.cmbDogru = new System.Windows.Forms.ComboBox();
            this.cmbYanlıs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNet
            // 
            this.btnNet.BackColor = System.Drawing.Color.SlateGray;
            this.btnNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNet.Location = new System.Drawing.Point(48, 186);
            this.btnNet.Name = "btnNet";
            this.btnNet.Size = new System.Drawing.Size(314, 60);
            this.btnNet.TabIndex = 0;
            this.btnNet.Text = "Net Doğru Hesapla";
            this.btnNet.UseVisualStyleBackColor = false;
            this.btnNet.Click += new System.EventHandler(this.btnNet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğru Sayı=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yanlış Sayı=";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNet.Location = new System.Drawing.Point(45, 143);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(95, 18);
            this.lblNet.TabIndex = 3;
            this.lblNet.Text = "Net Doğru=";
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbDogru.Location = new System.Drawing.Point(173, 50);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(189, 21);
            this.cmbDogru.TabIndex = 4;
            // 
            // cmbYanlıs
            // 
            this.cmbYanlıs.FormattingEnabled = true;
            this.cmbYanlıs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbYanlıs.Location = new System.Drawing.Point(173, 94);
            this.cmbYanlıs.Name = "cmbYanlıs";
            this.cmbYanlıs.Size = new System.Drawing.Size(189, 21);
            this.cmbYanlıs.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.cmbYanlıs);
            this.Controls.Add(this.cmbDogru);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.ComboBox cmbDogru;
        private System.Windows.Forms.ComboBox cmbYanlıs;
    }
}

