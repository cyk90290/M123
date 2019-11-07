using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class Program
    {
#pragma warning disable IDE0060 // 移除未使用的參數
        static void Main(string[] args)
#pragma warning restore IDE0060 // 移除未使用的參數
        {
            HanoiGame game = new HanoiGame();
            game.Setup();
            game.Play();

            Console.ReadKey();
        }
    }
}
