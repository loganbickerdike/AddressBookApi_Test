using AddressBookApi.Models;
using System.Net;
using System.Text.Json;

namespace AddressBookApi.Helpers
{
    public static class JsonHelper<T>
    {
        public const string FileName = "AddressBook.json";
        public static void CreateFile(T type)
        {
            using FileStream stream = File.Create(FileName);
            JsonSerializer.Serialize(stream, type);
            stream.Dispose();
        }

        public static void CreateFile(List<T> type)
        {
            using FileStream stream = File.Create(FileName);
            JsonSerializer.Serialize(stream, type);
            stream.Dispose();
        }

        public static IEnumerable<T> GetFiles()
        {
            using FileStream stream = File.OpenRead(FileName);
            var file = JsonSerializer.Deserialize<List<T>>(stream);
            stream.Dispose();
            return file;
        }

        public static T GetFile()
        {
            using FileStream stream = File.OpenRead(FileName);
            var file = JsonSerializer.Deserialize<T>(stream);
            stream.Dispose();
            return file;
        }

    }
}
