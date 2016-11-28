using CalculatorOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalc
{
    public partial class Calculator : Form
    {

        private CalculatorController cc = new CalculatorController();

        public Calculator()
        {
            InitializeComponent();
        }

        #region Arithmetic functions

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text) && char.IsDigit(tbResult.Text[tbResult.Text.Length - 1]))
                tbResult.Text += "=";
            tbResult.Text = CalculateArithmeticFunction(tbResult.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text) && char.IsDigit(tbResult.Text[tbResult.Text.Length - 1]))
                tbResult.Text += "/";
            CalculateArithmeticFunction(tbResult.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text) && char.IsDigit(tbResult.Text[tbResult.Text.Length - 1]))
                tbResult.Text += "*";
            CalculateArithmeticFunction(tbResult.Text);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text) && char.IsDigit(tbResult.Text[tbResult.Text.Length - 1]))
                tbResult.Text += "-";
            CalculateArithmeticFunction(tbResult.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbResult.Text) && char.IsDigit(tbResult.Text[tbResult.Text.Length - 1]))
                tbResult.Text += "+";
            CalculateArithmeticFunction(tbResult.Text);
        }
        

        #endregion Arithmetic functions

        #region Digit buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btn0.Text);
        }

        #endregion Digit Buttons

        #region Memory buttons

        private void btnMem_Click(object sender, EventArgs e)
        {
            cc.SaveMemory(tbResult.Text);
        }

        private void btnRecallMem_Click(object sender, EventArgs e)
        {
            tbResult.Text = cc.RecallMemory().ToString();
        }

        private void btnClearMem_Click(object sender, EventArgs e)
        {
            cc.ClearMemory();
        }
        #endregion Memory buttons

        #region Other buttons and functions

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            tbResult.AppendText(btnDecimal.Text);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            char[] operationSymbols = { '*', '+', '-', '/', '=' };
            tbHistory.Text = tbHistory.Text.Substring(0, tbHistory.Text.LastIndexOfAny(operationSymbols, tbHistory.Text.Length - 2) + 1);

            cc.UndoOperation();
            tbResult.Text = string.Empty;
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {
            tbResult.BackColor = SystemColors.Window;
        }

        private void tbResult_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                case Keys.Divide:
                case Keys.Multiply:
                case Keys.Subtract: { CalculateArithmeticFunction(tbResult.Text); break; }
                case Keys.Enter: { tbResult.Text = CalculateArithmeticFunction(tbResult.Text + "="); break; }
            }

            SetCursorAtEndOFTextBox();
        }


        private string CalculateArithmeticFunction(string equation)
        {
            if (cc.Validate(equation))
            {
                tbHistory.Text += equation;

                string result = cc.OnOperation(equation).ToString();

                tbResult.Text = string.Empty;
                return result;
            }
            else
            {
                tbResult.BackColor = Color.Red;
                return string.Empty;
            }
        }
        private void SetCursorAtEndOFTextBox()
        {
            if (tbResult.Text.Length > 0)
                tbResult.SelectionStart = tbResult.Text.Length;
        }
        #endregion Other buttons

    }
}
