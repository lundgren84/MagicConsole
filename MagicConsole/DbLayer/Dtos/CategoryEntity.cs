using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicConsole.DbLayer.Dtos
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public List<CategoryEntity> SubCategories { get; set; } = new List<CategoryEntity>();
    }
}