using System.Windows.Forms;

namespace ListCompareV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            //LoadSampleData();
        }

        private void LoadSampleData()
        {
            // Sample data for TextBox A and B with each item on a new line
            textBoxA.Text = $"Item1{Environment.NewLine}Item2{Environment.NewLine}Item3{Environment.NewLine}Item4{Environment.NewLine}Item5";
            textBoxB.Text = $"Item2{Environment.NewLine}Item4{Environment.NewLine}Item6";
        }

        private void PopulateComboBox()
        {
            // Add operation names to the ComboBox
            comboBoxOperations.Items.AddRange(new string[]
            {
                    "Remove B from A",
                    "Show Common Items",
                    "Union",
                    "Difference",
                    "Symmetric Difference"
            });

            // Optionally set the first item as the default selected
            comboBoxOperations.SelectedIndex = 0;
        }

        private void RemoveBFromA(List<string> listA, List<string> listB)
        {
            var result = listA.Except(listB).ToList();
            textBoxC.Text = string.Join(Environment.NewLine, result);
        }

        private void ShowCommonItems(List<string> listA, List<string> listB)
        {
            var commonItems = listA.Intersect(listB).ToList();
            textBoxC.Text = string.Join(Environment.NewLine, commonItems);
        }

        private void ShowUnion(List<string> listA, List<string> listB)
        {
            var union = listA.Union(listB).ToList();
            textBoxC.Text = string.Join(Environment.NewLine, union);
        }

        private void ShowDifference(List<string> listA, List<string> listB)
        {
            var difference = listA.Except(listB).ToList();
            textBoxC.Text = string.Join(Environment.NewLine, difference);
        }

        private void ShowSymmetricDifference(List<string> listA, List<string> listB)
        {
            var symmetricDifference = listA.Except(listB).Union(listB.Except(listA)).ToList();
            textBoxC.Text = string.Join(Environment.NewLine, symmetricDifference);
        }

        private void btnExecute_Click_1(object sender, EventArgs e)
        {
            // Determine the selected operation and execute it
            string? selectedOperation = comboBoxOperations.SelectedItem?.ToString();

            if (selectedOperation != null)
            {
                var (listA, listB) = GetDataFromTextBoxes();

                switch (selectedOperation)
                {
                    case "Remove B from A":
                        RemoveBFromA(listA, listB);
                        break;

                    case "Show Common Items":
                        ShowCommonItems(listA, listB);
                        break;

                    case "Union":
                        ShowUnion(listA, listB);
                        break;

                    case "Difference":
                        ShowDifference(listA, listB);
                        break;

                    case "Symmetric Difference":
                        ShowSymmetricDifference(listA, listB);
                        break;
                }

                // Copy the result to the clipboard
                CopyToClipboard();
            }
        }
        private (List<string> listA, List<string> listB) GetDataFromTextBoxes()
        {
            var listA = textBoxA.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listB = textBoxB.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            return (listA, listB);
        }

        private void btnClearA_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
        }

        private void btnClearB_Click(object sender, EventArgs e)
        {
            textBoxB.Clear();
        }
        private void CopyToClipboard()
        {
            if (!string.IsNullOrEmpty(textBoxC.Text))
            {
                Clipboard.SetText(textBoxC.Text);
                //MessageBox.Show("Output copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
