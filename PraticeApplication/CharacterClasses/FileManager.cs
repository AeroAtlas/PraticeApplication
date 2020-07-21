using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using PraticeApplication.Properties;

namespace PraticeApplication.CharacterClasses
{
    class FileManager
    {
        public static void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(PlayerSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }

        private static String SettingsFolder
        {
            get
            {
                //create a string folder
                string folder = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);
                //add a subfolder
                folder = Path.Combine(folder, "RPG Project");
                folder = Path.Combine(folder, "CharacterSettings");
                //create folder if it doesn't exist
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                //return folder
                return folder;
            }
        }

        private static String PlayerSettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "PlayerSettings.xml");
            }
        }

        private static Player DefaultSettings
        {
            get
            {
                return new Player
                {
                    Name = "",
                    Sex = EntitySex.Unknown,
                    CharacterClass = EntityClass.Unknown,
                    Strength = 0,
                    Speed = 0,
                    Health = 0,
                    Intelligence = 0,
                };
            }
        }
       
        public static Player LoadPlayer()
        {
            if (!File.Exists(PlayerSettingsFile))
                return DefaultSettings;
            using (Stream stream = File.OpenRead(PlayerSettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Player));
                return (Player)ser.Deserialize(stream);
            }
        }
    }
}
