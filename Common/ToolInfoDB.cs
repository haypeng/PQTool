using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.Common
{
    [SugarTable("toolInfo")]
    public class ToolInfoDB
    {
        [SugarColumn(ColumnName = "id", IsPrimaryKey = true)]
        public int ID { get; set; }

        [SugarColumn(ColumnName = "name")]
        public string Name { get; set; }

        [SugarColumn(ColumnName = "description")]
        public string Description { get; set; }

        [SugarColumn(ColumnName = "image")]
        public string Image { get; set; }
        [SugarColumn(ColumnName = "url")]
        public string Url { get; set; }
        [SugarColumn(ColumnName = "toolType")]
        public ToolType ToolType { get; set; }
    }
}
