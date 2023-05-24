

using Newtonsoft.Json;

namespace SerilazaLib
{
    public class Class1
    {
        public void Serilaz(string text)
        {
            string json = JsonConvert.SerializeObject(text);
            File.WriteAllText("D:\\JsonPract.json", json);
            
        } 
        public string DeSerilaz()
        {
            string text = File.ReadAllText("D:\\JsonPract.json");
            string jsontext = JsonConvert.DeserializeObject<string>(text);
            return jsontext;
            
        }

    }
}