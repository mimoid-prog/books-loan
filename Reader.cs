using Newtonsoft.Json;

namespace zaliczenie
{
    public class Reader<T> : IReader<T>
    {
        public T? Read()
        {
            using (var stream = new FileStream(@"/Users/mateuszszkop/Projects/programowanie-obiektowe-r1-s2/zaliczenie/zaliczenie/state.txt", FileMode.Open, FileAccess.Read))
            {
                using var sr = new StreamReader(stream);
                var obj = sr.ReadToEnd();


                var deserializedObj = JsonConvert.DeserializeObject<T>(obj);
                return deserializedObj;
            }
        }
    }
}

