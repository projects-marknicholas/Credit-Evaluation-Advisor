using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Credit_Evaluation_Advisor
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=gene;User ID=root;Password=;";
        private int currentIndex = 0;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();

            // Link button click events
            btnPrevious.Click += btnPrevious_Click;
            btnNext.Click += btnNext_Click;
            btnFirst.Click += btnFirst_Click;
            btnLast.Click += btnLast_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
            FetchAndFilterRequests();
            list_of_requests.CellClick += ListOfRequests_CellClick;
        }

        private void CheckDatabaseConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FetchAndFilterRequests()
        {
            // This query selects only the columns you want to display in the DataGridView
            string displayQuery = "SELECT id, user_no, applicant_name FROM requests";

            // This query fetches all the columns you need for displaying detailed data
            string fullDataQuery = "SELECT * FROM requests";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch display data (only the columns for the DataGridView)
                    using (MySqlDataAdapter displayAdapter = new MySqlDataAdapter(displayQuery, connection))
                    {
                        DataTable displayTable = new DataTable();
                        displayAdapter.Fill(displayTable);

                        // Bind the display table to the DataGridView
                        list_of_requests.DataSource = displayTable;
                    }

                    // Fetch full data (all columns) and store in a separate DataTable
                    using (MySqlDataAdapter fullDataAdapter = new MySqlDataAdapter(fullDataQuery, connection))
                    {
                        dataTable = new DataTable(); // This is your full data table
                        fullDataAdapter.Fill(dataTable);
                    }

                    // Optionally display the first record in detail
                    if (dataTable.Rows.Count > 0)
                    {
                        DisplayRequestDetails(0);  // Display the first record in detail
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListOfRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < list_of_requests.Rows.Count)
            {
                // Find the selected request's ID from the display DataGridView
                int selectedId = Convert.ToInt32(list_of_requests.Rows[e.RowIndex].Cells["id"].Value);

                // Find the corresponding row in the full data table using the selected ID
                DataRow selectedRow = dataTable.Select($"id = {selectedId}").FirstOrDefault();

                if (selectedRow != null)
                {
                    currentIndex = dataTable.Rows.IndexOf(selectedRow);
                    DisplayRequestDetails(currentIndex);
                }
            }
        }

        private void DisplayRequestDetails(int rowIndex)
        {
            if (dataTable != null && rowIndex >= 0 && rowIndex < dataTable.Rows.Count)
            {
                // Assuming you have controls to display request details
                DataRow row = dataTable.Rows[rowIndex];
                string requested_credit = row["requested_credit"].ToString();
                string currency_deposits = row["currency_deposits"].ToString();
                string stocks = row["stocks"].ToString();
                string mortgages = row["mortgages"].ToString();
                string networth_to_assets = row["net_worth_to_assets"].ToString();
                string last_year_sales_growth = row["last_year_sales_growth"].ToString();
                string growth_profit_on_sales = row["growth_profit_on_sales"].ToString();
                string short_tem_debt_to_sales = row["short_term_debt_to_sales"].ToString();
                string expected_yield = row["expected_yield"].ToString();

                // Update controls with details (e.g., TextBoxes, Labels)
                requested_credit_value.Text = requested_credit;
                currency_deposits_value.Text = currency_deposits;
                stocks_value.Text = stocks;
                mortgages_value.Text = mortgages;
                networth_to_assets_value.Text = networth_to_assets;
                last_year_sales_growth_value.Text = last_year_sales_growth;
                growth_profit_on_sales_value.Text = growth_profit_on_sales;
                short_tem_debt_to_sales_value.Text = short_tem_debt_to_sales;
                expected_yield_value.Text = expected_yield;

                // Validate yield value
                double yieldValue;
                if (double.TryParse(expected_yield, out yieldValue))
                {
                    if (yieldValue >= 15)
                    {
                        expected_yield_value.Text = "Excellent";
                    }
                    else if (yieldValue >= 10 && yieldValue < 15)
                    {
                        expected_yield_value.Text = "Good";
                    }
                    else
                    {
                        expected_yield_value.Text = "Bad";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid expected yield value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void evaluate_credit_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the values from the text fields
                double requestedCredit = double.Parse(requested_credit_value.Text);
                double currencyDeposits = double.Parse(currency_deposits_value.Text);
                double stocks = double.Parse(stocks_value.Text);
                double mortgages = double.Parse(mortgages_value.Text);
                double networthToAssets = double.Parse(networth_to_assets_value.Text);
                double lastYearSalesGrowth = double.Parse(last_year_sales_growth_value.Text);
                double growthProfitOnSales = double.Parse(growth_profit_on_sales_value.Text);
                double shortTermDebtToSales = double.Parse(short_tem_debt_to_sales_value.Text);

                double expectedYield;

                // Handle the expected_yield_value which might be a non-numeric value
                if (double.TryParse(expected_yield_value.Text, out expectedYield))
                {
                    // Evaluate Collateral Rating
                    double totalCollateral = currencyDeposits + stocks + mortgages;
                    string collateralRating = EvaluateCollateralRating(totalCollateral, requestedCredit);

                    // Evaluate Financial Rating
                    string financialRating = EvaluateFinancialRating(networthToAssets, lastYearSalesGrowth, growthProfitOnSales, shortTermDebtToSales, expectedYield);

                    // Display the ratings
                    collateral_rating.Text = collateralRating;
                    financial_rating.Text = financialRating;
                }
                else
                {
                    // Handle non-numeric expected yield cases (e.g., "Excellent", "Good", "Bad")
                    string financialRating = expected_yield_value.Text;  // Use the text as financial rating directly

                    // Calculate collateral rating
                    double totalCollateral = currencyDeposits + stocks + mortgages;
                    string collateralRating = EvaluateCollateralRating(totalCollateral, requestedCredit);

                    // Display the ratings
                    collateral_rating.Text = collateralRating;
                    financial_rating.Text = financialRating;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please ensure all fields contain numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EvaluateCollateralRating(double totalCollateral, double requestedCredit)
        {
            if (totalCollateral >= requestedCredit)
            {
                return "Strong";
            }
            else if (totalCollateral >= requestedCredit * 0.75)
            {
                return "Moderate";
            }
            else
            {
                return "Weak";
            }
        }

        private string EvaluateFinancialRating(double networthToAssets, double lastYearSalesGrowth, double growthProfitOnSales, double shortTermDebtToSales, double expectedYield)
        {
            // Implement your financial rating logic here based on the values
            // This is a placeholder logic, customize as needed
            if (networthToAssets >= 0.5 && lastYearSalesGrowth >= 10 && growthProfitOnSales >= 5 && shortTermDebtToSales <= 0.3 && expectedYield >= 10)
            {
                return "Strong";
            }
            else if (networthToAssets >= 0.3 && lastYearSalesGrowth >= 5)
            {
                return "Moderate";
            }
            else
            {
                return "Weak";
            }
        }

        // Event Handlers for Navigation Buttons
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0) return;

            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayRequestDetails(currentIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0) return;

            if (currentIndex < dataTable.Rows.Count - 1)
            {
                currentIndex++;
                DisplayRequestDetails(currentIndex);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0) return;

            currentIndex = 0;
            DisplayRequestDetails(currentIndex);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (dataTable == null || dataTable.Rows.Count == 0) return;

            currentIndex = dataTable.Rows.Count - 1;
            DisplayRequestDetails(currentIndex);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // Add your custom paint logic here
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Add your custom paint logic here, if needed
        }

        private void give_credit_Click(object sender, EventArgs e)
        {

        }

        private void give_credit_Click_1(object sender, EventArgs e)
        {
            if (dataTable != null && currentIndex >= 0 && currentIndex < dataTable.Rows.Count)
            {
                // Get the selected request details
                DataRow selectedRow = dataTable.Rows[currentIndex];
                string requested_credit = selectedRow["requested_credit"].ToString();
                string currency_deposits = selectedRow["currency_deposits"].ToString();
                string stocks = selectedRow["stocks"].ToString();
                string mortgages = selectedRow["mortgages"].ToString();

                // Display a message box confirming that credit has been given
                MessageBox.Show($"Credit has been given for the selected request:\n\n" +
                                $"Requested Credit: {requested_credit}\n" +
                                $"Currency Deposits: {currency_deposits}\n" +
                                $"Stocks: {stocks}\n" +
                                $"Mortgages: {mortgages}",
                                "Credit Given",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No request is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
