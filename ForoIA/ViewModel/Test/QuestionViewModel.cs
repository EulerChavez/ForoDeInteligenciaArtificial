using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoIA.ViewModel.Test {

    public class QuestionViewModel {

        public int Id { get; set; }

        public int QuestionType { get; set; }

        public string Question { get; set; }

        public IEnumerable<KeyValuePair<int, string>> Answers { get; set; }

        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

    }

}