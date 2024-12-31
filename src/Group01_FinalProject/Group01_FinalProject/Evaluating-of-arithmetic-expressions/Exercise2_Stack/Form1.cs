namespace Exercise2_Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            string expression = txtInfix.Text;
            PostfixEvaluator evaluator = new PostfixEvaluator();

            // Kiểm tra nếu biểu thức rỗng
            if (string.IsNullOrWhiteSpace(expression))
            {
                MessageBox.Show("Please enter an infix expression.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                for (int i = 0; i < expression.Length; i++)
                {
                    char c = expression[i];

                    if (!Char.IsDigit(c) && !evaluator.isOperator(c))
                    {
                        MessageBox.Show("Please enter an infix expression.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInfix.Text = "";
                        return;
                    }
                }
            }



            try
            {
                // Chuyển đổi Infix thành Postfix
                string postfixExpression = evaluator.InfixToPostfix(expression);
                txtPostfix.Text = postfixExpression; // Hiển thị biểu thức Postfix

                // Tính toán biểu thức Postfix
                int result = evaluator.Evaluate(postfixExpression);
                txtResult.Text = result.ToString(); // Hiển thị kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInfix.Text = "";
            txtPostfix.Text = "";
            txtResult.Text = "";
        }
    }
}