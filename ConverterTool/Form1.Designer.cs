namespace ConverterTool
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
            this.btn_select_file = new System.Windows.Forms.Button();
            this.lb_chosen_file = new System.Windows.Forms.ListBox();
            this.clb_conversion_options = new System.Windows.Forms.CheckedListBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.txtbox_step_2_instructions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_select_file
            // 
            this.btn_select_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_file.Location = new System.Drawing.Point(57, 113);
            this.btn_select_file.Margin = new System.Windows.Forms.Padding(1);
            this.btn_select_file.Name = "btn_select_file";
            this.btn_select_file.Size = new System.Drawing.Size(205, 86);
            this.btn_select_file.TabIndex = 0;
            this.btn_select_file.Text = "Step 1: Choose File to Convert";
            this.btn_select_file.UseVisualStyleBackColor = true;
            this.btn_select_file.Click += new System.EventHandler(this.btn_select_file_Click);
            // 
            // lb_chosen_file
            // 
            this.lb_chosen_file.FormattingEnabled = true;
            this.lb_chosen_file.Location = new System.Drawing.Point(57, 230);
            this.lb_chosen_file.Name = "lb_chosen_file";
            this.lb_chosen_file.Size = new System.Drawing.Size(205, 160);
            this.lb_chosen_file.TabIndex = 1;
            // 
            // clb_conversion_options
            // 
            this.clb_conversion_options.FormattingEnabled = true;
            this.clb_conversion_options.Location = new System.Drawing.Point(354, 215);
            this.clb_conversion_options.Name = "clb_conversion_options";
            this.clb_conversion_options.Size = new System.Drawing.Size(205, 94);
            this.clb_conversion_options.TabIndex = 2;
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.Location = new System.Drawing.Point(319, 325);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(271, 86);
            this.btn_convert.TabIndex = 3;
            this.btn_convert.Text = "Perform Conversion";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // txtbox_step_2_instructions
            // 
            this.txtbox_step_2_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_step_2_instructions.Location = new System.Drawing.Point(319, 113);
            this.txtbox_step_2_instructions.Multiline = true;
            this.txtbox_step_2_instructions.Name = "txtbox_step_2_instructions";
            this.txtbox_step_2_instructions.ReadOnly = true;
            this.txtbox_step_2_instructions.Size = new System.Drawing.Size(271, 86);
            this.txtbox_step_2_instructions.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 476);
            this.Controls.Add(this.txtbox_step_2_instructions);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.clb_conversion_options);
            this.Controls.Add(this.lb_chosen_file);
            this.Controls.Add(this.btn_select_file);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select_file;
        private System.Windows.Forms.ListBox lb_chosen_file;
        private System.Windows.Forms.CheckedListBox clb_conversion_options;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.TextBox txtbox_step_2_instructions;
    }
}

