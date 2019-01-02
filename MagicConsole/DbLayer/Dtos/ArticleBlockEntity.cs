namespace MagicConsole.DbLayer.Dtos
{
    public class ArticleBlockEntity
    {
        public int Id { get; set; }
        public ArticleType Type { get; set; }
        public string Content { get; set; }
    }
}