
namespace MegaDesk_Bear
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.return1 = new System.Windows.Forms.Button();
            this.width_label = new System.Windows.Forms.Label();
            this.depth_label = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.Label();
            this.num_drawers_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desktop_material_label = new System.Windows.Forms.Label();
            this.rush_order_label = new System.Windows.Forms.Label();
            this.desktop_material = new System.Windows.Forms.ListBox();
            this.rush_order = new System.Windows.Forms.ListBox();
            this.num_drawers_1 = new System.Windows.Forms.NumericUpDown();
            this.desk_width_1 = new System.Windows.Forms.TextBox();
            this.desk_depth_1 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.customer_name_value = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_drawers_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // return1
            // 
            this.return1.Location = new System.Drawing.Point(336, 434);
            this.return1.Name = "return1";
            this.return1.Size = new System.Drawing.Size(75, 23);
            this.return1.TabIndex = 0;
            this.return1.Text = "Return";
            this.return1.UseVisualStyleBackColor = true;
            this.return1.Click += new System.EventHandler(this.return1_Click);
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(168, 83);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(105, 24);
            this.width_label.TabIndex = 1;
            this.width_label.Text = "Desk Width";
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth_label.Location = new System.Drawing.Point(164, 113);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(107, 24);
            this.depth_label.TabIndex = 2;
            this.depth_label.Text = "Desk Depth";
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(106, 23);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(147, 24);
            this.customer_name.TabIndex = 3;
            this.customer_name.Text = "Customer Name";
            // 
            // num_drawers_label
            // 
            this.num_drawers_label.AutoSize = true;
            this.num_drawers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_drawers_label.Location = new System.Drawing.Point(100, 148);
            this.num_drawers_label.Name = "num_drawers_label";
            this.num_drawers_label.Size = new System.Drawing.Size(173, 24);
            this.num_drawers_label.TabIndex = 4;
            this.num_drawers_label.Text = "Number of Drawers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 5;
            // 
            // desktop_material_label
            // 
            this.desktop_material_label.AutoSize = true;
            this.desktop_material_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktop_material_label.Location = new System.Drawing.Point(125, 182);
            this.desktop_material_label.Name = "desktop_material_label";
            this.desktop_material_label.Size = new System.Drawing.Size(148, 24);
            this.desktop_material_label.TabIndex = 6;
            this.desktop_material_label.Text = "Desktop Material";
            // 
            // rush_order_label
            // 
            this.rush_order_label.AutoSize = true;
            this.rush_order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rush_order_label.Location = new System.Drawing.Point(82, 316);
            this.rush_order_label.Name = "rush_order_label";
            this.rush_order_label.Size = new System.Drawing.Size(191, 24);
            this.rush_order_label.TabIndex = 7;
            this.rush_order_label.Text = "Rush Order Selection";
            // 
            // desktop_material
            // 
            this.desktop_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktop_material.FormattingEnabled = true;
            this.desktop_material.ItemHeight = 24;
            this.desktop_material.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.desktop_material.Location = new System.Drawing.Point(291, 182);
            this.desktop_material.Name = "desktop_material";
            this.desktop_material.Size = new System.Drawing.Size(120, 124);
            this.desktop_material.TabIndex = 13;
       
            // 
            // rush_order
            // 
            this.rush_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rush_order.FormattingEnabled = true;
            this.rush_order.ItemHeight = 24;
            this.rush_order.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.rush_order.Location = new System.Drawing.Point(291, 316);
            this.rush_order.Name = "rush_order";
            this.rush_order.Size = new System.Drawing.Size(120, 28);
            this.rush_order.TabIndex = 17;
            // 
            // num_drawers_1
            // 
            this.num_drawers_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_drawers_1.Location = new System.Drawing.Point(291, 148);
            this.num_drawers_1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_drawers_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_drawers_1.Name = "num_drawers_1";
            this.num_drawers_1.Size = new System.Drawing.Size(120, 29);
            this.num_drawers_1.TabIndex = 18;
            this.num_drawers_1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // desk_width_1
            // 
            this.desk_width_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desk_width_1.Location = new System.Drawing.Point(291, 80);
            this.desk_width_1.Name = "desk_width_1";
            this.desk_width_1.Size = new System.Drawing.Size(120, 29);
            this.desk_width_1.TabIndex = 19;
            this.desk_width_1.Validating += new System.ComponentModel.CancelEventHandler(this.desk_width_1_Validating);
            // 
            // desk_depth_1
            // 
            this.desk_depth_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desk_depth_1.Location = new System.Drawing.Point(291, 115);
            this.desk_depth_1.Name = "desk_depth_1";
            this.desk_depth_1.Size = new System.Drawing.Size(120, 29);
            this.desk_depth_1.TabIndex = 20;
            this.desk_depth_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desk_depth_1_KeyPress);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(263, 371);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(148, 36);
            this.calculate.TabIndex = 21;
            this.calculate.Text = "Calculate Cost";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click_1);
            // 
            // customer_name_value
            // 
            this.customer_name_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_value.Location = new System.Drawing.Point(259, 23);
            this.customer_name_value.Name = "customer_name_value";
            this.customer_name_value.Size = new System.Drawing.Size(152, 29);
            this.customer_name_value.TabIndex = 22;
            this.customer_name_value.Validating += new System.ComponentModel.CancelEventHandler(this.customer_name_value_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 469);
            this.Controls.Add(this.customer_name_value);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.desk_depth_1);
            this.Controls.Add(this.desk_width_1);
            this.Controls.Add(this.num_drawers_1);
            this.Controls.Add(this.rush_order);
            this.Controls.Add(this.desktop_material);
            this.Controls.Add(this.rush_order_label);
            this.Controls.Add(this.desktop_material_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_drawers_label);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.depth_label);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.return1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.num_drawers_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return1;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.Label num_drawers_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label desktop_material_label;
        private System.Windows.Forms.Label rush_order_label;
        private System.Windows.Forms.ListBox desktop_material;
        private System.Windows.Forms.ListBox rush_order;
        private System.Windows.Forms.NumericUpDown num_drawers_1;
        private System.Windows.Forms.TextBox desk_width_1;
        private System.Windows.Forms.TextBox desk_depth_1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox customer_name_value;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}