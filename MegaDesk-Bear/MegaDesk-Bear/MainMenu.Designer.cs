
namespace MegaDesk_Bear
{
    partial class MainMenu
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
            this.add_new_quote = new System.Windows.Forms.Button();
            this.view_quotes = new System.Windows.Forms.Button();
            this.search_quotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_new_quote
            // 
            this.add_new_quote.AutoSize = true;
            this.add_new_quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_quote.Location = new System.Drawing.Point(28, 52);
            this.add_new_quote.Name = "add_new_quote";
            this.add_new_quote.Size = new System.Drawing.Size(200, 50);
            this.add_new_quote.TabIndex = 0;
            this.add_new_quote.Text = "Add New Quote";
            this.add_new_quote.UseVisualStyleBackColor = true;
            this.add_new_quote.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_quotes
            // 
            this.view_quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_quotes.Location = new System.Drawing.Point(28, 108);
            this.view_quotes.Name = "view_quotes";
            this.view_quotes.Size = new System.Drawing.Size(200, 50);
            this.view_quotes.TabIndex = 1;
            this.view_quotes.Text = "View Quotes";
            this.view_quotes.UseVisualStyleBackColor = true;
            this.view_quotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // search_quotes
            // 
            this.search_quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_quotes.Location = new System.Drawing.Point(28, 164);
            this.search_quotes.Name = "search_quotes";
            this.search_quotes.Size = new System.Drawing.Size(200, 50);
            this.search_quotes.TabIndex = 2;
            this.search_quotes.Text = "Search Quotes";
            this.search_quotes.UseVisualStyleBackColor = true;
            this.search_quotes.Click += new System.EventHandler(this.search_quotes_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(28, 220);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 50);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 299);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search_quotes);
            this.Controls.Add(this.view_quotes);
            this.Controls.Add(this.add_new_quote);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_new_quote;
        private System.Windows.Forms.Button view_quotes;
        private System.Windows.Forms.Button search_quotes;
        private System.Windows.Forms.Button exit;
    }
}

