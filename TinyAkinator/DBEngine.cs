using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TinyAkinator
{
    public sealed class DBEngine
    {
        private static volatile DBEngine instance;
        private static object syncRoot = new object();
        private TinyAkinatorEntities db;
        public static DBEngine Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DBEngine();
                    }
                }
                return instance;
            }
        }
        public List<character> Characters { get; private set; }
        public List<question> Questions { get; private set; }

        private DBEngine()
        {
            db = new TinyAkinatorEntities();
            Load();
        }
        public void Dispose()
        {
            instance = null;
        }
        private void Load()
        {
            Characters = db.characters.ToList();
            Questions = db.questions.ToList();
        }
        public long Add(character character)
        {
            db.characters.Add(character);
            db.SaveChanges();
            Load();
            return db.characters.ToList().LastOrDefault().id;
        }
        public long Add(question question)
        {
            db.questions.Add(question);
            db.SaveChanges();
            Load();
            return db.questions.ToList().LastOrDefault().id;
        }
        public void Delete(long id, Type ObjectType)
        {
            if (ObjectType == typeof(question))
            {
                {
                    var ObjToRemove = db.questions.Find(id);
                    db.questions.Remove(ObjToRemove);
                    db.SaveChanges();
                    Load();
                }
            }
            else if (ObjectType == typeof(character))
            {
                var ObjToRemove = db.characters.Find(id);
                db.characters.Remove(ObjToRemove);
                db.SaveChanges();
                Load();
            }
        }
        public void Update(int characterID, character newCharacterData)
        {
            db.Entry(newCharacterData).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            db.SaveChanges();
            db.Configuration.ValidateOnSaveEnabled = true;
            Load();
        }
        public void Update(int questionID, question newQuestionData)
        {
            db.Entry(newQuestionData).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            db.SaveChanges();
            db.Configuration.ValidateOnSaveEnabled = true;
            Load();
        }
        public dynamic GetByID(long id, Type ObjectType)
        {
            if (ObjectType == typeof(question))
            {
                return db.questions.Find(id);
            }
            else if (ObjectType == typeof(character))
            {
                return db.characters.Find(id);
            }
            else
                return null;
        }
    }
}
