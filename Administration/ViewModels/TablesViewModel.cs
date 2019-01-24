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
            Tables = new List<Table>();
        }

        public TablesViewModel(IEnumerable<Infrastructure.Entities.Table> tables)
        {
            Tables = tables.Select(t => Table.MapFromEntity(t)).ToList();
        }

        public List<Table> Tables { get; set; }
    }
}