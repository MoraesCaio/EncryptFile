using System;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using EncryptStringSample;

namespace EncryptFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BROWSE INPUT FILES
        private void encInBrowse_Click(object sender, EventArgs e)
        {
            encOFD.ShowDialog();
        }

        private void decInBrowse_Click(object sender, EventArgs e)
        {
            decOFD.ShowDialog();
        }
        //FILE OK EVENTS
        //ENC
        private void encOFD_FileOk(object sender, CancelEventArgs e)
        {
            encInputTBox.Text = encOFD.FileName;
        }

        private void encSFD_FileOk(object sender, CancelEventArgs e)
        {
            //encOutputTBox.Text = encSFD.FileName;
        }
        //DEC
        private void decOFD_FileOk(object sender, CancelEventArgs e)
        {
            decInputTBox.Text = decOFD.FileName;
        }
        private void decSFD_FileOk(object sender, CancelEventArgs e)
        {
            //decOutputTBox.Text = decSFD.FileName;
        }
        //BROWSE OUTPUT FILES
        private void encOutBrowse_Click(object sender, EventArgs e)
        {
            encSFD.ShowDialog();
        }
        private void decOutBrowse_Click(object sender, EventArgs e)
        {
            decSFD.ShowDialog();
        }
        private bool CheckInputsUI(TextBox t)
        {
            if (t.Text == "")
            {
                MessageBox.Show("Please input a file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (!File.Exists(t.Text))
            {
                MessageBox.Show("File doesn't exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }
        private void CheckOutputsUI(TextBox tIn, /*TextBox tOut,*/ SaveFileDialog s)
        {
            /*if (string.IsNullOrWhiteSpace(tOut.Text))
            {*/
                s.FileName = Path.GetFileNameWithoutExtension(tIn.Text);
                s.ShowDialog();
            //}
        }

        private bool promptUserUI(TextBox textInput, /*TextBox textOutput,*/ SaveFileDialog s)
        {
            if (!CheckInputsUI(textInput))
            {
                return false;
            }
            CheckOutputsUI(textInput, /*textOutput,*/ s);
            return true;
        }
        private bool setOutputFile(TextBox tIn, /*TextBox tOut,*/ SaveFileDialog s, out string outFile)
        {
            /*if (!string.IsNullOrWhiteSpace(tOut.Text))
            {
                outFile = tOut.Text;
            }
            else */if (!string.IsNullOrWhiteSpace(s.FileName))
            {
                outFile = s.FileName;
            }
            else
            {
                try
                {
                    outFile = Path.Combine(
                                  Path.GetDirectoryName(tIn.Text),
                                  Path.GetFileNameWithoutExtension(tIn.Text)
                              );
                }
                catch (Exception ex)
                {
                    outFile = "";
                    return false;
                }
            }
            return true;
        }
        private bool runCrypto(TextBox inputTBox, /*TextBox outputTBox,*/ SaveFileDialog sFD, bool encrypt)
        {
            //Checks input and output on textbox
            if (!promptUserUI(inputTBox, /*outputTBox,*/ sFD))
            {
                return false;
            }
            //Variables
            string key = passwordTBox.Text;
            string inputFile = inputTBox.Text;
            string outputFile = "";
            if (!setOutputFile(inputTBox, /*outputTBox,*/ sFD, out outputFile))
            {
                return false;
            }
            //Running crypto
            try
            {
                string textInput = File.ReadAllText(inputFile, Encoding.Default);
                string textOutput = (encrypt)?  StringCipher.Encrypt(textInput, key, inputFile):
                                                StringCipher.Decrypt(textInput, key, out outputFile);
                File.WriteAllText(outputFile, textOutput, Encoding.Default);
                MessageBox.Show("File \"" + Path.GetFileName(outputFile) + "\" " + ((encrypt) ? "encrypted" : "decrypted") + " sucessfully.\n" + 
                    "Saved on:\n\"" + Path.GetDirectoryName(outputFile) + "\"");
                return true;
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", "Mensagem:\n" + ex.Message + "\n\nStackTrace:\n" + ex.StackTrace);
                return false;
            }
        }
        private void encButton_Click(object sender, EventArgs e)
        {
            //Gui Elements
            SaveFileDialog sFD = encSFD;
            TextBox inputTBox = encInputTBox;
            //TextBox outputTBox = encOutputTBox;
            runCrypto(inputTBox, /*outputTBox,*/ sFD, true);
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            //Gui Elements
            SaveFileDialog sFD = decSFD;
            TextBox inputTBox = decInputTBox;
            //TextBox outputTBox = decOutputTBox;
            runCrypto(inputTBox, /*outputTBox,*/ sFD, false);
        }
    }
}
