using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GPSS.Visualiztion
{
    public partial class VisualGPSS_Schema
    {
        public void Serialize(string savingFilePath)
        {
            try
            {
                JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                StreamWriter writer = new StreamWriter(savingFilePath);
                serializer.Serialize(writer, this);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сериализации: {ex.Message}");
            }
        }

        public static VisualGPSS_Schema Deserialize(string readingFilePath)
        {
            try
            {
                JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                StreamReader reader = new StreamReader(readingFilePath);
                return (VisualGPSS_Schema)serializer.Deserialize(reader, typeof(VisualGPSS_Schema));
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка десериализации: {ex.Message}");
            }
        }
    }
}
