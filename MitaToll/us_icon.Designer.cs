namespace MitaToll
{
    partial class us_icon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIp = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panColor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbIp);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.panColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 79);
            this.panel1.TabIndex = 0;
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(77, 47);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(111, 17);
            this.lbIp.TabIndex = 2;
            this.lbIp.Text = "ip  : 192.168.1.1";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(73, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(104, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Máy CCC))(\\";
            // 
            // panColor
            // 
            this.panColor.BackColor = System.Drawing.Color.ForestGreen;
            this.panColor.Location = new System.Drawing.Point(3, 3);
            this.panColor.Name = "panColor";
            this.panColor.Size = new System.Drawing.Size(46, 71);
            this.panColor.TabIndex = 0;
            // 
            // us_icon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "us_icon";
            this.Size = new System.Drawing.Size(280, 79);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panColor;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbName;
    }
}
