//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Drawing;
using System.Reflection;
using System.IO;

namespace GeneralAssembly
{
    public static class ResourceHelpers
    {
        private static Assembly CurrentAssembly => typeof(ResourceHelpers).Assembly;
        private static string GetResourceName(string sampleName)
            => $"GeneralAssembly.{sampleName}";
        private static string GetResourceNameWithFolder(string sampleName, string folderName)
            => $"GeneralAssembly.{folderName}.{sampleName}";

        public static Stream GetResourceStream(string resourceName, string folderName)
            => CurrentAssembly.GetManifestResourceStream(GetResourceNameWithFolder(resourceName, folderName)) ??
               CurrentAssembly.GetManifestResourceStream(GetResourceName(resourceName)) ??
               CurrentAssembly.GetManifestResourceStream(GetResourceNameWithFolder(resourceName, "Resources"));

        public static string GetResourceString(string name, string folderName = null)
        {
            using (var stream = GetResourceStream(name, folderName))
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }

        public static Bitmap GetResourceBitmap(string name, string folderName = null)
        {
            using (var stream = GetResourceStream(name, folderName) ??
                                GetResourceStream(name + ".png", folderName) ??
                                GetResourceStream(name + ".bmp", folderName))
            {
                return new Bitmap(Image.FromStream(stream));
            }
        }

        public static Icon GetResourceIcon(string name, string folderName = null)
        {
            using (var stream = GetResourceStream(name, folderName) ??
                                GetResourceStream(name + ".ico", folderName))
            {
                return new Icon(stream);
            }
        }
    }
}
