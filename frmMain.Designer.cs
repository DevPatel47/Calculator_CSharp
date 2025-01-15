namespace Calculator_CSharp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tbx_input = new TextBox();
            btn_openingBracket = new Button();
            btn_closingBracket = new Button();
            btn_clear = new Button();
            btn_divide = new Button();
            btn_number7 = new Button();
            btn_number8 = new Button();
            btn_number9 = new Button();
            btn_multiply = new Button();
            btn_number4 = new Button();
            btn_number5 = new Button();
            btn_number6 = new Button();
            btn_substract = new Button();
            btn_number1 = new Button();
            btn_number2 = new Button();
            btn_number3 = new Button();
            btn_equals = new Button();
            btn_dot = new Button();
            btn_zero = new Button();
            btn_add = new Button();
            btn_backspace = new Button();
            SuspendLayout();
            // 
            // tbx_input
            // 
            tbx_input.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_input.Location = new Point(15, 12);
            tbx_input.Multiline = true;
            tbx_input.Name = "tbx_input";
            tbx_input.Size = new Size(549, 185);
            tbx_input.TabIndex = 0;
            tbx_input.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_openingBracket
            // 
            btn_openingBracket.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_openingBracket.Location = new Point(14, 203);
            btn_openingBracket.Name = "btn_openingBracket";
            btn_openingBracket.Size = new Size(123, 100);
            btn_openingBracket.TabIndex = 1;
            btn_openingBracket.Text = "(";
            btn_openingBracket.UseVisualStyleBackColor = true;
            btn_openingBracket.Click += btn_openingBracket_Click;
            // 
            // btn_closingBracket
            // 
            btn_closingBracket.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_closingBracket.Location = new Point(156, 203);
            btn_closingBracket.Name = "btn_closingBracket";
            btn_closingBracket.Size = new Size(123, 100);
            btn_closingBracket.TabIndex = 2;
            btn_closingBracket.Text = ")";
            btn_closingBracket.UseVisualStyleBackColor = true;
            btn_closingBracket.Click += btn_closingBracket_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_clear.Location = new Point(298, 203);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(123, 100);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_divide
            // 
            btn_divide.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_divide.Location = new Point(13, 309);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(123, 100);
            btn_divide.TabIndex = 5;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_number7
            // 
            btn_number7.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number7.Location = new Point(156, 309);
            btn_number7.Name = "btn_number7";
            btn_number7.Size = new Size(123, 100);
            btn_number7.TabIndex = 6;
            btn_number7.Text = "7";
            btn_number7.UseVisualStyleBackColor = true;
            btn_number7.Click += btn_number7_Click;
            // 
            // btn_number8
            // 
            btn_number8.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number8.Location = new Point(298, 309);
            btn_number8.Name = "btn_number8";
            btn_number8.Size = new Size(123, 100);
            btn_number8.TabIndex = 7;
            btn_number8.Text = "8";
            btn_number8.UseVisualStyleBackColor = true;
            btn_number8.Click += btn_number8_Click;
            // 
            // btn_number9
            // 
            btn_number9.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number9.Location = new Point(440, 309);
            btn_number9.Name = "btn_number9";
            btn_number9.Size = new Size(123, 100);
            btn_number9.TabIndex = 8;
            btn_number9.Text = "9";
            btn_number9.UseVisualStyleBackColor = true;
            btn_number9.Click += btn_number9_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_multiply.Location = new Point(13, 415);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(123, 100);
            btn_multiply.TabIndex = 9;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_number4
            // 
            btn_number4.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number4.Location = new Point(156, 415);
            btn_number4.Name = "btn_number4";
            btn_number4.Size = new Size(123, 100);
            btn_number4.TabIndex = 10;
            btn_number4.Text = "4";
            btn_number4.UseVisualStyleBackColor = true;
            btn_number4.Click += btn_number4_Click;
            // 
            // btn_number5
            // 
            btn_number5.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number5.Location = new Point(298, 415);
            btn_number5.Name = "btn_number5";
            btn_number5.Size = new Size(123, 100);
            btn_number5.TabIndex = 11;
            btn_number5.Text = "5";
            btn_number5.UseVisualStyleBackColor = true;
            btn_number5.Click += btn_number5_Click;
            // 
            // btn_number6
            // 
            btn_number6.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number6.Location = new Point(440, 415);
            btn_number6.Name = "btn_number6";
            btn_number6.Size = new Size(123, 100);
            btn_number6.TabIndex = 12;
            btn_number6.Text = "6";
            btn_number6.UseVisualStyleBackColor = true;
            btn_number6.Click += btn_number6_Click;
            // 
            // btn_substract
            // 
            btn_substract.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_substract.Location = new Point(13, 521);
            btn_substract.Name = "btn_substract";
            btn_substract.Size = new Size(123, 100);
            btn_substract.TabIndex = 13;
            btn_substract.Text = "-";
            btn_substract.UseVisualStyleBackColor = true;
            btn_substract.Click += btn_substract_Click;
            // 
            // btn_number1
            // 
            btn_number1.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number1.Location = new Point(156, 521);
            btn_number1.Name = "btn_number1";
            btn_number1.Size = new Size(123, 100);
            btn_number1.TabIndex = 14;
            btn_number1.Text = "1";
            btn_number1.UseVisualStyleBackColor = true;
            btn_number1.Click += btn_number1_Click;
            // 
            // btn_number2
            // 
            btn_number2.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number2.Location = new Point(298, 521);
            btn_number2.Name = "btn_number2";
            btn_number2.Size = new Size(123, 100);
            btn_number2.TabIndex = 15;
            btn_number2.Text = "2";
            btn_number2.UseVisualStyleBackColor = true;
            btn_number2.Click += btn_number2_Click;
            // 
            // btn_number3
            // 
            btn_number3.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_number3.Location = new Point(440, 521);
            btn_number3.Name = "btn_number3";
            btn_number3.Size = new Size(123, 100);
            btn_number3.TabIndex = 16;
            btn_number3.Text = "3";
            btn_number3.UseVisualStyleBackColor = true;
            btn_number3.Click += btn_number3_Click;
            // 
            // btn_equals
            // 
            btn_equals.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_equals.Location = new Point(440, 627);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(123, 100);
            btn_equals.TabIndex = 20;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = true;
            btn_equals.Click += btn_equals_Click;
            // 
            // btn_dot
            // 
            btn_dot.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_dot.Location = new Point(298, 627);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(123, 100);
            btn_dot.TabIndex = 19;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_zero
            // 
            btn_zero.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_zero.Location = new Point(156, 627);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(123, 100);
            btn_zero.TabIndex = 18;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = true;
            btn_zero.Click += btn_zero_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_add.Location = new Point(13, 627);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(123, 100);
            btn_add.TabIndex = 17;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_backspace
            // 
            btn_backspace.Font = new Font("Segoe UI Semibold", 20.1428585F, FontStyle.Bold);
            btn_backspace.Location = new Point(440, 203);
            btn_backspace.Name = "btn_backspace";
            btn_backspace.Size = new Size(123, 100);
            btn_backspace.TabIndex = 4;
            btn_backspace.Text = "<";
            btn_backspace.UseVisualStyleBackColor = true;
            btn_backspace.Click += btn_backspace_Click;
            // 
            // frmMain
            // 
            AcceptButton = btn_equals;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btn_clear;
            ClientSize = new Size(576, 736);
            Controls.Add(btn_backspace);
            Controls.Add(btn_equals);
            Controls.Add(btn_dot);
            Controls.Add(btn_zero);
            Controls.Add(btn_add);
            Controls.Add(btn_number3);
            Controls.Add(btn_number2);
            Controls.Add(btn_number1);
            Controls.Add(btn_substract);
            Controls.Add(btn_number6);
            Controls.Add(btn_number5);
            Controls.Add(btn_number4);
            Controls.Add(btn_multiply);
            Controls.Add(btn_number9);
            Controls.Add(btn_number8);
            Controls.Add(btn_number7);
            Controls.Add(btn_divide);
            Controls.Add(btn_clear);
            Controls.Add(btn_closingBracket);
            Controls.Add(btn_openingBracket);
            Controls.Add(tbx_input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(600, 800);
            MinimumSize = new Size(600, 800);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator by Dev";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_input;
        private Button btn_openingBracket;
        private Button btn_closingBracket;
        private Button btn_clear;
        private Button btn_divide;
        private Button btn_number7;
        private Button btn_number8;
        private Button btn_number9;
        private Button btn_multiply;
        private Button btn_number4;
        private Button btn_number5;
        private Button btn_number6;
        private Button btn_substract;
        private Button btn_number1;
        private Button btn_number2;
        private Button btn_number3;
        private Button btn_equals;
        private Button btn_dot;
        private Button btn_zero;
        private Button btn_add;
        private Button btn_backspace;
    }
}
