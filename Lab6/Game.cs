
namespace Lab6
{
    /// <summary>
    /// Абстрактный класс Game, который реализует интерфейс IGame
    /// </summary>
    public abstract class Game : IGame
    {

        private readonly string _title;
        private string _genre;
        private string _manufacturer;
        private float _rating;
        private string _currentState;
        private const byte MAX_RATING = 5;
        private const byte MIN_RATING = 0;

        /// <summary>
        /// Данный конструктор создает новый объект класса Game  
        /// </summary>
        /// <param name="title">название игры</param>
        /// <param name="genre">жанр игры</param>
        /// <param name="manufacturer">производителя игры</param>
        /// <param name="rating">рейтинг игры</param>
        protected Game(string title, string genre, string manufacturer, float rating)
        {
            Title = title;
            Genre = genre;
            Manufacturer = manufacturer;
            Rating = rating;
            CurrentState = GameStates.START;
        }

        /// <summary>
        ///  Сеттер и геттер поля _title в котором хранится название игры, 
        ///  возвращает Неверно указаное название, при попытке присвоить пустую строку
        /// </summary>
        public string Title
        {
            get => _title;
            init
            {
                string trimValue = value.Trim();
                if (!string.IsNullOrEmpty(value))
                {
                    _title = trimValue;
                }
                else
                {
                    throw new FormatException("Неверно указаное название");
                }

            }
        }

        /// <summary>
        ///  Сеттер и геттер поля _genre в котором хранится жанр игры, 
        ///  возвращает Неверно указаный жанр, при попытке присвоить пустую строку
        /// </summary>
        public string Genre
        {
            get => _genre;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _genre = value;
                }
                else
                {
                    throw new FormatException("Неверно указаный жанр");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _manufacturer в котором хранится производитель игры, 
        /// возвращает Неверно указаный произоводитель, при попытке присвоить пустую строку
        /// </summary>
        public string Manufacturer
        {
            get => _manufacturer;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _manufacturer = value;
                }
                else
                {
                    throw new FormatException("Неверно указаный произоводитель");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _rating в котором хранится рейтинг игры, 
        /// возвращает Неверный рейтинг, если рейтинг ниже 0(минимальный) и выше 5(максимальный)
        /// </summary>
        public float Rating
        {
            get => _rating;
            set
            {
                if (value >= MIN_RATING && value <= MAX_RATING)
                {
                    _rating = value;
                }
                else
                {
                    throw new FormatException("Неверный рейтинг");
                }
            }
        }

        /// <summary>
        /// Сеттер и геттер поля _currentState в котором хранится состояние игры, 
        /// возвращает Неверное состояние, при попытке присвоить пустую строку
        /// </summary>
        public string CurrentState
        {

            get => _currentState;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _currentState = value.Trim();
                }
                else
                {
                    throw new FormatException("Неверное состояние");
                }
            }

        }
        
        /// <summary>
        /// Метод для изменения текущего состояния игры на "start"
        /// </summary>
        public void StartGame()
        {
            if (CurrentState != GameStates.START)
            {
                CurrentState = GameStates.START;
            }
        }

        /// <summary>
        /// Метод для изменения текущего состояния игры на "play"
        /// </summary>
        public void PlayGame()
        {
            if (CurrentState != GameStates.PLAY)
            {
                CurrentState = GameStates.PLAY;
            }
        }

        /// <summary>
        /// Метод для изменения текущего состояния игры на "end"
        /// </summary>
        public void EndGame()
        {
            if (CurrentState != GameStates.END)
            {
                CurrentState = GameStates.END;
            }
        }

        public override string ToString()
        {
            return $"\nИгра:{Title};\nЖанр:{Genre};\nПроизводитель{Manufacturer};\nОценка критиков:{Rating};\nСостояние игры:{CurrentState};\n";
        }
    }
}
