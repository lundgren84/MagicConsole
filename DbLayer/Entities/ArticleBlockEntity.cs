using DbLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities
{
    public class ArticleBlockEntity
    {
        public int Id { get; set; }
        public ArticleType Type { get; set; }
        public string Content { get; set; }

    }
}
