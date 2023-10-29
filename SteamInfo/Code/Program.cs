using System;
using System.Net;
using System.Diagnostics;

namespace SteamInfo
{
    public class Program
    {
        static string steamAPIKey = "";
        static string steamID = "";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("State SteamAPI-Key: ");
            steamAPIKey = Console.ReadLine();

            Console.WriteLine("State SteamID: ");
            steamID = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                Console.WriteLine(
                "\n \n \n \n" +
                $"Current SteamID: {GetInfo.GetSteamID()}" +
                "\n" +
                $"Cuurrent Community State: {GetInfo.GetCommunityState()}" +
                "\n" +
                $"Current Profile State: {GetInfo.GetProfileState()}" +
                "\n" +
                $"Comment Permission Level: {GetInfo.GetCommentPermission()}" +
                "\n" +
                $"Profile URL: {GetInfo.GetProfileURL()}" +
                "\n" +
                $"Current Steam Name: {GetInfo.GetName()}" +
                "\n" +
                $"Current Steam Online State: {GetInfo.GetSteamOnlineStatus()}" +
                "\n" +
                $"User Realname: {GetInfo.GetRealName()}" +
                "\n" +
                $"Primary Clan ID: {GetInfo.GetPrimaryClanID()}" +
                "\n" +
                $"Local Country Code: {GetInfo.GetLocalCountryCode()}" +
                "\n" +
                $"Local State Code: {GetInfo.GetLocalStateCode()}" +
                "\n" +
                $"Local City ID: {GetInfo.GetLocalCityID()}" +
                "\n \n \n \n"
                );
            }
            catch (WebException e)
            {
                Debug.WriteLine(e);
            }

            Console.ReadLine();
        }

        public static string ReturnKey()
        {
            string steamURL = $"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={steamAPIKey}&steamids={steamID}";
            return steamURL;
        }
    }
}
