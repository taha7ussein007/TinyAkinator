using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TinyAkinator
{
    public partial class question
    {
        public question(question q)
        {
            this.id = q.id;
            this.value = q.value;
            this.IsAnswered = q.IsAnswered;
            this._Answer = q._Answer;
            this.characters = new List<character>(q.characters);
        }
        public bool IsAnswered { get; private set; }

        private MYCIN_TERM_FACTOR _Answer;
        public MYCIN_TERM_FACTOR Answer
        {
            get
            {
                return _Answer;
            }
            set
            {
                _Answer = value;
                IsAnswered = true;
                foreach (var _character in GameEngine.Instance.Characters) _character.Push(this);
                GameEngine.Instance.Characters.Sort((x, y) => -1 * x.Score.CompareTo(y.Score)); //Sort Desc By Scores
            }
        }
        public void Reset()
        {
            _Answer = 0; //Default Value
            IsAnswered = false;
            foreach (var _character in GameEngine.Instance.Characters) _character.Pull();
            GameEngine.Instance.Characters.Sort((x, y) => -1 * x.Score.CompareTo(y.Score)); //Sort Desc By Scores
        }
    }
}