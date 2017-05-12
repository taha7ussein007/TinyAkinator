using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyAkinator
{
    public class DBAppendModel
    {
        private DBEngine db;
        private const string filepath = "DBAppendCharacter";
        private const string defaultStartLine = "--> Remove This Line First! <--";
        private readonly string[] defaultLines = 
            new string[10] 
            {
                defaultStartLine,
                "اسم الشخصية",
                "وصف الشخصية",
                string.Empty,
                "سؤال؟",
                "سؤال؟",
                ".",
                ".",
                ".",
                "سؤال؟"
            };
        public DBAppendModel()
        {
            db = DBEngine.Instance;
        }
        public async Task Append()
        {
            await Task.Run(() => 
            {
                try
                {
                    var fileLines = File.ReadAllLines(filepath, Encoding.Default);
                    if (fileLines.FirstOrDefault() == defaultStartLine 
                    || string.IsNullOrEmpty(fileLines.FirstOrDefault()))
                    {
                        BeforeReturn();
                        return;
                    }
                    var newCharacter = new character();

                    newCharacter.name = fileLines[0];
                    newCharacter.description = fileLines[1];
                    newCharacter.img_path = string.Empty;

                    var newCharacter_Questons = fileLines.Skip(3).ToArray();

                    fileLines = null;

                    var qCollection = HandleQuestions(newCharacter_Questons);
                    if(qCollection.Count == 0)
                    {
                        BeforeReturn();
                        return;
                    }

                    newCharacter.questions = qCollection;
                    newCharacter.id = db.Add(newCharacter);
                    newCharacter.img_path = string.Format("Design/characters/{0}.png", newCharacter.id);
                    db.Update((int)newCharacter.id, newCharacter);

                    new Bitmap(100, 100).Save(newCharacter.img_path);
                    BeforeReturn();
                    return;
                }
                catch
                {
                    BeforeReturn();
                    return;
                }
            });
        }
        private ICollection<question> HandleQuestions(string[] questions)
        {
            var result = new List<question>();
            foreach (var q in questions)
            {
                if (!string.IsNullOrEmpty(q))
                {
                    var question = db.Questions.FirstOrDefault(x => x.value == q);
                    if (question == null) //new question
                    {
                        db.Add(new question() { value = q });
                        question = db.Questions.FirstOrDefault(x => x.value == q);

                    }
                    result.Add(question);
                }
            }
            return result;
        }
        private void BeforeReturn()
        {
            try
            {
                db.Dispose();
                File.WriteAllLines(filepath, defaultLines, Encoding.UTF8);
            }
            catch
            {
                return;
            }
        }

    }
}
