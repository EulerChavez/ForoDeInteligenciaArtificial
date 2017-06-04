using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForoIA.ViewModel.Post {

    public class UserPostsViewModel {

        public int Id { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Categoría")]
        public string Category { get; set; }

        [Display(Name = "Fecha de publicación")]
        public DateTime Date { get; set; }

    }

}