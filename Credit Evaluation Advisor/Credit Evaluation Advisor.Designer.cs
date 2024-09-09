namespace Credit_Evaluation_Advisor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            short_tem_debt_to_sales_value = new TextBox();
            growth_profit_on_sales_value = new TextBox();
            last_year_sales_growth_value = new TextBox();
            networth_to_assets_value = new TextBox();
            mortgages_value = new TextBox();
            stocks_value = new TextBox();
            currency_deposits_value = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            requested_credit_value = new TextBox();
            expected_yield_value = new TextBox();
            panel1 = new Panel();
            label10 = new Label();
            list_of_requests = new DataGridView();
            btnPrevious = new Button();
            btnNext = new Button();
            btnFirst = new Button();
            btnLast = new Button();
            label11 = new Label();
            give_credit = new Button();
            evaluate_credit = new Button();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            financial_rating = new TextBox();
            collateral_rating = new TextBox();
            label12 = new Label();
            label13 = new Label();
            help = new Button();
            restart = new Button();
            exit = new Button();
            deny_credit = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)list_of_requests).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(short_tem_debt_to_sales_value, 1, 7);
            tableLayoutPanel1.Controls.Add(growth_profit_on_sales_value, 1, 6);
            tableLayoutPanel1.Controls.Add(last_year_sales_growth_value, 1, 5);
            tableLayoutPanel1.Controls.Add(networth_to_assets_value, 1, 4);
            tableLayoutPanel1.Controls.Add(mortgages_value, 1, 3);
            tableLayoutPanel1.Controls.Add(stocks_value, 1, 2);
            tableLayoutPanel1.Controls.Add(currency_deposits_value, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(requested_credit_value, 1, 0);
            tableLayoutPanel1.Controls.Add(expected_yield_value, 1, 8);
            tableLayoutPanel1.Location = new Point(15, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.Size = new Size(413, 304);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // short_tem_debt_to_sales_value
            // 
            short_tem_debt_to_sales_value.BackColor = Color.White;
            short_tem_debt_to_sales_value.BorderStyle = BorderStyle.None;
            short_tem_debt_to_sales_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            short_tem_debt_to_sales_value.Location = new Point(209, 234);
            short_tem_debt_to_sales_value.Name = "short_tem_debt_to_sales_value";
            short_tem_debt_to_sales_value.ReadOnly = true;
            short_tem_debt_to_sales_value.RightToLeft = RightToLeft.No;
            short_tem_debt_to_sales_value.Size = new Size(201, 22);
            short_tem_debt_to_sales_value.TabIndex = 27;
            short_tem_debt_to_sales_value.Text = "0";
            short_tem_debt_to_sales_value.TextAlign = HorizontalAlignment.Right;
            // 
            // growth_profit_on_sales_value
            // 
            growth_profit_on_sales_value.BackColor = Color.White;
            growth_profit_on_sales_value.BorderStyle = BorderStyle.None;
            growth_profit_on_sales_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            growth_profit_on_sales_value.Location = new Point(209, 201);
            growth_profit_on_sales_value.Name = "growth_profit_on_sales_value";
            growth_profit_on_sales_value.ReadOnly = true;
            growth_profit_on_sales_value.RightToLeft = RightToLeft.No;
            growth_profit_on_sales_value.Size = new Size(201, 22);
            growth_profit_on_sales_value.TabIndex = 26;
            growth_profit_on_sales_value.Text = "0";
            growth_profit_on_sales_value.TextAlign = HorizontalAlignment.Right;
            // 
            // last_year_sales_growth_value
            // 
            last_year_sales_growth_value.BackColor = Color.White;
            last_year_sales_growth_value.BorderStyle = BorderStyle.None;
            last_year_sales_growth_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            last_year_sales_growth_value.Location = new Point(209, 168);
            last_year_sales_growth_value.Name = "last_year_sales_growth_value";
            last_year_sales_growth_value.ReadOnly = true;
            last_year_sales_growth_value.RightToLeft = RightToLeft.No;
            last_year_sales_growth_value.Size = new Size(201, 22);
            last_year_sales_growth_value.TabIndex = 25;
            last_year_sales_growth_value.Text = "0";
            last_year_sales_growth_value.TextAlign = HorizontalAlignment.Right;
            // 
            // networth_to_assets_value
            // 
            networth_to_assets_value.BackColor = Color.White;
            networth_to_assets_value.BorderStyle = BorderStyle.None;
            networth_to_assets_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networth_to_assets_value.Location = new Point(209, 135);
            networth_to_assets_value.Name = "networth_to_assets_value";
            networth_to_assets_value.ReadOnly = true;
            networth_to_assets_value.RightToLeft = RightToLeft.No;
            networth_to_assets_value.Size = new Size(201, 22);
            networth_to_assets_value.TabIndex = 24;
            networth_to_assets_value.Text = "0";
            networth_to_assets_value.TextAlign = HorizontalAlignment.Right;
            // 
            // mortgages_value
            // 
            mortgages_value.BackColor = Color.White;
            mortgages_value.BorderStyle = BorderStyle.None;
            mortgages_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mortgages_value.Location = new Point(209, 102);
            mortgages_value.Name = "mortgages_value";
            mortgages_value.ReadOnly = true;
            mortgages_value.RightToLeft = RightToLeft.No;
            mortgages_value.Size = new Size(201, 22);
            mortgages_value.TabIndex = 23;
            mortgages_value.Text = "0";
            mortgages_value.TextAlign = HorizontalAlignment.Right;
            // 
            // stocks_value
            // 
            stocks_value.BackColor = Color.White;
            stocks_value.BorderStyle = BorderStyle.None;
            stocks_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stocks_value.Location = new Point(209, 69);
            stocks_value.Name = "stocks_value";
            stocks_value.ReadOnly = true;
            stocks_value.RightToLeft = RightToLeft.No;
            stocks_value.Size = new Size(201, 22);
            stocks_value.TabIndex = 22;
            stocks_value.Text = "0";
            stocks_value.TextAlign = HorizontalAlignment.Right;
            // 
            // currency_deposits_value
            // 
            currency_deposits_value.BackColor = Color.White;
            currency_deposits_value.BorderStyle = BorderStyle.None;
            currency_deposits_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currency_deposits_value.Location = new Point(209, 36);
            currency_deposits_value.Name = "currency_deposits_value";
            currency_deposits_value.ReadOnly = true;
            currency_deposits_value.RightToLeft = RightToLeft.No;
            currency_deposits_value.Size = new Size(201, 22);
            currency_deposits_value.TabIndex = 21;
            currency_deposits_value.Text = "0";
            currency_deposits_value.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(200, 33);
            label2.TabIndex = 12;
            label2.Text = "Currency deposits";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(200, 33);
            label1.TabIndex = 11;
            label1.Text = "Requested credit";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(200, 33);
            label3.TabIndex = 13;
            label3.Text = "Stocks";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(200, 33);
            label4.TabIndex = 14;
            label4.Text = "Mortgages";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(200, 33);
            label5.TabIndex = 15;
            label5.Text = "Networth to assets";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 165);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(200, 33);
            label6.TabIndex = 16;
            label6.Text = "Last year's sales growth";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 198);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(200, 33);
            label7.TabIndex = 17;
            label7.Text = "Growth profit on sales";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 231);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(200, 33);
            label8.TabIndex = 18;
            label8.Text = "Short-term debt to sales";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 264);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(200, 33);
            label9.TabIndex = 19;
            label9.Text = "Expected yield";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // requested_credit_value
            // 
            requested_credit_value.BackColor = Color.White;
            requested_credit_value.BorderStyle = BorderStyle.None;
            requested_credit_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requested_credit_value.Location = new Point(209, 3);
            requested_credit_value.Name = "requested_credit_value";
            requested_credit_value.ReadOnly = true;
            requested_credit_value.RightToLeft = RightToLeft.No;
            requested_credit_value.Size = new Size(201, 22);
            requested_credit_value.TabIndex = 20;
            requested_credit_value.Text = "0";
            requested_credit_value.TextAlign = HorizontalAlignment.Right;
            // 
            // expected_yield_value
            // 
            expected_yield_value.BackColor = Color.White;
            expected_yield_value.BorderStyle = BorderStyle.None;
            expected_yield_value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expected_yield_value.Location = new Point(209, 267);
            expected_yield_value.Name = "expected_yield_value";
            expected_yield_value.ReadOnly = true;
            expected_yield_value.RightToLeft = RightToLeft.No;
            expected_yield_value.Size = new Size(201, 22);
            expected_yield_value.TabIndex = 28;
            expected_yield_value.Text = "Excellent";
            expected_yield_value.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 334);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(554, 12);
            label10.Name = "label10";
            label10.Size = new Size(150, 25);
            label10.TabIndex = 3;
            label10.Text = "List of Requests";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // list_of_requests
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            list_of_requests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            list_of_requests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list_of_requests.Location = new Point(474, 52);
            list_of_requests.Name = "list_of_requests";
            list_of_requests.Size = new Size(314, 150);
            list_of_requests.TabIndex = 4;
            // 
            // btnPrevious
            // 
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.Location = new Point(551, 222);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 28);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Location = new Point(632, 222);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 28);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.Location = new Point(551, 256);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 28);
            btnFirst.TabIndex = 7;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.Cursor = Cursors.Hand;
            btnLast.Location = new Point(632, 255);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 28);
            btnLast.TabIndex = 8;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(474, 301);
            label11.MaximumSize = new Size(306, 40);
            label11.MinimumSize = new Size(306, 40);
            label11.Name = "label11";
            label11.Size = new Size(306, 40);
            label11.TabIndex = 9;
            label11.Text = "The Credit Evaluation Advisor has determin\r\ned the category  of the credit requests as";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // give_credit
            // 
            give_credit.BackColor = Color.Black;
            give_credit.Cursor = Cursors.Hand;
            give_credit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            give_credit.ForeColor = Color.White;
            give_credit.Location = new Point(474, 366);
            give_credit.Name = "give_credit";
            give_credit.Size = new Size(314, 39);
            give_credit.TabIndex = 10;
            give_credit.Text = "Give Credit";
            give_credit.UseVisualStyleBackColor = false;
            give_credit.Click += give_credit_Click_1;
            // 
            // evaluate_credit
            // 
            evaluate_credit.Cursor = Cursors.Hand;
            evaluate_credit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            evaluate_credit.Location = new Point(12, 366);
            evaluate_credit.Name = "evaluate_credit";
            evaluate_credit.Size = new Size(445, 39);
            evaluate_credit.TabIndex = 11;
            evaluate_credit.Text = "Evaluate credit";
            evaluate_credit.UseVisualStyleBackColor = true;
            evaluate_credit.Click += evaluate_credit_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(12, 421);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 87);
            panel2.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(financial_rating, 1, 1);
            tableLayoutPanel2.Controls.Add(collateral_rating, 1, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 0);
            tableLayoutPanel2.Controls.Add(label13, 0, 1);
            tableLayoutPanel2.Location = new Point(16, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(413, 60);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // financial_rating
            // 
            financial_rating.BackColor = Color.White;
            financial_rating.BorderStyle = BorderStyle.None;
            financial_rating.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            financial_rating.Location = new Point(209, 33);
            financial_rating.Name = "financial_rating";
            financial_rating.ReadOnly = true;
            financial_rating.RightToLeft = RightToLeft.No;
            financial_rating.Size = new Size(201, 22);
            financial_rating.TabIndex = 30;
            financial_rating.TextAlign = HorizontalAlignment.Right;
            // 
            // collateral_rating
            // 
            collateral_rating.BackColor = Color.White;
            collateral_rating.BorderStyle = BorderStyle.None;
            collateral_rating.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            collateral_rating.Location = new Point(209, 3);
            collateral_rating.Name = "collateral_rating";
            collateral_rating.ReadOnly = true;
            collateral_rating.RightToLeft = RightToLeft.No;
            collateral_rating.Size = new Size(201, 22);
            collateral_rating.TabIndex = 29;
            collateral_rating.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(200, 30);
            label12.TabIndex = 20;
            label12.Text = "Collateral";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 30);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(200, 30);
            label13.TabIndex = 21;
            label13.Text = "Financial rating";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // help
            // 
            help.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            help.Location = new Point(12, 524);
            help.Name = "help";
            help.Size = new Size(75, 29);
            help.TabIndex = 13;
            help.Text = "Help";
            help.UseVisualStyleBackColor = true;
            // 
            // restart
            // 
            restart.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restart.Location = new Point(93, 524);
            restart.Name = "restart";
            restart.Size = new Size(75, 29);
            restart.TabIndex = 14;
            restart.Text = "Restart";
            restart.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(713, 524);
            exit.Name = "exit";
            exit.Size = new Size(75, 29);
            exit.TabIndex = 15;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // deny_credit
            // 
            deny_credit.BackColor = Color.FromArgb(192, 0, 0);
            deny_credit.Cursor = Cursors.Hand;
            deny_credit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deny_credit.ForeColor = Color.White;
            deny_credit.Location = new Point(474, 366);
            deny_credit.Name = "deny_credit";
            deny_credit.Size = new Size(314, 39);
            deny_credit.TabIndex = 16;
            deny_credit.Text = "Deny Credit";
            deny_credit.UseVisualStyleBackColor = false;
            deny_credit.Click += deny_credit_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 591);
            Controls.Add(deny_credit);
            Controls.Add(exit);
            Controls.Add(restart);
            Controls.Add(help);
            Controls.Add(panel2);
            Controls.Add(evaluate_credit);
            Controls.Add(give_credit);
            Controls.Add(label11);
            Controls.Add(btnLast);
            Controls.Add(btnFirst);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(list_of_requests);
            Controls.Add(label10);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credit Evaluation Advisor";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)list_of_requests).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox requested_credit_value;
        private TextBox expected_yield_value;
        private TextBox short_tem_debt_to_sales_value;
        private TextBox growth_profit_on_sales_value;
        private TextBox last_year_sales_growth_value;
        private TextBox networth_to_assets_value;
        private TextBox mortgages_value;
        private TextBox stocks_value;
        private TextBox currency_deposits_value;
        private Panel panel1;
        private Label label10;
        private DataGridView list_of_requests;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnFirst;
        private Button btnLast;
        private Label label11;
        private Button give_credit;
        private Button evaluate_credit;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox financial_rating;
        private TextBox collateral_rating;
        private Label label12;
        private Label label13;
        private Button help;
        private Button restart;
        private Button exit;
        private Button deny_credit;
    }
}
