namespace Astronomical_Processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNeutrino = new ListBox();
            lblNeutrino = new Label();
            btnSort = new Button();
            txtSearch = new TextBox();
            txtEdit = new TextBox();
            btnEdit = new Button();
            lblMessage = new Label();
            rtbMessage = new RichTextBox();
            lblHour = new Label();
            btnBinSearch = new Button();
            btnLinSearch = new Button();
            lblSearch = new Label();
            lblCalc = new Label();
            btnMidEx = new Button();
            btnMode = new Button();
            btnAvg = new Button();
            btnRange = new Button();
            SuspendLayout();
            // 
            // lbNeutrino
            // 
            lbNeutrino.FormattingEnabled = true;
            lbNeutrino.Location = new Point(69, 29);
            lbNeutrino.Name = "lbNeutrino";
            lbNeutrino.Size = new Size(110, 379);
            lbNeutrino.TabIndex = 0;
            lbNeutrino.SelectedIndexChanged += lbNeutrino_SelectedIndexChanged;
            // 
            // lblNeutrino
            // 
            lblNeutrino.AutoSize = true;
            lblNeutrino.Location = new Point(12, 9);
            lblNeutrino.Name = "lblNeutrino";
            lblNeutrino.Size = new Size(167, 15);
            lblNeutrino.TabIndex = 1;
            lblNeutrino.Text = "Neutrino interactions per hour";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(190, 29);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(100, 23);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(190, 182);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 4;
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(190, 86);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(100, 23);
            txtEdit.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(190, 115);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit Value";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            lblMessage.Location = new Point(278, 258);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(55, 15);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Message";
            // 
            // rtbMessage
            // 
            rtbMessage.Font = new Font("Segoe UI", 10F);
            rtbMessage.Location = new Point(190, 286);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.ReadOnly = true;
            rtbMessage.Size = new Size(211, 65);
            rtbMessage.TabIndex = 9;
            rtbMessage.Text = "";
            // 
            // lblHour
            // 
            lblHour.Location = new Point(12, 31);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(55, 378);
            lblHour.TabIndex = 10;
            lblHour.Text = "Hour 1";
            // 
            // btnBinSearch
            // 
            btnBinSearch.Location = new Point(190, 211);
            btnBinSearch.Name = "btnBinSearch";
            btnBinSearch.Size = new Size(50, 23);
            btnBinSearch.TabIndex = 11;
            btnBinSearch.Text = "Binary";
            btnBinSearch.UseVisualStyleBackColor = true;
            btnBinSearch.Click += btnBinSearch_Click;
            // 
            // btnLinSearch
            // 
            btnLinSearch.Location = new Point(240, 211);
            btnLinSearch.Name = "btnLinSearch";
            btnLinSearch.Size = new Size(50, 23);
            btnLinSearch.TabIndex = 12;
            btnLinSearch.Text = "Linear";
            btnLinSearch.UseVisualStyleBackColor = true;
            btnLinSearch.Click += btnLinSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.Location = new Point(220, 164);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search";
            // 
            // lblCalc
            // 
            lblCalc.AutoSize = true;
            lblCalc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCalc.Location = new Point(320, 90);
            lblCalc.Name = "lblCalc";
            lblCalc.Size = new Size(70, 19);
            lblCalc.TabIndex = 14;
            lblCalc.Text = "Calculate";
            // 
            // btnMidEx
            // 
            btnMidEx.Location = new Point(309, 123);
            btnMidEx.Name = "btnMidEx";
            btnMidEx.Size = new Size(92, 23);
            btnMidEx.TabIndex = 15;
            btnMidEx.Text = "Mid-extreme";
            btnMidEx.UseVisualStyleBackColor = true;
            btnMidEx.Click += btnMidEx_Click;
            // 
            // btnMode
            // 
            btnMode.Location = new Point(309, 152);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(92, 23);
            btnMode.TabIndex = 16;
            btnMode.Text = "Mode";
            btnMode.UseVisualStyleBackColor = true;
            btnMode.Click += btnMode_Click;
            // 
            // btnAvg
            // 
            btnAvg.Location = new Point(309, 181);
            btnAvg.Name = "btnAvg";
            btnAvg.Size = new Size(92, 23);
            btnAvg.TabIndex = 17;
            btnAvg.Text = "Average";
            btnAvg.UseVisualStyleBackColor = true;
            btnAvg.Click += btnAvg_Click;
            // 
            // btnRange
            // 
            btnRange.Location = new Point(309, 211);
            btnRange.Name = "btnRange";
            btnRange.Size = new Size(92, 23);
            btnRange.TabIndex = 18;
            btnRange.Text = "Range";
            btnRange.UseVisualStyleBackColor = true;
            btnRange.Click += btnRange_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 415);
            Controls.Add(btnRange);
            Controls.Add(btnAvg);
            Controls.Add(btnMode);
            Controls.Add(btnMidEx);
            Controls.Add(lblCalc);
            Controls.Add(lblSearch);
            Controls.Add(btnLinSearch);
            Controls.Add(btnBinSearch);
            Controls.Add(lblHour);
            Controls.Add(rtbMessage);
            Controls.Add(lblMessage);
            Controls.Add(btnEdit);
            Controls.Add(txtEdit);
            Controls.Add(txtSearch);
            Controls.Add(btnSort);
            Controls.Add(lblNeutrino);
            Controls.Add(lbNeutrino);
            Name = "Form1";
            Text = "Astronomical Processing";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbNeutrino;
        private Label lblNeutrino;
        private Button btnSort;
        private TextBox txtSearch;
        private TextBox txtEdit;
        private Button btnEdit;
        private Label lblMessage;
        private RichTextBox rtbMessage;
        private Label lblHour;
        private Button btnBinSearch;
        private Button btnLinSearch;
        private Label lblSearch;
        private Label lblCalc;
        private Button btnMidEx;
        private Button btnMode;
        private Button btnAvg;
        private Button btnRange;
    }
}
