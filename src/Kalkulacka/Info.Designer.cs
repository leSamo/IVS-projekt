namespace Kalkulacka
{
    partial class Info
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
            this.next1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 399.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Image = global::Kalkulacka.Properties.Resources.info1;
            this.label1.Location = new System.Drawing.Point(-2002, -39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4944, 603);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                .";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // next1
            // 
            this.next1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.next1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.next1.FlatAppearance.BorderSize = 0;
            this.next1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.next1.ForeColor = System.Drawing.Color.LightGray;
            this.next1.Location = new System.Drawing.Point(838, 441);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(70, 70);
            this.next1.TabIndex = 1;
            this.next1.Text = "NEXT";
            this.next1.UseVisualStyleBackColor = false;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 523);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next1;
    }
}