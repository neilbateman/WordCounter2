using System;
using System.Collections.Generic;
namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _intakeSentence;
        private string _intakeWord;

        public RepeatCounter(string sentence, string word)
        {
            _intakeSentence = sentence.ToLower();
            _intakeWord = word.ToLower();
        }
        public string GetSentence()
        {
            return _intakeSentence;
        }
        public string GetWord()
        {
            return _intakeWord;
        }
        public void SetSentence(string setSentence)
        {
            _intakeSentence = setSentence;
        }
        public void SetWord(string setWord)
        {
            _intakeWord = setWord;
        }

        public int GetPairs()
        {
            int pairs = 0;
            string[] splitSentence = _intakeSentence.Split();
            foreach (string word in splitSentence)
            {
                if (word == _intakeWord)
                {
                    pairs += 1;
                }
            }
            return pairs;
        }


    }

}
