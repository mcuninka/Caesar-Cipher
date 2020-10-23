using System;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string ogMessage = textBoxNormalText1.Text;
                int shift = Int32.Parse(textBoxshift1.Text);
                textBoxCipherText1.Text = encrypt(ogMessage.ToLower(), shift);
            }
            catch (FormatException)
            {
                MessageBox.Show("You have to insert NUMBER in Shift", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string ogMessage = textBoxCipherText2.Text;
                int shift = Int32.Parse(textBoxshift2.Text);
                textBoxNormalText2.Text = decrypt(ogMessage.ToLower(), shift);
            }
            catch (FormatException)
            {
                MessageBox.Show("You have to insert NUMBER in Shift", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonClear1_Click(object sender, EventArgs e)
        {
            textBoxshift1.Text = String.Empty;
            textBoxNormalText1.Text = String.Empty;
            textBoxCipherText1.Text = String.Empty;
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            textBoxshift2.Text = String.Empty;
            textBoxCipherText2.Text = String.Empty;
            textBoxNormalText2.Text = String.Empty;
        }

        private static string encrypt(string words, int shiftNo)
        {
            char[] buffer = words.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (!char.IsLetter(letter))
                {
                    buffer[i] = letter;
                }
                else
                {
                    letter = (char)(letter + shiftNo);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    buffer[i] = letter;
                }

            }
            return new string(buffer);
        }

        private static string decrypt(string words, int shiftNo)
        {
            char[] buffer = words.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (!char.IsLetter(letter))
                {
                    buffer[i] = letter;
                }
                else
                {
                    letter = (char)(letter - shiftNo);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    buffer[i] = letter;
                }
            }
            return new string(buffer);
        }
    }
}
