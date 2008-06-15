using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Web;

namespace PlurkApi
{
    public class WebUtil
    {
        /// <summary>
        /// Make a http POST or GET request
        /// </summary>
        /// <param name="url">Url</param>
        /// <param name="query">Parameters in this format "var1=A&var2=B". If you pass null, this function makes a GET request.</param>
        /// <param name="cookie">Get or set the cookie used in the request or response</param>
        /// <param name="waitContent">If you don't want wait the http content. Set this false, to get only the cookie for example.</param>
        /// <returns>Request response. If "" a error ocurred or you set the waitContent with false</returns>
        public string GetPage(String url, String query, ref Cookie cookie, Boolean waitContent)
        {
            Stream requestStream = null;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = "EvilDeadBot";
                request.CookieContainer = new CookieContainer();
                if (cookie != null)
                    request.CookieContainer.Add(cookie);
                
                StringBuilder urlEncoded = new StringBuilder();
                Char[] reserved = { '?', '=', '&' };
                byte[] byteBuffer = null;

                if (query != null)
                {
                    request.Method = WebRequestMethods.Http.Post;
                    int i = 0, j;
                    string tmp;
                    while (i < query.Length)
                    {
                        j = query.IndexOfAny(reserved, i);
                        if (j == -1)
                        {
                            tmp = query.Substring(i, query.Length - i);
                            if (tmp != "?" && tmp != "=" && tmp != "&")
                                urlEncoded.Append(HttpUtility.UrlEncode(tmp));
                            else 
                                urlEncoded.Append(tmp);
                            break;
                        }
                        tmp = query.Substring(i, j - i);
                        if (tmp != "?" && tmp != "=" && tmp != "&")
                            urlEncoded.Append(HttpUtility.UrlEncode(tmp));
                        else
                            urlEncoded.Append(tmp);

                        tmp = query.Substring(j, 1);
                        if (tmp != "?" && tmp != "=" && tmp != "&")
                            urlEncoded.Append(HttpUtility.UrlEncode(tmp));
                        else
                            urlEncoded.Append(tmp);
                        
                        i = j + 1;
                    } 
                    byteBuffer = Encoding.UTF8.GetBytes(urlEncoded.ToString());

                    request.ContentLength = byteBuffer.Length;                    
                    requestStream = request.GetRequestStream();
                    requestStream.Write(byteBuffer, 0, byteBuffer.Length);
                    requestStream.Close();
                }
                else
                {
                    request.Method = WebRequestMethods.Http.Get;
                    request.ContentLength = 0;
                }
                //received data
                response = (HttpWebResponse)request.GetResponse();
                //get cookie
                try
                {
                    cookie = request.CookieContainer.GetCookies(request.RequestUri)[0];
                }
                catch 
                {
                    cookie = null;
                }
                if (waitContent)
                {
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    return reader.ReadToEnd();
                }
                else 
                {
                    return "";
                }
            }
            catch
            {
                //error
                return "";
            }
            finally
            {
                // close and clean 
                if (requestStream != null)
                    requestStream.Close();
                if (response != null)
                    response.Close();
            }
        }
    }
}
