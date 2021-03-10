using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Component
{
    public interface IZapisPlikowFacade
    {
        void SaveObjectToFile(Object obiectToSave);

        void SaveObjectToFile(Object obiectToSave, string pathToSave);

        void SaveObjectToFile(IEnumerable<Object> obiectToSave);

        void SaveObjectToFile(IEnumerable<Object> obiectToSave, string pathToSave);

        string ReadFromFile(string path);

    }
}
