namespace Animals
{
    partial class AddAnimalForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addBugRadioButton = new System.Windows.Forms.RadioButton();
            this.addFishRadioButton = new System.Windows.Forms.RadioButton();
            this.addDinosaursRadioButton = new System.Windows.Forms.RadioButton();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addDetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(89, 336);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "OK";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(241, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addBugRadioButton
            // 
            this.addBugRadioButton.AutoSize = true;
            this.addBugRadioButton.Location = new System.Drawing.Point(110, 68);
            this.addBugRadioButton.Name = "addBugRadioButton";
            this.addBugRadioButton.Size = new System.Drawing.Size(44, 17);
            this.addBugRadioButton.TabIndex = 3;
            this.addBugRadioButton.TabStop = true;
            this.addBugRadioButton.Text = "Bug";
            this.addBugRadioButton.UseVisualStyleBackColor = true;
            // 
            // addFishRadioButton
            // 
            this.addFishRadioButton.AutoSize = true;
            this.addFishRadioButton.Location = new System.Drawing.Point(110, 116);
            this.addFishRadioButton.Name = "addFishRadioButton";
            this.addFishRadioButton.Size = new System.Drawing.Size(44, 17);
            this.addFishRadioButton.TabIndex = 4;
            this.addFishRadioButton.TabStop = true;
            this.addFishRadioButton.Text = "Fish";
            this.addFishRadioButton.UseVisualStyleBackColor = true;
            // 
            // addDinosaursRadioButton
            // 
            this.addDinosaursRadioButton.AutoSize = true;
            this.addDinosaursRadioButton.Location = new System.Drawing.Point(110, 158);
            this.addDinosaursRadioButton.Name = "addDinosaursRadioButton";
            this.addDinosaursRadioButton.Size = new System.Drawing.Size(67, 17);
            this.addDinosaursRadioButton.TabIndex = 5;
            this.addDinosaursRadioButton.TabStop = true;
            this.addDinosaursRadioButton.Text = "Dinosaur";
            this.addDinosaursRadioButton.UseVisualStyleBackColor = true;
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(229, 68);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(38, 13);
            this.addNameLabel.TabIndex = 6;
            this.addNameLabel.Text = "Name:";
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(286, 68);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addNameTextBox.TabIndex = 12;
            // 
            // addDetailsRichTextBox
            // 
            this.addDetailsRichTextBox.Location = new System.Drawing.Point(504, 65);
            this.addDetailsRichTextBox.Name = "addDetailsRichTextBox";
            this.addDetailsRichTextBox.Size = new System.Drawing.Size(215, 96);
            this.addDetailsRichTextBox.TabIndex = 15;
            this.addDetailsRichTextBox.Text = "";
            // 
            // addDetailsLabel
            // 
            this.addDetailsLabel.AutoSize = true;
            this.addDetailsLabel.Location = new System.Drawing.Point(446, 65);
            this.addDetailsLabel.Name = "addDetailsLabel";
            this.addDetailsLabel.Size = new System.Drawing.Size(42, 13);
            this.addDetailsLabel.TabIndex = 16;
            this.addDetailsLabel.Text = "Details:";
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 409);
            this.Controls.Add(this.addDetailsLabel);
            this.Controls.Add(this.addDetailsRichTextBox);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.addDinosaursRadioButton);
            this.Controls.Add(this.addFishRadioButton);
            this.Controls.Add(this.addBugRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddAnimalForm";
            this.Text = "AddAnimalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNameLabel;
        new public System.Windows.Forms.Button AcceptButton;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.RadioButton addBugRadioButton;
        public System.Windows.Forms.RadioButton addFishRadioButton;
        public System.Windows.Forms.RadioButton addDinosaursRadioButton;
        public System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label addDetailsLabel;
        public System.Windows.Forms.RichTextBox addDetailsRichTextBox;
    }
}
