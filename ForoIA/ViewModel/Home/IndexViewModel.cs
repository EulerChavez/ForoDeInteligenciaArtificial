using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoIA.ViewModel.Home {

    public class IndexViewModel {

        public int CategoryId { get; set; }

        public string Category { get; set; }

        public int TotalPosts { get; set; }

        public int TotalComments { get; set; }

        public int PostId { get; set; }

        public string UserName { get; set; }

        public DateTime Date { get; set; }

    }

}