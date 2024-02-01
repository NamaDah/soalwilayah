using System.Windows.Forms;
using System.Drawing;


namespace soalwilayah
{
    partial class HalamanUtama
    {

        #region

        private void AdjustLabelUsernameAlignment()
        {
            labelUsername.Anchor = AnchorStyles.None;
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            buttonCek.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCek.ImageAlign = ContentAlignment.MiddleRight;
            buttonCek.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLaporkan.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLaporkan.ImageAlign = ContentAlignment.MiddleRight;
            buttonLaporkan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;


        }

        #endregion






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
            this.buttonLaporkan = new System.Windows.Forms.Button();
            this.buttonCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLaporkan
            // 
            this.buttonLaporkan.Location = new System.Drawing.Point(243, 160);
            this.buttonLaporkan.Name = "buttonLaporkan";
            this.buttonLaporkan.Size = new System.Drawing.Size(286, 38);
            this.buttonLaporkan.TabIndex = 0;
            this.buttonLaporkan.Text = "Laporkan";
            this.buttonLaporkan.UseVisualStyleBackColor = true;
            this.buttonLaporkan.Click += new System.EventHandler(this.buttonLaporkan_Click);
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(243, 228);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(286, 37);
            this.buttonCek.TabIndex = 1;
            this.buttonCek.Text = "Cek laporan";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMKN 2 Jakarta";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(243, 289);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(286, 37);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(353, 43);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 16);
            this.labelUsername.TabIndex = 4;
            // 
            // HalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLaporkan);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCek);
            this.Name = "HalamanUtama";
            this.Text = "HalamanUtama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaporkan;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelUsername;

    }
}