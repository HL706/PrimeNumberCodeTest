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
        /// A handle to the currently selected prime generator.
        /// </summary>
        private IPrimeGenerator _primeGenerator;

        public MainForm()
        {
            InitializeComponent();
        }

        private void EratosthenesLimit_1_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(false, 1);
        }

        private void EratosthenesLimit_2_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(false, 2);
        }

        private void EratosthenesLimit_3_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(false, 3);
        }

        private void AtkinLimit_1_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(true, 1);
        }

        private void AtkinLimit_2_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(true, 2);
        }

        private void AtkinLimit_3_Click(object sender, EventArgs e)
        {
            SetStateOfSelectionMenu(true, 3);
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
    }
}
