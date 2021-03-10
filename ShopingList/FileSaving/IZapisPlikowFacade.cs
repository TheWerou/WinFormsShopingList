using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.FileSaving
{
    public interface IZapisPlikowFacade
    {
        public void SaveObjectToFile(Object obiectToSave);

        public void SaveObjectToFile(Object obiectToSave, string pathToSave);

        public void SaveObjectToFile(IEnumerable<Object> obiectToSave);

        public void SaveObjectToFile(IEnumerable<Object> obiectToSave, string pathToSave);

        public string? ReadFromFile(string path);

    }
}
