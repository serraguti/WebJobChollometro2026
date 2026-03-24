using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;
using MvcNetCoreChollometro.Data;
using MvcNetCoreChollometro.Models;

namespace MvcNetCoreChollometro.Repositories
{
    public class RepositoryChollometro
    {
        private ChollometroContext context;
        public RepositoryChollometro(ChollometroContext context)
        {
            this.context = context;
        }

        public async Task<List<Chollo>> GetChollosAsync()
        {
            return await this.context.Chollos
                .OrderByDescending(x => x.Fecha).ToListAsync();
        }
    }
}
