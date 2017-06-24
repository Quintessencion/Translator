using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Translator
    {
        // принимает аргумент = путь к файлу (Lang.RU.xml)
        public void Translate(string Path)
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(DataObject));

            // десериализация
            using (FileStream FileStream = new FileStream(Path, FileMode.OpenOrCreate))
            {
                DataObject Data = (DataObject)formatter.Deserialize(FileStream);
             
                Text = Data.Text;
                File_MenuItem.Text = Data.File_MenuItem;
                OpenModel_MenuItem.Text = Data.OpenModel_MenuItem;
                ExportPicture_MenuItem.Text = Data.ExportPicture_MenuItem;
                Settings_MenuItem.Text = Data.Settings_MenuItem;
                Close_MenuItem.Text = Data.Close_MenuItem;
                View_MenuItem.Text = Data.View_MenuItem;
                ResetViiew_MenuItem.Text = Data.ResetViiew_MenuItem;
                OptimizateView_MenuItem.Text = Data.OptimizateView_MenuItem;
                ColorModel_MenuItem.Text = Data.ColorModel_MenuItem;

                ColorBackground_MenuItem.Text = Data.ColorBackground_MenuItem;
                Database_MenuItem.Text = Data.Database_MenuItem;
                AddGroup_ContextMenuTreeDBView.Text = Data.AddGroup_ContextMenuTreeDBView;
                RemoveGroup_MenuItem.Text = Data.RemoveGroup_MenuItem;
                AddModel_MenuItem.Text = Data.AddModel_MenuItem;
                RemoveModel_MenuItem.Text = Data.RemoveModel_MenuItem;
                UpLevel_MenuItem.Text = Data.UpLevel_MenuItem;
                DownLevel_MenuItem.Text = Data.DownLevel_MenuItem;
                Rename_MenuItem.Text = Data.Rename_MenuItem;
                Help_MenuItem.Text = Data.Help_MenuItem;

                ShowHelp_MenuItem.Text = Data.ShowHelp_MenuItem;
                About_MenuItem.Text = Data.About_MenuItem;
                toolStripStatusLabel1.Text = Data.toolStripStatusLabel1;
                toolStripStatusLabel2.Text = Data.toolStripStatusLabel2;
                ShowLegend_MenuItem.Text = Data.ShowLegend_MenuItem;
                HideLegend_MenuItem.Text = Data.HideLegend_MenuItem;
                AddGroup_MenuItem.Text = Data.AddGroup_MenuItem;
                RemoveGroup_ContextMenuTreeDBView.Text = Data.RemoveGroup_ContextMenuTreeDBView;
                AddModel_ContextMenuTreeDBView.Text = Data.AddModel_ContextMenuTreeDBView;
                RemoveModel_ContextMenuTreeDBView.Text = Data.RemoveModel_ContextMenuTreeDBView;

                UpLevel_ContextMenuTreeDBView.Text = Data.UpLevel_ContextMenuTreeDBView;
                DownLevel_ContextMenuTreeDBView.Text = Data.DownLevel_ContextMenuTreeDBView;
                Rename_ContextMenuTreeDBView.Text = Data.Rename_ContextMenuTreeDBView;
            }
        }
    }
}
