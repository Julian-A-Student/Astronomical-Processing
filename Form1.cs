/* Name: Julian Anthony (P220041)
 * Sprint: 1
 * Date: 2025/04/25
 * Version: 1
 * Program name: Astronomical Processing
 * Brief explanation: Allows editing, sorting and searching values in an array
 *      using a listbox and textbox input.
*/


namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        // Global variables
        int[] neutrinoArr = new int[24];
        // Also track the index so hours can be sorted.
        int[] indexOrder = new int[24];
        int editIndex;
        bool recentEdit = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // When the form loads, create the array and update UI to reflect values
            CreateArray();
            UpdateLB();
            UpdateHourLabel();
        }

        private void CreateArray()
        {
            // Fill the array with random ints between 10 and 90 (inclusive)
            Random random = new Random();
            for (int i = 0; i < neutrinoArr.Length; i++)
            {
                neutrinoArr[i] = random.Next(10, 91);
                indexOrder[i] = i;
            }
        }

        private void UpdateHourLabel()
        {
            // Creates a multiline label with the respective hours. Used to update when sorted
            string hourStr = "";
            for (int i = 0; i < indexOrder.Length; i++)
            {
                hourStr += "Hour " + (indexOrder[i] + 1) + ":\n";
            }
            lblHour.Text = hourStr;
        }

        /// <summary>
        /// Updates the listbox with neutrinoArr as datasource
        /// </summary>
        private void UpdateLB()
        {
            lbNeutrino.DataSource = null; // Reset
            lbNeutrino.DataSource = neutrinoArr;
        }

        private void lbNeutrino_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the editIndex 
            if (lbNeutrino.SelectedIndex != -1)
            {
                editIndex = lbNeutrino.SelectedIndex;
                txtEdit.Text = neutrinoArr[editIndex].ToString();
            }
        }
        /// <summary>
        /// Bubble sort algorithm that sorts values by looping through and checking if
        /// the next value in array is larger, 1 by 1.
        /// </summary>
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
                        // Also update the index order to keep track of the hour the value reflects
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

        /// <summary>
        /// Updates the rtb text used for notices
        /// </summary>
        /// <param name="text"></param>
        private void UpdateText(string text)
        {
            rtbMessage.ForeColor = Color.Black;
            rtbMessage.Text = text;
        }

        /// <summary>
        /// Override for UpdateText for color output for error messages
        /// </summary>
        /// <param name="text"></param>
        /// <param name="col"></param>
        private void UpdateText(string text, Color col)
        {
            rtbMessage.ForeColor = col;
            rtbMessage.Text = text;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // When sorting, UI needs to be updated to reflect new order. Also notify user of sort.
            //BubbleSort();
            LinearSort();
            UpdateLB();
            UpdateHourLabel();
            UpdateText("Values have been sorted in ascending order.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /* Edit values in the array and update with appropriate error messages
             * If it's not a valid integer, warn the user, else if not already the value user entered
             * then we can update the array, update the listbox and let the user know what values
             * changed and where.
            */
            if (!int.TryParse(txtEdit.Text, out int editVal))
            {
                UpdateText("Please enter a valid integer!", Color.Red);
            }
            else if (editVal != neutrinoArr[editIndex])
            {
                int old = neutrinoArr[editIndex];
                neutrinoArr[editIndex] = editVal;
                UpdateLB();
                recentEdit = true;
                UpdateText("Value at hour " + (indexOrder[editIndex] + 1) + " has been changed from " +
                    old + " to " + editVal + ".");
            }
            else if (!recentEdit)
            {
                // Don't unecessarily edit, let user know, don't override recent edit, avoid misclicks
                UpdateText("Value at hour " + (indexOrder[editIndex] + 1) + " is already " +
                    editVal + ".");
            }
            else
            {
                recentEdit = false;
            }
        }

        /// <summary>
        /// Algorithm for BinarySearching. Requires values to be pre-sorted
        /// </summary>
        private void BinarySearch()
        {
            int min = 0;
            int max = neutrinoArr.Length - 1;

            // If the user didn't enter a valid number, warn user and exit function
            if (!(int.TryParse(txtSearch.Text, out int searchVal)))
            {
                UpdateText("Please enter a valid integer!", Color.Red);
                return;
            }

            while (min <= max)
            {
                int mid = (min + max) / 2;
                // If the value is found, notify user, select the value in lb and exit function
                if (searchVal == neutrinoArr[mid])
                {
                    UpdateText(searchVal + " was found at hour " + (indexOrder[mid] + 1) + ".");
                    lbNeutrino.SelectedIndex = mid;
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
            // If it was unable to find the requested value, notify user
            UpdateText("No values found matching " + searchVal + ".", Color.OrangeRed);
        }

        private void LinearSort()
        {
            int[] minMax = CalcMinMax();
            int min = minMax[0];
            int max = minMax[1];


            List<int> counts = new List<int>();

            for (int j = 0; j < neutrinoArr.Length - 1; j++)
            {
                if (neutrinoArr[j + 1] < neutrinoArr[j])
                {
                        // Also update the index order to keep track of the hour the value reflects
                        int temp = neutrinoArr[j];
                        int tempInd = indexOrder[j];
                        neutrinoArr[j] = neutrinoArr[j + 1];
                        indexOrder[j] = indexOrder[j + 1];
                        neutrinoArr[j + 1] = temp;
                        indexOrder[j + 1] = tempInd;
                    j = -1;
                    }
            }
        }

        private void LinearSearch()
        {
            List<int> hourIndexes = new List<int>();
            int firstIndex = -1;

            if (!(int.TryParse(txtSearch.Text, out int searchVal)))
            {
                UpdateText("Please enter a valid integer!", Color.Red);
                return;
            }

            for (int i = 0; i < neutrinoArr.Length; i++)
            {
                if (neutrinoArr[i] == searchVal)
                {
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }
                    hourIndexes.Add(indexOrder[i] + 1);
                }
            }

            if (hourIndexes.Count < 1)
            {
                UpdateText("No values found matching " + searchVal + ".", Color.OrangeRed);
            }
            else if (hourIndexes.Count == 1)
            {
                UpdateText(searchVal + " was found at hour " + hourIndexes[0] + ".");
                lbNeutrino.SelectedIndex = firstIndex;
            }
            else
            {
                UpdateText(searchVal + " was found at hours " + string.Join(", ", hourIndexes) +
                    ".");
                lbNeutrino.SelectedIndex = firstIndex;
            }
        }

        private void CalcMode()
        {
            // Create a dictionary to store the unique values and their occurances
            var counter = new Dictionary<int, int>();
            int highestCount = 1;
            List<int> mode = new List<int>();
            /* Loop through all values in array and check if they've been added
             * to the dictionary already, if they have increase the counter and
             * check if the occurance is higher than previous highest to increase.
             * If it's unique add to dictionary.
             */
            foreach (int val in neutrinoArr)
            {
                if (counter.ContainsKey(val))
                {
                    counter[val]++;
                    if (counter[val] > highestCount)
                    {
                        highestCount++;
                    }
                }
                else
                {
                    counter.Add(val, 1);
                }
            }

            // Check if the values in the dictionary equal the highest and add to a list
            foreach (var coun in counter)
            {
                if (coun.Value == highestCount)
                {
                    mode.Add(coun.Key);
                }
            }
            // If there's no distinctively appearing mode (<2) notify user
            if (highestCount < 2)
            {
                UpdateText("No mode found.", Color.OrangeRed);
            }
            else
            {
                UpdateText("Mode: " + string.Join(", ", mode));
            }
        }

        private void CalcMidExtreme()
        {
            int[] minMax = CalcMinMax();
            double midExtreme = (minMax[1] - minMax[0]) / 2.0; // (Max - Min)
            UpdateText("Mid-Extreme: " + midExtreme);
        }

        private int[] CalcMinMax()
        {
            // Set to min/max values as they get calculated later
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int val in neutrinoArr)
            {
                if (val < min)
                {
                    min = val;
                }
                else if (val > max)
                {
                    max = val;
                }
            }
            return [min, max];
        }

        private void CalcAvg()
        {
            double total = 0;

            foreach (int val in neutrinoArr)
            {
                total += val;
            }
            double avg = total / neutrinoArr.Length;
            UpdateText("Average: " + avg.ToString("F2"));
        }

        private void CalcRange()
        {
            int[] minMax = CalcMinMax();
            int range = minMax[1] - minMax[0]; // Max - Min
            UpdateText("Range: " + range);
        }

        private void btnBinSearch_Click(object sender, EventArgs e)
        {
            // When searching we need to sort first, also update UI to reflect the sort
            BubbleSort();
            UpdateLB();
            UpdateHourLabel();
            BinarySearch();
        }

        private void btnLinSearch_Click(object sender, EventArgs e)
        {
            LinearSort();
            UpdateLB();
            UpdateHourLabel();
            LinearSearch();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            CalcMode();
        }

        private void btnMidEx_Click(object sender, EventArgs e)
        {
            CalcMidExtreme();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            CalcAvg();
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            CalcRange();
        }

        
    }
}
