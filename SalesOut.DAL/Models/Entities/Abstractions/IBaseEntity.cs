﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesOut.DAL.Models.Entities.Abstractions
{
    public interface IBaseEntity
    {
        ulong Id { get; set; }
    }
}
