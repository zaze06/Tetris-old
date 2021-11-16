using System.Threading;
using System;

namespace tetris
{
    public class Game
    {
        static void Main(string[] args)
        {
            new Game();
        }
        public Game(){
            ThreadStart print = new ThreadStart(Print);
            Thread printThread = new Thread(print);
            printThread.Start();
        }
        public void Print(){
            while(true){
                Console.WriteLine(Util.timeToSring());
                Util.wait(1);
            }
        }
    }
}