using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BoardGame board_game1 = new BoardGame(1,5,true,"Chess","strategy","manufacturer",4);
            BoardGame board_game2 = new BoardGame(4, 20, false, "Warhammer", "wargaming", "Gamesworkshop", 5);
            BoardGame board_game3 = new BoardGame(2, 10, true, "Monopoly", "economics-themed", "Elizabeth Magie", 3);
            BoardGame board_game4 = new BoardGame(2, 15, true, "Cards", "card game", "Jonh", 1);

            Games games = new Games(board_game1, board_game2,board_game4);
            Console.WriteLine("\nИгры:\n" + games);
            
            games.AddGame(board_game3);
            Console.WriteLine("------------------После добавление нового элемента в массив------------------");
            Console.WriteLine("\nИгры:\n" + games);

            games.DeleteGame(1);
            Console.WriteLine("------------------После удаления элемента массива------------------");
            Console.WriteLine("\nИгры:\n" + games);

            games.EditGames(board_game3,0);
            Console.WriteLine("------------------Изменение состояния c начала игры на продолжение игры------------------");
            board_game4.PlayGame();
            Console.WriteLine("\nИгры:\n" + games);

            Console.ReadLine();
        }
    }
}
