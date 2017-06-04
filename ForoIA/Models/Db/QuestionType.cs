using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class QuestionType {

        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

    }

}