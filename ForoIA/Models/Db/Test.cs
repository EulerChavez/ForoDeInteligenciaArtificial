using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class Test {

        public int Id { get; set; }

        [Required]
        public string Question { get; set; }

        public int DificultId { get; set; }

        public int QuestionTypeId { get; set; }

        public int TopicId { get; set; }

        // Navigation Properties

        public virtual ICollection<Answer> Answers { get; set; }

        public virtual Dificulty Dificult { get; set; }

        public virtual QuestionType QuestionType { get; set; }

        public virtual Topic Topic { get; set; }

    }

}