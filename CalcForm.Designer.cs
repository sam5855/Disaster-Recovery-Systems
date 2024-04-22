namespace Disaster_Recovery_Solution
{
    partial class CalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accrualMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.repaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.amountBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.amortizedTermTextBox = new System.Windows.Forms.TextBox();
            this.loanTermTextBox = new System.Windows.Forms.TextBox();
            this.loanDatePicker = new System.Windows.Forms.DateTimePicker();
            this.initialRateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paymentFreqComboBox = new System.Windows.Forms.ComboBox();
            this.paymentAmountOverrideTextBox = new System.Windows.Forms.TextBox();
            this.maturityDatePicker = new System.Windows.Forms.DateTimePicker();
            this.firstPaymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.jon2AprComboBox = new System.Windows.Forms.ComboBox();
            this.jonAprComboBox = new System.Windows.Forms.ComboBox();
            this.aprAprComboBox = new System.Windows.Forms.ComboBox();
            this.jon2AmountTextBox = new System.Windows.Forms.TextBox();
            this.jonAmountTextBox = new System.Windows.Forms.TextBox();
            this.aprAmountTextBox = new System.Windows.Forms.TextBox();
            this.jon2PayableComboBox = new System.Windows.Forms.ComboBox();
            this.jonPayableComboBox = new System.Windows.Forms.ComboBox();
            this.aprPayableComboBox = new System.Windows.Forms.ComboBox();
            this.jon2CollectionComboBox = new System.Windows.Forms.ComboBox();
            this.jonCollectionComboBox = new System.Windows.Forms.ComboBox();
            this.aprEffectingCollectionComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loanDetailsDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.calculateLoanButton = new System.Windows.Forms.Button();
            this.importCSVButton = new System.Windows.Forms.Button();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.deleteLoanButton = new System.Windows.Forms.Button();
            this.loanDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxAprWithFees = new System.Windows.Forms.TextBox();
            this.textBoxTotalFinanceCharge = new System.Windows.Forms.TextBox();
            this.textBoxAprEffectingFee = new System.Windows.Forms.TextBox();
            this.textBoxAprNoFeesIncluded = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrincipalPaid = new System.Windows.Forms.TextBox();
            this.textBoxTotalInterestPaid = new System.Windows.Forms.TextBox();
            this.textBoxEstimatedPayment = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxTotalFinancedWithFees = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.clearInputsButton = new System.Windows.Forms.Button();
            this.exportProgressButton = new System.Windows.Forms.Button();
            this.importProgressButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsDGV)).BeginInit();
            this.loanDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calc Engine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loan Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Initial Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repayment Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loan Term";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amortized Term";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount Borrowed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(52, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Payment Frequency";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Specified 1st Payment Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(28, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Specified Maturity Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(11, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Payment Amount Override";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accrualMethodComboBox);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.repaymentMethodComboBox);
            this.groupBox1.Controls.Add(this.amountBorrowedTextBox);
            this.groupBox1.Controls.Add(this.amortizedTermTextBox);
            this.groupBox1.Controls.Add(this.loanTermTextBox);
            this.groupBox1.Controls.Add(this.loanDatePicker);
            this.groupBox1.Controls.Add(this.initialRateTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(42, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 276);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Terms";
            // 
            // accrualMethodComboBox
            // 
            this.accrualMethodComboBox.FormattingEnabled = true;
            this.accrualMethodComboBox.Items.AddRange(new object[] {
            "Term Loan (P&I)",
            "Balloon",
            "Interest Only",
            "Principle Plus"});
            this.accrualMethodComboBox.Location = new System.Drawing.Point(149, 206);
            this.accrualMethodComboBox.Name = "accrualMethodComboBox";
            this.accrualMethodComboBox.Size = new System.Drawing.Size(106, 23);
            this.accrualMethodComboBox.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(29, 207);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "Accrual Method";
            // 
            // repaymentMethodComboBox
            // 
            this.repaymentMethodComboBox.FormattingEnabled = true;
            this.repaymentMethodComboBox.Items.AddRange(new object[] {
            "Term Loan (P&I)",
            "Balloon",
            "Interest Only",
            "Principle Plus"});
            this.repaymentMethodComboBox.Location = new System.Drawing.Point(149, 88);
            this.repaymentMethodComboBox.Name = "repaymentMethodComboBox";
            this.repaymentMethodComboBox.Size = new System.Drawing.Size(106, 23);
            this.repaymentMethodComboBox.TabIndex = 24;
            // 
            // amountBorrowedTextBox
            // 
            this.amountBorrowedTextBox.Location = new System.Drawing.Point(149, 175);
            this.amountBorrowedTextBox.Name = "amountBorrowedTextBox";
            this.amountBorrowedTextBox.Size = new System.Drawing.Size(106, 23);
            this.amountBorrowedTextBox.TabIndex = 29;
            // 
            // amortizedTermTextBox
            // 
            this.amortizedTermTextBox.Location = new System.Drawing.Point(149, 146);
            this.amortizedTermTextBox.Name = "amortizedTermTextBox";
            this.amortizedTermTextBox.Size = new System.Drawing.Size(106, 23);
            this.amortizedTermTextBox.TabIndex = 28;
            // 
            // loanTermTextBox
            // 
            this.loanTermTextBox.Location = new System.Drawing.Point(149, 117);
            this.loanTermTextBox.Name = "loanTermTextBox";
            this.loanTermTextBox.Size = new System.Drawing.Size(106, 23);
            this.loanTermTextBox.TabIndex = 27;
            // 
            // loanDatePicker
            // 
            this.loanDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.loanDatePicker.Location = new System.Drawing.Point(149, 30);
            this.loanDatePicker.Name = "loanDatePicker";
            this.loanDatePicker.Size = new System.Drawing.Size(106, 23);
            this.loanDatePicker.TabIndex = 25;
            // 
            // initialRateTextBox
            // 
            this.initialRateTextBox.Location = new System.Drawing.Point(149, 59);
            this.initialRateTextBox.Name = "initialRateTextBox";
            this.initialRateTextBox.Size = new System.Drawing.Size(106, 23);
            this.initialRateTextBox.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentFreqComboBox);
            this.groupBox2.Controls.Add(this.paymentAmountOverrideTextBox);
            this.groupBox2.Controls.Add(this.maturityDatePicker);
            this.groupBox2.Controls.Add(this.firstPaymentDatePicker);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(368, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 276);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Specified Terms";
            // 
            // paymentFreqComboBox
            // 
            this.paymentFreqComboBox.FormattingEnabled = true;
            this.paymentFreqComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.paymentFreqComboBox.Location = new System.Drawing.Point(195, 43);
            this.paymentFreqComboBox.Name = "paymentFreqComboBox";
            this.paymentFreqComboBox.Size = new System.Drawing.Size(106, 23);
            this.paymentFreqComboBox.TabIndex = 30;
            // 
            // paymentAmountOverrideTextBox
            // 
            this.paymentAmountOverrideTextBox.Location = new System.Drawing.Point(195, 130);
            this.paymentAmountOverrideTextBox.Name = "paymentAmountOverrideTextBox";
            this.paymentAmountOverrideTextBox.Size = new System.Drawing.Size(106, 23);
            this.paymentAmountOverrideTextBox.TabIndex = 30;
            // 
            // maturityDatePicker
            // 
            this.maturityDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maturityDatePicker.Location = new System.Drawing.Point(195, 101);
            this.maturityDatePicker.Name = "maturityDatePicker";
            this.maturityDatePicker.Size = new System.Drawing.Size(106, 23);
            this.maturityDatePicker.TabIndex = 31;
            // 
            // firstPaymentDatePicker
            // 
            this.firstPaymentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstPaymentDatePicker.Location = new System.Drawing.Point(195, 72);
            this.firstPaymentDatePicker.Name = "firstPaymentDatePicker";
            this.firstPaymentDatePicker.Size = new System.Drawing.Size(106, 23);
            this.firstPaymentDatePicker.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.jon2AprComboBox);
            this.groupBox3.Controls.Add(this.jonAprComboBox);
            this.groupBox3.Controls.Add(this.aprAprComboBox);
            this.groupBox3.Controls.Add(this.jon2AmountTextBox);
            this.groupBox3.Controls.Add(this.jonAmountTextBox);
            this.groupBox3.Controls.Add(this.aprAmountTextBox);
            this.groupBox3.Controls.Add(this.jon2PayableComboBox);
            this.groupBox3.Controls.Add(this.jonPayableComboBox);
            this.groupBox3.Controls.Add(this.aprPayableComboBox);
            this.groupBox3.Controls.Add(this.jon2CollectionComboBox);
            this.groupBox3.Controls.Add(this.jonCollectionComboBox);
            this.groupBox3.Controls.Add(this.aprEffectingCollectionComboBox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(703, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 276);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fees";
            // 
            // jon2AprComboBox
            // 
            this.jon2AprComboBox.FormattingEnabled = true;
            this.jon2AprComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.jon2AprComboBox.Location = new System.Drawing.Point(506, 163);
            this.jon2AprComboBox.Name = "jon2AprComboBox";
            this.jon2AprComboBox.Size = new System.Drawing.Size(121, 23);
            this.jon2AprComboBox.TabIndex = 23;
            // 
            // jonAprComboBox
            // 
            this.jonAprComboBox.FormattingEnabled = true;
            this.jonAprComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.jonAprComboBox.Location = new System.Drawing.Point(506, 121);
            this.jonAprComboBox.Name = "jonAprComboBox";
            this.jonAprComboBox.Size = new System.Drawing.Size(121, 23);
            this.jonAprComboBox.TabIndex = 22;
            // 
            // aprAprComboBox
            // 
            this.aprAprComboBox.FormattingEnabled = true;
            this.aprAprComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.aprAprComboBox.Location = new System.Drawing.Point(506, 80);
            this.aprAprComboBox.Name = "aprAprComboBox";
            this.aprAprComboBox.Size = new System.Drawing.Size(121, 23);
            this.aprAprComboBox.TabIndex = 21;
            // 
            // jon2AmountTextBox
            // 
            this.jon2AmountTextBox.Location = new System.Drawing.Point(400, 164);
            this.jon2AmountTextBox.Name = "jon2AmountTextBox";
            this.jon2AmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.jon2AmountTextBox.TabIndex = 20;
            // 
            // jonAmountTextBox
            // 
            this.jonAmountTextBox.Location = new System.Drawing.Point(400, 122);
            this.jonAmountTextBox.Name = "jonAmountTextBox";
            this.jonAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.jonAmountTextBox.TabIndex = 19;
            // 
            // aprAmountTextBox
            // 
            this.aprAmountTextBox.Location = new System.Drawing.Point(400, 80);
            this.aprAmountTextBox.Name = "aprAmountTextBox";
            this.aprAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.aprAmountTextBox.TabIndex = 18;
            // 
            // jon2PayableComboBox
            // 
            this.jon2PayableComboBox.FormattingEnabled = true;
            this.jon2PayableComboBox.Items.AddRange(new object[] {
            "Borrower",
            "Lender"});
            this.jon2PayableComboBox.Location = new System.Drawing.Point(273, 163);
            this.jon2PayableComboBox.Name = "jon2PayableComboBox";
            this.jon2PayableComboBox.Size = new System.Drawing.Size(121, 23);
            this.jon2PayableComboBox.TabIndex = 17;
            // 
            // jonPayableComboBox
            // 
            this.jonPayableComboBox.FormattingEnabled = true;
            this.jonPayableComboBox.Items.AddRange(new object[] {
            "Borrower",
            "Lender"});
            this.jonPayableComboBox.Location = new System.Drawing.Point(273, 121);
            this.jonPayableComboBox.Name = "jonPayableComboBox";
            this.jonPayableComboBox.Size = new System.Drawing.Size(121, 23);
            this.jonPayableComboBox.TabIndex = 16;
            // 
            // aprPayableComboBox
            // 
            this.aprPayableComboBox.FormattingEnabled = true;
            this.aprPayableComboBox.Items.AddRange(new object[] {
            "Borrower",
            "Lender"});
            this.aprPayableComboBox.Location = new System.Drawing.Point(273, 80);
            this.aprPayableComboBox.Name = "aprPayableComboBox";
            this.aprPayableComboBox.Size = new System.Drawing.Size(121, 23);
            this.aprPayableComboBox.TabIndex = 15;
            // 
            // jon2CollectionComboBox
            // 
            this.jon2CollectionComboBox.FormattingEnabled = true;
            this.jon2CollectionComboBox.Items.AddRange(new object[] {
            "Cash",
            "Added to Amount Financed",
            "Subtracted from Amount Financed"});
            this.jon2CollectionComboBox.Location = new System.Drawing.Point(147, 164);
            this.jon2CollectionComboBox.Name = "jon2CollectionComboBox";
            this.jon2CollectionComboBox.Size = new System.Drawing.Size(121, 23);
            this.jon2CollectionComboBox.TabIndex = 14;
            // 
            // jonCollectionComboBox
            // 
            this.jonCollectionComboBox.FormattingEnabled = true;
            this.jonCollectionComboBox.Items.AddRange(new object[] {
            "Cash",
            "Added to Amount Financed",
            "Subtracted from Amount Financed"});
            this.jonCollectionComboBox.Location = new System.Drawing.Point(147, 121);
            this.jonCollectionComboBox.Name = "jonCollectionComboBox";
            this.jonCollectionComboBox.Size = new System.Drawing.Size(121, 23);
            this.jonCollectionComboBox.TabIndex = 13;
            // 
            // aprEffectingCollectionComboBox
            // 
            this.aprEffectingCollectionComboBox.FormattingEnabled = true;
            this.aprEffectingCollectionComboBox.Items.AddRange(new object[] {
            "Cash",
            "Added to Amount Financed",
            "Subtracted from Amount Financed"});
            this.aprEffectingCollectionComboBox.Location = new System.Drawing.Point(146, 80);
            this.aprEffectingCollectionComboBox.Name = "aprEffectingCollectionComboBox";
            this.aprEffectingCollectionComboBox.Size = new System.Drawing.Size(121, 23);
            this.aprEffectingCollectionComboBox.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(529, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "APR Effecting";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(422, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "Amount";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(297, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Payable By";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(146, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Collection Method";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(102, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Fee";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(68, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Jon Fee 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(79, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Jon Fee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "APR Effecting Origin";
            // 
            // loanDetailsDGV
            // 
            this.loanDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanDetailsDGV.Location = new System.Drawing.Point(42, 465);
            this.loanDetailsDGV.Name = "loanDetailsDGV";
            this.loanDetailsDGV.RowTemplate.Height = 25;
            this.loanDetailsDGV.Size = new System.Drawing.Size(627, 150);
            this.loanDetailsDGV.TabIndex = 15;
            this.loanDetailsDGV.SelectionChanged += new System.EventHandler(this.loanDetailsDGV_SelectionChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1251, 826);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calculateLoanButton
            // 
            this.calculateLoanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateLoanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateLoanButton.Location = new System.Drawing.Point(1128, 335);
            this.calculateLoanButton.Name = "calculateLoanButton";
            this.calculateLoanButton.Size = new System.Drawing.Size(109, 39);
            this.calculateLoanButton.TabIndex = 18;
            this.calculateLoanButton.Text = "Calculate Loan";
            this.calculateLoanButton.UseVisualStyleBackColor = false;
            this.calculateLoanButton.Click += new System.EventHandler(this.calculateLoanButton_Click);
            // 
            // importCSVButton
            // 
            this.importCSVButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.importCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importCSVButton.Location = new System.Drawing.Point(42, 621);
            this.importCSVButton.Name = "importCSVButton";
            this.importCSVButton.Size = new System.Drawing.Size(109, 39);
            this.importCSVButton.TabIndex = 19;
            this.importCSVButton.Text = "Import CSV";
            this.importCSVButton.UseVisualStyleBackColor = false;
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exportCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportCSVButton.Location = new System.Drawing.Point(157, 621);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(109, 39);
            this.exportCSVButton.TabIndex = 20;
            this.exportCSVButton.Text = "Export CSV";
            this.exportCSVButton.UseVisualStyleBackColor = false;
            this.exportCSVButton.Click += new System.EventHandler(this.exportCSVButton_Click);
            // 
            // deleteLoanButton
            // 
            this.deleteLoanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteLoanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLoanButton.Location = new System.Drawing.Point(560, 621);
            this.deleteLoanButton.Name = "deleteLoanButton";
            this.deleteLoanButton.Size = new System.Drawing.Size(109, 39);
            this.deleteLoanButton.TabIndex = 21;
            this.deleteLoanButton.Text = "Delete";
            this.deleteLoanButton.UseVisualStyleBackColor = false;
            this.deleteLoanButton.Click += new System.EventHandler(this.deleteLoanButton_Click);
            // 
            // loanDetailsGroupBox
            // 
            this.loanDetailsGroupBox.Controls.Add(this.textBoxAprWithFees);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxTotalFinanceCharge);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxAprEffectingFee);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxAprNoFeesIncluded);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxTotalAmountPaid);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxTotalPrincipalPaid);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxTotalInterestPaid);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxEstimatedPayment);
            this.loanDetailsGroupBox.Controls.Add(this.label29);
            this.loanDetailsGroupBox.Controls.Add(this.label28);
            this.loanDetailsGroupBox.Controls.Add(this.label27);
            this.loanDetailsGroupBox.Controls.Add(this.label26);
            this.loanDetailsGroupBox.Controls.Add(this.label25);
            this.loanDetailsGroupBox.Controls.Add(this.label24);
            this.loanDetailsGroupBox.Controls.Add(this.label23);
            this.loanDetailsGroupBox.Controls.Add(this.label22);
            this.loanDetailsGroupBox.Controls.Add(this.textBoxTotalFinancedWithFees);
            this.loanDetailsGroupBox.Controls.Add(this.label21);
            this.loanDetailsGroupBox.Location = new System.Drawing.Point(703, 447);
            this.loanDetailsGroupBox.Name = "loanDetailsGroupBox";
            this.loanDetailsGroupBox.Size = new System.Drawing.Size(649, 213);
            this.loanDetailsGroupBox.TabIndex = 22;
            this.loanDetailsGroupBox.TabStop = false;
            this.loanDetailsGroupBox.Text = "Loan Details";
            // 
            // textBoxAprWithFees
            // 
            this.textBoxAprWithFees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxAprWithFees.Location = new System.Drawing.Point(499, 115);
            this.textBoxAprWithFees.Name = "textBoxAprWithFees";
            this.textBoxAprWithFees.ReadOnly = true;
            this.textBoxAprWithFees.Size = new System.Drawing.Size(106, 23);
            this.textBoxAprWithFees.TabIndex = 49;
            // 
            // textBoxTotalFinanceCharge
            // 
            this.textBoxTotalFinanceCharge.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTotalFinanceCharge.Location = new System.Drawing.Point(499, 84);
            this.textBoxTotalFinanceCharge.Name = "textBoxTotalFinanceCharge";
            this.textBoxTotalFinanceCharge.ReadOnly = true;
            this.textBoxTotalFinanceCharge.Size = new System.Drawing.Size(106, 23);
            this.textBoxTotalFinanceCharge.TabIndex = 48;
            // 
            // textBoxAprEffectingFee
            // 
            this.textBoxAprEffectingFee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxAprEffectingFee.Location = new System.Drawing.Point(499, 55);
            this.textBoxAprEffectingFee.Name = "textBoxAprEffectingFee";
            this.textBoxAprEffectingFee.ReadOnly = true;
            this.textBoxAprEffectingFee.Size = new System.Drawing.Size(106, 23);
            this.textBoxAprEffectingFee.TabIndex = 47;
            // 
            // textBoxAprNoFeesIncluded
            // 
            this.textBoxAprNoFeesIncluded.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxAprNoFeesIncluded.Location = new System.Drawing.Point(499, 21);
            this.textBoxAprNoFeesIncluded.Name = "textBoxAprNoFeesIncluded";
            this.textBoxAprNoFeesIncluded.ReadOnly = true;
            this.textBoxAprNoFeesIncluded.Size = new System.Drawing.Size(106, 23);
            this.textBoxAprNoFeesIncluded.TabIndex = 46;
            // 
            // textBoxTotalAmountPaid
            // 
            this.textBoxTotalAmountPaid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTotalAmountPaid.Location = new System.Drawing.Point(218, 150);
            this.textBoxTotalAmountPaid.Name = "textBoxTotalAmountPaid";
            this.textBoxTotalAmountPaid.ReadOnly = true;
            this.textBoxTotalAmountPaid.Size = new System.Drawing.Size(106, 23);
            this.textBoxTotalAmountPaid.TabIndex = 45;
            // 
            // textBoxTotalPrincipalPaid
            // 
            this.textBoxTotalPrincipalPaid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTotalPrincipalPaid.Location = new System.Drawing.Point(218, 115);
            this.textBoxTotalPrincipalPaid.Name = "textBoxTotalPrincipalPaid";
            this.textBoxTotalPrincipalPaid.ReadOnly = true;
            this.textBoxTotalPrincipalPaid.Size = new System.Drawing.Size(106, 23);
            this.textBoxTotalPrincipalPaid.TabIndex = 44;
            // 
            // textBoxTotalInterestPaid
            // 
            this.textBoxTotalInterestPaid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTotalInterestPaid.Location = new System.Drawing.Point(218, 84);
            this.textBoxTotalInterestPaid.Name = "textBoxTotalInterestPaid";
            this.textBoxTotalInterestPaid.ReadOnly = true;
            this.textBoxTotalInterestPaid.Size = new System.Drawing.Size(106, 23);
            this.textBoxTotalInterestPaid.TabIndex = 43;
            // 
            // textBoxEstimatedPayment
            // 
            this.textBoxEstimatedPayment.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEstimatedPayment.Location = new System.Drawing.Point(218, 55);
            this.textBoxEstimatedPayment.Name = "textBoxEstimatedPayment";
            this.textBoxEstimatedPayment.ReadOnly = true;
            this.textBoxEstimatedPayment.Size = new System.Drawing.Size(106, 23);
            this.textBoxEstimatedPayment.TabIndex = 42;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(405, 116);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 17);
            this.label29.TabIndex = 41;
            this.label29.Text = "APR with Fees";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(364, 85);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(129, 17);
            this.label28.TabIndex = 40;
            this.label28.Text = "Total Finance Charge";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(373, 56);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 17);
            this.label27.TabIndex = 39;
            this.label27.Text = "APR Effecting Fee $";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(351, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(142, 17);
            this.label26.TabIndex = 38;
            this.label26.Text = "APR (No fees Inlcuded)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(98, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 17);
            this.label25.TabIndex = 37;
            this.label25.Text = "Total Amount Paid";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(94, 116);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 17);
            this.label24.TabIndex = 36;
            this.label24.Text = "Total Principal Paid";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(100, 85);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 17);
            this.label23.TabIndex = 35;
            this.label23.Text = "Total Interest Paid";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(94, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "Estimated Payment";
            // 
            // textBoxTotalFinancedWithFees
            // 
            this.textBoxTotalFinancedWithFees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTotalFinancedWithFees.Location = new System.Drawing.Point(218, 22);
            this.textBoxTotalFinancedWithFees.Name = "textBoxTotalFinancedWithFees";
            this.textBoxTotalFinancedWithFees.ReadOnly = true;
            this.textBoxTotalFinancedWithFees.Size = new System.Drawing.Size(106, 23);
            this.textBoxTotalFinancedWithFees.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(3, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(209, 17);
            this.label21.TabIndex = 33;
            this.label21.Text = "Total Proceeds Financed with Fee\'s";
            // 
            // clearInputsButton
            // 
            this.clearInputsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearInputsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInputsButton.Location = new System.Drawing.Point(1243, 335);
            this.clearInputsButton.Name = "clearInputsButton";
            this.clearInputsButton.Size = new System.Drawing.Size(109, 39);
            this.clearInputsButton.TabIndex = 23;
            this.clearInputsButton.Text = "Clear Inputs";
            this.clearInputsButton.UseVisualStyleBackColor = false;
            this.clearInputsButton.Click += new System.EventHandler(this.clearInputsButton_Click);
            // 
            // exportProgressButton
            // 
            this.exportProgressButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exportProgressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportProgressButton.Location = new System.Drawing.Point(42, 335);
            this.exportProgressButton.Name = "exportProgressButton";
            this.exportProgressButton.Size = new System.Drawing.Size(109, 39);
            this.exportProgressButton.TabIndex = 24;
            this.exportProgressButton.Text = "Save Progress";
            this.exportProgressButton.UseVisualStyleBackColor = false;
            // 
            // importProgressButton
            // 
            this.importProgressButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.importProgressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importProgressButton.Location = new System.Drawing.Point(157, 335);
            this.importProgressButton.Name = "importProgressButton";
            this.importProgressButton.Size = new System.Drawing.Size(109, 39);
            this.importProgressButton.TabIndex = 25;
            this.importProgressButton.Text = "Load Inputs";
            this.importProgressButton.UseVisualStyleBackColor = false;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1372, 877);
            this.Controls.Add(this.importProgressButton);
            this.Controls.Add(this.exportProgressButton);
            this.Controls.Add(this.clearInputsButton);
            this.Controls.Add(this.loanDetailsGroupBox);
            this.Controls.Add(this.deleteLoanButton);
            this.Controls.Add(this.exportCSVButton);
            this.Controls.Add(this.importCSVButton);
            this.Controls.Add(this.calculateLoanButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loanDetailsDGV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disaster Recovery Solutions";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDetailsDGV)).EndInit();
            this.loanDetailsGroupBox.ResumeLayout(false);
            this.loanDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label8;
        private Label label9;
        private Label label19;
        private ComboBox jon2CollectionComboBox;
        private ComboBox jonCollectionComboBox;
        private ComboBox aprEffectingCollectionComboBox;
        private ComboBox jon2PayableComboBox;
        private ComboBox jonPayableComboBox;
        private ComboBox aprPayableComboBox;
        private TextBox amountBorrowedTextBox;
        private TextBox amortizedTermTextBox;
        private TextBox loanTermTextBox;
        private DateTimePicker loanDatePicker;
        private TextBox initialRateTextBox;
        private TextBox paymentAmountOverrideTextBox;
        private DateTimePicker maturityDatePicker;
        private DateTimePicker firstPaymentDatePicker;
        private ComboBox jon2AprComboBox;
        private ComboBox jonAprComboBox;
        private ComboBox aprAprComboBox;
        private TextBox jon2AmountTextBox;
        private TextBox jonAmountTextBox;
        private TextBox aprAmountTextBox;
        private DataGridView loanDetailsDGV;
        private Button button2;
        private Button calculateLoanButton;
        private ComboBox repaymentMethodComboBox;
        private Button importCSVButton;
        private Button exportCSVButton;
        private ComboBox paymentFreqComboBox;
        private Button deleteLoanButton;
        private ComboBox accrualMethodComboBox;
        private Label label20;
        private GroupBox loanDetailsGroupBox;
        private Label label21;
        private TextBox textBoxTotalFinancedWithFees;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private TextBox textBoxAprWithFees;
        private TextBox textBoxTotalFinanceCharge;
        private TextBox textBoxAprEffectingFee;
        private TextBox textBoxAprNoFeesIncluded;
        private TextBox textBoxTotalAmountPaid;
        private TextBox textBoxTotalPrincipalPaid;
        private TextBox textBoxTotalInterestPaid;
        private TextBox textBoxEstimatedPayment;
        private Button clearInputsButton;
        private Button exportProgressButton;
        private Button importProgressButton;
    }
}