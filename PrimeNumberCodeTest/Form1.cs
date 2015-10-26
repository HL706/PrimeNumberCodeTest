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

            AtkinLimit_1.Checked = isAtkinAlgorithmSelected && indexOfSelection == 1;
            AtkinLimit_2.Checked = isAtkinAlgorithmSelected && indexOfSelection == 2;
            AtkinLimit_3.Checked = isAtkinAlgorithmSelected && indexOfSelection == 3;
        }

        private void SetStateOfAlgorithmMenu(Boolean isAtkinAlgorithmSelected)
        {
            AlgorithmSieveOfEratosthenes.Checked = !isAtkinAlgorithmSelected;
            AlgorithmSieveOfAtkin.Checked = isAtkinAlgorithmSelected;
        }

        private void GenerateTable_Click(object sender, EventArgs e)
        {
            // We're going to hide this as all the resizing looks pretty nasty.
            PrimeNumberTable.Visible = false;

            // Set the generator based on the select menu items.
            if (AlgorithmSieveOfAtkin.Checked)
            {
                _primeGenerator = new SieveOfAtkin();
            }
            else
            {
                _primeGenerator = new SieveOfEratosthenes();
            }

            List<int> primeNumbers = _primeGenerator.GeneratePrimes(_limit);

            int sizeOfTable = 0;
            bool isConversionSuccessful = Int32.TryParse(NumberOfPrimes.Text, out sizeOfTable);
            if (! isConversionSuccessful)
            {
                sizeOfTable = DEFAULT_TABLE_SIZE;
            }

            // Get the range requested by the user.
            primeNumbers = primeNumbers.GetRange(0, sizeOfTable);

            // Create the table.
            PrimeNumberTable.ColumnCount = sizeOfTable + 1;
            PrimeNumberTable.RowCount = sizeOfTable + 1;


            // Create a table, making sure to place a label in each cell we use.
            int x;
            int y;

            // Set the headers.
            for (x = 1; x < PrimeNumberTable.ColumnCount; ++x)
            {
                Label label = new Label();
                label.Size = new Size(50, 25);
                label.Text = primeNumbers[x - 1].ToString();

                PrimeNumberTable.Controls.Add(label, x, 0);
            }
            
            for (y = 1; y < PrimeNumberTable.RowCount; ++y)
            {
                Label label = new Label();
                label.Size = new Size(50, 25);
                label.Text = primeNumbers[y - 1].ToString();

                PrimeNumberTable.Controls.Add(label, 0, y);
            }

            // Now that the headers are set we'll do the multiplications...
            for (x = 1; x < PrimeNumberTable.ColumnCount; ++x)
            {
                for (y = 1; y < PrimeNumberTable.RowCount; ++y)
                {
                    Label firstNumberLabel = PrimeNumberTable.GetControlFromPosition(0, y) as Label;
                    int firstNumber = Int32.Parse(firstNumberLabel.Text);

                    Label secondNumberLabel = PrimeNumberTable.GetControlFromPosition(x, 0) as Label;
                    int secondNumber = Int32.Parse(secondNumberLabel.Text);

                    Label cell = new Label();
                    cell.Size = new Size(50, 25);
                    cell.Text = (firstNumber * secondNumber).ToString();

                    PrimeNumberTable.Controls.Add(cell, x, y);
                }
            }

            PrimeNumberTable.Visible = true;
        }
    }
}
