using Newtonsoft.Json;

namespace zaliczenie
{
    public class Writer<T> : IWriter<T>
    {
        public void Write(T obj)
        {
            var stream = new FileStream(@"/Users/mateuszszkop/Projects/programowanie-obiektowe-r1-s2/zaliczenie/zaliczenie/state.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(stream);

            var serializedObj = JsonConvert.SerializeObject(obj, Formatting.Indented);

            try
            {
                sw.Write(serializedObj);
                sw.Flush();
            }
            catch
            {
                Console.WriteLine("Nie udalo sie zapisac do pliku.");
            }
            finally
            {
                sw.Dispose();
                stream.Dispose();
            }
        }
    }
}

