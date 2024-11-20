namespace Beltmatic_Calculator_Helper
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
            txtTargetNumber = new TextBox();
            button1 = new Button();
            txtExecutionTime = new Label();
            listCheckOperations = new CheckedListBox();
            lblOperation = new Label();
            lblTargetNumber = new Label();
            lblBaseNumber = new Label();
            txtMaxBaseNumber = new NumericUpDown();
            tbxResult = new TextBox();
            lblResult = new Label();
            lboxHistory = new ListBox();
            lblHistory = new Label();
            btnClearHistory = new Button();
            chkBoxTopMost = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)txtMaxBaseNumber).BeginInit();
            SuspendLayout();
            // 
            // txtTargetNumber
            // 
            txtTargetNumber.Location = new Point(22, 36);
            txtTargetNumber.Name = "txtTargetNumber";
            txtTargetNumber.PlaceholderText = "11";
            txtTargetNumber.Size = new Size(140, 23);
            txtTargetNumber.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(22, 109);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnFindExpression_Click;
            // 
            // txtExecutionTime
            // 
            txtExecutionTime.AutoSize = true;
            txtExecutionTime.Location = new Point(22, 502);
            txtExecutionTime.Name = "txtExecutionTime";
            txtExecutionTime.Size = new Size(33, 15);
            txtExecutionTime.TabIndex = 5;
            txtExecutionTime.Text = "Time";
            // 
            // listCheckOperations
            // 
            listCheckOperations.FormattingEnabled = true;
            listCheckOperations.Items.AddRange(new object[] { "Addition", "Multiplication", "Subtraction", "Division", "Elevation" });
            listCheckOperations.Location = new Point(170, 36);
            listCheckOperations.Name = "listCheckOperations";
            listCheckOperations.Size = new Size(120, 130);
            listCheckOperations.TabIndex = 11;
            listCheckOperations.ItemCheck += listCheckOperations_ItemCheck;
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.Location = new Point(170, 15);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(68, 15);
            lblOperation.TabIndex = 12;
            lblOperation.Text = "Operations:";
            // 
            // lblTargetNumber
            // 
            lblTargetNumber.AutoSize = true;
            lblTargetNumber.Location = new Point(19, 17);
            lblTargetNumber.Name = "lblTargetNumber";
            lblTargetNumber.Size = new Size(86, 15);
            lblTargetNumber.TabIndex = 13;
            lblTargetNumber.Text = "Target Number";
            // 
            // lblBaseNumber
            // 
            lblBaseNumber.AutoSize = true;
            lblBaseNumber.Location = new Point(22, 62);
            lblBaseNumber.Name = "lblBaseNumber";
            lblBaseNumber.Size = new Size(109, 15);
            lblBaseNumber.TabIndex = 14;
            lblBaseNumber.Text = "Unlocked Numbers";
            // 
            // txtMaxBaseNumber
            // 
            txtMaxBaseNumber.Location = new Point(22, 80);
            txtMaxBaseNumber.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            txtMaxBaseNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtMaxBaseNumber.Name = "txtMaxBaseNumber";
            txtMaxBaseNumber.Size = new Size(140, 23);
            txtMaxBaseNumber.TabIndex = 6;
            txtMaxBaseNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbxResult
            // 
            tbxResult.Location = new Point(22, 179);
            tbxResult.MaxLength = 32767000;
            tbxResult.Multiline = true;
            tbxResult.Name = "tbxResult";
            tbxResult.ReadOnly = true;
            tbxResult.ScrollBars = ScrollBars.Both;
            tbxResult.Size = new Size(532, 319);
            tbxResult.TabIndex = 15;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.Orange;
            lblResult.Location = new Point(22, 161);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(44, 15);
            lblResult.TabIndex = 17;
            lblResult.Text = "Results";
            // 
            // lboxHistory
            // 
            lboxHistory.FormattingEnabled = true;
            lboxHistory.ItemHeight = 15;
            lboxHistory.Location = new Point(309, 36);
            lboxHistory.Name = "lboxHistory";
            lboxHistory.Size = new Size(245, 94);
            lboxHistory.TabIndex = 18;
            lboxHistory.SelectedIndexChanged += lboxHistory_SelectedIndexChanged;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(309, 15);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(45, 15);
            lblHistory.TabIndex = 19;
            lblHistory.Text = "History";
            // 
            // btnClearHistory
            // 
            btnClearHistory.Location = new Point(309, 136);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(245, 28);
            btnClearHistory.TabIndex = 20;
            btnClearHistory.Text = "Clear History";
            btnClearHistory.UseVisualStyleBackColor = true;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // chkBoxTopMost
            // 
            chkBoxTopMost.AutoSize = true;
            chkBoxTopMost.Location = new Point(381, 501);
            chkBoxTopMost.Name = "chkBoxTopMost";
            chkBoxTopMost.Size = new Size(173, 19);
            chkBoxTopMost.TabIndex = 21;
            chkBoxTopMost.Text = "Show above other Windows";
            chkBoxTopMost.UseVisualStyleBackColor = true;
            chkBoxTopMost.CheckedChanged += chkBoxTopMost_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 541);
            Controls.Add(chkBoxTopMost);
            Controls.Add(btnClearHistory);
            Controls.Add(lblHistory);
            Controls.Add(lboxHistory);
            Controls.Add(lblResult);
            Controls.Add(tbxResult);
            Controls.Add(lblBaseNumber);
            Controls.Add(lblTargetNumber);
            Controls.Add(lblOperation);
            Controls.Add(listCheckOperations);
            Controls.Add(txtMaxBaseNumber);
            Controls.Add(txtExecutionTime);
            Controls.Add(button1);
            Controls.Add(txtTargetNumber);
            Name = "Form1";
            Text = "Beltmatix Calc";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtMaxBaseNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTargetNumber;
        private Button button1;
        private Label txtExecutionTime;
        private Label lblOperation;
        public CheckedListBox listCheckOperations;
        private Label lblTargetNumber;
        private Label lblBaseNumber;
        private NumericUpDown txtMaxBaseNumber;
        private TextBox tbxResult;
        private Label lblResult;
        private ListBox lboxHistory;
        private Label lblHistory;
        private Button btnClearHistory;
        private CheckBox chkBoxTopMost;
    }
}
