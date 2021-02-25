using System.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Test_Stavitskii.Responses;
using System.Security.Cryptography;
using System.Text;

namespace Test_Stavitskii.Classes
{
    
    
    public class Authentication
    {
        private static string _pixlUrl = "http://api.pixlpark.com/";
        private static string _publicKey = "38cd79b5f2b2486d86f562e3c43034f8";
        private static string _privateKey = "8e49ff607b1f46e1a5e8f6ad5d312a80";


        private static string getHASH(string text)
        {
            SHA1CryptoServiceProvider provider = new SHA1CryptoServiceProvider();
            provider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] bytesArr = provider.Hash;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in bytesArr)
            {
                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static  Orders Order()
        {
            string access = AccessToken();
            HttpWebRequest requestGet = WebRequest.CreateHttp(_pixlUrl+ "/orders?oauth_token=" + access);
                Orders order;
                using (var response = requestGet.GetResponse())
                    {
                        var streamReader = new StreamReader(response.GetResponseStream());
                        string data = streamReader.ReadToEnd();
                        Orders json = JsonConvert.DeserializeObject<Orders>(data); // Десериализуем полученный ответ в JSON
                        order = json;
                    }
                
                return order;
        }
        
        private static string AccessToken()
        {
            string reqToken = RequestToken();

            string password = getHASH(reqToken+_privateKey);
            
            HttpWebRequest requestGet = WebRequest.CreateHttp(_pixlUrl+"oauth/accesstoken?grant_type=api&oauth_token=" + reqToken +"&username="+_publicKey+"&password="+password);
            AccessTokenResponse accessToken;
            using (var response = requestGet.GetResponse())
            {
                var streamReader = new StreamReader(response.GetResponseStream());
                string data = streamReader.ReadToEnd();
                AccessTokenResponse json = JsonConvert.DeserializeObject<AccessTokenResponse>(data); // Десериализуем полученный ответ в JSON
                accessToken = json;
            }
            return accessToken.AccessToken;
        }
        
        
        private static string RequestToken()
        {
            HttpWebRequest requestGet = WebRequest.CreateHttp(_pixlUrl+"oauth/requesttoken");
            RequestTokenResponse requestToken;
            using (var response = requestGet.GetResponse())
            {
                var streamReader = new StreamReader(response.GetResponseStream());
                string data = streamReader.ReadToEnd();
                RequestTokenResponse json = JsonConvert.DeserializeObject<RequestTokenResponse>(data); // Десериализуем полученный ответ в JSON
                requestToken = json;
            }
            return requestToken.RequestToken;
        }
    }
}