namespace xLib
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
            this.ConstExpressionTextBox = new System.Windows.Forms.TextBox();
            this.ListExpresstionTextBox = new System.Windows.Forms.TextBox();
            this.ConstExpression = new System.Windows.Forms.Label();
            this.DeriveButton = new System.Windows.Forms.Button();
            this.MonomialExpression = new System.Windows.Forms.Label();
            this.MonomialExpressionTextBox = new System.Windows.Forms.TextBox();
            this.BinaryExpression1 = new System.Windows.Forms.Label();
            this.BinaryExpression1TextBox = new System.Windows.Forms.TextBox();
            this.BinaryExpression2 = new System.Windows.Forms.Label();
            this.BinaryExpression2TextBox = new System.Windows.Forms.TextBox();
            this.EvaluateButton = new System.Windows.Forms.Button();
            this.InfixNotationButton = new System.Windows.Forms.Button();
            this.PostfixNotationButton = new System.Windows.Forms.Button();
            this.PrefixNotationButton = new System.Windows.Forms.Button();
            this.Operator = new System.Windows.Forms.Label();
            this.OperatorTextBox = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.XValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConstExpressionTextBox
            // 
            this.ConstExpressionTextBox.Location = new System.Drawing.Point(39, 68);
            this.ConstExpressionTextBox.Name = "ConstExpressionTextBox";
            this.ConstExpressionTextBox.Size = new System.Drawing.Size(125, 20);
            this.ConstExpressionTextBox.TabIndex = 0;
            this.ConstExpressionTextBox.Text = "5";
            // 
            // ListExpresstionTextBox
            // 
            this.ListExpresstionTextBox.Location = new System.Drawing.Point(522, 68);
            this.ListExpresstionTextBox.Multiline = true;
            this.ListExpresstionTextBox.Name = "ListExpresstionTextBox";
            this.ListExpresstionTextBox.Size = new System.Drawing.Size(232, 272);
            this.ListExpresstionTextBox.TabIndex = 2;
            // 
            // ConstExpression
            // 
            this.ConstExpression.AutoSize = true;
            this.ConstExpression.Location = new System.Drawing.Point(36, 47);
            this.ConstExpression.Name = "ConstExpression";
            this.ConstExpression.Size = new System.Drawing.Size(88, 13);
            this.ConstExpression.TabIndex = 3;
            this.ConstExpression.Text = "Const Expression";
            // 
            // DeriveButton
            // 
            this.DeriveButton.Location = new System.Drawing.Point(39, 266);
            this.DeriveButton.Name = "DeriveButton";
            this.DeriveButton.Size = new System.Drawing.Size(75, 23);
            this.DeriveButton.TabIndex = 4;
            this.DeriveButton.Text = "Derive";
            this.DeriveButton.UseVisualStyleBackColor = true;
            this.DeriveButton.Click += new System.EventHandler(this.DeriveButton_Click);
            // 
            // MonomialExpression
            // 
            this.MonomialExpression.AutoSize = true;
            this.MonomialExpression.Location = new System.Drawing.Point(36, 115);
            this.MonomialExpression.Name = "MonomialExpression";
            this.MonomialExpression.Size = new System.Drawing.Size(106, 13);
            this.MonomialExpression.TabIndex = 6;
            this.MonomialExpression.Text = "Monomial Expression";
            // 
            // MonomialExpressionTextBox
            // 
            this.MonomialExpressionTextBox.Location = new System.Drawing.Point(39, 136);
            this.MonomialExpressionTextBox.Name = "MonomialExpressionTextBox";
            this.MonomialExpressionTextBox.Size = new System.Drawing.Size(125, 20);
            this.MonomialExpressionTextBox.TabIndex = 5;
            this.MonomialExpressionTextBox.Text = "5x4";
            // 
            // BinaryExpression1
            // 
            this.BinaryExpression1.AutoSize = true;
            this.BinaryExpression1.Location = new System.Drawing.Point(36, 186);
            this.BinaryExpression1.Name = "BinaryExpression1";
            this.BinaryExpression1.Size = new System.Drawing.Size(99, 13);
            this.BinaryExpression1.TabIndex = 8;
            this.BinaryExpression1.Text = "Binary Expression 1";
            // 
            // BinaryExpression1TextBox
            // 
            this.BinaryExpression1TextBox.Location = new System.Drawing.Point(39, 207);
            this.BinaryExpression1TextBox.Name = "BinaryExpression1TextBox";
            this.BinaryExpression1TextBox.Size = new System.Drawing.Size(125, 20);
            this.BinaryExpression1TextBox.TabIndex = 7;
            this.BinaryExpression1TextBox.Text = "7x5";
            // 
            // BinaryExpression2
            // 
            this.BinaryExpression2.AutoSize = true;
            this.BinaryExpression2.Location = new System.Drawing.Point(316, 186);
            this.BinaryExpression2.Name = "BinaryExpression2";
            this.BinaryExpression2.Size = new System.Drawing.Size(99, 13);
            this.BinaryExpression2.TabIndex = 10;
            this.BinaryExpression2.Text = "Binary Expression 2";
            // 
            // BinaryExpression2TextBox
            // 
            this.BinaryExpression2TextBox.Location = new System.Drawing.Point(319, 207);
            this.BinaryExpression2TextBox.Name = "BinaryExpression2TextBox";
            this.BinaryExpression2TextBox.Size = new System.Drawing.Size(125, 20);
            this.BinaryExpression2TextBox.TabIndex = 9;
            this.BinaryExpression2TextBox.Text = "13";
            // 
            // EvaluateButton
            // 
            this.EvaluateButton.Location = new System.Drawing.Point(139, 266);
            this.EvaluateButton.Name = "EvaluateButton";
            this.EvaluateButton.Size = new System.Drawing.Size(75, 23);
            this.EvaluateButton.TabIndex = 11;
            this.EvaluateButton.Text = "Evaluate";
            this.EvaluateButton.UseVisualStyleBackColor = true;
            this.EvaluateButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // InfixNotationButton
            // 
            this.InfixNotationButton.Location = new System.Drawing.Point(39, 317);
            this.InfixNotationButton.Name = "InfixNotationButton";
            this.InfixNotationButton.Size = new System.Drawing.Size(75, 23);
            this.InfixNotationButton.TabIndex = 12;
            this.InfixNotationButton.Text = "Infix";
            this.InfixNotationButton.UseVisualStyleBackColor = true;
            this.InfixNotationButton.Click += new System.EventHandler(this.InfixNotationButton_Click);
            // 
            // PostfixNotationButton
            // 
            this.PostfixNotationButton.Location = new System.Drawing.Point(139, 317);
            this.PostfixNotationButton.Name = "PostfixNotationButton";
            this.PostfixNotationButton.Size = new System.Drawing.Size(75, 23);
            this.PostfixNotationButton.TabIndex = 13;
            this.PostfixNotationButton.Text = "Postfix";
            this.PostfixNotationButton.UseVisualStyleBackColor = true;
            this.PostfixNotationButton.Click += new System.EventHandler(this.PostfixNotationButton_Click);
            // 
            // PrefixNotationButton
            // 
            this.PrefixNotationButton.Location = new System.Drawing.Point(244, 317);
            this.PrefixNotationButton.Name = "PrefixNotationButton";
            this.PrefixNotationButton.Size = new System.Drawing.Size(75, 23);
            this.PrefixNotationButton.TabIndex = 14;
            this.PrefixNotationButton.Text = "Prefix";
            this.PrefixNotationButton.UseVisualStyleBackColor = true;
            this.PrefixNotationButton.Click += new System.EventHandler(this.PrefixNotationButton_Click);
            // 
            // Operator
            // 
            this.Operator.AutoSize = true;
            this.Operator.Location = new System.Drawing.Point(207, 186);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(48, 13);
            this.Operator.TabIndex = 16;
            this.Operator.Text = "Operator";
            // 
            // OperatorTextBox
            // 
            this.OperatorTextBox.Location = new System.Drawing.Point(210, 207);
            this.OperatorTextBox.Name = "OperatorTextBox";
            this.OperatorTextBox.Size = new System.Drawing.Size(59, 20);
            this.OperatorTextBox.TabIndex = 15;
            this.OperatorTextBox.Text = "+";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(241, 271);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(23, 13);
            this.X.TabIndex = 18;
            this.X.Text = "X =";
            // 
            // XValueTextBox
            // 
            this.XValueTextBox.Location = new System.Drawing.Point(270, 268);
            this.XValueTextBox.Name = "XValueTextBox";
            this.XValueTextBox.Size = new System.Drawing.Size(59, 20);
            this.XValueTextBox.TabIndex = 17;
            this.XValueTextBox.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.X);
            this.Controls.Add(this.XValueTextBox);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.OperatorTextBox);
            this.Controls.Add(this.PrefixNotationButton);
            this.Controls.Add(this.PostfixNotationButton);
            this.Controls.Add(this.InfixNotationButton);
            this.Controls.Add(this.EvaluateButton);
            this.Controls.Add(this.BinaryExpression2);
            this.Controls.Add(this.BinaryExpression2TextBox);
            this.Controls.Add(this.BinaryExpression1);
            this.Controls.Add(this.BinaryExpression1TextBox);
            this.Controls.Add(this.MonomialExpression);
            this.Controls.Add(this.MonomialExpressionTextBox);
            this.Controls.Add(this.DeriveButton);
            this.Controls.Add(this.ConstExpression);
            this.Controls.Add(this.ListExpresstionTextBox);
            this.Controls.Add(this.ConstExpressionTextBox);
            this.Name = "Form1";
            this.Text = "My Expression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConstExpressionTextBox;
        private System.Windows.Forms.TextBox ListExpresstionTextBox;
        private System.Windows.Forms.Label ConstExpression;
        private System.Windows.Forms.Button DeriveButton;
        private System.Windows.Forms.Label MonomialExpression;
        private System.Windows.Forms.TextBox MonomialExpressionTextBox;
        private System.Windows.Forms.Label BinaryExpression1;
        private System.Windows.Forms.TextBox BinaryExpression1TextBox;
        private System.Windows.Forms.Label BinaryExpression2;
        private System.Windows.Forms.TextBox BinaryExpression2TextBox;
        private System.Windows.Forms.Button EvaluateButton;
        private System.Windows.Forms.Button InfixNotationButton;
        private System.Windows.Forms.Button PostfixNotationButton;
        private System.Windows.Forms.Button PrefixNotationButton;
        private System.Windows.Forms.Label Operator;
        private System.Windows.Forms.TextBox OperatorTextBox;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox XValueTextBox;
    }
}

