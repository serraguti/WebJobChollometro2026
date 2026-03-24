using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MvcNetCoreChollometro.Data;
using MvcNetCoreChollometro.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;

#region TABLA CHOLLOS
/*
create table CHOLLOS
(IDCHOLLO int primary key,
TITULO  nvarchar(max),
LINK nvarchar(max),
DESCRIPCION nvarchar(max),
FECHA datetime)
*/
#endregion

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
