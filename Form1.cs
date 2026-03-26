namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double previousValue = 0; //숫자 입력 변수
        string expression = ""; //계산식 변수
        string currentOperator = ""; //연산자 변수
        bool isNewInput = true; //새로운 입력인지 여부를 나타내는 변수

        private void txt_Input_TextChanged(object sender, EventArgs e) //입력창 텍스트 변경 이벤트 메소드
        {

        }
        private void Number_Click(object sender, EventArgs e) //숫자 입력 메소드
        {
            Button btn = sender as Button;

            if (isNewInput || txt_Input.Text == "0")
            {
                txt_Input.Text = btn.Text;
                isNewInput = false;
            }
            else
            {
                txt_Input.Text += btn.Text;
            }
            expression += btn.Text;
            txt_Result.Text = expression;
        }
        private void Operator_Click(object sender, EventArgs e) //연산자 메소드
        {
            Button btn = sender as Button;
            double currentValue = double.Parse(txt_Input.Text);

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
        }
        private void btn_Equal_Click(object sender, EventArgs e) //계산 결과 메소드
        {
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
            txt_Input.Text = result.ToString();
            txt_Result.Text = expression + " = " + result.ToString();

            isNewInput = true;
            // 다음 계산을 위해 초기화
            expression = "";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "0";
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
    }
}
