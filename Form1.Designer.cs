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
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtEdit = new TextBox();
            btnEdit = new Button();
            txtMessage = new TextBox();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lbNeutrino
            // 
            lbNeutrino.FormattingEnabled = true;
            lbNeutrino.Location = new Point(12, 29);
            lbNeutrino.Name = "lbNeutrino";
            lbNeutrino.Size = new Size(167, 454);
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
            btnSort.Location = new Point(214, 29);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(214, 198);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(214, 169);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(75, 23);
            txtSearch.TabIndex = 4;
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(214, 90);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(75, 23);
            txtEdit.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(214, 119);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit Value";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(185, 262);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(122, 55);
            txtMessage.TabIndex = 7;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblMessage.Location = new Point(223, 244);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 15);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 492);
            Controls.Add(lblMessage);
            Controls.Add(txtMessage);
            Controls.Add(btnEdit);
            Controls.Add(txtEdit);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
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
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtEdit;
        private Button btnEdit;
        private TextBox txtMessage;
        private Label lblMessage;
    }
}
