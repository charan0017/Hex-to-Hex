using System;
using System.IO;
using System.Threading;

namespace Hex_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Title
            /// </summary>
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
             .__   ___                       .__                .__   ___                   
             |  | |   |                      |  |___            |  | |   |                  
             |  |_|   | ____  .__    __      |   __/ ____       |  |_|   | ____  .__    __ 
             |   _    _/ __ \ |_ \  / _|     |  |   /  _ \      |   _    _/ __ \ |_ \  / _|
             |  | |   \  ___/  _| )( |_      |  |__(  <_> )     |  | |   \  ___/  _| )( |_ 
             |__| |___|\___  >|__/  \__|     \_____/\____/      |__| |___|\___  >|__/  \__|
                           \/                                                 \/           
            ");

            /// <summary>
            /// This is Initiation for taking Input Hex String.
            /// </summary>
            int i = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[H2H]    Note: This converter Limits your input Hex Bytes to 254 Characters Only", Console.ForegroundColor);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[H2H]    Please Enter your input Hex Bytes: ");
            string inputString = Console.ReadLine() + ", ";

            /// <summary>
            /// This is method to remove '0x' and ','. For Ex: i/p: 0x2F, 0x46 -> o/p: 2F46
            /// </summary>
            while (i<inputString.Length)
            {
                if(inputString[i] == '0')
                    if(inputString[i+1] == 'x')
                        if(inputString[i+4] == ',')
                        {
                            inputString = inputString.Remove(i, 2);
                            inputString = inputString.Remove(i + 2, 2);
                        }
                ++i;
            }

            /// <summary>
            /// Verifying for Output file existence
            /// </summary>
            if (File.Exists(@"Output.txt"))
                File.Delete(@"Output.txt");

            /// <summary>
            /// Writing the Output
            /// </summary>
            using (StreamWriter sw = new StreamWriter(@"Output.txt"))
            {
                sw.WriteLine(inputString);
            }

            Console.WriteLine("[H2H]    The Output was successfully written.");
            Console.WriteLine("[H2H]    Now Exiting Application...");
            Thread.Sleep(7000);
            Environment.Exit(0);
        }
    }
}
