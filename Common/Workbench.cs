using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.Common
{
    public class Workbench
    {
        private static Workbench _instance = null;
        public static Workbench Instance => _instance ??= new Workbench()
            ;
        private Workbench()
        {
            ToolInfos = SqlHelper.Instance.Client.Queryable<ToolInfoDB>()?.ToList() ?? new List<ToolInfoDB>();
        }
        public List<ToolInfoDB> ToolInfos = new List<ToolInfoDB>();

        public void Init()
        {

        }
        /// <summary>
        /// 获取指定类型的工具信息
        /// </summary>
        /// <param name="toolType"></param>
        /// <returns></returns>
        public List<ToolInfoDB> GetToolInfoDBByType(ToolType toolType) => ToolInfos.Where(t => t.ToolType == toolType).ToList();
        public List<ToolInfo> GetToolInfosByType(ToolType toolType) => ToolInfos.Where(t => t.ToolType == toolType).ToList().ConvertTo();

        public void SaveToolInfo()
        {
            if (!ToolInfos.Any())
            {
                return;
            }
            //SetToolType(ToolType.Practical, 20, 20);
            //SetToolType(ToolType.Media, 40, 20);
            //SetToolType(ToolType.AI, 60, 15);
            //SetToolType(ToolType.To, 75, 20);
            //SetToolType(ToolType.Essential, 95, 20);
            //SetToolType(ToolType.Treasure, 115, 4);
            //SetToolType(ToolType.Study, 119, 20);
            //SetToolType(ToolType.Resource, 139, 12);
            //SetToolType(ToolType.Browser, 151, 12);
            //SetToolType(ToolType.Search, 163, 17);
            //SetToolType(ToolType.Life, 180, 8);
            //SetToolType(ToolType.Program, 188, 15);
            //SetToolType(ToolType.Blog, 203, 12);
            //SetToolType(ToolType.Entertainment, 215, 20);

            SqlHelper.Instance.Client.Storageable(ToolInfos).ExecuteCommand();
        }

        private void SetToolType(ToolType toolType, int startIndex, int couont)
        {
            this.ToolInfos.Skip(startIndex).Take(couont).ToList().ForEach(t => t.ToolType = toolType);
        }
    }
}
