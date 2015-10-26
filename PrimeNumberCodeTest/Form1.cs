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

        /// <summary>
        /// Selects the sieve of eratosthenes algorithm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlgorithmSieveOfEratosthenes_Click(object sender, EventArgs e)
        {
            AlgorithmSieveOfEratosthenes.Checked = true;
            AlgorithmSieveOfAtkin.Checked = false;
        }

        /// <summary>
        /// Selects the sieve of atkin algorithm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlgorithmSieveOfAtkin_Click(object sender, EventArgs e)
        {
            AlgorithmSieveOfAtkin.Checked = true;
            AlgorithmSieveOfEratosthenes.Checked = false;
        }
    }
}
