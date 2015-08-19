namespace CrmParser.Data
{
    public class OperatorInfo
    {
        /// <summary>
        /// Добавочный оператора
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Количество принятых звонков
        /// </summary>
        public string CountAnswered { get; set; }

        /// <summary>
        /// Время паузы
        /// </summary>
        public string PauseTime { get; set; }

        /// <summary>
        /// Время в работе
        /// </summary>
        public string WorkTime { get; set; }

        /// <summary>
        /// Статус паузы
        /// </summary>
        public string PauseStatus { get; set; }

    }
}
