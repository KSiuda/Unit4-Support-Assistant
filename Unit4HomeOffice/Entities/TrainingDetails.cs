using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unit4HomeOffice.Entities.Base;

namespace Unit4HomeOffice.Entities
{
    public class TrainingDetails : EntityBase
    {
        public string TrainingName { get; set; }

        public string ConsultantName { get; set; }

        public string Status { get; set; }
    }
}
