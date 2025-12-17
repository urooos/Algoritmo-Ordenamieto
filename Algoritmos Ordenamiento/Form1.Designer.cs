namespace Algoritmos_Ordenamiento
{
    partial class Form1
    {
       
            private System.ComponentModel.IContainer components = null;
            private TextBox txtSize;
            private Button btnQuickSort;
            private TextBox txtOriginal;
            private TextBox txtSorted;
            private Label lblSize;
            private Label lblOriginal;
            private Label lblSorted;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            txtSize = new TextBox();
            btnQuickSort = new Button();
            txtOriginal = new TextBox();
            txtSorted = new TextBox();
            lblSize = new Label();
            lblOriginal = new Label();
            lblSorted = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCocktailSort = new Button();
            btnBubbleSort = new Button();
            btnInsertionSort = new Button();
            btnHeapSort = new Button();
            btnShellSort = new Button();
            btnGnomeSort = new Button();
            lblSwapsCount = new Label();
            lblComparisonCount = new Label();
            lblTime = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSize
            // 
            txtSize.BorderStyle = BorderStyle.FixedSingle;
            txtSize.Location = new Point(260, 74);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(120, 27);
            txtSize.TabIndex = 0;
            txtSize.TextChanged += txtSize_TextChanged;
            // 
            // btnQuickSort
            // 
            btnQuickSort.BackColor = Color.FromArgb(128, 128, 255);
            btnQuickSort.FlatStyle = FlatStyle.Popup;
            btnQuickSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickSort.ForeColor = SystemColors.ButtonHighlight;
            btnQuickSort.Location = new Point(18, 113);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(144, 38);
            btnQuickSort.TabIndex = 1;
            btnQuickSort.Text = "QuickSort";
            btnQuickSort.UseVisualStyleBackColor = false;
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // txtOriginal
            // 
            txtOriginal.BorderStyle = BorderStyle.FixedSingle;
            txtOriginal.Location = new Point(20, 199);
            txtOriginal.Multiline = true;
            txtOriginal.Name = "txtOriginal";
            txtOriginal.Size = new Size(1042, 100);
            txtOriginal.TabIndex = 2;
            // 
            // txtSorted
            // 
            txtSorted.BorderStyle = BorderStyle.FixedSingle;
            txtSorted.Location = new Point(20, 339);
            txtSorted.Multiline = true;
            txtSorted.Name = "txtSorted";
            txtSorted.Size = new Size(1042, 100);
            txtSorted.TabIndex = 3;
            // 
            // lblSize
            // 
            lblSize.Font = new Font("Segoe UI", 11F);
            lblSize.Location = new Point(20, 73);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(244, 37);
            lblSize.TabIndex = 4;
            lblSize.Text = "Elegir tamaño del arreglo:";
            // 
            // lblOriginal
            // 
            lblOriginal.Location = new Point(20, 173);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(496, 23);
            lblOriginal.TabIndex = 5;
            lblOriginal.Text = "Arreglo original:";
            // 
            // lblSorted
            // 
            lblSorted.Location = new Point(20, 313);
            lblSorted.Name = "lblSorted";
            lblSorted.Size = new Size(516, 23);
            lblSorted.TabIndex = 6;
            lblSorted.Text = "Arreglo ordenado:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(407, 71);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 9;
            label1.Text = "Comparaciones:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(429, 28);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 10;
            label2.Text = "Intercambios:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(477, 113);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 12;
            label3.Text = "Tiempo:";
            // 
            // btnCocktailSort
            // 
            btnCocktailSort.BackColor = Color.FromArgb(128, 128, 255);
            btnCocktailSort.FlatStyle = FlatStyle.Popup;
            btnCocktailSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCocktailSort.ForeColor = SystemColors.ButtonHighlight;
            btnCocktailSort.Location = new Point(318, 113);
            btnCocktailSort.Name = "btnCocktailSort";
            btnCocktailSort.Size = new Size(144, 38);
            btnCocktailSort.TabIndex = 13;
            btnCocktailSort.Text = "Cocktail Sort";
            btnCocktailSort.UseVisualStyleBackColor = false;
            btnCocktailSort.Click += btnCocktailSort_Click;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.BackColor = Color.FromArgb(98, 98, 225);
            btnBubbleSort.FlatStyle = FlatStyle.Popup;
            btnBubbleSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBubbleSort.ForeColor = SystemColors.ButtonHighlight;
            btnBubbleSort.Location = new Point(168, 113);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(144, 38);
            btnBubbleSort.TabIndex = 14;
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = false;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnInsertionSort
            // 
            btnInsertionSort.BackColor = Color.FromArgb(98, 98, 225);
            btnInsertionSort.FlatStyle = FlatStyle.Popup;
            btnInsertionSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertionSort.ForeColor = SystemColors.ButtonHighlight;
            btnInsertionSort.Location = new Point(468, 113);
            btnInsertionSort.Name = "btnInsertionSort";
            btnInsertionSort.Size = new Size(144, 38);
            btnInsertionSort.TabIndex = 15;
            btnInsertionSort.Text = "Insertion Sort";
            btnInsertionSort.UseVisualStyleBackColor = false;
            btnInsertionSort.Click += btnInsertionSort_Click;
            // 
            // btnHeapSort
            // 
            btnHeapSort.BackColor = Color.FromArgb(128, 128, 255);
            btnHeapSort.FlatStyle = FlatStyle.Popup;
            btnHeapSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHeapSort.ForeColor = SystemColors.ButtonHighlight;
            btnHeapSort.Location = new Point(618, 113);
            btnHeapSort.Name = "btnHeapSort";
            btnHeapSort.Size = new Size(144, 38);
            btnHeapSort.TabIndex = 16;
            btnHeapSort.Text = "Heap Sort";
            btnHeapSort.UseVisualStyleBackColor = false;
            btnHeapSort.Click += btnHeapSort_Click;
            // 
            // btnShellSort
            // 
            btnShellSort.BackColor = Color.FromArgb(98, 98, 225);
            btnShellSort.FlatStyle = FlatStyle.Popup;
            btnShellSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShellSort.ForeColor = SystemColors.ButtonHighlight;
            btnShellSort.Location = new Point(768, 113);
            btnShellSort.Name = "btnShellSort";
            btnShellSort.Size = new Size(144, 38);
            btnShellSort.TabIndex = 17;
            btnShellSort.Text = "Shell Sort";
            btnShellSort.UseVisualStyleBackColor = false;
            btnShellSort.Click += btnShellSort_Click;
            // 
            // btnGnomeSort
            // 
            btnGnomeSort.BackColor = Color.FromArgb(128, 128, 255);
            btnGnomeSort.FlatStyle = FlatStyle.Popup;
            btnGnomeSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGnomeSort.ForeColor = SystemColors.ButtonHighlight;
            btnGnomeSort.Location = new Point(918, 113);
            btnGnomeSort.Name = "btnGnomeSort";
            btnGnomeSort.Size = new Size(144, 38);
            btnGnomeSort.TabIndex = 18;
            btnGnomeSort.Text = "Gnome Sort";
            btnGnomeSort.UseVisualStyleBackColor = false;
            btnGnomeSort.Click += btnGnomeSort_Click;
            // 
            // lblSwapsCount
            // 
            lblSwapsCount.Font = new Font("Segoe UI", 11F);
            lblSwapsCount.Location = new Point(568, 28);
            lblSwapsCount.Name = "lblSwapsCount";
            lblSwapsCount.Size = new Size(149, 23);
            lblSwapsCount.TabIndex = 19;
            lblSwapsCount.Text = "0";
            // 
            // lblComparisonCount
            // 
            lblComparisonCount.AutoSize = true;
            lblComparisonCount.Font = new Font("Segoe UI", 11F);
            lblComparisonCount.Location = new Point(568, 71);
            lblComparisonCount.Name = "lblComparisonCount";
            lblComparisonCount.Size = new Size(22, 25);
            lblComparisonCount.TabIndex = 20;
            lblComparisonCount.Text = "0";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 11F);
            lblTime.Location = new Point(568, 113);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(46, 25);
            lblTime.TabIndex = 21;
            lblTime.Text = "0ms";
            lblTime.Click += lblTime_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label4.Location = new Point(20, 9);
            label4.Name = "label4";
            label4.Size = new Size(460, 45);
            label4.TabIndex = 22;
            label4.Text = "Algoritmos de Ordenamiento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 222, 255);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblComparisonCount);
            panel1.Controls.Add(lblSwapsCount);
            panel1.Location = new Point(-4, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 168);
            panel1.TabIndex = 23;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1098, 637);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(btnGnomeSort);
            Controls.Add(btnShellSort);
            Controls.Add(btnHeapSort);
            Controls.Add(btnInsertionSort);
            Controls.Add(btnBubbleSort);
            Controls.Add(btnCocktailSort);
            Controls.Add(txtSize);
            Controls.Add(btnQuickSort);
            Controls.Add(txtOriginal);
            Controls.Add(txtSorted);
            Controls.Add(lblSize);
            Controls.Add(lblOriginal);
            Controls.Add(lblSorted);
            Name = "Form1";
            Text = "InsertSort Demo";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
            private Label label2;
            private Label label3;
        private Button btnCocktailSort;
        private Button btnBubbleSort;
        private Button btnInsertionSort;
        private Button btnHeapSort;
        private Button btnShellSort;
        private Button btnGnomeSort;
        private Label lblSwapsCount;
        private Label lblComparisonCount;
        private Label lblTime;
        private Label label4;
        private Panel panel1;
    }
    }

