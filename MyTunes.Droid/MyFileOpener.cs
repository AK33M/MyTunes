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
            return Android.App.Application.Context.Assets.Open(Filename);
        }
    }
}
