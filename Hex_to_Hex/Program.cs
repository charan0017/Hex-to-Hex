namespace Hex_to_Hex
{
    #region Usings

    using System;
    using System.Threading;

    #endregion Usings

    class Program
    {
        public HexEditor _HexEditor = null;

        static void Main(string[] args)
        {
            bool isFirstTime = true;

            /// <summary>
            /// Title
            /// </summary>
            Console.Title = "H2H - Hex to Hex Editor | Copyright ©  2017";
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[H2H]    Note: This converter Limits your Input Hex-Bytes to 254 Characters at each time.", Console.ForegroundColor);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            /// <summary>
            /// This will Start your program.
            /// </summary>
            HexEditor _HexEditor    = new HexEditor(isFirstTime);
            isFirstTime  = false;

            /// <summary>
            /// This method will Switch your opinion.
            /// </summary>
            Console.WriteLine();
            Console.Write("[H2H]    Do you want to add more Hex-Bytes to the Existing queue? (Y/N)");
            ConsoleKeyInfo _Command = Console.ReadKey(false);
            while (_Command.Key != ConsoleKey.N)
            {
                switch (_Command.Key)
                {
                    case ConsoleKey.Y:
                        {
                            Console.WriteLine();
                            _HexEditor = new HexEditor(isFirstTime);
                            Console.WriteLine("[H2H]    Successfully added the new Hex-Bytes to the previous queue.");
                            Console.WriteLine();
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command parsed, try again.");
                            Console.WriteLine();
                            break;
                        }
                }

                Console.Write("[H2H]    Do you want to add more Hex-Bytes to the Existing queue? (Y/N)");
                _Command = Console.ReadKey(false);
            }

            /// <summary>
            /// Now Exiting Application
            /// </summary>
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[H2H]    The Output was successfully written.");
            Console.WriteLine("[H2H]    Now Exiting Application...");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
}
