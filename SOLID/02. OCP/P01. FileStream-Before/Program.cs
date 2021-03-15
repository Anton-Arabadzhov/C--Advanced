using System;
using System.Threading;

namespace P01._FileStream_Before
{
    class Program
    {
        
        static void Main(string[] args)
        {
            File file = new File();
            Music music = new Music();
            music.Sent = 0;
            music.Length = 100;
            file.Sent = 0;
            file.Length = 100;
            Progress progress = new Progress(file);
            Progress musics = new Progress(music);
            
            
            
            
            while (file.Sent < 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                file.Sent += 10;
                Console.WriteLine($"{progress.CurrentPercent()}% sent");

                Console.ForegroundColor = ConsoleColor.Cyan;
                music.Sent += 10;
                Console.WriteLine($"{musics.CurrentPercent()}% sent");


                Thread.Sleep(1200);
                
                
                
            }
            
           

        }
        
    }
}
