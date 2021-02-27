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
                JsonSerializer serializer = new JsonSerializer
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented
                };
                StreamWriter writer = new StreamWriter(savingFilePath);
                serializer.Serialize(writer, this);
                writer.Close();
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
                JsonSerializer serializer = new JsonSerializer
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented
                };
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
