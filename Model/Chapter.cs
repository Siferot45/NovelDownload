namespace NovelDownload.Model
{
    /// <summary>
    /// Модель глав
    /// </summary>
    public class Chapter
    {
        /// <summary>
        /// Заглавие
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Текст главы
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Проверка глава
        /// </summary>
        public bool IsValid => !string.IsNullOrWhiteSpace(Content);
    }
}
