using System;
using System.Windows.Forms;

namespace SwordsAndSandals3Editor {
    class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //GenerateNewString();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        static void GenerateNewString() {
            if (Clipboard.ContainsText()) {
                string[] ReadData = Clipboard.GetText().Replace("\r", "").Split('\n');
                string newBuffer = string.Empty;
                for (int i = 0; i < ReadData.Length; i++) {
                    string[] Data = ReadData[i].Split('|');

                    newBuffer += "\"" + Data[1] + ", " + Data[2] + " (" + Data[3] + ") Lv. " + Data[4].Trim('+') + "\", ";

                    if ((i + 1).ToString().EndsWith("0")) {
                        newBuffer += "\n";
                    }
                }

                newBuffer = newBuffer;
            }
        }
    }
}
