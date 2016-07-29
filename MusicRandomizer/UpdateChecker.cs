using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MusicRandomizer
{
    public class UpdateInfo
    {
        public String latestVersion;
        public String changes;
    }

    class UpdateChecker
    {
        private static XmlSerializer serializer = new XmlSerializer(typeof(UpdateInfo));

        public static UpdateInfo CheckForUpdate()
        {
            string xml;
            using (var client = new WebClient())
            {
#if DEBUG
                xml = client.DownloadString("https://oatmealdome.github.io/MusicRandomizer/UpdateInfo-pre-release.xml");
#else
                xml = client.DownloadString("https://oatmealdome.github.io/MusicRandomizer/UpdateInfo.xml");
#endif
            }

            UpdateInfo updateInfo;
            using (TextReader reader = new StringReader(xml))
            {
                updateInfo = (UpdateInfo) serializer.Deserialize(reader);
            }

            return updateInfo;
        }

        public static void ConvertIfNeeded()
        {
            String changelist = "";

            if (Directory.Exists("other_files"))
            {
                String titleId = SplatoonRegionTools.toTitleId(Configuration.currentConfig.region);
                String shortName = SplatoonRegionTools.toShortName(Configuration.currentConfig.region);
                
                // Don't continue if the destination directory already exists
                if (!Directory.Exists("cafiine_root\\" + titleId))
                {
                    // Move the other_files directory to a new location depending on the user's region
                    Directory.Move("other_files", "cafiine_root\\" + titleId);
                    File.Create("cafiine_root\\" + titleId + " - Splatoon " + shortName + ".txt");

                    changelist += "- The files inside other_files were moved to a new folder called cafiine_root.\n";
                }
            }

            if (File.Exists("Tracks.xml") && !File.Exists("playlists\\Default.xml"))
            {
                // Move the file so it is the new default playlist
                File.Move("Tracks.xml", "playlists/Default.xml");

                // Set the default playlist in Configuration
                Configuration.currentConfig.currentPlaylist = "Default";
                Configuration.Save();

                changelist += "- The current Tracks.xml file has become the new default playlist.\n";
            }

            if (changelist.Length != 0)
            {
                MessageBox.Show("The following changes were made:\n\n" + changelist);
            }
        }

        public static String StripDot(String input)
        {
            StringBuilder builder = new StringBuilder(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (!input[i].Equals('.'))
                {
                    builder.Append(input[i]);
                }
            }

            return builder.ToString();
        }

    }
}
