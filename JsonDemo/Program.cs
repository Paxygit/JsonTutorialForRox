using System;
using System.IO;
using Newtonsoft.Json;


namespace JsonDemo
{
    class Program
    {
         static void Main(string[] args)
        {
            Startup();   
        }
       

        static public void Startup()
        { 
            string cachepath = $"{ Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))}\\Users\\{Environment.UserName}\\Documents\\JsonDemo\\cache\\lastused.json";

            if (File.Exists(cachepath) && File.ReadAllText(cachepath) != "")
            {
                UserSettings deserializedJson = JsonConvert.DeserializeObject<UserSettings>(File.ReadAllText(cachepath));

                Console.WriteLine(
                    deserializedJson.lastDateTime.Minute.ToString() + " min"+
                    deserializedJson.savedArtists[2] + " artist name"+
                    deserializedJson.savedArtistLinks[2] + " Link" +
                    deserializedJson.lastUsername + " Username"
                    );

            }
            else {
                Console.WriteLine("Nobody has logged in yet! Make an account.");
            }

            //Login Screen

            //If Login was successful........ STEVE LOGGED IN!
            DoStuff("STEVEISC00L2019");

            //If login fail (epic fail gaming)
            Startup();
        }

        static public void DoStuff(string lastUsername)
        {
            //add artists                          
            string[] savedArtists = new string[] {"Led Zepplin", "Aerosmith", "Metallica"};
            string[] savedArtistsLinks = new string[] { "ZepplyLeppy.com", "Aerobarozaro.net", "Congress.gov" };

            //get the current time
            DateTime currentDateTime = DateTime.Now;
            //check if there is new stuff since last login


            //hits the close button
            UserSettings cacheUserSettings = UserSettings.Create(lastUsername, savedArtists, savedArtistsLinks, currentDateTime);
            Close(cacheUserSettings);

        }

        static private void Close(UserSettings cacheUserSettings)
        {
            string cachepath = $"{ Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))}\\Users\\{Environment.UserName}\\Documents\\JsonDemo\\cache\\lastused.json";

            string serializedJson = JsonConvert.SerializeObject(cacheUserSettings);

            Directory.CreateDirectory($"{Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))}\\Users\\{Environment.UserName}\\Documents\\JsonDemo\\cache\\");
            File.WriteAllText(cachepath, serializedJson);

            //actually close the program down here
        }
    }
}
