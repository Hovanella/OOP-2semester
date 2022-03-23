using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Laba2.Json
{
    public class JsonBookFileBaseFacade
    {
        private readonly ListBox _bookFileBase;

        private readonly string _jsonFilePath;


        public JsonBookFileBaseFacade(string jsonFilePath, ListBox bookFileBase)
        {
            _jsonFilePath = jsonFilePath;
            _bookFileBase = bookFileBase;
        }


        public void SaveInFile()
        {
            var bookFilesList = (from object item in _bookFileBase.Items select item as BookFile.BookFile).ToList();

            using (var reader = new StreamWriter(_jsonFilePath))
            {
                string jsonString = JsonConvert.SerializeObject(bookFilesList);
                reader.Write(jsonString);
            }
        }

        public void LoadFromFile()
        {
            List<BookFile.BookFile> bookFilesList;

            using (var reader = new StreamReader(_jsonFilePath))
            {
                bookFilesList = JsonConvert.DeserializeObject<List<BookFile.BookFile>>(reader.ReadToEnd());
            }

            foreach (var bookFile in bookFilesList) _bookFileBase.Items.Add(bookFile);
        }
    }
}