
namespace Lab6
{
    internal class Games
    {
        private Game[] _games;

        /// <summary>
        /// Если параметром приходит ноль инициализируем с нулевой длиной массив 
        /// </summary>
        /// <param name="games">Элементы вставляемые в массив, наследники класса Student</param>
        public Games(params Game[] games)
        {
            if (games is not null)
            {
                _games = games;
            }
            else
            {
                _games = new Game[0];
            }
        }

        /// <summary>
        /// Добавление объекта в массив
        /// </summary>
        /// <param name="game">Объект для добавления</param>
        /// <exception cref="FormatException"></exception>
        public void AddGame(Game game)
        {
            if (game is null)
            {
                throw new FormatException("Неверно задана игра");
            }
            else
            {
                Array.Resize(ref _games, _games.Length + 1);
                _games[_games.Length - 1] = game;
            }
        }

        /// <summary>
        /// Удаление объекта из массива
        /// </summary>
        /// <param name="index">Индекс элемента который необходимо удалить</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void DeleteGame(int index)
        {
            if (index >= 0 && index < _games.Length)
            {
                Array.Copy(_games, index + 1, _games, index, _games.Length - index - 1);
                Array.Resize(ref _games, _games.Length - 1);
                Console.WriteLine("Игра успешно удалена из списка.");
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Обновление элемента по индексу, вызовет ArgumentOutOfRangeException, если индекс неверный
        /// </summary>
        /// <param name="game"></param>
        /// <param name="index"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void EditGames(Game game,uint index)
        {
            if (index >= 0 && index < _games.Length && (game is not null))
            {
                _games[index] = game;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            String result = "";
            foreach (Game game in _games)
            {
                result += game + "\n";
            }
            return result;
        }

    }
}
