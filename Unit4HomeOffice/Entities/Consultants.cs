using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unit4HomeOffice.Entities.Base;

namespace Unit4HomeOffice.Entities
{
    public class Consultants : EntityBase
    {
        public string Name { get; set; }

        public string Position { get; set; }
    }
}
