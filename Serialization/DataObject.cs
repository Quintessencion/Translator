using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class DataObject
    {
        //Fields
        public string Text { get; set; }
        public string File_MenuItem { get; set; }
        public string OpenModel_MenuItem { get; set; }
        public string ExportPicture_MenuItem { get; set; }
        public string Settings_MenuItem { get; set; }
        public string Close_MenuItem { get; set; }
        public string View_MenuItem { get; set; }
        public string ResetViiew_MenuItem { get; set; }
        public string OptimizateView_MenuItem { get; set; }
        public string ColorModel_MenuItem { get; set; }

        public string ColorBackground_MenuItem { get; set; }
        public string Database_MenuItem { get; set; }
        public string AddGroup_ContextMenuTreeDBView { get; set; }
        public string RemoveGroup_MenuItem { get; set; }
        public string AddModel_MenuItem { get; set; }
        public string RemoveModel_MenuItem { get; set; }
        public string UpLevel_MenuItem { get; set; }
        public string DownLevel_MenuItem { get; set; }
        public string Rename_MenuItem { get; set; }
        public string Help_MenuItem { get; set; }

        public string ShowHelp_MenuItem { get; set; }
        public string About_MenuItem { get; set; }
        public string toolStripStatusLabel1 { get; set; }
        public string toolStripStatusLabel2 { get; set; }
        public string ShowLegend_MenuItem { get; set; }
        public string HideLegend_MenuItem { get; set; }
        public string AddGroup_MenuItem { get; set; }
        public string RemoveGroup_ContextMenuTreeDBView { get; set; }
        public string AddModel_ContextMenuTreeDBView { get; set; }
        public string RemoveModel_ContextMenuTreeDBView { get; set; }

        public string UpLevel_ContextMenuTreeDBView { get; set; }
        public string DownLevel_ContextMenuTreeDBView { get; set; }
        public string Rename_ContextMenuTreeDBView { get; set; }

        //Constructors
        public DataObject ()
        {

        }

        public DataObject (string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, 
            string v11, string v12, string v13, string v14, string v15, string v16, string v17, string v18, string v19, string v20, 
            string v21, string v22, string v23, string v24, string v25, string v26, string v27, string v28, string v29, string v30, 
            string v31, string v32, string v33)
        {
            this.Text = v1;
            this.File_MenuItem = v2;
            this.OpenModel_MenuItem = v3;
            this.ExportPicture_MenuItem = v4;
            this.Settings_MenuItem = v5;
            this.Close_MenuItem = v6;
            this.View_MenuItem = v7;
            this.ResetViiew_MenuItem = v8;
            this.OptimizateView_MenuItem = v9;
            this.ColorModel_MenuItem = v10;
            this.ColorBackground_MenuItem = v11;
            this.Database_MenuItem = v12;
            this.AddGroup_ContextMenuTreeDBView = v13;
            this.RemoveGroup_MenuItem = v14;
            this.AddModel_MenuItem = v15;
            this.RemoveModel_MenuItem = v16;
            this.UpLevel_MenuItem = v17;
            this.DownLevel_MenuItem = v18;
            this.Rename_MenuItem = v19;
            this.Help_MenuItem = v20;
            this.ShowHelp_MenuItem = v21;
            this.About_MenuItem = v22;
            this.toolStripStatusLabel1 = v23;
            this.toolStripStatusLabel2 = v24;
            this.ShowLegend_MenuItem = v25;
            this.HideLegend_MenuItem = v26;
            this.AddGroup_MenuItem = v27;
            this.RemoveGroup_ContextMenuTreeDBView = v28;
            this.AddModel_ContextMenuTreeDBView = v29;
            this.RemoveModel_ContextMenuTreeDBView = v30;
            this.UpLevel_ContextMenuTreeDBView = v31;
            this.DownLevel_ContextMenuTreeDBView = v32;
            this.Rename_ContextMenuTreeDBView = v33;
        }
    }
}
