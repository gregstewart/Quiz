using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using WebGrease.Css.Extensions;

namespace Quiz.Models
{
    public class QuestionSelector
    {
        IEnumerable<Question> _shuffledQuestions;
        List<QuestionBag> _selectedQuestions = new List<QuestionBag>();
        public IEnumerable<QuestionBag> GetQuestions()
        {
            
            QuestionRepository questionsRepository = new QuestionRepository();
            IEnumerable<Question> questions = questionsRepository.GetAll();

            var randGen = new Random();

            _shuffledQuestions = Shuffle(questions, randGen);

            foreach(var _question in _shuffledQuestions)
            {
                _selectedQuestions.Add(new QuestionBag(_question.Id, _question.QuestionString));
            }

            return _selectedQuestions;
        }

        public IEnumerable<Answer> GetAnswersForSelectedQuestions(int questionId)
        {
            AnswerRepository answerRepository = new AnswerRepository();
            IEnumerable<Answer> answers = answerRepository.GetAll().Where(p => int.Equals(p.QuestionId, questionId));
            return answers;
        } 

        public static IEnumerable<Question> Shuffle<Question>(IEnumerable<Question> source, Random rng)
        {
            Question[] elements = source.ToArray();
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                // Swap element "i" with a random earlier element it (or itself)
                // ... except we don't really need to swap it fully, as we can
                // return it immediately, and afterwards it's irrelevant.
                int swapIndex = rng.Next(i + 1);
                yield return elements[swapIndex];
                elements[swapIndex] = elements[i];
            }
        }

        public IEnumerable<QuestionBag> Select()
        {
            this.GetQuestions();

            foreach (var _question in _selectedQuestions)
            {
                _question.SetAnswers(GetAnswersForSelectedQuestions(_question.Id));
            }

            return _selectedQuestions;
        }
    }
}