namespace Hex_to_Hex
{
    #region Usings

    using System;
    using System.IO;

    #endregion Usings

    internal class HexEditor
    {
        public HexEditor(bool isFirstTime)
        {
            /// <summary>
            /// This is Initiation for taking Input Hex String.
            /// </summary>
            if (isFirstTime)
                Console.Write("[H2H]    Please Enter your input Hex Bytes: ");
            else
            {
                Console.WriteLine();
                Console.Write("[H2H]    Now Enter the remaining Hex-Code: ");
            }
            string inputString = Console.ReadLine() + ", ";
            int i = 0;

            /// <summary>
            /// This is method to remove '0x' and ','. For Ex: i/p: 0x2F, 0x46 -> o/p: 2F46
            /// </summary>
            while (i < inputString.Length)
            {
                if (inputString[i] == '0')
                    if (inputString[i + 1] == 'x')
                        if (inputString[i + 4] == ',')
                        {
                            inputString = inputString.Remove(i, 2);
                            inputString = inputString.Remove(i + 2, 2);
                        }
                ++i;
            }

            /// <summary>
            /// Verifying for Output file existence
            /// </summary>
            if (isFirstTime)
                if (File.Exists(@"Output.txt"))
                    File.Delete(@"Output.txt");

            /// <summary>
            /// Writing the Output
            /// </summary>
            if (isFirstTime)
            {
                using (StreamWriter sw = new StreamWriter(@"Output.txt"))
                {
                    sw.Write(inputString);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(@"Output.txt"))
                {
                    sw.Write(inputString);
                }
            }
        }
    }
}
