using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Web;
using NetServ.Net.Json;

namespace PlurkApi
{
    public class PlurkMessageResponse 
    {
        public string lang { get; set; }
        public string content_raw { get; set; }
        public int user_id { get; set; }
        public string qualifier { get; set; }
        public int plurk_id { get; set; }
        public string content { get; set; }
        public int id { get; set; }
        public string posted { get; set; }

        public PlurkMessageResponse(string jsonString) 
        {
            JsonObject jsonObject;

            using (JsonParser parser = new JsonParser(new StringReader(jsonString), true))
                jsonObject = parser.ParseObject();


            try { this.lang = ((JsonString)jsonObject["lang"]).Value; }
            catch { this.lang = ""; }

            try { this.content_raw = ((JsonString)jsonObject["content_raw"]).Value; }
            catch { this.content_raw = ""; }

            try { this.user_id = Convert.ToInt32(((JsonNumber)jsonObject["user_id"]).Value); }
            catch { this.user_id = 0; }
          
            try { this.qualifier = ((JsonString)jsonObject["qualifier"]).Value; }
            catch { this.qualifier = ""; }

            try { this.plurk_id = Convert.ToInt32(((JsonNumber)jsonObject["plurk_id"]).Value); }
            catch { this.plurk_id = 0; }

            try { this.content = ((JsonString)jsonObject["content"]).Value; }
            catch { this.content = ""; }

            try { this.id = Convert.ToInt32(((JsonNumber)jsonObject["id"]).Value); }
            catch { this.id = 0; }

            try { this.posted = ((JsonString)jsonObject["posted"]).Value; }
            catch { this.posted = ""; }
        }
    }

    public class PlurkMessageResponses : Collection<PlurkMessageResponse> 
    {
 
    }

    public class PlurkMessage
    {
        public int response_count { get; set; }
        public int responses_seen { get; set; }
        public string qualifier { get; set; }
        public int plurk_id { get; set; }
        public int is_mute { get; set; }
        public string limited_to { get; set; }
        public int no_comments { get; set; }
        public int is_unread { get; set; }
        public string lang { get; set; }
        public string content_raw { get; set; }
        public int user_id { get; set; }
        public int id { get; set; }
        public string content { get; set;}
        public int source { get; set; }
        public string posted { get; set; }
        public int owner_id { get; set; }
        public PlurkMessageResponses responses { get; set; }

        public PlurkMessage(string jsonString) 
        {
            JsonObject jsonObject;

            using (JsonParser parser = new JsonParser(new StringReader(jsonString), true))
                jsonObject = parser.ParseObject();

            try { this.response_count = Convert.ToInt32(((JsonNumber)jsonObject["response_count"]).Value); }
            catch { this.response_count = 0; }

            try { this.responses_seen = Convert.ToInt32(((JsonNumber)jsonObject["responses_seen"]).Value); }
            catch { this.responses_seen = 0; }

            try { this.qualifier = ((JsonString)jsonObject["qualifier"]).Value; }
            catch { this.qualifier = ""; }

            try { this.plurk_id = Convert.ToInt32(((JsonNumber)jsonObject["plurk_id"]).Value); }
            catch { this.plurk_id = 0; }

            try { this.is_mute = Convert.ToInt32(((JsonNumber)jsonObject["is_mute"]).Value); }
            catch { this.is_mute = 0; }

            try { this.limited_to = ((JsonString)jsonObject["limited_to"]).Value; }
            catch { this.limited_to = ""; }

            try { this.no_comments = Convert.ToInt32(((JsonNumber)jsonObject["no_comments"]).Value); }
            catch { this.no_comments = 0; }

            try { this.is_unread = Convert.ToInt32(((JsonNumber)jsonObject["is_unread"]).Value); }
            catch { this.is_unread = 0; }

            try { this.lang = ((JsonString)jsonObject["lang"]).Value; }
            catch { this.lang = ""; }

            try { this.content_raw = ((JsonString)jsonObject["content_raw"]).Value; }
            catch { this.content_raw = ""; }

            try { this.user_id = Convert.ToInt32(((JsonNumber)jsonObject["user_id"]).Value); }
            catch { this.user_id = 0; }

            try { this.id = Convert.ToInt32(((JsonNumber)jsonObject["id"]).Value); }
            catch { this.id = 0; }

            try { this.content = ((JsonString)jsonObject["content"]).Value; }
            catch { this.content = ""; }

            try { this.source = Convert.ToInt32(((JsonNumber)jsonObject["source"]).Value); }
            catch { this.source = 0; }

            try { this.posted = ((JsonString)jsonObject["posted"]).Value; }
            catch { this.posted = ""; }

            try { this.owner_id = Convert.ToInt32(((JsonNumber)jsonObject["owner_id"]).Value); }
            catch { this.owner_id = 0; }

            this.responses = new PlurkMessageResponses();
        }
    }

