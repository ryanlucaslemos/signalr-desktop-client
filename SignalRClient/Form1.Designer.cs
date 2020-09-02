namespace SignalRClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageTextbox = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.sendMessageButton = new FontAwesome.Sharp.IconButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageTextbox
            // 
            this.messageTextbox.Location = new System.Drawing.Point(55, 165);
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Size = new System.Drawing.Size(361, 20);
            this.messageTextbox.TabIndex = 0;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.Location = new System.Drawing.Point(55, 225);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(776, 290);
            this.messageListBox.TabIndex = 1;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sendMessageButton.FlatAppearance.BorderSize = 0;
            this.sendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessageButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.sendMessageButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sendMessageButton.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.sendMessageButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.sendMessageButton.IconSize = 20;
            this.sendMessageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendMessageButton.Location = new System.Drawing.Point(450, 161);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Rotation = 0D;
            this.sendMessageButton.Size = new System.Drawing.Size(135, 27);
            this.sendMessageButton.TabIndex = 2;
            this.sendMessageButton.Text = "Enviar Mensagem";
            this.sendMessageButton.UseVisualStyleBackColor = false;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(55, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensagem:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTextbox;
        private System.Windows.Forms.ListBox messageListBox;
        private FontAwesome.Sharp.IconButton sendMessageButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

