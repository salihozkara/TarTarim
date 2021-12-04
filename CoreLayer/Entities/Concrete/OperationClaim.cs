using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreLayer.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }

        public bool Status { get; set; }
    }
}
