using ITFCodeWA.Domain.DataContext.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFCodeWA.Domain.DataContext
{
    public class DataContext : DbContext, IDataContext
    {
    }
}
