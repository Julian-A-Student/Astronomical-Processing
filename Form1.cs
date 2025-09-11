using System.Collections.Generic;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        // Global variables
        int[] neutrinoArr = new int[24];
        bool updated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void createArray()
        {
            Random random = new Random();
            for (int i = 0; i < neutrinoArr.Length; i++)
            {
                neutrinoArr[i] = random.Next(10, 90);
            }
            updateLB();
        }
        public void updateLB(bool changed = true)
        {
            updated = changed;
            lbNeutrino.DataSource = null; // Reset
            lbNeutrino.DataSource = neutrinoArr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createArray();
        }

        private void lbNeutrino_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbNeutrino.SelectedIndex;
            if (index != -1)
            {
                txtEdit.Text = neutrinoArr[index].ToString();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
