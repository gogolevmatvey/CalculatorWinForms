

namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        double argument1 = 0;
        double argument2 = 0;
        string selectedOperation = "";
        bool isOperationClicked = false;
        bool isErrorOccured = false;
        string memory = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DigitClick(object sender, EventArgs e)
        {
            if (isOperationClicked || isErrorOccured)
            {
                textBox.Clear();
                isErrorOccured = false;
                isOperationClicked = false;
            }           
            Button pressedButton = (Button)sender;
            textBox.Text += pressedButton.Text;
            textBox.Text = double.Parse(textBox.Text).ToString();
        }

        private void PointClick(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains(","))
                textBox.Text += ",";
        }

        private void SignClick(object sender, EventArgs e)
        {
            bool isParsed = double.TryParse(textBox.Text, out double parsedNumber);
            if (isParsed)
            {
                textBox.Text = (-parsedNumber).ToString();
            }
             
        }

        private void OperationClick(object sender, EventArgs e)
        {
                argument1 = double.Parse(textBox.Text);
                Button pressedButton = (Button)sender;
                selectedOperation = pressedButton.Text;
                isOperationClicked = true;         
        }

        private void SqrtClick(object sender, EventArgs e)
        {
            textBox.Text = Math.Sqrt(double.Parse(textBox.Text)).ToString();
            //textBox.Text = Math.Sqrt(double.Parse(textBox.Text)).ToString();
        }

        private void PercentClick(object sender, EventArgs e)
        {
            if (argument2 == 0)
            {
                argument2 = double.Parse(textBox.Text);
            }

            double result = (argument1 * argument2) / 100;
            argument2 = result;
            textBox.Text = result.ToString();
        }

        private void InverseClick(object sender, EventArgs e)
        {
            textBox.Text = (1 / double.Parse(textBox.Text)).ToString();
        }

        private void EqualityClick(object sender, EventArgs e)
        {
            if (argument2 == 0)
            {
                argument2 = double.Parse(textBox.Text);
            }
            double result;

            switch (selectedOperation)
            {            
                case "+":                
                    result = argument1 + argument2;
                    argument1 = result;
                    textBox.Text = result.ToString();
                    break;
                case "-":
                    result = argument1 - argument2;
                    argument1 = result;
                    textBox.Text = result.ToString();
                    break;
                case "*":
                    result = argument1 * argument2;
                    argument1 = result;
                    textBox.Text = result.ToString();
                    break;
                case "/":
                    try
                    {
                        result = argument1 / argument2;
                        argument1 = result;
                        textBox.Text = result.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBox.Text = "Cannot divide by zero";
                        isErrorOccured = true;
                    }
                    break;
            }
        }


        private void ClearClick(object sender, EventArgs e)
        {
            textBox.Text = "0";
            argument1 = 0;
            argument2 = 0;
            selectedOperation = "";
            memory = "";
            isOperationClicked = false;
            isErrorOccured = false;

            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }

        private void ClearEntryClick(object sender, EventArgs e)
        {
            textBox.Text = "0";

            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }

        }

        private void BackSpaceClick(object sender, EventArgs e)
        {
            string lastSymbol = textBox.Text[textBox.Text.Length - 1].ToString();

            // Проверка является ли последний символ числом или запятой
            bool isLastSymbolRemovable = double.TryParse(lastSymbol, out double output);
            if (!isLastSymbolRemovable) 
            {
                if (lastSymbol == ",") 
                    isLastSymbolRemovable = true;
            }

            if (isLastSymbolRemovable)
            {
                if (textBox.Text != "0" && textBox.Text.Length != 1)
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                else if (textBox.Text.Length == 1)
                    textBox.Text = "0";
            }
        }

        private void MemoryReadClick(object sender, EventArgs e)
        {
            textBox.Text = memory;
        }

        private void MemoryClearClick(object sender, EventArgs e)
        {
            memory = "";
            memoryLabel.Text = "";
        }

        private void MemorySaveClick(object sender, EventArgs e)
        {
            bool isTextANumber = double.TryParse(textBox.Text, out double output);
            if (isTextANumber)
            {
                memory = textBox.Text;
                memoryLabel.Text = "M";
                isOperationClicked = true;
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }
                buttonClear.Enabled = true;
                buttonClearEntry.Enabled = true;
            }
        }

        private void MemoryPlusClick(object sender, EventArgs e)
        {
            memory = (double.Parse(memory) + double.Parse(textBox.Text)).ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
