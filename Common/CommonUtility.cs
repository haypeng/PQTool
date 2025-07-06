using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.Common
{
    public static class CommonUtility
    {
        public static List<ToolInfo> ConvertTo(this List<ToolInfoDB> toolInfoDBs)
        {
            var datas = new List<ToolInfo>();
            foreach (var item in toolInfoDBs)
            {
                var data = new ToolInfo()
                {
                    Id = item.ID,
                    Name = item.Name,
                    Description = item.Description,
                    Url = item.Url,
                    Image = item.Image,
                };
                datas.Add(data);
            }
            return datas;
        }
        public static List<ToolInfoDB> ConvertToDB(this List<ToolInfo> toolInfos)
        {
            var datas = new List<ToolInfoDB>();
            foreach (var item in toolInfos)
            {
                var data = new ToolInfoDB()
                {
                    ID = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Url = item.Url,
                    Image = item.Image,
                };
                datas.Add(data);
            }
            return datas;
        }
    }
}
