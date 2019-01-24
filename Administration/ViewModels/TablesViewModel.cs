using Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administration.ViewModels
{
    public class TablesViewModel
    {
        public TablesViewModel()
        {
            Tables = new List<Table> { new Table { TableId = 1, TableNumber = "aaa44" } };
        }

        public List<Table> Tables { get; set; }
    }
}