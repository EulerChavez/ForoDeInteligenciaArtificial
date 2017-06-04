using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class Dificulty {

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        // Navigation Properties

    }

}