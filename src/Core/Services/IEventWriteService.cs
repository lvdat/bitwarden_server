﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.Core.Models.Data;

#nullable enable

namespace Bit.Core.Services
{
    public interface IEventWriteService
    {
        Task CreateAsync(IEvent e);
        Task CreateManyAsync(IEnumerable<IEvent> e);
    }
}
