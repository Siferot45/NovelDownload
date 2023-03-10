
namespace NovelDownload.Model
{
    /// <summary>
    /// Модель книги
    /// </summary>
    public class Novel
    {
        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Статус перевода
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Последние обновление
        /// </summary>
        public string LastUpdated { get; set; }
        /// <summary>
        /// Расположение книги
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// Обложка книги
        /// </summary>
        public Image Cover { get; set; }
        /// <summary>
        /// Главы книги
        /// </summary>
        public IEnumerable<Chapter> Chapters { get; set; }
        /// <summary>
        /// Номер последней главы
        /// </summary>
        public string NumberOfChapters { get; set; }
    }
}
