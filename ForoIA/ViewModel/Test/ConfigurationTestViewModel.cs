using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForoIA.ViewModel.Test {

    public class ConfigurationTestViewModel {

        [Display(Name = "Unidad 1. ")]
        public bool Unidad1 { get; set; }

        [Display(Name = "Unidad 2. ")]
        public bool Unidad2 { get; set; }

        [Display(Name = "Unidad 3. ")]
        public bool Unidad3 { get; set; }

        [Display(Name = "Unidad 4. ")]
        public bool Unidad4 { get; set; }

        [Display(Name = "Unidad 5. ")]
        public bool Unidad5 { get; set; }

        public int Dificultad { get; set; }

    }

}