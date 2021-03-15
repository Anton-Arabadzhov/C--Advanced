using System;
using System.Threading;

namespace Virus
{
    class Program
    {
        static System.Threading.Timer timer = new Timer(TimerCallback, null, System.Threading.Timeout.Infinite, 0);
        static int alertX;
        static int alertY;
        static bool alertDisplayed = false;
        static int cursorX;
        static int cursorY;
        static object consoleLock = new object();
        static void Main(string[] args)
        {
            File file = new File();
            file.Sent = 0;
            file.Length = 100;
            Progress progress = new Progress(file);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press \"Enter\" to uploading the Virus");
            var input = Console.ReadKey();
            Console.Clear();
            while (file.Sent < 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                file.Sent += 10;
                // Console.WriteLine($"{progress.CurrentPercent()}% ");
                for (int a = 0; a <= 100; a++)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write("{0} ", a + "% Uploading...");  // Override complete previous contents
                    Thread.Sleep(100);

                }
                Console.WriteLine();
                break;
                Thread.Sleep(1200);



            }
            WriteFlashingText();
            Console.WriteLine();
            var imput = Console.Read();

        }
        static void WriteFlashingText()
        {
            alertX = Console.CursorLeft;
            alertY = Console.CursorTop;
            timer.Change(0, 400);
        }
        static void TimerCallback(object state)
        {
            lock (consoleLock)
            {
                cursorX = Console.CursorLeft;
                cursorY = Console.CursorTop;

                Console.CursorLeft = alertX;
                Console.CursorTop = alertY;

                if (alertDisplayed)
                {
                    Console.WriteLine("Virus uploading succesfully...");
                }
                else
                {
                    Console.WriteLine("                                  ");
                }
                alertDisplayed = !alertDisplayed;

                Console.CursorLeft = cursorX;
                Console.CursorTop = cursorY;
            }
        }
    }
}
