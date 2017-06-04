using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForoIA.ViewModel.Post {

    public class CreatePostViewModel {

        [Required]
        [StringLength(50)]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Categoría")]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(1024)]
        [Display(Name = "Introducción")]
        public string Review { get; set; }

        [Required]
        [StringLength(5120)]
        [Display(Name = "Contenido")]
        public string Content { get; set; }

    }

}