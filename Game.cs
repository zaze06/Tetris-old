using System.Threading;
using System;

namespace tetris
{
    public class Game
    {
        private static readonly int width = 6;
        private static readonly int hight = 10;
        int[,] map = new int[width, hight];

        static void Main(string[] args)
        {
            new Game();
        }
        public Game(){
            Setup();
            ThreadStart print = new ThreadStart(Print);
            Thread printThread = new Thread(print);
            Console.Clear();
            printThread.Start();
        }
        public void Setup(){
            for(int y = 0; y < hight; y++){
                for(int x = 0; x < width; x++){
                    map[x,y] = (((int)Util.rnd(1))==0?0:1);
                }
            }
        }
        public void Print(){
            while(true){
                Console.SetCursorPosition(0,0);
                Setup();
                for(int y = 0; y < hight; y++){
                    for(int x = 0; x < width; x++){
                        Console.Write(Util.find(map[x,y]));
                    }
                    Console.Write("\n");
                }
                Util.wait(2);
            }
        }
    }
}