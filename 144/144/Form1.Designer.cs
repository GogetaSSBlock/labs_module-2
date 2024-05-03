namespace _144
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
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            addButton = new Button();
            deleteButton = new Button();
            countryTextBox = new TextBox();
            capitalTextBox = new TextBox();
            filterTextBox = new TextBox();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView.Location = new Point(1, 28);
            listView.Name = "listView";
            listView.Size = new Size(403, 181);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Country";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Capital";
            columnHeader2.Width = 200;
            // 
            // addButton
            // 
            addButton.Location = new Point(329, 215);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(197, 215);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.Click += deleteButton_Click;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(300, 267);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(114, 23);
            countryTextBox.TabIndex = 3;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // capitalTextBox
            // 
            capitalTextBox.Location = new Point(300, 306);
            capitalTextBox.Name = "capitalTextBox";
            capitalTextBox.Size = new Size(114, 23);
            capitalTextBox.TabIndex = 4;
            capitalTextBox.TextChanged += capitalTextBox_TextChanged;
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(300, 347);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.Size = new Size(114, 23);
            filterTextBox.TabIndex = 5;
            filterTextBox.TextChanged += filterTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(filterTextBox);
            Controls.Add(capitalTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(listView);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button addButton;
        private Button deleteButton;
        private TextBox countryTextBox;
        private TextBox capitalTextBox;
        private TextBox filterTextBox;
    }
}
