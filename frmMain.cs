// *************************************************************
// Project: Calculator_CSharp
// File: frmMain.cs
// Description: This is the main form of a simple calculator application
//              that handles basic arithmetic operations (addition, subtraction,
//              multiplication, division) and supports parentheses and decimals.
//              Users can enter mathematical expressions and calculate the result.
//
// Author: Dev Patel
// Date: January 15, 2025
// Version: 1.0
// *************************************************************


using System.Data;  // For evaluating mathematical expressions
using System.Linq.Expressions;  // Not used in this code, but can be helpful for more complex expression evaluation

namespace Calculator_CSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();  // Initializes the components of the form
        }

        // Event handler for when the '0' button is clicked
        private void btn_zero_Click(object sender, EventArgs e)
        {
            buttonClick(btn_zero);  // Appends '0' to the input textbox
        }

        // General method to handle button click for any numeric or operator button
        private void buttonClick(Button btn)
        {
            if (btn != null)  // Ensure the button is not null
            {
                tbx_input.Text = tbx_input.Text + btn.Text;  // Append the button's text to the input field
            }
        }

        // Event handlers for number buttons (1 to 9)
        private void btn_number1_Click(object sender, EventArgs e) { buttonClick(btn_number1); }
        private void btn_number2_Click(object sender, EventArgs e) { buttonClick(btn_number2); }
        private void btn_number3_Click(object sender, EventArgs e) { buttonClick(btn_number3); }
        private void btn_number4_Click(object sender, EventArgs e) { buttonClick(btn_number4); }
        private void btn_number5_Click(object sender, EventArgs e) { buttonClick(btn_number5); }
        private void btn_number6_Click(object sender, EventArgs e) { buttonClick(btn_number6); }
        private void btn_number7_Click(object sender, EventArgs e) { buttonClick(btn_number7); }
        private void btn_number8_Click(object sender, EventArgs e) { buttonClick(btn_number8); }
        private void btn_number9_Click(object sender, EventArgs e) { buttonClick(btn_number9); }

        // Event handler for the 'Clear' button (clears the input)
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_input.Clear();  // Clears the input textbox
        }

        // Event handlers for operator buttons
        private void btn_add_Click(object sender, EventArgs e) { buttonClick(btn_add); }
        private void btn_substract_Click(object sender, EventArgs e) { buttonClick(btn_substract); }
        private void btn_multiply_Click(object sender, EventArgs e) { buttonClick(btn_multiply); }
        private void btn_divide_Click(object sender, EventArgs e) { buttonClick(btn_divide); }

        // Event handler for opening parenthesis button
        private void btn_openingBracket_Click(object sender, EventArgs e)
        {
            buttonClick(btn_openingBracket);  // Adds '(' to the input
        }

        // Event handler for closing parenthesis button
        private void btn_closingBracket_Click(object sender, EventArgs e)
        {
            int numberOfOpeningBracket = 0;
            int numberOfClosingBracket = 0;

            // Loop through the current input and count the brackets
            foreach (char text in tbx_input.Text)
            {
                if (text.ToString() == "(") { numberOfOpeningBracket++; }
                if (text.ToString() == ")") { numberOfClosingBracket++; }
            }

            // If there are more opening brackets, add a closing bracket
            if (numberOfOpeningBracket > numberOfClosingBracket)
            {
                buttonClick(btn_closingBracket);  // Adds ')' to the input
            }
        }

        // Event handler for the decimal point button
        private void btn_dot_Click(object sender, EventArgs e)
        {
            buttonClick(btn_dot);  // Appends '.' to the input
        }

        // Event handler for the 'Equals' button (calculates the result of the expression)
        private void btn_equals_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the expression from the textbox
                string expression = tbx_input.Text;

                // Use DataTable to evaluate the mathematical expression
                DataTable table = new DataTable();
                object result = table.Compute(expression, string.Empty);

                // Display the result in the textbox
                tbx_input.Text = result.ToString();
            }
            catch (Exception ex)
            {
                // Display error if the expression is invalid (e.g., syntax errors)
                MessageBox.Show("Invalid expression! Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx_input.Clear();  // Clear the input field
            }
        }

        // Event handler for the 'Backspace' button (removes the last character from input)
        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_input.Text))  // Ensure input is not empty
            {
                tbx_input.Text = tbx_input.Text.Substring(0, tbx_input.Text.Length - 1);  // Remove the last character
            }
        }
    }
}
