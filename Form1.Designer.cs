namespace SimpleCalculator
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
            label1 = new Label();
            txt_Input = new TextBox();
            txt_Result = new TextBox();
            btn_CE = new Button();
            btn_C = new Button();
            btn_Delete = new Button();
            btn_divide = new Button();
            btn_mul = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_sub = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_plus = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_Equal = new Button();
            btn_Dot = new Button();
            btn_0 = new Button();
            btn_Sign = new Button();
            list_Result = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("휴먼편지체", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 28);
            label1.Name = "label1";
            label1.Size = new Size(298, 47);
            label1.TabIndex = 0;
            label1.Text = "SimpleCalculator";
            // 
            // txt_Input
            // 
            txt_Input.Font = new Font("맑은 고딕", 15F);
            txt_Input.Location = new Point(46, 144);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(325, 34);
            txt_Input.TabIndex = 1;
            txt_Input.TextChanged += txt_Input_TextChanged;
            // 
            // txt_Result
            // 
            txt_Result.Font = new Font("맑은 고딕", 15F);
            txt_Result.Location = new Point(46, 93);
            txt_Result.Name = "txt_Result";
            txt_Result.Size = new Size(325, 34);
            txt_Result.TabIndex = 1;
            // 
            // btn_CE
            // 
            btn_CE.Font = new Font("맑은 고딕", 15F);
            btn_CE.Location = new Point(49, 278);
            btn_CE.Name = "btn_CE";
            btn_CE.Size = new Size(76, 54);
            btn_CE.TabIndex = 3;
            btn_CE.Text = "CE";
            btn_CE.UseVisualStyleBackColor = true;
            btn_CE.Click += btn_CE_Click;
            // 
            // btn_C
            // 
            btn_C.Font = new Font("맑은 고딕", 15F);
            btn_C.Location = new Point(131, 278);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(76, 54);
            btn_C.TabIndex = 3;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = true;
            btn_C.Click += btn_C_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("맑은 고딕", 15F);
            btn_Delete.Location = new Point(213, 278);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(76, 54);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Del";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_divide
            // 
            btn_divide.Font = new Font("맑은 고딕", 15F);
            btn_divide.ForeColor = Color.Red;
            btn_divide.Location = new Point(295, 278);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(76, 54);
            btn_divide.TabIndex = 3;
            btn_divide.Text = "%";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += Operator_Click;
            // 
            // btn_mul
            // 
            btn_mul.Font = new Font("맑은 고딕", 15F);
            btn_mul.ForeColor = Color.Red;
            btn_mul.Location = new Point(295, 338);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(76, 54);
            btn_mul.TabIndex = 4;
            btn_mul.Text = "X";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += Operator_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("맑은 고딕", 15F);
            btn_9.ForeColor = SystemColors.HotTrack;
            btn_9.Location = new Point(213, 338);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(76, 54);
            btn_9.TabIndex = 5;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += Number_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("맑은 고딕", 15F);
            btn_8.ForeColor = SystemColors.HotTrack;
            btn_8.Location = new Point(131, 338);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(76, 54);
            btn_8.TabIndex = 6;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += Number_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("맑은 고딕", 15F);
            btn_7.ForeColor = SystemColors.HotTrack;
            btn_7.Location = new Point(49, 338);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(76, 54);
            btn_7.TabIndex = 7;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += Number_Click;
            // 
            // btn_sub
            // 
            btn_sub.Font = new Font("맑은 고딕", 15F);
            btn_sub.ForeColor = Color.Red;
            btn_sub.Location = new Point(295, 398);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(76, 54);
            btn_sub.TabIndex = 8;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += Operator_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("맑은 고딕", 15F);
            btn_6.ForeColor = SystemColors.HotTrack;
            btn_6.Location = new Point(213, 398);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(76, 54);
            btn_6.TabIndex = 9;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += Number_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("맑은 고딕", 15F);
            btn_5.ForeColor = SystemColors.HotTrack;
            btn_5.Location = new Point(131, 398);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(76, 54);
            btn_5.TabIndex = 10;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += Number_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("맑은 고딕", 15F);
            btn_4.ForeColor = SystemColors.HotTrack;
            btn_4.Location = new Point(49, 398);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(76, 54);
            btn_4.TabIndex = 11;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += Number_Click;
            // 
            // btn_plus
            // 
            btn_plus.Font = new Font("맑은 고딕", 15F);
            btn_plus.ForeColor = Color.Red;
            btn_plus.Location = new Point(295, 458);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(76, 54);
            btn_plus.TabIndex = 12;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += Operator_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("맑은 고딕", 15F);
            btn_3.ForeColor = SystemColors.HotTrack;
            btn_3.Location = new Point(213, 458);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(76, 54);
            btn_3.TabIndex = 13;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += Number_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("맑은 고딕", 15F);
            btn_2.ForeColor = SystemColors.HotTrack;
            btn_2.Location = new Point(131, 458);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(76, 54);
            btn_2.TabIndex = 14;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += Number_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("맑은 고딕", 15F);
            btn_1.ForeColor = SystemColors.HotTrack;
            btn_1.Location = new Point(49, 458);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(76, 54);
            btn_1.TabIndex = 15;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += Number_Click;
            // 
            // btn_Equal
            // 
            btn_Equal.Font = new Font("맑은 고딕", 15F);
            btn_Equal.Location = new Point(295, 518);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(76, 54);
            btn_Equal.TabIndex = 16;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            btn_Equal.Click += btn_Equal_Click;
            // 
            // btn_Dot
            // 
            btn_Dot.Font = new Font("맑은 고딕", 15F);
            btn_Dot.Location = new Point(213, 518);
            btn_Dot.Name = "btn_Dot";
            btn_Dot.Size = new Size(76, 54);
            btn_Dot.TabIndex = 17;
            btn_Dot.Text = ".";
            btn_Dot.UseVisualStyleBackColor = true;
            btn_Dot.Click += btn_Dot_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("맑은 고딕", 15F);
            btn_0.ForeColor = SystemColors.HotTrack;
            btn_0.Location = new Point(131, 518);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(76, 54);
            btn_0.TabIndex = 18;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += Number_Click;
            // 
            // btn_Sign
            // 
            btn_Sign.Font = new Font("맑은 고딕", 15F);
            btn_Sign.Location = new Point(49, 518);
            btn_Sign.Name = "btn_Sign";
            btn_Sign.Size = new Size(76, 54);
            btn_Sign.TabIndex = 19;
            btn_Sign.Text = "+/-";
            btn_Sign.UseVisualStyleBackColor = true;
            btn_Sign.Click += btn_Sign_Click;
            // 
            // list_Result
            // 
            list_Result.FormattingEnabled = true;
            list_Result.Location = new Point(398, 96);
            list_Result.Name = "list_Result";
            list_Result.Size = new Size(262, 469);
            list_Result.TabIndex = 20;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15F);
            button1.Location = new Point(49, 218);
            button1.Name = "button1";
            button1.Size = new Size(76, 54);
            button1.TabIndex = 21;
            button1.Text = "(";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 15F);
            button2.Location = new Point(131, 218);
            button2.Name = "button2";
            button2.Size = new Size(76, 54);
            button2.TabIndex = 21;
            button2.Text = ")";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(684, 596);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(list_Result);
            Controls.Add(btn_Equal);
            Controls.Add(btn_Dot);
            Controls.Add(btn_0);
            Controls.Add(btn_Sign);
            Controls.Add(btn_plus);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_sub);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_mul);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_divide);
            Controls.Add(btn_Delete);
            Controls.Add(btn_C);
            Controls.Add(btn_CE);
            Controls.Add(txt_Result);
            Controls.Add(txt_Input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Input;
        private TextBox txt_Result;
        private Button btn_CE;
        private Button btn_C;
        private Button btn_Delete;
        private Button btn_divide;
        private Button btn_mul;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_sub;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_plus;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_Equal;
        private Button btn_Dot;
        private Button btn_0;
        private Button btn_Sign;
        private ListBox list_Result;
        private Button button1;
        private Button button2;
    }
}
