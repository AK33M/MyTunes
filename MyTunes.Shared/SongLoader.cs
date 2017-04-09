using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;

namespace MyTunes
{
    public static class SongLoader
    {
        public static async Task<IEnumerable<Song>> Load()
        {
            using (var reader = new StreamReader(await MyFileOpener.OpenData()))
            {
                return JsonConvert.DeserializeObject<List<Song>>(await reader.ReadToEndAsync());
            }
        }
    }
}

