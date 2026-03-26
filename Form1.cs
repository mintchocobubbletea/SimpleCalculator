namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
            
        }
        double previousValue = 0; //숫자 입력 변수
        string expression = ""; //계산식 변수
        string currentOperator = ""; //연산자 변수
        bool isNewInput = true; //새로운 입력인지 여부를 나타내는 변수
        private bool isCalculated = false; // 계산 완료 플래그 추가 (멤버 변수)

        private void txt_Input_TextChanged(object sender, EventArgs e) //입력창 텍스트 변경 이벤트 메소드
        {

        }
        private void Number_Click(object sender, EventArgs e) //숫자 입력 메소드
        {
            Button btn = sender as Button;

            if (isNewInput || txt_Input.Text == "0")
            {
                txt_Input.Text = btn.Text;
                txt_Input.ForeColor = Color.Black; //새 입력은 검은색으로 표시
                isNewInput = false;
            }
            else
            {
                txt_Input.Text += btn.Text;
            }
            expression += btn.Text;
            txt_Result.Text = expression;
            this.ActiveControl = null;
        }
        private void Operator_Click(object sender, EventArgs e) //연산자 메소드
        {
            Button btn = sender as Button;
            double currentValue = double.Parse(txt_Input.Text);
            if (isNewInput)
            {
                // 이미 연산자가 있으면 마지막 연산자만 교체
                if (expression.Length > 0)
                {
                    string[] parts = expression.Split(' ');
                    if (parts.Length >= 2)
                    {
                        parts[parts.Length - 2] = btn.Text;
                        expression = string.Join(" ", parts);
                        txt_Result.Text = expression;
                    }
                }

                currentOperator = btn.Text;
                return;
            }
            if (!string.IsNullOrEmpty(currentOperator))
            {
                switch (currentOperator)
                {
                    case "+":
                        previousValue += currentValue;
                        break;
                    case "-":
                        previousValue -= currentValue;
                        break;
                    case "X":
                    case "*":
                        previousValue *= currentValue;
                        break;
                    case "%":
                        previousValue /= currentValue;
                        break;
                }
            }
            else
            {
                previousValue = currentValue;
            }
            currentOperator = btn.Text;
            isNewInput = true;
            //식 표시
            expression += " " + btn.Text + " ";
            txt_Result.Text = expression;
            this.ActiveControl = null;
        }
        private void btn_Equal_Click(object sender, EventArgs e) //계산 결과 메소드
        {
            if (string.IsNullOrEmpty(currentOperator))
                return;

            double currentValue = double.Parse(txt_Input.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = previousValue + currentValue;
                    break;
                case "-":
                    result = previousValue - currentValue;
                    break;

                case "X":
                case "*":
                    result = previousValue * currentValue;
                    break;
                case "%":
                    result = previousValue / currentValue;
                    break;

            }
            string resultExpression = expression + " = " + result.ToString(); //현재 입력값 포함
            txt_Input.Text = result.ToString();
            txt_Input.ForeColor = Color.Blue; // 결과값을 파란색으로 표시

            txt_Result.Text = resultExpression;
            list_Result.Items.Add(resultExpression); // 계산식과 결과를 리스트에 추가

            previousValue = result; // 결과를 이전 값으로 저장
            currentOperator = "";
            expression = "";

            isNewInput = true;
            isCalculated = true;
            // 다음 계산을 위해 초기화
            expression = "";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "0";
            txt_Input.ForeColor = Color.Black;
            txt_Result.Text = "";

            previousValue = 0;
            currentOperator = "";
            expression = "";

            isNewInput = true;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            // 현재 입력값 길이만큼 expression에서 제거
            int len = txt_Input.Text.Length;
            if (expression.Length >= len)
            {
                expression = expression.Substring(0, expression.Length - len);
            }
            txt_Input.Text = "0";
            isNewInput = true;
            txt_Result.Text = expression;
        }

        private void btn_Delete_Click(object sender, EventArgs e) //De;버튼 기능
        {
            if (!isNewInput && txt_Input.Text.Length > 1)
            {
                // 현재 입력값 줄이기
                txt_Input.Text = txt_Input.Text.Substring(0, txt_Input.Text.Length - 1);
            }
            else
            {
                txt_Input.Text = "0";
                isNewInput = true;
            }

            // expression 재구성
            string[] parts = expression.Split(' ');

            if (parts.Length >= 3)
            {
                // 앞부분 (예: "53 -")
                string front = parts[0] + " " + parts[1];

                // 새 expression 만들기
                expression = front + " " + txt_Input.Text;
            }
            else
            {
                // 숫자만 있는 경우
                expression = txt_Input.Text;
            }


            txt_Result.Text = expression.TrimEnd();

        }

        private void btn_Dot_Click(object sender, EventArgs e) // 소수점 버튼 기능
        {
            if (isNewInput)
            {
                txt_Input.Text = "0.";
                isNewInput = false;
            }
            else if (!txt_Input.Text.Contains("."))
            {
                txt_Input.Text += ".";
            }

            expression += ".";
            txt_Result.Text = expression;
        }

        private void btn_Sign_Click(object sender, EventArgs e) // +/- 버튼 기능
        {
            double value = double.Parse(txt_Input.Text);
            value *= -1;

            txt_Input.Text = value.ToString();

            // expression도 반영
            if (expression.Length > 0)
            {
                string[] parts = expression.Split(' ');

                if (parts.Length >= 1)
                {
                    parts[parts.Length - 1] = txt_Input.Text;
                    expression = string.Join(" ", parts);
                }
            }

            txt_Result.Text = expression;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            Button fakeBtn = new Button();

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                fakeBtn.Text = (e.KeyCode - Keys.D0).ToString();
                Number_Click(fakeBtn, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                fakeBtn.Text = (e.KeyCode - Keys.NumPad0).ToString();
                Number_Click(fakeBtn, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_Equal_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                btn_Delete_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) // Enter 키 KeyPress 완전 차단
            {
                e.Handled = true;
            }
        }
    }
}
