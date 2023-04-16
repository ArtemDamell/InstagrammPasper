using Newtonsoft.Json;
using System.IO;

namespace InstagrammPasper.Classes
{
    public class UniversalSerializeDataClass<TModel>
    {
        /// <summary>
        /// Deserializes a JSON file into a model object.
        /// </summary>
        /// <param name="fullPath">The full path of the JSON file.</param>
        /// <returns>The deserialized model object.</returns>
        public TModel DeserializeData(string fullPath)
        {
            var serializer = new JsonSerializer();
            TModel model;

            // Deserialize
            using var sr = new StreamReader(fullPath);
            using (var reader = new JsonTextReader(sr))
            {
                model = serializer.Deserialize<TModel>(reader);
                reader.Close();
            }
            sr.Close();

            return model;
        }

        /// <summary>
        /// Serializes the given model to a JSON file at the given path.
        /// </summary>
        /// <param name="model">The model to serialize.</param>
        /// <param name="fullPath">The full path of the file to serialize to.</param>
        public void SerializeData(TModel model, string fullPath)
        {
            var serializer = new JsonSerializer();

            // Serialize
            using var sw = new StreamWriter(fullPath);
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, model);
                writer.Close();
            }
            sw.Close();
        }
    }
}
