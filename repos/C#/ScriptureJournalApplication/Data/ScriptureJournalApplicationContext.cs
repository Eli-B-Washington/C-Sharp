using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptureJournalApplication.Models;

namespace ScriptureJournalApplication.Data
{
    public class ScriptureJournalApplicationContext : DbContext
    {
        public ScriptureJournalApplicationContext (DbContextOptions<ScriptureJournalApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureJournalApplication.Models.Scripture> Scripture { get; set; }
    }
}
