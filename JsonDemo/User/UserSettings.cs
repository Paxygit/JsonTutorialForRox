using System;
using System.Collections.Generic;
using System.Text;

namespace JsonDemo
{
    public class UserSettings
    {
        //Pieces of the variable that we are storing
        public string lastUsername { get; set; }
        public string[] savedArtists { get; set; }
        public string[] savedArtistLinks { get; set; }
        public DateTime lastDateTime { get; set; }

        //Making an instance of that variable
        static public UserSettings Create(string LastUsername, string[] SavedArtists,string[] SavedArtistsLinks, DateTime LastDateTime)
        { //returning a new "UserSettings" variable
            return new UserSettings
            {
                lastUsername = LastUsername,
                savedArtists = SavedArtists,
                savedArtistLinks = SavedArtistsLinks,
                lastDateTime = LastDateTime
            };
        }

    }
}
/*
The class watching duck returns again.
⣿⣿⣿⣿⣿⣿⣿⣿⡿⢋⣩⣭⣶⣶⣮⣭⡙⠿⣿⣿⣿⣿⣿⣿ 
⣿⣿⣿⣿⣿⣿⠿⣋⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡙⢿⣿⣿⣿ 
⣿⣿⣿⣿⣿⡃⠄⠹⡿⣿⣿⣿⣿⠟⠛⣿⣿⣿⣿⣷⡌⢿⣿⣿ 
⣿⣿⣿⣿⣿⠐⣠⡶⣶⣲⡎⢻⣿⣤⣴⣾⣿⣿⣿⣿⣿⠸⣿⣿ 
⣿⠟⣋⡥⡶⣞⡯⣟⣾⣺⢽⡧⣥⣭⣉⢻⣿⣿⣿⣿⣿⣆⢻⣿ 
⡃⣾⢯⢿⢽⣫⡯⣷⣳⢯⡯⠯⠷⠻⠞⣼⣿⣿⣿⣿⣿⣿⡌⣿ 
⣦⣍⡙⠫⠛⠕⣋⡓⠭⣡⢶⠗⣡⣶⡝⣿⣿⣿⣿⣿⣿⣿⣧⢹ 
⣿⣿⣿⣿⣿⣿⣘⣛⣋⣡⣵⣾⣿⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿⡌
*/