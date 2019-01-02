using MagicConsole.DbLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagicConsole.DbLayer
{
    public class LundgrenDbContext : DbContext
    {
        public LundgrenDbContext() : base("Lundgren84ConnectionString")
        { }

        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<ArticleBlockEntity> ArticleBlocks { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}