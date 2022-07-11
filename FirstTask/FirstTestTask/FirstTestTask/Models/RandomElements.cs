namespace FirstTestTask.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RandomElements
    {
        public int Id { get; set; }

        public string Element { get; set; }
    }
}
