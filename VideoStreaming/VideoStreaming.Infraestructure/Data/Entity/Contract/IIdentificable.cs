﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoStreaming.Infraestructure.Data.Entity.Contract
{
    interface IIdentificable
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        Guid ID { get; set; }

    }
}
