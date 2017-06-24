using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator t = new Translator();
            t.Translate("LangRU.xml");
            t.Translate("LangEN.xml");
            // объект для сериализации RU
            /*
            DataObject DataRU = new DataObject("STL Просмотрщик", "Файл", "Открыть ...", "Экспорт картинки ...", "Настройки ...",
                "Закрыть", "Вид", "Сброс вида", "Центрирование вида", "Цвет модели", "Цвет фона", "База моделей", "Добавить группу",
                "Удалить группу", "Добавить модель", "Удалить модель", "Переместить вверх", "Переместить вниз", "Переименовать",
                "Помощь", "Показать справку", "О программе", "Язык", "Загруженная модель: ", "Показать легенду",
                "Скрыть легенду", "Добавить группу", "Удалить группу", "Добавить модель", "Удалить модель", "Переместить вверх",
                "Переместить вниз", "Переименовать");
                */

            // объект для сериализации EN
            /*
            DataObject DataEN = new DataObject("STL Viewer", "File", "Open ...", "Export picture ...", "Settings ...", "Close", "View", 
                "Reset view", "Centering View", "Color model", "Color background", "ModelBase", "Add group", "Remove group", 
                "Add model", "Remove model", "Up level item", "Down level item", "Rename", "Help", "Show", "About", "Language: ", 
                "Loaded model: ", "Show legend", "Hide legend", "Add Group", "Remove group", "Add model", "Remove model", 
                "Up level item", "Down level item", "Rename");
                */

            // передаем в конструктор тип класса
            //XmlSerializer formatter = new XmlSerializer(typeof(DataObject));

            // сериализация
            /*
            using (FileStream FileStream = new FileStream("LangEN.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(FileStream, DataEN);
            }
            */

            // десериализация
            /*
            using (FileStream FileStream = new FileStream("LangRU.xml", FileMode.OpenOrCreate))
            {
                DataObject Data = (DataObject)formatter.Deserialize(FileStream);

                Console.WriteLine(Data.Text);
                Console.WriteLine(Data.File_MenuItem);
                Console.WriteLine(Data.OpenModel_MenuItem);
                Console.WriteLine(Data.ExportPicture_MenuItem);
                Console.WriteLine(Data.Settings_MenuItem);
                Console.WriteLine(Data.Close_MenuItem);
                Console.WriteLine(Data.View_MenuItem);
                Console.WriteLine(Data.ResetViiew_MenuItem);
                Console.WriteLine(Data.OptimizateView_MenuItem);
                Console.WriteLine(Data.ColorModel_MenuItem);

                Console.WriteLine(Data.ColorBackground_MenuItem);
                Console.WriteLine(Data.Database_MenuItem);
                Console.WriteLine(Data.AddGroup_ContextMenuTreeDBView);
                Console.WriteLine(Data.RemoveGroup_MenuItem);
                Console.WriteLine(Data.AddModel_MenuItem);
                Console.WriteLine(Data.RemoveModel_MenuItem);
                Console.WriteLine(Data.UpLevel_MenuItem);
                Console.WriteLine(Data.DownLevel_MenuItem);
                Console.WriteLine(Data.Rename_MenuItem);
                Console.WriteLine(Data.Help_MenuItem);

                Console.WriteLine(Data.ShowHelp_MenuItem);
                Console.WriteLine(Data.About_MenuItem);
                Console.WriteLine(Data.toolStripStatusLabel1);
                Console.WriteLine(Data.toolStripStatusLabel2);
                Console.WriteLine(Data.ShowLegend_MenuItem);
                Console.WriteLine(Data.HideLegend_MenuItem);
                Console.WriteLine(Data.AddGroup_MenuItem);
                Console.WriteLine(Data.RemoveGroup_ContextMenuTreeDBView);
                Console.WriteLine(Data.AddModel_ContextMenuTreeDBView);
                Console.WriteLine(Data.RemoveModel_ContextMenuTreeDBView);

                Console.WriteLine(Data.UpLevel_ContextMenuTreeDBView);
                Console.WriteLine(Data.DownLevel_ContextMenuTreeDBView);
                Console.WriteLine(Data.Rename_ContextMenuTreeDBView);
            }
            Console.ReadLine();
            */
        }
    }
}
