
namespace MegaDesk_Bear
{
    partial class SearchQuotes
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
            this.return4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return4
            // 
            this.return4.Location = new System.Drawing.Point(333, 374);
            this.return4.Name = "return4";
            this.return4.Size = new System.Drawing.Size(75, 23);
            this.return4.TabIndex = 0;
            this.return4.Text = "Return";
            this.return4.UseVisualStyleBackColor = true;
            this.return4.Click += new System.EventHandler(this.return4_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return4);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return4;
    }
}