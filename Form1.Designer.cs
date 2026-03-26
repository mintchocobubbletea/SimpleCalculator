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
            button2 = new Button();
            button3 = new Button();
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
            button19 = new Button();
            btn_0 = new Button();
            button21 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 25F);
            label1.Location = new Point(43, 28);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
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
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 15F);
            button2.Location = new Point(46, 216);
            button2.Name = "button2";
            button2.Size = new Size(76, 54);
            button2.TabIndex = 3;
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 15F);
            button3.Location = new Point(128, 216);
            button3.Name = "button3";
            button3.Size = new Size(76, 54);
            button3.TabIndex = 3;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("맑은 고딕", 15F);
            btn_Delete.Location = new Point(210, 216);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(76, 54);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "del";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_divide
            // 
            btn_divide.Font = new Font("맑은 고딕", 15F);
            btn_divide.ForeColor = Color.Red;
            btn_divide.Location = new Point(292, 216);
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
            btn_mul.Location = new Point(292, 276);
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
            btn_9.Location = new Point(210, 276);
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
            btn_8.Location = new Point(128, 276);
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
            btn_7.Location = new Point(46, 276);
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
            btn_sub.Location = new Point(292, 336);
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
            btn_6.Location = new Point(210, 336);
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
            btn_5.Location = new Point(128, 336);
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
            btn_4.Location = new Point(46, 336);
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
            btn_plus.Location = new Point(292, 396);
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
            btn_3.Location = new Point(210, 396);
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
            btn_2.Location = new Point(128, 396);
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
            btn_1.Location = new Point(46, 396);
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
            btn_Equal.Location = new Point(292, 456);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(76, 54);
            btn_Equal.TabIndex = 16;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            btn_Equal.Click += btn_Equal_Click;
            // 
            // button19
            // 
            button19.Font = new Font("맑은 고딕", 15F);
            button19.Location = new Point(210, 456);
            button19.Name = "button19";
            button19.Size = new Size(76, 54);
            button19.TabIndex = 17;
            button19.Text = ".";
            button19.UseVisualStyleBackColor = true;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("맑은 고딕", 15F);
            btn_0.ForeColor = SystemColors.HotTrack;
            btn_0.Location = new Point(128, 456);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(76, 54);
            btn_0.TabIndex = 18;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += Number_Click;
            // 
            // button21
            // 
            button21.Font = new Font("맑은 고딕", 15F);
            button21.Location = new Point(46, 456);
            button21.Name = "button21";
            button21.Size = new Size(76, 54);
            button21.TabIndex = 19;
            button21.Text = "+/-";
            button21.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 596);
            Controls.Add(btn_Equal);
            Controls.Add(button19);
            Controls.Add(btn_0);
            Controls.Add(button21);
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_Result);
            Controls.Add(txt_Input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Input;
        private TextBox txt_Result;
        private Button button2;
        private Button button3;
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
        private Button button19;
        private Button btn_0;
        private Button button21;
        
    }
}
