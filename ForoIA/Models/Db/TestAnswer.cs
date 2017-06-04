using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class TestAnswer {

        public int Id { get; set; }

        public int ConfigurationTestId { get; set; }

        public int? TestId { get; set; }

        public int AnwserIdSelected { get; set; }

        public string TextAnswer { get; set; }

        public bool IsAnswered { get; set; }

        // Navigation Properties

        public virtual ConfigurationTest ConfigurationTest { get; set; }

        public Test Test { get; set; }

    }

}