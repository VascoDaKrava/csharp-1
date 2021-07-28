namespace TrueFalseEditor
{
    /// <summary>
    /// Класс для объектов "Вопрос"
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Правильный ответ
        /// </summary>
        public bool TrueFalse { get; set; }

        #region Constructors
        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }

        public Question() { }
        #endregion
    }
}
