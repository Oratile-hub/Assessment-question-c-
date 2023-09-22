using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_question
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            List<string> wordsList;


            {
                InitializeComponent();
                wordsList = new List<string>();
            }


            {
                string newWord = tbNewWord.Text.Trim();

                if (string.IsNullOrEmpty(newWord))
                {
                    MessageBox.Show("Please enter a word to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (wordsList.Contains(newWord))
                {
                    MessageBox.Show("The word has already been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                wordsList.Add(newWord);
                cbWordsOne.Items.Add(newWord);
                cbWordsTwo.Items.Add(newWord);
                tbNewWord.Clear();

                MessageBox.Show("The new word has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            List<string> wordsList;
            {
                if (rbRemoveOne.Checked)
                {
                    string wordOne = cbWordsOne.SelectedItem?.ToString().Trim();

                    if (string.IsNullOrEmpty(wordOne))
                    {
                        MessageBox.Show("Please select a word to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    wordsList.Remove(wordOne);
                    cbWordsOne.Items.Remove(wordOne);
                    MessageBox.Show("The selected word has been removed from ComboBox One.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbRemoveTwo.Checked)
                {
                    string wordTwo = cbWordsTwo.SelectedItem?.ToString().Trim();

                    if (string.IsNullOrEmpty(wordTwo))
                    {
                        MessageBox.Show("Please select a word to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    wordsList.Remove(wordTwo);
                    cbWordsTwo.Items.Remove(wordTwo);
                    MessageBox.Show("The selected word has been removed from ComboBox Two.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }




}
    


            





            
        

