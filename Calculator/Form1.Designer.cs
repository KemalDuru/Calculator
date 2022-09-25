
namespace Calculator
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ShortcutsEnabled = false;
            this.txtResult.Size = new System.Drawing.Size(251, 86);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResult.Location = new System.Drawing.Point(21, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(3);
            this.lblResult.Size = new System.Drawing.Size(16, 21);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = " ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMod
            // 
            this.btnMod.AutoSize = true;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(12, 100);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(65, 59);
            this.btnMod.TabIndex = 2;
            this.btnMod.TabStop = false;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.optEvent);
            this.btnMod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 82);
            this.textBox2.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.Location = new System.Drawing.Point(74, 100);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(127, 59);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.TabStop = false;
            this.btnClearAll.Text = "CE";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.clear_result_event);
            this.btnClearAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(198, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 59);
            this.btnClear.TabIndex = 2;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clear_event);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnSqrt
            // 
            this.btnSqrt.AutoSize = true;
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(12, 155);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(65, 59);
            this.btnSqrt.TabIndex = 2;
            this.btnSqrt.TabStop = false;
            this.btnSqrt.Text = "½X";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.optsqrt);
            // 
            // btnTimes
            // 
            this.btnTimes.AutoSize = true;
            this.btnTimes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimes.Location = new System.Drawing.Point(136, 155);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(65, 59);
            this.btnTimes.TabIndex = 2;
            this.btnTimes.TabStop = false;
            this.btnTimes.Text = "X";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.optEvent);
            // 
            // btnPow
            // 
            this.btnPow.AutoSize = true;
            this.btnPow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPow.Location = new System.Drawing.Point(74, 155);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(65, 59);
            this.btnPow.TabIndex = 2;
            this.btnPow.TabStop = false;
            this.btnPow.Text = "X2";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.optsqrt);
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(198, 155);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(65, 59);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.optEvent);
            this.btnDivide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_7
            // 
            this.btn_7.AutoSize = true;
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(12, 210);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(65, 59);
            this.btn_7.TabIndex = 2;
            this.btn_7.TabStop = false;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Numbers_event);
            this.btn_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_9
            // 
            this.btn_9.AutoSize = true;
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(136, 210);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(65, 59);
            this.btn_9.TabIndex = 2;
            this.btn_9.TabStop = false;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Numbers_event);
            this.btn_9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_4
            // 
            this.btn_4.AutoSize = true;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(12, 265);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(65, 59);
            this.btn_4.TabIndex = 2;
            this.btn_4.TabStop = false;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Numbers_event);
            this.btn_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_8
            // 
            this.btn_8.AutoSize = true;
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(74, 210);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(65, 59);
            this.btn_8.TabIndex = 2;
            this.btn_8.TabStop = false;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Numbers_event);
            this.btn_8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_6
            // 
            this.btn_6.AutoSize = true;
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(136, 265);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(65, 59);
            this.btn_6.TabIndex = 2;
            this.btn_6.TabStop = false;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Numbers_event);
            this.btn_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_5
            // 
            this.btn_5.AutoSize = true;
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(74, 265);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(65, 59);
            this.btn_5.TabIndex = 2;
            this.btn_5.TabStop = false;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Numbers_event);
            this.btn_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSize = true;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(198, 210);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(65, 59);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.optEvent);
            this.btnMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(198, 265);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 59);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.optEvent);
            this.btnPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnOne
            // 
            this.btnOne.AutoSize = true;
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOne.Location = new System.Drawing.Point(12, 320);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(65, 59);
            this.btnOne.TabIndex = 2;
            this.btnOne.TabStop = false;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.Numbers_event);
            this.btnOne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_3
            // 
            this.btn_3.AutoSize = true;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(136, 320);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(65, 59);
            this.btn_3.TabIndex = 2;
            this.btn_3.TabStop = false;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Numbers_event);
            this.btn_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnZero
            // 
            this.btnZero.AutoSize = true;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(12, 375);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(127, 59);
            this.btnZero.TabIndex = 2;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.Numbers_event);
            this.btnZero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_2
            // 
            this.btn_2.AutoSize = true;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(74, 320);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(65, 59);
            this.btn_2.TabIndex = 2;
            this.btn_2.TabStop = false;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Numbers_event);
            this.btn_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = true;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(136, 375);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(65, 59);
            this.btnDot.TabIndex = 2;
            this.btnDot.TabStop = false;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSize = true;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(198, 320);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(65, 114);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.equal_event);
            this.btnEqual.Enter += new System.EventHandler(this.equal_event);
            this.btnEqual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 448);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btn_2);
            this.Enabled = false;
            this.MaximumSize = new System.Drawing.Size(295, 487);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
    }
}

