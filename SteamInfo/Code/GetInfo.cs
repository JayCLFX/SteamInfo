using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net;

namespace SteamInfo
{
    public static class GetInfo
    {
        static string steamURL = Program.ReturnKey();
        static WebClient steamwebClient = new WebClient();
        static string steamjson = steamwebClient.DownloadString(steamURL);
        static dynamic steamdata = JObject.Parse(steamjson);

        public static string GetLocalCityID()
        {
            try
            {
                string loccityid = steamdata.response.players[0].loccityid;

                if (loccityid != null)
                {
                    return loccityid;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetLocalStateCode()
        {
            try
            {

                string locstatecode = steamdata.response.players[0].locstatecode;

                if (locstatecode != null)
                {
                    return locstatecode;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetLocalCountryCode()
        {
            try
            {

                string loccountrycode = steamdata.response.players[0].loccountrycode;

                if (loccountrycode != null)
                {
                    return loccountrycode;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetPrimaryClanID()
        {
            try
            {
                string primaryclanid = steamdata.response.players[0].primaryclanid;

                if (primaryclanid != null)
                {
                    return primaryclanid;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetRealName()
        {
            try
            {
                string realname = steamdata.response.players[0].realname;

                if (realname != null)
                {
                    return realname;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetName()
        {
            try
            {
                string name = steamdata.response.players[0].personaname;

                if (name != null)
                {
                    return name;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetProfileURL()
        {
            try
            {
                string profileURL = steamdata.response.players[0].profileurl;

                if (profileURL != null)
                {
                    return profileURL;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetCommentPermission()
        {
            try
            {
                string commentpermission = steamdata.response.players[0].commentpermission;

                if (commentpermission != null)
                {
                    return commentpermission;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetProfileState()
        {
            try
            {
                string profilestate = steamdata.response.players[0].profilestate;

                if (profilestate != null)
                {
                    return profilestate;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetCommunityState()
        {
            try
            {
                string Comunitystate = steamdata.response.players[0].communityvisibilitystate;

                if (Comunitystate != null)
                {
                    return Comunitystate;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetSteamID()
        {
            try
            {
                string steamid = steamdata.response.players[0].steamid;

                if (steamid != null)
                {
                    return steamid;
                }
                else
                {
                    return "Error";
                }
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex);
                return "Error";
            }
        }

        public static string GetSteamOnlineStatus()
        {
            using (WebClient steamwebClient = new WebClient())
            {
                try
                {
                    string json = steamwebClient.DownloadString(steamURL);
                    dynamic data = JObject.Parse(json);

                    string SteamStatus = data.response.players[0].personastate;

                    if (SteamStatus == "0")
                    {
                        return "Offline or Private";
                    }

                    if (SteamStatus == "1")
                    {
                        return "Online";
                    }

                    if (SteamStatus == "2")
                    {
                        return "Busy";
                    }

                    if (SteamStatus == "3")
                    {
                        return "Away";
                    }

                    if (SteamStatus == "4")
                    {
                        return "Snooze";
                    }

                    if (SteamStatus == "5")
                    {
                        return "Looking for Trade";
                    }

                    if (SteamStatus == "6")
                    {
                        return "Looking to Play";
                    }
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return "Error";
        }

    }
}