using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Component
{
    public class ZapisPlikowFacde : IZapisPlikowFacade
    {
        public string path { get; set; }

        public string ConvertObjectToJson(Object objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize);
        }

        public string ConvertObjectToJson(IEnumerable<Object> listToSave)
        {
            return JsonConvert.SerializeObject(listToSave);
        }

        public T ConvertJsonToObject<T>(string stringToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(stringToDeserialize);
        }

        public IEnumerable<T> ConvertListOfJsonToObject<T>(string stringToDeserialize)
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(stringToDeserialize);
        }
        public void SaveToFile(string path, string textToSave)
        {
            FileSaverHandler.SaveToFile(path, textToSave);
        }

        public void SaveObjectToFile(Object obiectToSave)
        {
            var output = ConvertObjectToJson(obiectToSave);
            SaveToFile(this.path, output);
        }

        public void SaveObjectToFile(Object obiectToSave, string pathToSave)
        {
            var output = ConvertObjectToJson(obiectToSave);
            SaveToFile(pathToSave, output);
        }

        public void SaveObjectToFile(IEnumerable<Object> obiectToSave)
        {
            var output = ConvertObjectToJson(obiectToSave);
            SaveToFile(this.path, output);
        }

        public void SaveObjectToFile(IEnumerable<Object> obiectToSave, string pathToSave)
        {
            var output = ConvertObjectToJson(obiectToSave);
            SaveToFile(pathToSave, output);
        }

        public string ReadFromFile(string path)
        {
            return FileSaverHandler.ReadFromFile(path);
        }

    }
}
