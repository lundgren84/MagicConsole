using DbLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities
{
   public class ArticleEntity
    {
        public int Id { get; set; }
        public List<ArticleBlockEntity> Blocks { get; set; } = new List<ArticleBlockEntity>();
    }
}
