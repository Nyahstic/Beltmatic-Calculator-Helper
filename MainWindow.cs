using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Beltmatic_Calculator_Helper

{
    public partial class MainWindow : Form
    {
        Font NormalFont;
        Font BigFont;
        public MainWindow()
        {
            AllowTransparency = true;
            InitializeComponent();
            listCheckOperations.SetItemChecked(listCheckOperations.Items.IndexOf("Addition"), true);
            chkBoxTopMost_CheckedChanged(this, EventArgs.Empty);
        }

        private void listCheckOperations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
        private void btnFindExpression_Click(object sender, EventArgs e)
        {
            int targetNumber;
            if (int.TryParse(txtTargetNumber.Text, out targetNumber))
            {
                System.Diagnostics.Debug.WriteLine($"Target number set to {targetNumber}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Invalid target number. Using default of 11.");
                targetNumber = 11;
            }

            int maxBaseNumber;
            if (int.TryParse(txtMaxBaseNumber.Text, out maxBaseNumber) && maxBaseNumber >= 1 && maxBaseNumber <= 999)
            {
                System.Diagnostics.Debug.WriteLine($"Max base number set to {maxBaseNumber}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Invalid max base number. Using default of 15.");
                maxBaseNumber = 999;
            }

            Dictionary<string, string> operatorMap = new Dictionary<string, string>
                {
                    {"Addition", "+"},
                    {"Subtraction", "-"},
                    {"Multiplication", "*"},
                    {"Division", "/"},
                    {"Elevation", "^" }
                };

            string[] operations = listCheckOperations.CheckedItems.Cast<string>()
               .Select(item => operatorMap[item])
               .ToArray(); //{ "+", "-", "*", "/" };
            int[] baseNumbers = Enumerable.Range(1, maxBaseNumber).ToArray();

            var stopwatch = Stopwatch.StartNew();
            string result = ShortestExpression(targetNumber, operations, baseNumbers);
            stopwatch.Stop();

            if (result == null)
            {
                tbxResult.Text = "No expression found";
            }
            else
            {
                tbxResult.Text = result;
                lboxHistory.Items.Add(result);
            }

            txtExecutionTime.Text = "Execution time: " + stopwatch.ElapsedMilliseconds + " ms";
        }

        static string ShortestExpression(int target, string[] operations, int[] bases)
        {
            var dp = new Dictionary<int, string>();
            var seen = new HashSet<int>();
            var pq = new PriorityQueue();

            foreach (int baseNumber in bases)
            {
                var initialState = new State { Total = baseNumber, Expression = baseNumber.ToString() };
                pq.Enqueue(initialState);
                seen.Add(baseNumber);
                dp[baseNumber] = baseNumber.ToString();
            }

            while (pq.Count > 0)
            {
                var current = pq.Dequeue();

                if (current.Total == target)
                {
                    return current.Expression;
                }

                foreach (int baseNumber in bases)
                {
                    foreach (string op in operations)
                    {
                        int newTotal;
                        if (op == "^")
                        {
                            newTotal = (int)Math.Pow(current.Total, baseNumber);
                        }
                        else
                        {
                            newTotal = EvaluateExpression(current.Total, op, baseNumber);
                        }

                        if (newTotal < 0 || newTotal > target * 2)
                        {
                            continue;
                        }

                        var newExpression = $"({current.Expression}{op}{baseNumber})";
                        if (!seen.Contains(newTotal) || newExpression.Length < dp[newTotal].Length)
                        {
                            dp[newTotal] = newExpression;
                            seen.Add(newTotal);
                            pq.Enqueue(new State { Total = newTotal, Expression = newExpression });
                        }
                    }
                }
            }

            return null;
        }

        static int EvaluateExpression(int num1, string op, int num2)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }

        private void lboxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxResult.Text = lboxHistory.Items[lboxHistory.SelectedIndex].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BigFont = new Font(tbxResult.Font.FontFamily, tbxResult.Font.SizeInPoints * 4);
            NormalFont = tbxResult.Font;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lboxHistory.Items.Clear();
        }

        bool alreadyDivided = true;
        private void chkBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkBoxTopMost.Checked;
            lbOpacity.Visible = TopMost;
            tbOpacity.Visible = tbOpacity.Enabled = TopMost;

        }

        private void LoseTransparency(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void GainTransparency(object sender, EventArgs e)
        {
            try
            {
                if (TopMost) Opacity = (double)tbOpacity.Value / 100;
            }
            catch (Exception)
            {
                Debug.WriteLine("I got an exception by having opacity anything other than 1");
            }
        }

        private void ChangeOpacity(object sender, EventArgs e)
        {
            if (TopMost && tbOpacity.Value < 20)
            {
                tbxResult.BackColor = Color.Black;
                tbxResult.ForeColor = Color.White;
                tbxResult.Font = BigFont;
                alreadyDivided = true;
            }
            else
            {
                tbxResult.BackColor = Color.White;
                tbxResult.ForeColor = Color.Black;
                tbxResult.Font = NormalFont;
                alreadyDivided = true;
            }
        }

        private void listCheckOperations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    class State : IComparable<State>
    {
        public int Total { get; set; }
        public string Expression { get; set; }

        public int CompareTo(State other)
        {
            return Expression.Length.CompareTo(other.Expression.Length);
        }
    }

    class PriorityQueue : List<State>
    {
        public void Enqueue(State item)
        {
            Add(item);
            Sort();
        }

        public State Dequeue()
        {
            var item = this[0];
            RemoveAt(0);
            return item;
        }
    }
}