using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrueFalseEditor
{

    class TrueFalse
    {
        #region  Private Fields
        string fileName;
        private List<Question> list;
        #endregion

        #region Public Properties
        /// <summary>
        /// Имя файла для сохранения/загрузки базы
        /// </summary>
        public string FileName
        {
            set { fileName = value; }
        }

        /// <summary>
        /// Количество вопросов в базе
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// Индексатор для доступа к конкретному вопросу в базе
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Question this[int index]
        {
            get { return list[index]; }
        }
        #endregion


        #region Constructors
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public TrueFalse()
        {
            list = new List<Question>();
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Добавить вопрос в базу
        /// </summary>
        /// <param name="text"></param>
        /// <param name="trueFalse"></param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        /// <summary>
        /// Удалить вопрос из базы по индексу
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0)
                list.RemoveAt(index);
        }

        /// <summary>
        /// Загрузить базу из файла
        /// </summary>
        public void Load()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Question>)xmlSerializer.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранить базу в файл
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(stream, list);
            stream.Close();
        }
        #endregion
    }
}
