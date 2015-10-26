using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrimeNumberCodeTest.Utilities;

namespace PrimeNumberCodeTest
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// The default limit we want to specify.
        /// </summary>
        private const int DEFAULT_LIMIT = 10000;

        /// <summary>
        /// The default size of the table.
        /// </summary>
        private const int DEFAULT_TABLE_SIZE = 1;

        /// <summary>
        /// An array of limits.
        /// </summary>
        private readonly List<int> LIMITS = new List<int> { 100, 1000, 10000 };

        /// <summary>
        /// A handle to the currently selected prime generator.
        /// </summary>
        private IPrimeGenerator _primeGenerator;

        /// <summary>
        /// The maximum limit we'll allow for each algorithm to generate its prime numbers.
        /// </summary>
        private int _limit = DEFAULT_LIMIT;

        public MainForm()
        {
            InitializeComponent();

            // This should make everything a little bit smoother :)
            DoubleBuffered = true;
        }

        private void EratosthenesLimit_1_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(false, 1);

            _limit = LIMITS[0];
        }

        private void EratosthenesLimit_2_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(false, 2);

            _limit = LIMITS[1];
        }

        private void EratosthenesLimit_3_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(false, 3);

            _limit = LIMITS[2];
        }

        private void AtkinLimit_1_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(true, 1);

            _limit = LIMITS[0];
        }

        private void AtkinLimit_2_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(true, 2);

            _limit = LIMITS[1];
        }

        private void AtkinLimit_3_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(true, 3);

            _limit = LIMITS[2];
        }

        private void SetStateOfSelectionMenu(Boolean isAtkinAlgorithmSelected, int indexOfSelection)
        {
            SetStateOfAlgorithmMenu(isAtkinAlgorithmSelected);

            EratosthenesLimit_1.Checked = !isAtkinAlgorithmSelected && indexOfSelection == 1;
            EratosthenesLimit_2.Checked = !isAtkinAlgorithmSelected && indexOfSelection == 2;
            EratosthenesLimit_3.Checked = !isAtkinAlgorithmSelected && indexOfSelection == 3;
        }

        private void SetStateOfAlgorithmMenu(Boolean isAtkinAlgorithmSelected)
        {
            AlgorithmSieveOfEratosthenes.Checked = !isAtkinAlgorithmSelected;
        }

        private void GenerateTable_Click(object sender, EventArgs e)
        {
            // Set the generator based on the select menu items.
            if (AlgorithmSieveOfEratosthenes.Checked)
            {
                _primeGenerator = new SieveOfEratosthenes();
            }

            List<int> primeNumbers = _primeGenerator.GeneratePrimes(_limit);

            int sizeOfTable = 0;
            bool isConversionSuccessful = Int32.TryParse(NumberOfPrimes.Text, out sizeOfTable);
            if (! isConversionSuccessful || sizeOfTable == 0)
            {
                sizeOfTable = DEFAULT_TABLE_SIZE;
            }

            // Now that we've got the requested size of the table from the user we should really check to see if that
            // size is valid. If not we'll cap it to stop a range error.
            if (sizeOfTable >= primeNumbers.Count)
            {
                sizeOfTable = primeNumbers.Count - 1;
            }

            // Grab the prime numbers that the user is interested in.
            primeNumbers = primeNumbers.GetRange(0, sizeOfTable);

            // Create the size of the data view.
            PrimeNumberView.ColumnCount = sizeOfTable;
            PrimeNumberView.RowCount = sizeOfTable;

            // Set the sizing of the cells so everything looks good.
            PrimeNumberView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            // Set the data contained within the view.
            int x;
            int y;

            // We'll start by setting the headers.
            for (x = 0; x < PrimeNumberView.ColumnCount; ++x)
            {
                PrimeNumberView.Columns[x].HeaderCell.Value = primeNumbers[x].ToString();
            }

            for (y = 0; y < PrimeNumberView.RowCount; ++y)
            {
                PrimeNumberView.Rows[y].HeaderCell.Value = primeNumbers[y].ToString();
            }

            // Now that the headers are set we'll do the multiplications...
            for (x = 0; x < PrimeNumberView.ColumnCount; ++x)
            {
                for (y = 0; y < PrimeNumberView.RowCount; ++y)
                {
                    String firstNumberText = PrimeNumberView.Columns[x].HeaderCell.Value as String;
                    int firstNumber = Int32.Parse(firstNumberText);

                    String secondNumberText = PrimeNumberView.Rows[y].HeaderCell.Value as String;
                    int secondNumber = Int32.Parse(secondNumberText);

                    PrimeNumberView.Rows[x].Cells[y].Value = (firstNumber * secondNumber).ToString();
                }
            }
        }
    }
}
