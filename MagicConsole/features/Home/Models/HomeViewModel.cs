using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagicConsole.DbLayer.Dtos;

namespace MagicConsole.features.Home.Models
{
    public class HomeViewModel
    {

        public List<CategoryEntity> Categories { get; set; }
    }
}