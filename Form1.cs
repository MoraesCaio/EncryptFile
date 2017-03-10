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
        //DEC
        private void decOFD_FileOk(object sender, CancelEventArgs e)
        {
            decInputTBox.Text = decOFD.FileName;
        }
        //BROWSE OUTPUT FILES
        private void encOutBrowse_Click(object sender, EventArgs e)
        {
            encSFD.ShowDialog();
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

        private void CheckOutputsUI(TextBox tIn, SaveFileDialog s, FolderBrowserDialog f, bool encrypt)
        {
            if (encrypt)
            {
                s.FileName = Path.GetFileNameWithoutExtension(tIn.Text);
                DialogResult result = s.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(s.FileName))
                    {
                        try
                        {
                            s.FileName = Path.Combine(
                                             Path.GetDirectoryName(tIn.Text),
                                             Path.GetFileNameWithoutExtension(tIn.Text)
                                         );
                        }
                        catch (Exception ex)
                        {
                            s.FileName = "";
                        }
                    }
                }
                else
                {
                    s.FileName = "";
                    return;
                }
            }
            else
            {
                f.SelectedPath = Application.StartupPath;
                if(DialogResult.OK != f.ShowDialog())
                {
                    f.SelectedPath = "";
                }

            }
        }

        private bool promptUserUI(TextBox tIn, SaveFileDialog s, FolderBrowserDialog f, bool encrypt)
        {
            if (!CheckInputsUI(tIn))
            {
                return false;
            }
            CheckOutputsUI(tIn, s, f, encrypt);
            return true;
        }

        private void runCrypto(TextBox inputTBox, SaveFileDialog sFD, FolderBrowserDialog fBD, bool encrypt)
        {
            //Checks input and output on textbox
            if (!promptUserUI(inputTBox, sFD, fBD, encrypt))
            {
                return;
            }

            //Variables
            string key = passwordTBox.Text;
            string inputFile = inputTBox.Text;
            string outputFile = (encrypt)? sFD.FileName : "";

            //Error! No Output file
            if (encrypt && outputFile == "")
            {
                MessageBox.Show("Please inform the name of the encrypted file.!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            //Running crypto
            try
            {
                //Reading input file
                string inputFileContent = File.ReadAllText(inputFile, Encoding.Default);
                string outputFileContent = (encrypt)?  StringCipher.Encrypt(inputFileContent, key, inputFile) : StringCipher.Decrypt(inputFileContent, key, out outputFile);

                //Ensure full path for decryption
                if (!encrypt)
                {
                    if(fBD.SelectedPath != "")
                    {
                        outputFile = Path.Combine(fBD.SelectedPath, Path.GetFileName(outputFile));
                    }
                    else
                    {
                        MessageBox.Show("Please inform the folder to save the file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }

                //Writing OutputFile
                File.WriteAllText(outputFile, outputFileContent, Encoding.Default);

                //Message
                MessageBox.Show("File \"" + Path.GetFileName(outputFile) + "\" " + ((encrypt) ? "encrypted" : "decrypted") + " sucessfully.\n" + 
                    "Saved on:\n\"" +
                    ((encrypt)? Path.GetDirectoryName(outputFile) : fBD.SelectedPath) + "\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                //File.WriteAllText("log.txt", "Mensagem:\n" + ex.Message + "\n\nStackTrace:\n" + ex.StackTrace);
            }
        }
        private void encButton_Click(object sender, EventArgs e)
        {
            //Gui Elements
            runCrypto(encInputTBox, encSFD, null, true);
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            //Gui Elements
            runCrypto(decInputTBox, null, decFBD, false);
        }
    }
}
