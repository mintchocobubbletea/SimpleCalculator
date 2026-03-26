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

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {

        }
        private void Number_Click(object sender, EventArgs e) //숫자 입력 메소드
        {
            Button btn = sender as Button;

            if (isNewInput)
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

            previousValue = double.Parse(txt_Input.Text);
            currentOperator = btn.Text;
            isNewInput = true;

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

                
            }

            txt_Result.Text = result.ToString();
            txt_Result.Text = expression + " = " + result.ToString();

            isNewInput = true;
            // 다음 계산을 위해 초기화
            expression = "";
        }
    }
}
