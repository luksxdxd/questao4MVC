using MvcProva4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProva4.Context
{
    public class Contexto : DbContext
    {
        public DbSet<Professor> Professores { get; set; }
    }
}