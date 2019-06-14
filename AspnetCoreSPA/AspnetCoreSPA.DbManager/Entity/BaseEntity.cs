using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspnetCoreSPA.Data.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
