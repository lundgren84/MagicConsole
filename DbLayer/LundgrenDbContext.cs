using DbLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DbLayer
{
    public class LundgrenDbContext : DbContext
    {
        public LundgrenDbContext() : base("Lundgren84ConnectionString")
        { }

        //public DbSet<ArticleEntity> Articles { get; set; }
        //public DbSet<ArticleBlockEntity> ArticleBlocks { get; set; }
    }
}
