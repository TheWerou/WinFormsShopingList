using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopingList
{
    public class FileSaverHandler
    {
        public static bool SaveToFile(string path, string textToSave)
        {
            try
            {
                File.WriteAllText(path, textToSave);
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }

        public static string? ReadFromFile(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch(Exception)
            {
                return null;
            }

        }

    }
}
