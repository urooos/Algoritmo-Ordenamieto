using System.Diagnostics;

namespace Algoritmos_Ordenamiento
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            txtSize.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(txtSize.Text, out size) || size <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor a 0",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.SwapCount = 0;
            Order.ComparisonCount = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, 101);

            txtOriginal.Text = string.Join(", ", array);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Order.QuickSort(array, 0, array.Length - 1);

            stopwatch.Stop();

            txtSorted.Text = string.Join(", ", array);

            lblSwapsCount.Text = Order.SwapCount.ToString();
            lblComparisonCount.Text = Order.ComparisonCount.ToString();

            lblTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4}ms";
            txtSize.Clear();
            txtSize.Focus();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(txtSize.Text, out size) || size <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor a 0",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.SwapCount = 0;
            Order.ComparisonCount = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, 101);

            txtOriginal.Text = string.Join(", ", array);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Order.BubbleSort(array);

            stopwatch.Stop();

            txtSorted.Text = string.Join(", ", array);

            lblSwapsCount.Text = Order.SwapCount.ToString();
            lblComparisonCount.Text = Order.ComparisonCount.ToString();

            lblTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4}ms";
            txtSize.Clear();
            txtSize.Focus();
        }

        private void btnCocktailSort_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(txtSize.Text, out size) || size <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor a 0",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.SwapCount = 0;
            Order.ComparisonCount = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, 101);

            txtOriginal.Text = string.Join(", ", array);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Order.CocktailSort(array);

            stopwatch.Stop();

            txtSorted.Text = string.Join(", ", array);

            lblSwapsCount.Text = Order.SwapCount.ToString();
            lblComparisonCount.Text = Order.ComparisonCount.ToString();

            lblTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4}ms";
            txtSize.Clear();
            txtSize.Focus();

        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(txtSize.Text, out size) || size <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor a 0",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.SwapCount = 0;
            Order.ComparisonCount = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, 101);

            txtOriginal.Text = string.Join(", ", array);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Order.InsertSort(array);

            stopwatch.Stop();

            txtSorted.Text = string.Join(", ", array);

            lblSwapsCount.Text = Order.SwapCount.ToString();
            lblComparisonCount.Text = Order.ComparisonCount.ToString();

            lblTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4}ms";
            txtSize.Clear();
            txtSize.Focus();

        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(txtSize.Text, out size) || size <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor a 0",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.SwapCount = 0;
            Order.ComparisonCount = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, 101);

            txtOriginal.Text = string.Join(", ", array);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Order.HeapSort(array);

            stopwatch.Stop();

            txtSorted.Text = string.Join(", ", array);

            lblSwapsCount.Text = Order.SwapCount.ToString();
            lblComparisonCount.Text = Order.ComparisonCount.ToString();

            lblTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4}ms";
            txtSize.Clear();
            txtSize.Focus();
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(txtSize.Text, out size) || size <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor a 0",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.SwapCount = 0;
            Order.ComparisonCount = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, 101);

            txtOriginal.Text = string.Join(", ", array);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Order.ShellSort(array, ref Order.ComparisonCount, ref Order.SwapCount);

            stopwatch.Stop();

            txtSorted.Text = string.Join(", ", array);

            lblSwapsCount.Text = Order.SwapCount.ToString();
            lblComparisonCount.Text = Order.ComparisonCount.ToString();

            lblTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4}ms";
            txtSize.Clear();
            txtSize.Focus();
        }

        private void btnGnomeSort_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(txtSize.Text, out size) || size <= 0)
            {
                MessageBox.Show("Ingresa un número válido mayor a 0",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.SwapCount = 0;
            Order.ComparisonCount = 0;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(0, 101);

            txtOriginal.Text = string.Join(", ", array);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Order.GnomeSort(array);

            stopwatch.Stop();

            txtSorted.Text = string.Join(", ", array);

            lblSwapsCount.Text = Order.SwapCount.ToString();
            lblComparisonCount.Text = Order.ComparisonCount.ToString();

            lblTime.Text = $"{stopwatch.Elapsed.TotalMilliseconds:F4}ms";
            txtSize.Clear();
            txtSize.Focus();
        }

        private void txtSwapsCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
