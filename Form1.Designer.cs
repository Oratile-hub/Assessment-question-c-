namespace Assessment_question
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
            this.lblResult = new System.Windows.Forms.Label();
            this.cbWordsOne = new System.Windows.Forms.ComboBox();
            this.cbWordsTwo = new System.Windows.Forms.ComboBox();
            this.tbNewWord = new System.Windows.Forms.TextBox();
            this.tbNewWordTwo = new System.Windows.Forms.TextBox();
            this.rbRemoveOne = new System.Windows.Forms.RadioButton();
            this.rbRemoveTwo = new System.Windows.Forms.RadioButton();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(296, 53);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 20);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Results";
            // 
            // cbWordsOne
            // 
            this.cbWordsOne.FormattingEnabled = true;
            this.cbWordsOne.Location = new System.Drawing.Point(94, 262);
            this.cbWordsOne.Name = "cbWordsOne";
            this.cbWordsOne.Size = new System.Drawing.Size(121, 28);
            this.cbWordsOne.TabIndex = 1;
            // 
            // cbWordsTwo
            // 
            this.cbWordsTwo.FormattingEnabled = true;
            this.cbWordsTwo.Location = new System.Drawing.Point(544, 262);
            this.cbWordsTwo.Name = "cbWordsTwo";
            this.cbWordsTwo.Size = new System.Drawing.Size(121, 28);
            this.cbWordsTwo.TabIndex = 1;
            // 
            // tbNewWord
            // 
            this.tbNewWord.Location = new System.Drawing.Point(287, 91);
            this.tbNewWord.Name = "tbNewWord";
            this.tbNewWord.Size = new System.Drawing.Size(100, 26);
            this.tbNewWord.TabIndex = 2;
            // 
            // tbNewWordTwo
            // 
            this.tbNewWordTwo.Location = new System.Drawing.Point(287, 147);
            this.tbNewWordTwo.Name = "tbNewWordTwo";
            this.tbNewWordTwo.Size = new System.Drawing.Size(100, 26);
            this.tbNewWordTwo.TabIndex = 2;
            // 
            // rbRemoveOne
            // 
            this.rbRemoveOne.AutoSize = true;
            this.rbRemoveOne.Location = new System.Drawing.Point(94, 319);
            this.rbRemoveOne.Name = "rbRemoveOne";
            this.rbRemoveOne.Size = new System.Drawing.Size(224, 24);
            this.rbRemoveOne.TabIndex = 3;
            this.rbRemoveOne.TabStop = true;
            this.rbRemoveOne.Text = "Remove from ComboBox 1";
            this.rbRemoveOne.UseVisualStyleBackColor = true;
            // 
            // rbRemoveTwo
            // 
            this.rbRemoveTwo.AutoSize = true;
            this.rbRemoveTwo.Location = new System.Drawing.Point(544, 319);
            this.rbRemoveTwo.Name = "rbRemoveTwo";
            this.rbRemoveTwo.Size = new System.Drawing.Size(224, 24);
            this.rbRemoveTwo.TabIndex = 3;
            this.rbRemoveTwo.TabStop = true;
            this.rbRemoveTwo.Text = "Remove from ComboBox 2";
            this.rbRemoveTwo.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(300, 381);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.rbRemoveTwo);
            this.Controls.Add(this.rbRemoveOne);
            this.Controls.Add(this.tbNewWordTwo);
            this.Controls.Add(this.tbNewWord);
            this.Controls.Add(this.cbWordsTwo);
            this.Controls.Add(this.cbWordsOne);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cbWordsOne;
        private System.Windows.Forms.ComboBox cbWordsTwo;
        private System.Windows.Forms.TextBox tbNewWord;
        private System.Windows.Forms.TextBox tbNewWordTwo;
        private System.Windows.Forms.RadioButton rbRemoveOne;
        private System.Windows.Forms.RadioButton rbRemoveTwo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}

