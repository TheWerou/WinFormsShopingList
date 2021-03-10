using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Compt
{
    public class ZapisPlikowFacde : IZapisPlikowFacade
    {
        public string path { get; set; }

        private string ConvertObjectToJson(Object objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize);
        }

        private string ConvertObjectToJson(IEnumerable<Object> listToSave)
        {
            return JsonConvert.SerializeObject(listToSave);
        }

        private T ConvertJsonToObject<T>(string stringToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(stringToDeserialize);
        }

        private IEnumerable<T> ConvertListOfJsonToObject<T>(string stringToDeserialize)
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(stringToDeserialize);
        }
        private void SaveToFile(string path, string textToSave)
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

        public string? ReadFromFile(string path)
        {
            return FileSaverHandler.ReadFromFile(path);
        }

    }
}
