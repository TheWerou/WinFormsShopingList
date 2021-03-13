using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Component
{
    public interface IZapisPlikowFacade
    {
        string ConvertObjectToJson(Object objectToSerialize);

        string ConvertObjectToJson(IEnumerable<Object> listToSave);

        T ConvertJsonToObject<T>(string stringToDeserialize);

        IEnumerable<T> ConvertListOfJsonToObject<T>(string stringToDeserialize);

        void SaveToFile(string path, string textToSave);

        void SaveObjectToFile(Object obiectToSave);

        void SaveObjectToFile(Object obiectToSave, string pathToSave);

        void SaveObjectToFile(IEnumerable<Object> obiectToSave);

        void SaveObjectToFile(IEnumerable<Object> obiectToSave, string pathToSave);

        string ReadFromFile(string path);

    }
}
