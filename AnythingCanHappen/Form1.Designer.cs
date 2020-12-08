namespace AnythingCanHappen
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
            this.label1 = new System.Windows.Forms.Label();
            this.PicButton = new System.Windows.Forms.Button();
            this.OutpouLabel1 = new System.Windows.Forms.Label();
            this.DoYouLabel1 = new System.Windows.Forms.Label();
            this.DoYouLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 647);
            this.label1.TabIndex = 0;
            // 
            // PicButton
            // 
            this.PicButton.BackColor = System.Drawing.Color.Black;
            this.PicButton.Location = new System.Drawing.Point(38, 150);
            this.PicButton.Name = "PicButton";
            this.PicButton.Size = new System.Drawing.Size(725, 368);
            this.PicButton.TabIndex = 1;
            this.PicButton.UseVisualStyleBackColor = false;
            // 
            // OutpouLabel1
            // 
            this.OutpouLabel1.BackColor = System.Drawing.Color.Black;
            this.OutpouLabel1.ForeColor = System.Drawing.Color.White;
            this.OutpouLabel1.Location = new System.Drawing.Point(35, 26);
            this.OutpouLabel1.Name = "OutpouLabel1";
            this.OutpouLabel1.Size = new System.Drawing.Size(728, 121);
            this.OutpouLabel1.TabIndex = 2;
            // 
            // DoYouLabel1
            // 
            this.DoYouLabel1.BackColor = System.Drawing.Color.Black;
            this.DoYouLabel1.ForeColor = System.Drawing.Color.White;
            this.DoYouLabel1.Location = new System.Drawing.Point(38, 525);
            this.DoYouLabel1.Name = "DoYouLabel1";
            this.DoYouLabel1.Size = new System.Drawing.Size(725, 46);
            this.DoYouLabel1.TabIndex = 3;
            // 
            // DoYouLabel2
            // 
            this.DoYouLabel2.BackColor = System.Drawing.Color.Black;
            this.DoYouLabel2.ForeColor = System.Drawing.Color.White;
            this.DoYouLabel2.Location = new System.Drawing.Point(38, 575);
            this.DoYouLabel2.Name = "DoYouLabel2";
            this.DoYouLabel2.Size = new System.Drawing.Size(725, 52);
            this.DoYouLabel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.DoYouLabel2);
            this.Controls.Add(this.DoYouLabel1);
            this.Controls.Add(this.OutpouLabel1);
            this.Controls.Add(this.PicButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PicButton;
        private System.Windows.Forms.Label OutpouLabel1;
        private System.Windows.Forms.Label DoYouLabel1;
        private System.Windows.Forms.Label DoYouLabel2;
    }
}

