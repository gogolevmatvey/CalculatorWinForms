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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            textBox.Location = new Point(11, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(524, 57);
            textBox.TabIndex = 2;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(103, 317);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DigitClick;
            // 
            // button2
            // 
            button2.Location = new Point(191, 317);
            button2.Name = "button2";
            button2.Size = new Size(50, 40);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitClick;
            // 
            // button3
            // 
            button3.Location = new Point(283, 317);
            button3.Name = "button3";
            button3.Size = new Size(50, 40);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitClick;
            // 
            // button4
            // 
            button4.Location = new Point(103, 226);
            button4.Name = "button4";
            button4.Size = new Size(50, 40);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitClick;
            // 
            // button5
            // 
            button5.Location = new Point(191, 226);
            button5.Name = "button5";
            button5.Size = new Size(50, 40);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitClick;
            // 
            // button6
            // 
            button6.Location = new Point(283, 226);
            button6.Name = "button6";
            button6.Size = new Size(50, 40);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitClick;
            // 
            // button7
            // 
            button7.Location = new Point(103, 146);
            button7.Name = "button7";
            button7.Size = new Size(50, 40);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitClick;
            // 
            // button8
            // 
            button8.Location = new Point(191, 146);
            button8.Name = "button8";
            button8.Size = new Size(50, 40);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitClick;
            // 
            // button9
            // 
            button9.Location = new Point(283, 146);
            button9.Name = "button9";
            button9.Size = new Size(50, 40);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitClick;
            // 
            // button0
            // 
            button0.Location = new Point(103, 389);
            button0.Name = "button0";
            button0.Size = new Size(50, 40);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += DigitClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(378, 389);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 40);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += OperationClick;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(378, 317);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(50, 40);
            buttonSub.TabIndex = 14;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += OperationClick;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(378, 226);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(50, 40);
            buttonMul.TabIndex = 15;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = true;
            buttonMul.Click += OperationClick;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(378, 146);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(50, 40);
            buttonDiv.TabIndex = 16;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += OperationClick;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Location = new Point(467, 146);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(50, 40);
            buttonSqrt.TabIndex = 17;
            buttonSqrt.Text = "sqrt";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += SqrtClick;
            // 
            // buttonPercent
            // 
            buttonPercent.Location = new Point(467, 226);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(50, 40);
            buttonPercent.TabIndex = 18;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += PercentClick;
            // 
            // buttonInverse
            // 
            buttonInverse.Location = new Point(467, 317);
            buttonInverse.Name = "buttonInverse";
            buttonInverse.Size = new Size(50, 40);
            buttonInverse.TabIndex = 19;
            buttonInverse.Text = "1/x";
            buttonInverse.UseVisualStyleBackColor = true;
            buttonInverse.Click += InverseClick;
            // 
            // buttonEquality
            // 
            buttonEquality.Location = new Point(467, 389);
            buttonEquality.Name = "buttonEquality";
            buttonEquality.Size = new Size(50, 40);
            buttonEquality.TabIndex = 20;
            buttonEquality.Text = "=";
            buttonEquality.UseVisualStyleBackColor = true;
            buttonEquality.Click += EqualityClick;
            // 
            // buttonClear
            // 
            buttonClear.ForeColor = Color.Red;
            buttonClear.Location = new Point(449, 90);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(86, 40);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ClearClick;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(283, 389);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(50, 40);
            buttonPoint.TabIndex = 22;
            buttonPoint.Text = ",";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += PointClick;
            // 
            // buttonSign
            // 
            buttonSign.Location = new Point(191, 389);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(50, 40);
            buttonSign.TabIndex = 23;
            buttonSign.Text = "+/-";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += SignClick;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.ForeColor = Color.Red;
            buttonClearEntry.Location = new Point(325, 90);
            buttonClearEntry.Margin = new Padding(3, 4, 3, 4);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(86, 40);
            buttonClearEntry.TabIndex = 24;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = true;
            buttonClearEntry.Click += ClearEntryClick;
            // 
            // buttonBackspace
            // 
            buttonBackspace.ForeColor = Color.Red;
            buttonBackspace.Location = new Point(204, 90);
            buttonBackspace.Margin = new Padding(3, 4, 3, 4);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(86, 40);
            buttonBackspace.TabIndex = 25;
            buttonBackspace.Text = "Backspace";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += BackSpaceClick;
            // 
            // buttonMemoryRead
            // 
            buttonMemoryRead.ForeColor = Color.Red;
            buttonMemoryRead.Location = new Point(21, 226);
            buttonMemoryRead.Name = "buttonMemoryRead";
            buttonMemoryRead.Size = new Size(50, 40);
            buttonMemoryRead.TabIndex = 26;
            buttonMemoryRead.Text = "MR";
            buttonMemoryRead.UseVisualStyleBackColor = true;
            buttonMemoryRead.Click += MemoryReadClick;
            // 
            // buttonMemoryClear
            // 
            buttonMemoryClear.ForeColor = Color.Red;
            buttonMemoryClear.Location = new Point(21, 146);
            buttonMemoryClear.Name = "buttonMemoryClear";
            buttonMemoryClear.Size = new Size(50, 40);
            buttonMemoryClear.TabIndex = 27;
            buttonMemoryClear.Text = "MC";
            buttonMemoryClear.UseVisualStyleBackColor = true;
            buttonMemoryClear.Click += MemoryClearClick;
            // 
            // buttonMemorySave
            // 
            buttonMemorySave.ForeColor = Color.Red;
            buttonMemorySave.Location = new Point(21, 317);
            buttonMemorySave.Name = "buttonMemorySave";
            buttonMemorySave.Size = new Size(50, 40);
            buttonMemorySave.TabIndex = 28;
            buttonMemorySave.Text = "MS";
            buttonMemorySave.UseVisualStyleBackColor = true;
            buttonMemorySave.Click += MemorySaveClick;
            // 
            // buttonMemoryPlus
            // 
            buttonMemoryPlus.ForeColor = Color.Red;
            buttonMemoryPlus.Location = new Point(21, 389);
            buttonMemoryPlus.Name = "buttonMemoryPlus";
            buttonMemoryPlus.Size = new Size(50, 40);
            buttonMemoryPlus.TabIndex = 29;
            buttonMemoryPlus.Text = "M+";
            buttonMemoryPlus.UseVisualStyleBackColor = true;
            buttonMemoryPlus.Click += MemoryPlusClick;
            // 
            // memoryLabel
            // 
            memoryLabel.AutoSize = true;
            memoryLabel.BorderStyle = BorderStyle.Fixed3D;
            memoryLabel.Location = new Point(35, 101);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new Size(2, 22);
            memoryLabel.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(554, 451);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
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
