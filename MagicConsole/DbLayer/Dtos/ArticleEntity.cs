using System.Collections.Generic;

namespace MagicConsole.DbLayer.Dtos
{
    public class ArticleEntity
    {
        public int Id { get; set; }
        public List<ArticleBlockEntity> Blocks { get; set; } = new List<ArticleBlockEntity>();
    }
}