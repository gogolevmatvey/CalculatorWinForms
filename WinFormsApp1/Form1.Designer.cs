namespace CalculatorWinForms
{
    partial class Form1
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
            textBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMul = new Button();
            buttonDiv = new Button();
            buttonSqrt = new Button();
            buttonPercent = new Button();
            buttonInverse = new Button();
            buttonEquality = new Button();
            buttonClear = new Button();
            buttonPoint = new Button();
            buttonSign = new Button();
            buttonClearEntry = new Button();
            buttonBackspace = new Button();
            buttonMemoryRead = new Button();
            buttonMemoryClear = new Button();
            buttonMemorySave = new Button();
            buttonMemoryPlus = new Button();
            memoryLabel = new Label();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = Color.White;
            textBox.Location = new Point(10, 9);
            textBox.Margin = new Padding(3, 2, 3, 2);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(680, 44);
            textBox.TabIndex = 2;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(311, 243);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(44, 30);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DigitClick;
            // 
            // button2
            // 
            button2.Location = new Point(388, 243);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(44, 30);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitClick;
            // 
            // button3
            // 
            button3.Location = new Point(468, 243);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(44, 30);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitClick;
            // 
            // button4
            // 
            button4.Location = new Point(311, 175);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(44, 30);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitClick;
            // 
            // button5
            // 
            button5.Location = new Point(388, 175);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(44, 30);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitClick;
            // 
            // button6
            // 
            button6.Location = new Point(468, 175);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(44, 30);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitClick;
            // 
            // button7
            // 
            button7.Location = new Point(311, 115);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(44, 30);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitClick;
            // 
            // button8
            // 
            button8.Location = new Point(388, 115);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(44, 30);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitClick;
            // 
            // button9
            // 
            button9.Location = new Point(468, 115);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(44, 30);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitClick;
            // 
            // button0
            // 
            button0.Location = new Point(311, 297);
            button0.Margin = new Padding(3, 2, 3, 2);
            button0.Name = "button0";
            button0.Size = new Size(44, 30);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += DigitClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(551, 297);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(44, 30);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += OperationClick;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(551, 243);
            buttonSub.Margin = new Padding(3, 2, 3, 2);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(44, 30);
            buttonSub.TabIndex = 14;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += OperationClick;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(551, 175);
            buttonMul.Margin = new Padding(3, 2, 3, 2);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(44, 30);
            buttonMul.TabIndex = 15;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = true;
            buttonMul.Click += OperationClick;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(551, 115);
            buttonDiv.Margin = new Padding(3, 2, 3, 2);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(44, 30);
            buttonDiv.TabIndex = 16;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += OperationClick;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Location = new Point(629, 115);
            buttonSqrt.Margin = new Padding(3, 2, 3, 2);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(44, 30);
            buttonSqrt.TabIndex = 17;
            buttonSqrt.Text = "sqrt";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += SqrtClick;
            // 
            // buttonPercent
            // 
            buttonPercent.Location = new Point(629, 175);
            buttonPercent.Margin = new Padding(3, 2, 3, 2);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(44, 30);
            buttonPercent.TabIndex = 18;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += PercentClick;
            // 
            // buttonInverse
            // 
            buttonInverse.Location = new Point(629, 243);
            buttonInverse.Margin = new Padding(3, 2, 3, 2);
            buttonInverse.Name = "buttonInverse";
            buttonInverse.Size = new Size(44, 30);
            buttonInverse.TabIndex = 19;
            buttonInverse.Text = "1/x";
            buttonInverse.UseVisualStyleBackColor = true;
            buttonInverse.Click += InverseClick;
            // 
            // buttonEquality
            // 
            buttonEquality.Location = new Point(629, 297);
            buttonEquality.Margin = new Padding(3, 2, 3, 2);
            buttonEquality.Name = "buttonEquality";
            buttonEquality.Size = new Size(44, 30);
            buttonEquality.TabIndex = 20;
            buttonEquality.Text = "=";
            buttonEquality.UseVisualStyleBackColor = true;
            buttonEquality.Click += EqualityClick;
            // 
            // buttonClear
            // 
            buttonClear.ForeColor = Color.Red;
            buttonClear.Location = new Point(613, 73);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 30);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ClearClick;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(468, 297);
            buttonPoint.Margin = new Padding(3, 2, 3, 2);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(44, 30);
            buttonPoint.TabIndex = 22;
            buttonPoint.Text = ",";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += PointClick;
            // 
            // buttonSign
            // 
            buttonSign.Location = new Point(388, 297);
            buttonSign.Margin = new Padding(3, 2, 3, 2);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(44, 30);
            buttonSign.TabIndex = 23;
            buttonSign.Text = "+/-";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += SignClick;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.ForeColor = Color.Red;
            buttonClearEntry.Location = new Point(505, 73);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(75, 30);
            buttonClearEntry.TabIndex = 24;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = true;
            buttonClearEntry.Click += ClearEntryClick;
            // 
            // buttonBackspace
            // 
            buttonBackspace.ForeColor = Color.Red;
            buttonBackspace.Location = new Point(399, 73);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(75, 30);
            buttonBackspace.TabIndex = 25;
            buttonBackspace.Text = "Backspace";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += BackSpaceClick;
            // 
            // buttonMemoryRead
            // 
            buttonMemoryRead.ForeColor = Color.Red;
            buttonMemoryRead.Location = new Point(239, 175);
            buttonMemoryRead.Margin = new Padding(3, 2, 3, 2);
            buttonMemoryRead.Name = "buttonMemoryRead";
            buttonMemoryRead.Size = new Size(44, 30);
            buttonMemoryRead.TabIndex = 26;
            buttonMemoryRead.Text = "MR";
            buttonMemoryRead.UseVisualStyleBackColor = true;
            buttonMemoryRead.Click += MemoryReadClick;
            // 
            // buttonMemoryClear
            // 
            buttonMemoryClear.ForeColor = Color.Red;
            buttonMemoryClear.Location = new Point(239, 115);
            buttonMemoryClear.Margin = new Padding(3, 2, 3, 2);
            buttonMemoryClear.Name = "buttonMemoryClear";
            buttonMemoryClear.Size = new Size(44, 30);
            buttonMemoryClear.TabIndex = 27;
            buttonMemoryClear.Text = "MC";
            buttonMemoryClear.UseVisualStyleBackColor = true;
            buttonMemoryClear.Click += MemoryClearClick;
            // 
            // buttonMemorySave
            // 
            buttonMemorySave.ForeColor = Color.Red;
            buttonMemorySave.Location = new Point(239, 243);
            buttonMemorySave.Margin = new Padding(3, 2, 3, 2);
            buttonMemorySave.Name = "buttonMemorySave";
            buttonMemorySave.Size = new Size(44, 30);
            buttonMemorySave.TabIndex = 28;
            buttonMemorySave.Text = "MS";
            buttonMemorySave.UseVisualStyleBackColor = true;
            buttonMemorySave.Click += MemorySaveClick;
            // 
            // buttonMemoryPlus
            // 
            buttonMemoryPlus.ForeColor = Color.Red;
            buttonMemoryPlus.Location = new Point(239, 297);
            buttonMemoryPlus.Margin = new Padding(3, 2, 3, 2);
            buttonMemoryPlus.Name = "buttonMemoryPlus";
            buttonMemoryPlus.Size = new Size(44, 30);
            buttonMemoryPlus.TabIndex = 29;
            buttonMemoryPlus.Text = "M+";
            buttonMemoryPlus.UseVisualStyleBackColor = true;
            buttonMemoryPlus.Click += MemoryPlusClick;
            // 
            // memoryLabel
            // 
            memoryLabel.AutoSize = true;
            memoryLabel.BorderStyle = BorderStyle.Fixed3D;
            memoryLabel.Location = new Point(251, 81);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new Size(2, 17);
            memoryLabel.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(710, 338);
            Controls.Add(memoryLabel);
            Controls.Add(buttonMemoryPlus);
            Controls.Add(buttonMemorySave);
            Controls.Add(buttonMemoryClear);
            Controls.Add(buttonMemoryRead);
            Controls.Add(buttonBackspace);
            Controls.Add(buttonClearEntry);
            Controls.Add(buttonSign);
            Controls.Add(buttonPoint);
            Controls.Add(buttonClear);
            Controls.Add(buttonEquality);
            Controls.Add(buttonInverse);
            Controls.Add(buttonPercent);
            Controls.Add(buttonSqrt);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMul);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMul;
        private Button buttonDiv;
        private Button buttonSqrt;
        private Button buttonPercent;
        private Button buttonInverse;
        private Button buttonEquality;
        private Button buttonClear;
        private Button buttonPoint;
        private Button buttonSign;
        private Button buttonClearEntry;
        private Button buttonBackspace;
        private Button buttonMemoryRead;
        private Button buttonMemoryClear;
        private Button buttonMemorySave;
        private Button buttonMemoryPlus;
        private Label memoryLabel;
    }
}