    public class PlurkMessages : Collection<PlurkMessage> 
    {
 
    }

    public class PlurkFriend
    {
        public int only_fan { get; set; }
        public string display_name { get; set; }
        public int uid { get; set; }
        public int is_channel { get; set; }
        public string nick_name { get; set; }
        public int has_profile_image { get; set; }
        public bool following_im { get; set; }
        public int star_reward { get; set; }
        public bool following_tl { get; set; }
        public string theme { get; set; }
        public string date_of_birth { get; set; }
        public string relationship { get; set; }
        public string karma { get; set; }
        public string full_name { get; set; }
        public int gender { get; set; }
        public string page_title { get; set; }
        public int recruited { get; set; }
        public int id { get; set; }
        public string location { get; set; }

        public PlurkFriend(string jsonString)
        {
            JsonObject jsonObject;

            using (JsonParser parser = new JsonParser(new StringReader(jsonString), true))
                jsonObject = parser.ParseObject();

            try { this.only_fan = Convert.ToInt32(((JsonNumber)jsonObject["only_fan"]).Value); }
            catch { this.only_fan = 0; }

            try { this.display_name = ((JsonString)jsonObject["display_name"]).Value; }
            catch { this.display_name = ""; }

            try { this.uid = Convert.ToInt32(((JsonNumber)jsonObject["uid"]).Value); }
            catch { this.uid = 0; }

            try { this.is_channel = Convert.ToInt32(((JsonNumber)jsonObject["is_channel"]).Value); }
            catch { this.is_channel = 0; }

            try { this.nick_name = ((JsonString)jsonObject["nick_name"]).Value; }
            catch { this.nick_name = ""; }

            try { this.has_profile_image = Convert.ToInt32(((JsonNumber)jsonObject["has_profile_image"]).Value); }
            catch { this.has_profile_image = 0; }

            try { this.following_im = ((JsonBoolean)jsonObject["following_im"]).Value; }
            catch { this.following_im = false; }

            try { this.star_reward = Convert.ToInt32(((JsonNumber)jsonObject["star_reward"]).Value); }
            catch { this.star_reward = 0; }

            try { this.following_tl = ((JsonBoolean)jsonObject["following_tl"]).Value; }
            catch { this.following_tl = false; }

            try { this.theme = ((JsonString)jsonObject["theme"]).Value; }
            catch { this.theme = ""; }

            try { this.date_of_birth = ((JsonString)jsonObject["date_of_birth"]).Value; }
            catch { this.date_of_birth = ""; }

            try { this.relationship = ((JsonString)jsonObject["relationship"]).Value; }
            catch { this.relationship = ""; }

            try { this.karma = ((JsonString)jsonObject["karma"]).Value; }
            catch { this.karma = ""; }

            try { this.full_name = ((JsonString)jsonObject["full_name"]).Value; }
            catch { this.full_name = ""; }

            try { this.gender = Convert.ToInt32(((JsonNumber)jsonObject["gender"]).Value); }
            catch { this.gender = 0; }

            try { this.page_title = ((JsonString)jsonObject["page_title"]).Value; }
            catch { this.page_title = ""; }

            try { this.recruited = Convert.ToInt32(((JsonNumber)jsonObject["recruited"]).Value); }
            catch { this.recruited = 0; }

            try { this.id = Convert.ToInt32(((JsonNumber)jsonObject["id"]).Value); }
            catch { this.id = 0; }

            try { this.location = ((JsonString)jsonObject["location"]).Value; }
            catch { this.location = ""; }
        }
    }

    public class PlurkFriends : Collection<PlurkFriend> 
    {
 
    }
    
    public class PlurkApi
    {
        private WebUtil web;
        private Cookie cookie = null;
        
        public string username{ get; set; }
        public string password { get; set; }
        public int uid { get; set; }
        public Boolean isLogged { get; set; }
        public PlurkFriends myFriends { get; set; }

