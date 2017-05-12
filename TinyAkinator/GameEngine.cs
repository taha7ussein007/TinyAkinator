using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyAkinator
{
    public sealed class GameEngine
    {
        private static volatile GameEngine instance;
        private static object syncRoot = new object();
        public static GameEngine Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new GameEngine();
                    }
                }
                return instance;
            }
        }
        public DBEngine dbe { get; private set; }
        public List<character> Characters { get; set; }
        public List<question> Questions { get; set; }
        public Stack<question> TrackAnsweredQuestions { get; private set; }
        public Stack<character> TrackFirstCharacterChange { get; private set; }

        public const double Threshold = 0.8;
        private GameEngine()
        {
            dbe = DBEngine.Instance;
        }
        public void Dispose()
        {
            instance = null;
        }
        public void StartNewGame(Func<string, MYCIN_TERM_FACTOR> AskFunc)
        {
            Characters = new List<character>();
            Questions = new List<question>();
            foreach (var item in dbe.Characters)
                Characters.Add(new character(item));
            foreach (var item in dbe.Questions)
                Questions.Add(new question(item));

            TrackAnsweredQuestions = new Stack<question>();
            TrackFirstCharacterChange = new Stack<character>();

            var RandomCharacter = new character(Characters.PickRandom());
            var RandomQuestion = RandomCharacter.questions.PickRandom();

            var qIndex = Questions.FindIndex(x => x.id == RandomQuestion.id);
            var ans = AskFunc(Questions[qIndex].value);
            Questions[qIndex].Answer = ans;

            TrackFirstCharacterChange.Push(new character(Characters.FirstOrDefault()));
            TrackAnsweredQuestions.Push(Questions[qIndex]);

            foreach (var c in Characters)
                c.questions.Shuffle();
        }
        public short Next(Func<string, MYCIN_TERM_FACTOR> AskFunc)
        {
            var topCharacter = Characters.FirstOrDefault();
            if(topCharacter.Score < Threshold)
            {
                var nxtQuestionIndex = FindNextQuestionIndex(topCharacter); //Random Because Shuffeled
                if(nxtQuestionIndex > -1)
                {
                    var ans = AskFunc(Questions[nxtQuestionIndex].value);
                    Questions[nxtQuestionIndex].Answer = ans;

                    TrackFirstCharacterChange.Push(new character(Characters.FirstOrDefault()));
                    TrackAnsweredQuestions.Push(Questions[nxtQuestionIndex]);

                    return 0; //Trying to find the goal
                }
                else
                {
                    if (Characters.Count > 1)
                    {
                        Characters.RemoveAt(0); //Skip To Next Character
                        return Next(AskFunc);
                    }
                    else
                        return -1; //Cannot Found
                }
            }
            else
            {
                return 1; //Found
            }
        }
        public void Back()
        {
            if(TrackAnsweredQuestions.Count > 0)
            {
                TrackFirstCharacterChange.Pop();
                TrackAnsweredQuestions.Pop().Reset();
            }
        }
        private int FindNextQuestionIndex(character c)
        {
            foreach (var item in c.questions)
            {
                var qIndex = Questions.FindIndex(x => x.id == item.id);
                if (!Questions[qIndex].IsAnswered)
                    return qIndex;
            }
            return -1;
        }
    }
}
