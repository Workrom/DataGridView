namespace WinFormsApp1
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
            txtn = new TextBox();
            label2 = new Label();
            txtm = new TextBox();
            label3 = new Label();
            txtRez = new TextBox();
            cmdStart = new Button();
            cmdExit = new Button();
            cmdClear = new Button();
            dgvMass = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 0;
            label1.Text = "Количество строк n=";
            // 
            // txtn
            // 
            txtn.Location = new Point(36, 44);
            txtn.Name = "txtn";
            txtn.Size = new Size(125, 34);
            txtn.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 108);
            label2.Name = "label2";
            label2.Size = new Size(248, 28);
            label2.TabIndex = 2;
            label2.Text = "Количество столбцов m=";
            // 
            // txtm
            // 
            txtm.Location = new Point(36, 139);
            txtm.Name = "txtm";
            txtm.Size = new Size(125, 34);
            txtm.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 203);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "Результат:";
            // 
            // txtRez
            // 
            txtRez.Location = new Point(36, 234);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(312, 171);
            txtRez.TabIndex = 5;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(36, 411);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(161, 41);
            cmdStart.TabIndex = 6;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(699, 411);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(161, 41);
            cmdExit.TabIndex = 7;
            cmdExit.Text = "Завершить работу";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(365, 411);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(161, 41);
            cmdClear.TabIndex = 8;
            cmdClear.Text = "Очистка полей";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(365, 12);
            dgvMass.Name = "dgvMass";
            dgvMass.RowHeadersWidth = 51;
            dgvMass.RowTemplate.Height = 29;
            dgvMass.Size = new Size(495, 393);
            dgvMass.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 464);
            Controls.Add(dgvMass);
            Controls.Add(cmdClear);
            Controls.Add(cmdExit);
            Controls.Add(cmdStart);
            Controls.Add(txtRez);
            Controls.Add(label3);
            Controls.Add(txtm);
            Controls.Add(label2);
            Controls.Add(txtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtn;
        private Label label2;
        private TextBox txtm;
        private Label label3;
        private TextBox txtRez;
        private Button cmdStart;
        private Button cmdExit;
        private Button cmdClear;
        private DataGridView dgvMass;
    }
}