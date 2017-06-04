using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class ConfigurationTest {

        public int Id { get; set; }

        public string Username { get; set; }

        public int DificultyId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        // Navigation Properties

        public virtual Dificulty Dificulty { get; set; }

        public virtual ICollection<TestAnswer> TestAnswer { get; set; }

    }

}