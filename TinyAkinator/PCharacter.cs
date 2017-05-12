using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyAkinator
{
    public partial class character
    {
        public character(character c)
        {
            this.id = c.id;
            this.name = c.name;
            this.description = c.description;
            this.img_path = c.img_path;
            this.Score = c.Score;
            this.ScoreTracking = new Stack<double>(c.ScoreTracking.Reverse());
            this.questions = new List<question>(c.questions);
        }
        public double Score { get; private set; }
        private Stack<double> ScoreTracking = new Stack<double>();
        public void Push(question q)
        {
            ScoreTracking.Push(Score);
            if (this.questions.ToList().Exists(x => x.id == q.id))
                Score += ((double)q.Answer / 100) / this.questions.Count;
        }
        public void Pull()
        {
            Score = ScoreTracking.Pop();
        }
    }
}