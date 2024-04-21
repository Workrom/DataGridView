namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calculation()
        {
            Random rnd = new Random();
            int n, m, nn = 0;
            float summ = 0, sr = 0;

            n = Int32.Parse(txtn.Text);
            m = Int32.Parse(txtm.Text);

            int[,] A = new int[n, m];

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    A[i, j] = rnd.Next(-50, 50);
                }
            }

            dgvMass.RowCount = n;
            dgvMass.ColumnCount = m;

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    dgvMass.Rows[i].Cells[j].Value = A[i, j];
                }
            }

            for (int j = 0; j <= m - 1; j++)
            {
                dgvMass.Columns[j].Width = 50;
            }

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    summ = summ + A[i, j];
                    nn += 1;
                }
            }

            sr = summ / nn;
            txtRez.Text = "Среднее арифмитическое = " + Math.Round(sr, 5).ToString() + Environment.NewLine + "Количество полодительних элементов = " + nn.ToString();

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtm.Text = "";
            txtn.Text = "";
            txtRez.Text = "";
            dgvMass.Rows.Clear();
            dgvMass.Columns.Clear();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Calculation();
        }
    }
}