        public PlurkApi() 
        {   
            web = new WebUtil();
            this.myFriends = new PlurkFriends();
        }

        /// <summary>
        /// Login to plurk
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>True if login was successful, false otherwise</returns>
        public bool Login(string username, string password) 
        {
            string data;
            this.username = username;
            this.password = password;
            data = web.GetPage(string.Format("http://www.plurk.com/Users/login?redirect_page=main&nick_name={0}&password={1}", this.username, this.password),
                                null, ref cookie, false);
            if (cookie == null)
            {
                this.isLogged = false;
                return false;
            }
            else 
            {
                data = web.GetPage("http://www.plurk.com/user/" + this.username, null, ref cookie,true);
                if (data == "") return false;
                this.uid = Convert.ToInt32(new Regex("var GLOBAL = \\{.*\"uid\": ([\\d]+),.*\\}").Matches(data)[0].Groups[1].Value);
                this.myFriends = this.getFriends(this.uid);
            }
            this.isLogged = true;
            return true;
        }

        /// <summary>
        /// Gets a friend collection
        /// </summary>
        /// <param name="uid">The user's uid that you wanna get friends</param>
        /// <returns>A friends collection</returns>
        public PlurkFriends getFriends(int uid) 
        {
            string jsonString = "";
            PlurkFriends friends = new PlurkFriends();
            string data = "";
            data = web.GetPage("http://www.plurk.com/Users/getFriends?user_id=" + uid.ToString(), null, ref cookie, true);
            if (data == "") return null;
            if (data == "[]") return friends;
            data = dejsonize(data);

            string[] arrayData = Regex.Split(data, "}, {");
            foreach (string item in arrayData)
            {
                jsonString = item;
                if (jsonString[0] != '{')
                {
                    jsonString = "{" + jsonString;
                }

                if (jsonString[jsonString.Length - 1] != '}')
                {
                    jsonString = jsonString + "}";
                }
                friends.Add(new PlurkFriend(jsonString));
            }
            return friends;
        }

