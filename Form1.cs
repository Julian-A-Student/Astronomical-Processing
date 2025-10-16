using System.Collections.Generic;
using System.Security.Cryptography;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        // Global variables
        int[] neutrinoArr = new int[24];
        int[] indexOrder = new int[24];
        int editIndex;
        bool changed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateArray()
        {
            Random random = new Random();
            for (int i = 0; i < neutrinoArr.Length; i++)
            {
                neutrinoArr[i] = random.Next(10, 90);
                indexOrder[i] = i;
            }
            UpdateLB(false);
        }

        private void UpdateHourLabel()
        {
            string hourStr = "";
            for (int i = 0; i < indexOrder.Length; i++)
            {
                hourStr += "Hour " + (indexOrder[i] + 1) + ":\n";
            }
            lblHour.Text = hourStr;
        }

        private void UpdateLB(bool changed = true)
        {
            this.changed = changed;
            lbNeutrino.DataSource = null; // Reset
            lbNeutrino.DataSource = neutrinoArr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateArray();
            UpdateHourLabel();
        }

        private void lbNeutrino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNeutrino.SelectedIndex != -1)
            {
                editIndex = lbNeutrino.SelectedIndex;
                txtEdit.Text = neutrinoArr[editIndex].ToString();
            }
        }

        private void BubbleSort()
        {
            bool next = true;
            for (int i = 1; i < neutrinoArr.Length && next; i++)
            {
                next = false;
                for (int j = 0; j < neutrinoArr.Length - 1; j++)
                {
                    if (neutrinoArr[j + 1] < neutrinoArr[j])
                    {
                        int temp = neutrinoArr[j];
                        int tempInd = indexOrder[j];
                        neutrinoArr[j] = neutrinoArr[j + 1];
                        indexOrder[j] = indexOrder[j + 1];
                        neutrinoArr[j + 1] = temp;
                        indexOrder[j + 1] = tempInd;
                        next = true;
                    }
                }
            }
        }

        private void UpdateText(string text)
        {
            rtbMessage.ForeColor = Color.Black;
            rtbMessage.Text = text;
        }
        private void UpdateText(string text, Color col)
        {
            rtbMessage.ForeColor = col;
            rtbMessage.Text = text;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
            UpdateLB();
            UpdateHourLabel();
            UpdateText("Values have been sorted in ascending order.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdit.Text, out int editVal))
            {
                UpdateText("Please enter a valid integer!", Color.Red);
            }
            else if (editVal != neutrinoArr[editIndex])
            {
                int old = neutrinoArr[editIndex];
                neutrinoArr[editIndex] = editVal;
                UpdateLB();
                UpdateText("Value at hour " + (editIndex + 1) + " has been changed from " +
                    old + " to " + editVal + ".");
            }
            else if (!changed)
            {
                UpdateText("Value at hour " + (editIndex + 1) + " is already " +
                    editVal + ".");
            }
        }

        private void BinarySearch()
        {
            int min = 0;
            int max = neutrinoArr.Length - 1;

            if (!(int.TryParse(txtSearch.Text, out int searchVal)))
            {
                UpdateText("Please enter a valid integer!", Color.Red);
                return;
            }

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (searchVal == neutrinoArr[mid])
                {
                    UpdateText(searchVal + " was found at hour " + (indexOrder[mid] + 1));
                    return;
                }
                else if (neutrinoArr[mid] >= searchVal)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            UpdateText("No values found matching " + searchVal + ".", Color.OrangeRed);
        }

        private void btnBinSearch_Click(object sender, EventArgs e)
        {
            BubbleSort();
            UpdateLB();
            UpdateHourLabel();
            BinarySearch();
        }
    }
}
