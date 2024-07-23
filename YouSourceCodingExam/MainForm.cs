using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouSourceCodingExam.Class;
using YouSourceCodingExam.Controller;
using YouSourceCodingExam.Model;

namespace YouSourceCodingExam
{

    public partial class MainForm : Form
    {

        private readonly SortModel _model;
        private readonly SortController _controller;
        public MainForm()
        {
            InitializeComponent();

            _model = new SortModel();
            _controller = new SortController(_model);

            // Populate ComboBox with sorting strategies
            comboBoxSortStrategy.Items.Add("Bubble Sort");
            comboBoxSortStrategy.Items.Add("Quick Sort");
            comboBoxSortStrategy.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;


            // Validate the input
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Input string cannot be null or empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _controller.UpdateModel(input);

            

            // Set the sorting strategy based on ComboBox selection
            ISortStrategy strategy;
            string selectedStrategy = comboBoxSortStrategy.SelectedItem.ToString();

            if (selectedStrategy == "Bubble Sort")
            {
                strategy = new BubbleSortStrategy();
            }
            else if (selectedStrategy == "Quick Sort")
            {
                strategy = new QuickSortStrategy();
            }
            else
            {
                throw new InvalidOperationException("Invalid sorting strategy selected");
            }

            _controller.SetSortStrategy(strategy);
            _controller.Sort();

            labelOutput.Text = _controller.GetSortedString();
        }

        private void comboBoxSortStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {          
                labelOutput.Text = "";
                textBoxInput.Text = "";                     
        }
    }
}