        /// <summary>
        /// Add plurk message
        /// </summary>
        /// <param name="lang">The plurk language</param>
        /// <param name="qualifier">The plurk qualifier</param>
        /// <param name="content">The content of plurk message to be posted</param>
        /// <param name="alowComments">true if this plurk message allows comments, false otherwise</param>
        /// <param name="limited_to">Limite this plurk message to some friends. Format: [uid,uid,uid]. Otherwise set with ""</param>
        /// <returns>true if it was posted, otherwise false</returns>
        public bool addMessage(string lang, string qualifier, string content, bool alowComments, string limited_to)
        {
            string query = "";
            string data = "";
            string error_match = "";

            query = string.Format("posted={0}&qualifier={1}&content={2}&lang={3}&no_comments={4}",
                                    HttpUtility.UrlEncode(DateTime.Now.ToUniversalTime().ToString("s")), qualifier, HttpUtility.UrlEncode(content), lang,
                                    !alowComments ? "1" : "0");
            if (limited_to != "")
            {
                query += "&limited_to=" + HttpUtility.UrlEncode(limited_to);
            }
            data = web.GetPage("http://www.plurk.com/TimeLine/addPlurk?" + query, null, ref cookie, true);
            if (data.IndexOf("/anti-flood/") != -1 || cookie == null)
                return false;
            try
            {
                error_match = new Regex("\"error\":\\s(\\S+)}").Matches(data)[0].Groups[1].Value;
            }
            catch 
            {
                return false;
            }
            if (error_match != "null")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get friend requests
        /// </summary>
        /// <returns>A collection with friends uids</returns>
        public Collection<Int32> getFriendRequests() 
        {
            string data = "";
            Regex reg;
            MatchCollection uidRequests;
            Collection<Int32> uidRequestsCollection = new Collection<Int32>();

            data = web.GetPage("http://www.plurk.com/Notifications", null, ref cookie, true);
            uidRequests = new Regex("\\s*\\(\\s*Notifications\\.render\\(\\s*(\\d+),\\s*0\\)\\s*\\);").Matches(data);
            foreach (Match m in uidRequests)
            {
                uidRequestsCollection.Add(Convert.ToInt32(m.Groups[1].Value));
            }
            return uidRequestsCollection;
        }
        
        /// <summary>
        /// Accept or decline the friend requests
        /// </summary>
        /// <param name="friendRequests"> A collection with friends requests uid</param>
        /// <param name="allow">If true accept the friend requests, otherwise decline</param>
        /// <returns></returns>
        public bool replyFriendRequests(Collection<Int32> friendRequests, bool allow) 
        {
            string data = "";
            string url = "";

            if (allow)
            {
                url = "http://www.plurk.com/Notifications/allow?";
            }
            else 
            {
                url = "http://www.plurk.com/Notifications/deny?";
            }

            foreach (Int32 uid in friendRequests) 
            {
                data = web.GetPage(url + "friend_id=" + uid.ToString(),null, ref cookie, false);
            }
            return true;
        }

        /// <summary>
        /// Get responses of a plurk message
        /// </summary>
        /// <param name="plurk_id">The plurk_id of plurk message that you wanna get responses</param>
        /// <returns>A collection with plurk message responses</returns>
        public PlurkMessageResponses getMessagesResponses(int plurk_id) 
        {
            string jsonString = "";
            string data = "";
            PlurkMessageResponses responses = new PlurkMessageResponses();

            data = web.GetPage("http://www.plurk.com/Responses/get2?plurk_id=" + plurk_id.ToString(), null, ref cookie, true);
            if (data == "") return null;
            if (data == "{\"friends\": [], \"responses_seen\": 0, \"responses\": []}") return responses;
            data = Regex.Split(data, "\"responses\": ")[1];
            data = data.Remove(data.Length-1);
            data = dejsonize(data);

            string[] arrayData = Regex.Split(data, "}, {");
            foreach (string item in arrayData)
            {
                jsonString = item;
                if (jsonString[0] != '{')
                {
                    jsonString = "{" + jsonString;
                }

                if (jsonString[jsonString.Length - 1] != '}')
                {
                    jsonString = jsonString + "}";
                }
                jsonString = new Regex("new Date\\((.*)\\)").Replace(jsonString, "$1");
                responses.Add(new PlurkMessageResponse(jsonString));
            }
            return responses;
        }

        /// <summary>
        /// Get plurk messages of a specific user
        /// </summary>
        /// <param name="uid">The uid of user that you get the plurk messages</param>
        /// <param name="date_from">Start datetime in UTC format. DateTime.ToUniversalTime().ToString("s")</param>
        /// <param name="data_offset">End datetime in UTC format. DateTime.ToUniversalTime().ToString("s")</param>
        /// <param name="fetch_responses">True if you wanna get all responses for all plurk messages</param>
        /// <returns>A collection with plurk messages</returns>
        public PlurkMessages getMessages(int uid, string date_from, string data_offset, bool fetch_responses)
        {
            string jsonString = "";
            string url="http://www.plurk.com/TimeLine/getPlurks";
            string data = "";
            PlurkMessages messages = new PlurkMessages();

            if (date_from == "")
            {
                data = web.GetPage(url + "?user_id=" + uid.ToString(), null, ref cookie, true);
            }
            else 
            {
                data = web.GetPage(url + "?" + string.Format("user_id={0}&from_date={1}&offset={2}", uid, HttpUtility.UrlEncode(date_from), HttpUtility.UrlEncode(data_offset)), null,ref cookie, true);
            }

            if (data == "") return null;
            if (data == "[]") return messages;
            data = dejsonize(data);

            string[] arrayData = Regex.Split(data, "}, {");
            foreach (string item in arrayData)
            {
                jsonString = item;
                if (jsonString[0] != '{')
                {
                    jsonString = "{" + jsonString;
                }

                if (jsonString[jsonString.Length - 1] != '}')
                {
                    jsonString = jsonString + "}";
                }
                jsonString = new Regex("new Date\\((.*)\\)").Replace(jsonString, "$1");
                PlurkMessage msg = new PlurkMessage(jsonString);
                if (fetch_responses) msg.responses = this.getMessagesResponses(msg.plurk_id);
                messages.Add(msg);
            }
            return messages;
        }


        /// <summary>
        /// Get unread plurk messages
        /// </summary>
        /// <param name="fetch_responses">True if you wanna get all responses for all plurk messages</param>
        /// <returns>A collectio with plurk messages</returns>
        public PlurkMessages getUnreadMessages(Boolean fetch_responses) 
        {
            string jsonString = "";
            string url = "http://www.plurk.com/TimeLine/getUnreadPlurks";
            string data = "";
            PlurkMessages messages = new PlurkMessages();

            data = web.GetPage(url, null, ref cookie, true);
            if (data == "") return null;
            if (data == "[]") return messages;
            data = dejsonize(data);

            string[] arrayData = Regex.Split(data, "}, {");
            foreach (string item in arrayData)
            {
                jsonString = item;
                if (jsonString[0] != '{')
                {
                    jsonString = "{" + jsonString;
                }

                if (jsonString[jsonString.Length - 1] != '}')
                {
                    jsonString = jsonString + "}";
                }
                jsonString = new Regex("new Date\\((.*)\\)").Replace(jsonString, "$1");
                PlurkMessage msg = new PlurkMessage(jsonString);
                if (fetch_responses) msg.responses = this.getMessagesResponses(msg.plurk_id);
                messages.Add(msg);
            }
            return messages;
        }

        /// <summary>
        /// Respond a plurk message
        /// </summary>
        /// <param name="lang">>The plurk language</param>
        /// <param name="qualifier">>The plurk qualifier</param>
        /// <param name="content">The content of plurk message</param>
        /// <param name="plurk_id">The id of plurk message that you wanna respond</param>
        /// <returns>True if it was successful, otherwise false</returns>
        public bool respondMessage(string lang, string qualifier, string content, int plurk_id)
        {
            string query = "";
            string data = "";

            query = string.Format("posted={0}&qualifier={1}&content={2}&lang={3}&p_uid={4}&plurk_id={5}",
                                    HttpUtility.UrlEncode(DateTime.Now.ToUniversalTime().ToString("s")), qualifier, HttpUtility.UrlEncode(content), lang,
                                    this.uid, plurk_id);
            data = web.GetPage("http://www.plurk.com/Responses/add?" + query, null, ref cookie, true);
            return true;
        }

        /// <summary>
        /// Convert a plurk message id to a fully permanent link
        /// </summary>
        /// <param name="plurk_id">The plurk id message</param>
        /// <returns>A string with a permanet link</returns>
        public string getMessagePermalink(int plurk_id) 
        {
            return "http://www.plurk.com/p/" + this.ConvertToBase(plurk_id, 36);
        }

        /// <summary>
        /// Replace some chars in a Json string
        /// </summary>
        /// <param name="data">A plurk json string</param>
        /// <returns>A string ready to be parsed by a json engine</returns>
        private string dejsonize(string data)
        {
            data = data.Remove(0, 1);
            data = data.Remove(data.Length - 1, 1);
            data = new Regex("karma': ([\\d\\.]+),").Replace(data, "karma': '$1',");
            //data = new Regex("new Date\\((.*)\\)").Replace(data, "$1");
            data = new Regex(": u'").Replace(data, ": '");
            data = new Regex(": u\"").Replace(data, ": \"");
            data = new Regex("L, '").Replace(data, ", '");
            data = new Regex("datetime\\.date\\((\\d+), (\\d+), (\\d+)\\), '").Replace(data, "'$1-$2-$3', '");
            data = new Regex("None, '").Replace(data, "'', '");
            //data = new Regex("True, '").Replace(data, "1, '");
            //data = new Regex("False, '").Replace(data, "0, '");
            data = new Regex("\\t").Replace(data, "'");
            data = new Regex("\\{'").Replace(data, "{\"");
            data = new Regex("':").Replace(data, "\":");
            data = new Regex(", '").Replace(data, ", \"");
            data = new Regex(": '").Replace(data, ": \"");
            data = new Regex("',").Replace(data, "\",");
            data = new Regex("'\\}").Replace(data, "\"}");
            data = data.Replace("\\u00", "%u00");
            data = data.Replace("\\x", "%u00");
            data = HttpUtility.UrlDecode(data);
            return data;
        }

        /// <summary>
        /// Convert a int base 10, to other bases
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="nbase">Base to convert</param>
        /// <returns>A string with a number converted</returns>
        private String ConvertToBase(int num, int nbase)
        {
            String chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // check if we can convert to another base
            if (nbase < 2 || nbase > chars.Length)
                return "";

            int r;
            String newNumber = "";

            // in r we have the offset of the char that was converted to the new base
            while (num >= nbase)
            {
                r = num % nbase;
                newNumber = chars[r] + newNumber;
                num = num / nbase;
            }
            // the last number to convert
            newNumber = chars[num] + newNumber;

            return newNumber;
        }
    }
}
