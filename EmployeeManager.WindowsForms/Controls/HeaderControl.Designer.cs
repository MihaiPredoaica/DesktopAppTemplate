
namespace EmployeeManager.WindowsForms.Controls
{
    partial class HeaderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderControl));
            this.ingLogo = new System.Windows.Forms.PictureBox();
            this.lblEmployeeManager = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ingLogo
            // 
            this.ingLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ingLogo.Image = ((System.Drawing.Image)(resources.GetObject("ingLogo.Image")));
            this.ingLogo.Location = new System.Drawing.Point(195, 3);
            this.ingLogo.Name = "ingLogo";
            this.ingLogo.Size = new System.Drawing.Size(189, 144);
            this.ingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ingLogo.TabIndex = 0;
            this.ingLogo.TabStop = false;
            // 
            // lblEmployeeManager
            // 
            this.lblEmployeeManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmployeeManager.AutoSize = true;
            this.lblEmployeeManager.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeManager.Location = new System.Drawing.Point(390, 42);
            this.lblEmployeeManager.Name = "lblEmployeeManager";
            this.lblEmployeeManager.Size = new System.Drawing.Size(430, 62);
            this.lblEmployeeManager.TabIndex = 1;
            this.lblEmployeeManager.Text = "Employee Manager";
            // 
            // HeaderControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(88)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lblEmployeeManager);
            this.Controls.Add(this.ingLogo);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(1021, 150);
            ((System.ComponentModel.ISupportInitialize)(this.ingLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ingLogo;
        private System.Windows.Forms.Label lblEmployeeManager;
    }
}
