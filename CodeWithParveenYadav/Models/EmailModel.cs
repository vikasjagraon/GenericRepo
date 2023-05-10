using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav
{
    public class EmailModel
    {
        public string To { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }
}


//using CodeWithParveenYadav.Helpers;
//using CodeWithParveenYadav.Models;
//using Newtonsoft.Json;
//using RestSharp;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using TestClassLib;

//namespace CodeWithParveenYadav
//{
//    // so much meaningless friction between variables and properties;
//    //Any data member you want to expose outside, go for property not variable
//    //but why I don't understand
//    //Why every model is created with get set properties, if it can be done through data field/variables?
//    //there is a concept of auto-implemented properties. 
//    //in variables we can't restrict, so in properties there is an abstraction level access modifier
//    //Properties should be lightweight, not like method
//    //Fields are for Class internal use they should be Private always, on the other side Properties are wrapper around those private fields 
//    // variable only store the data, no computation logic
//    //property is wrapper around the private variables
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Class1 test = new Class1();
//            // test.FirstName = "test";
//            // Console.WriteLine(test.FirstName);
//            // TestClass testClass = new TestClass();

//            // testClass.FullName = "test";

//            //var response = testClass.FullName;
//        }

//        #region
//        //// Replace YOUR_API_KEY with your actual API key
//        //var apiKey = "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";

//        //another key : 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

//        //var client = new HttpClient();
//        //client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

//        //Console.WriteLine("Hey, I am Chat GPT, Please ask your any question");
//        //var input = Console.ReadLine();

//        //string userInput = $"You: {input}\nChatGpt: ";

//        ////ChatGptBot(client, userInput);
//        //ChatGptBot1(client, userInput);


//        //static void ChatGptBot(HttpClient client, string userInput)
//        //{
//        //    // Send input to ChatGPT
//        //    var response = client.PostAsync("https://api.openai.com/v1/engines/davinci-codex/completions",
//        //        new StringContent(JsonConvert.SerializeObject(new
//        //        {
//        //            // Model = "text-davinci-003",
//        //            prompt = userInput,
//        //            max_tokens = 120
//        //        }), System.Text.Encoding.UTF8, "application/json")).Result;

//        //    // Get output from ChatGPT
//        //    var output = response.Content.ReadAsStringAsync().Result;
//        //    var json = JsonConvert.DeserializeObject<dynamic>(output);
//        //    var completions = json.choices[0].text;
//        //    Console.WriteLine(completions);

//        //    Console.WriteLine("====================================================");

//        //    Console.WriteLine("Hey, I am Chat GPT, Please ask your any question");
//        //    userInput = Console.ReadLine();
//        //    ChatGptBot(client, userInput);
//        //}

//        //static void ChatGptBot1(HttpClient client, string userInput)
//        //{
//        //    try
//        //    {
//        //        // Send input to ChatGPT
//        //        var response = client.PostAsync("https://api.openai.com/v1/engines/davinci-codex/completions",
//        //            new StringContent(JsonConvert.SerializeObject(new
//        //            {
//        //                prompt = userInput,
//        //                max_tokens = 120
//        //            }), System.Text.Encoding.UTF8, "application/json")).Result;

//        //        if (response.IsSuccessStatusCode)
//        //        {
//        //            // Get output from ChatGPT
//        //            var output = response.Content.ReadAsStringAsync().Result;
//        //            var json = JsonConvert.DeserializeObject<dynamic>(output);
//        //            var completions = json.choices[0].text;
//        //            Console.WriteLine(completions);

//        //            Console.WriteLine("====================================================");

//        //            Console.WriteLine("Hey, I am Chat GPT, Please ask your any question");
//        //            userInput = Console.ReadLine();
//        //            ChatGptBot(client, userInput);
//        //        }
//        //        else
//        //        {
//        //            Console.WriteLine("Error: " + response.ReasonPhrase);
//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        Console.WriteLine("Error: " + ex.Message);
//        //    }
//        //}
//        #endregion
//    }

//    public class TestClass
//    {

//        //only class level
//        public string FullName
//        {
//            get
//            {
//                //read only
//                return "";
//            }
//            set
//            {
//                //write only
//            }
//        }



//        public void TestMethod()
//        {
//            /// no propery at method level, only class level, struct or interface level
//            //public string Firstname { get;set; }
//        }

//    }

//    //During compile time,compiler generate backing fields
//    public class TestClass1
//    {
//        private string backing_FullName;

//        public string Get_FullName()
//        {
//            return backing_FullName;
//        }

//        public void Set_FullName(string fullname)
//        {
//            backing_FullName = fullname;
//        }
//    }

//}