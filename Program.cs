using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using EncryptStringSample;

/*This program encrypts or decrypts a file, files on a folder.
 * 
 * GUI mode:
 *  The user can specify a password and a file to be encrypted or decrypted. But, cannot specify a folder at the moment.
 *
 * Command-Line:
 *  
 *  options password file/folder [outputfolder]
 *  -f      folder mode
 *  -e      encrypt
 *  -d      decrypt
 *  
 *  The user can specify a password (it must have one) and a file or folder. In case a folder was specified, all files
 *      inside the folder (except for the files without extension) will be encrypted or decrypted.
 *  The encrypted file will have the same name withour extension.
 *  
 *  Author: Caio Moraes
 *  GitHub: MoraesCaio
 *  Email: caiomoraes@msn.com
 **/
namespace EncryptFile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Making use with GUI
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

            //Making use with command-line
            else
            {
                //Redirect (only!) output to current console window
                AttachConsole(ATTACH_PARENT_PROCESS);
                //Opens a new console window
                //AllocConsole();

                try
                {
                    string optionAllowedCharacters = "-edf";
                    string options = args[0];
                    string password = args[1];
                    string EncryptedExtension = "";

                    Console.WriteLine("\n");

                    if (CheckOption(options, optionAllowedCharacters, "") && args.Length >= 3)
                    {

                        if(CheckOption(options, "f", "-ed"))
                        {
                            string directory = args[2];
                            string outputDirectory = (args.Length >= 4 && Directory.Exists(args[3]))? args[3] : directory;

                            if (!Directory.Exists(directory))
                            {
                                Console.WriteLine("Directory \"" + directory + "\" does not exist.");
                                return;
                            }

                            string[] files = Directory.GetFiles(directory);
                            Console.WriteLine("Reading files from: \n" + directory + "\n");

                            foreach (string file in files)
                            {
                                if (File.Exists(file))
                                {
                                    string outputfileName = "", outputFileContent = "";
                                    string inputFileContent = File.ReadAllText(file, Encoding.Default);

                                    if (CheckOption(options, "fe", "-"))
                                    {
                                        Console.WriteLine("Encrypting File:");
                                        Console.WriteLine(file);

                                        outputfileName = Path.GetFileNameWithoutExtension(file) + EncryptedExtension;
                                        outputFileContent = StringCipher.Encrypt(inputFileContent, password, Path.GetFileName(file));
                                    }
                                    else if (CheckOption(options, "fd", "-"))
                                    {
                                        if (Path.GetExtension(file) == EncryptedExtension)
                                        {
                                            Console.WriteLine("Decrypting File:");
                                            Console.WriteLine(file);

                                            outputFileContent = StringCipher.Decrypt(inputFileContent, password, out outputfileName);
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("-f\tEncrypt or decrypt every file on folder (specify which with 'fe' or 'fd')\n");
                                        return;
                                    }

                                    string outputPath = Path.Combine(outputDirectory, outputfileName);

                                    Console.WriteLine("Saving as:\n" + outputPath + "\n");
                                    File.WriteAllText(outputPath, outputFileContent, Encoding.Default);
                                }
                            }
                        }
                        //One file mode
                        else if (CheckOption(options, "ed", "-"))
                        {
                            string file = args[2];
                            string directory = Path.GetDirectoryName(file);
                            string outputDirectory = (args.Length >= 4 && Directory.Exists(args[3]))? args[3] : directory;

                            if (!File.Exists(file))
                            {
                                Console.WriteLine("File \"" + file+ "\" does not exist.");
                                return;
                            }

                            string outputfileName = "", outputFileContent = "";
                            string inputFileContent = File.ReadAllText(file, Encoding.Default);

                            if (CheckOption(options, "e", "-"))
                            {
                                Console.WriteLine("Encrypting File:");
                                Console.WriteLine(file);

                                outputfileName = Path.GetFileNameWithoutExtension(file) + EncryptedExtension;
                                outputFileContent = StringCipher.Encrypt(inputFileContent, password, Path.GetFileName(file));
                            }
                            else if (CheckOption(options, "d", "-"))
                            {
                                if (Path.GetExtension(file) == EncryptedExtension)
                                {
                                    Console.WriteLine("Decrypting File:");
                                    Console.WriteLine(file);

                                    outputFileContent = StringCipher.Decrypt(inputFileContent, password, out outputfileName);
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect file extension. Input a " + EncryptedExtension + " file.");
                                    return;
                                }
                            }
                            else
                            {
                                return;
                            }

                            string outputPath = Path.Combine(outputDirectory, outputfileName);

                            Console.WriteLine("Saving as:\n" + outputPath + "\n");
                            File.WriteAllText(outputPath, outputFileContent, Encoding.Default);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid arguments.");
                        Console.WriteLine("Format:\noptions password file/directory");
                        Console.WriteLine("-f\tEncrypt or decrypt every file on folder (specify which with 'fe' or 'fd')\n" +
                                          "-e\tEncrypt\n" +
                                          "-d\tDecrypt");
                    }
                }
                catch (System.Security.Cryptography.CryptographicException)
                {
                    Console.WriteLine("INVALID PASSWORD!");
                }
                catch (Exception ex)
                {
                    string msg = "Type of excetion:\r\n" + ex.GetType().ToString() + "\r\nMesssage:\r\n" + ex.Message + "\r\nStackTrace:\r\n" + ex.StackTrace + "\n";
                    Console.WriteLine(msg);
                    File.WriteAllText("logArgs.txt", msg, Encoding.Default);
                }
                finally
                {
                    //No caso de AttachConsole(-1)
                    SendKeys.SendWait("{ENTER}");
                    //Application.Exit();
                    //Console.ReadLine();
                }
            }
        }

        //use ignoredChars for when you need to assure theres at least one of the allowedChars.
        private static bool CheckOption(string str, string allowedChars, string ignoredChars)
        {
            char[] ignoredCharsAr = ignoredChars.ToCharArray();
            foreach (char ignoredChar in ignoredCharsAr){
                str = str.Replace(ignoredChar.ToString(), "");
            }
            if (str == "")
            {
                return false;
            }
            if (str.All(c => allowedChars.Contains(c)))
            {
                return true;
            }
            return false;
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern bool AllocConsole();
    }
}
