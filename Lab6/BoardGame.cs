
namespace Lab6
{
    /// <summary>
    /// Класс BoardGame,содержащий свойства BoardGame и наследующий класс Game
    /// </summary>
    public class BoardGame : Game
    {
        private int _numberOfPlayers;
        private int _playingTimeInMinutes;
        private bool _isCooperative;
        private const byte MAX_TIME_LIMIT = 20;
        private const byte MAX_NUMBER_OF_PLAYES = 4;

        /// <summary>
        /// Сеттер и геттер поля _numberOfPlayers в котором хранится количество игроков, 
        /// возвращает Неверно установленое количество игроков, при попытке присвоить пустую строку
        /// </summary>
        public int NumberOfPlayers
        {
            get => _numberOfPlayers;
            set
            {
                if (value >= 0 && value <= MAX_NUMBER_OF_PLAYES)
                {
                    _numberOfPlayers = value;
                }
                else
                {
                    throw new FormatException("Неверно установленое количество игроков");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _playingTimeInMinutes в котором хранится время игры, 
        /// возвращает Неверно установленое время, если время ниже 0 и выше 20(максимальный лимит матча)
        /// </summary>
        public int PlayingTimeInMinutes
        {
            get => _playingTimeInMinutes;
            set
            {
                if (value >= 0 && value <= MAX_TIME_LIMIT)
                {
                    _playingTimeInMinutes = value;
                }
                else
                {
                    throw new FormatException("Неверно установленое время");
                }
            }
        }

        /// <summary>
        ///  Сеттер и геттер поля _isCooperative в котором хранится кооперативость игры(true-игра кооперативна,false-игра не кооперативна)
        /// </summary>
        public bool IsCooperative { get => _isCooperative; set => _isCooperative = value; }

        /// <summary>
        /// Данный конструктор создает новый объект класса BoardGame и наследует свойства Game 
        /// </summary>
        /// <param name="numberOfPlayers">Количетсво игроков</param>
        /// <param name="playingTimeInMinutes">Время игры в минутах</param>
        /// <param name="isCooperative">Кооперативность игры</param>
        /// <param name="title">Название игры</param>
        /// <param name="genre">Жанр игры</param>
        /// <param name="manufacturer">Производитель игры</param>
        /// <param name="rating">Рейтинг игры</param>
        public BoardGame(int numberOfPlayers, int playingTimeInMinutes, bool isCooperative, string title, string genre, string manufacturer, float rating) : base(title, genre, manufacturer, rating)
        {
            NumberOfPlayers = numberOfPlayers;
            PlayingTimeInMinutes = playingTimeInMinutes;
            IsCooperative = isCooperative;
        }

        public override string ToString()
        {
            return base.ToString() + $"Количество игроков:{NumberOfPlayers};\nВремя игры в минутах:{PlayingTimeInMinutes};\nКооперативность игры: {IsCooperative}\n";
        }
    }
}
