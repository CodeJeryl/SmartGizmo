using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using SmartGizmoWebApi.Models;
using SmartGizmoWebApi.Context;

namespace SmartGizmoWebApi.Controllers
{
    public class AlexaController : ApiController
    {
        [HttpGet, Route("api/alexa/GetRequests")]
        // GET api/alexa
        public IEnumerable<Request> GetRequests()
        {
           HotelContext hotelContext = new HotelContext();

           return hotelContext.Requests.ToList();
        }

        [HttpPost, Route("api/alexa/demo")]
        public dynamic Jeryl(dynamic request)
        {
            //HotelContext hotelContext = new HotelContext();

            Random rand = new Random();
            var num = rand.Next(1, 10000);

            //hotelContext.Requests.Add(
            //    new Request { Description = "Test Alexa post with random num "+ num, DateCreated = DateTime.Now }
            //     );

            //hotelContext.SaveChanges();
            
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://alexaapijeryl.azurewebsites.net/api");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    Request requestTest = new Request();
            //    request.Id = num;
            //    var response = client.PostAsJsonAsync("/Alexa/Post", requestTest);
            //    sd = response.Result;
            //}
             Request requestTest = new Request();
               request.Id = num;
             Post(requestTest);


            return new
            {
                version = "1.0",
                sessionAttributes = new { },
                response = new
                {
                    outputSpeech = new
                    {
                        type = "SSML",
                        ssml = "<speak>I want to tell you a secret. <amazon:effect name='whispered'> I am not a real human. </amazon:effect> Can you believe it? by the way, I am created by <prosody rate='fast'>the great.</prosody><emphasis>Jeryl Suarez.</emphasis> " +
                               "  </speak>"
                        //"<speak><p> This is a paragraph.There will be a pause after this.</p> <p> Followed by another paragraph.</p></speak>"
                        //
                    },
                    card = new
                    {
                        type = "Simple",
                        title = "Jeryl",
                        content = "Hello Jeryl!"
                    },
                    shouldEndSession = true
                }
            };
        }

         [HttpGet, Route("api/alexa/JokePost")]
        public IHttpActionResult JokePost(String Id)
        {
            HotelContext hotelContext = new HotelContext();

            Random rand = new Random();
            var num = rand.Next(1, 10000);

            hotelContext.Requests.Add(
                new Request { Description = "[Get] Test Alexa passed Id "+Id+" and post random num " + num, DateCreated = DateTime.Now }
                 );

            hotelContext.SaveChanges();

            return Json(new { success = true });
        }
        // POST api/alexa
        public IHttpActionResult Post(Request request)
        {
            HotelContext hotelContext = new HotelContext();

            Random rand = new Random();
            var num = rand.Next(1, 10000);

            hotelContext.Requests.Add(
                new Request { Description = "[Post] Test Alexa post with passed string " + request.Id + " random num " + num, DateCreated = DateTime.Now }
                 );

            hotelContext.SaveChanges();

            return Json(new {success = true});
        }

        // PUT api/alexa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/alexa/5
        public void Delete(int id)
        {
        }
    }
}
