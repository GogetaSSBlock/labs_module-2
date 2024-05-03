namespace pz16
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
            sendButton = new Button();
            messageTextBox = new TextBox();
            chatRichTextBox = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // sendButton
            // 
            sendButton.Location = new Point(331, 178);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(52, 23);
            sendButton.TabIndex = 0;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(166, 178);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(159, 23);
            messageTextBox.TabIndex = 1;
            // 
            // chatRichTextBox
            // 
            chatRichTextBox.Location = new Point(166, 12);
            chatRichTextBox.Name = "chatRichTextBox";
            chatRichTextBox.Size = new Size(217, 153);
            chatRichTextBox.TabIndex = 2;
            chatRichTextBox.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(419, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(chatRichTextBox);
            Controls.Add(messageTextBox);
            Controls.Add(sendButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendButton;
        private TextBox messageTextBox;
        private RichTextBox chatRichTextBox;
        private TextBox textBox1;
    }
}
