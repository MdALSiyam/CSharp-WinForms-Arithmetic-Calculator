namespace ArithmeticOperatorTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtleftHandSide = new System.Windows.Forms.TextBox();
            this.txtRightHandSide = new System.Windows.Forms.TextBox();
            this.rbtnAddition = new System.Windows.Forms.RadioButton();
            this.rbtnSubtraction = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplication = new System.Windows.Forms.RadioButton();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.rbtnModulous = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arithmetic Operation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Hand Side";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Right Hand Side";
            // 
            // txtleftHandSide
            // 
            this.txtleftHandSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleftHandSide.Location = new System.Drawing.Point(56, 118);
            this.txtleftHandSide.Name = "txtleftHandSide";
            this.txtleftHandSide.Size = new System.Drawing.Size(143, 31);
            this.txtleftHandSide.TabIndex = 2;
            this.txtleftHandSide.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRightHandSide
            // 
            this.txtRightHandSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightHandSide.Location = new System.Drawing.Point(534, 118);
            this.txtRightHandSide.Name = "txtRightHandSide";
            this.txtRightHandSide.Size = new System.Drawing.Size(158, 31);
            this.txtRightHandSide.TabIndex = 3;
            this.txtRightHandSide.TextChanged += new System.EventHandler(this.txtRightHandSide_TextChanged);
            // 
            // rbtnAddition
            // 
            this.rbtnAddition.AutoSize = true;
            this.rbtnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAddition.Location = new System.Drawing.Point(287, 111);
            this.rbtnAddition.Name = "rbtnAddition";
            this.rbtnAddition.Size = new System.Drawing.Size(106, 22);
            this.rbtnAddition.TabIndex = 5;
            this.rbtnAddition.TabStop = true;
            this.rbtnAddition.Text = "+  Addition";
            this.rbtnAddition.UseVisualStyleBackColor = true;
            this.rbtnAddition.CheckedChanged += new System.EventHandler(this.rbtnAddition_CheckedChanged);
            // 
            // rbtnSubtraction
            // 
            this.rbtnSubtraction.AutoSize = true;
            this.rbtnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubtraction.Location = new System.Drawing.Point(287, 139);
            this.rbtnSubtraction.Name = "rbtnSubtraction";
            this.rbtnSubtraction.Size = new System.Drawing.Size(123, 22);
            this.rbtnSubtraction.TabIndex = 5;
            this.rbtnSubtraction.TabStop = true;
            this.rbtnSubtraction.Text = "- Subtraction";
            this.rbtnSubtraction.UseVisualStyleBackColor = true;
            this.rbtnSubtraction.CheckedChanged += new System.EventHandler(this.rbtnAddition_CheckedChanged);
            // 
            // rbtnMultiplication
            // 
            this.rbtnMultiplication.AutoSize = true;
            this.rbtnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiplication.Location = new System.Drawing.Point(287, 167);
            this.rbtnMultiplication.Name = "rbtnMultiplication";
            this.rbtnMultiplication.Size = new System.Drawing.Size(137, 22);
            this.rbtnMultiplication.TabIndex = 5;
            this.rbtnMultiplication.TabStop = true;
            this.rbtnMultiplication.Text = "* Multiplication";
            this.rbtnMultiplication.UseVisualStyleBackColor = true;
            this.rbtnMultiplication.CheckedChanged += new System.EventHandler(this.rbtnAddition_CheckedChanged);
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDivision.Location = new System.Drawing.Point(287, 195);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(96, 22);
            this.rbtnDivision.TabIndex = 5;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "/ Division";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            this.rbtnDivision.CheckedChanged += new System.EventHandler(this.rbtnAddition_CheckedChanged);
            // 
            // rbtnModulous
            // 
            this.rbtnModulous.AutoSize = true;
            this.rbtnModulous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnModulous.Location = new System.Drawing.Point(287, 223);
            this.rbtnModulous.Name = "rbtnModulous";
            this.rbtnModulous.Size = new System.Drawing.Size(126, 22);
            this.rbtnModulous.TabIndex = 5;
            this.rbtnModulous.TabStop = true;
            this.rbtnModulous.Text = "% Remainder";
            this.rbtnModulous.UseVisualStyleBackColor = true;
            this.rbtnModulous.CheckedChanged += new System.EventHandler(this.rbtnAddition_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(55, 309);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 26);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Expression: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Result: ";
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(217, 352);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(0, 24);
            this.lblExpression.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(242, 394);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 464);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbtnModulous);
            this.Controls.Add(this.rbtnDivision);
            this.Controls.Add(this.rbtnMultiplication);
            this.Controls.Add(this.rbtnSubtraction);
            this.Controls.Add(this.rbtnAddition);
            this.Controls.Add(this.txtRightHandSide);
            this.Controls.Add(this.txtleftHandSide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aritjmetic Operator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtleftHandSide;
        private System.Windows.Forms.TextBox txtRightHandSide;
        private System.Windows.Forms.RadioButton rbtnAddition;
        private System.Windows.Forms.RadioButton rbtnSubtraction;
        private System.Windows.Forms.RadioButton rbtnMultiplication;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.RadioButton rbtnModulous;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblResult;
    }
}

