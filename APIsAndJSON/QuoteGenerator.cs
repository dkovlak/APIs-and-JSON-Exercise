﻿using System;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
	public class QuoteGenerator
	{
		public static void KanyeQuote()
		{
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse);

            Console.WriteLine($"Kanye West: {kanyeQuote["quote"]}");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse);
            
            Console.WriteLine($"Ron Swanson: {ronQuote[0]}");
        }

    }
}

