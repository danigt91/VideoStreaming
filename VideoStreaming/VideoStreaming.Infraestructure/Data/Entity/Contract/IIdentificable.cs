using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStreaming.Infraestructure.Data.Entity.Contract
{
    interface IIdentificable
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        Guid ID { get; set; }

    }
}
