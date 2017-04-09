using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MyTunes
{
    internal class MyFileOpener
    {
        const string Filename = "songs.json";
        internal static async Task<Stream> OpenData()
        {
            var sf = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(Filename);
              return await sf.OpenStreamForReadAsync();
        }
    }
}
