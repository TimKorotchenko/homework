using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Middleware
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;
        public TokenMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task InvokeAsync(HttpContext context)

        {   // step 1

            List<string> UserUrls;

            // step 2

            var serializer = new JsonSerializer();
            using (StreamReader file = System.IO.File.OpenText(@"c:\user.json"))
            {

            // step 3

                UserUrls = (List<string>)serializer.Deserialize(file, typeof(List<string>));
            }

            // step 4
            
            var userPath = context.Request.Path;
            UserUrls.Add(userPath);

            // step 5

            using (var sw = new StreamWriter(@"c:\user.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, UserUrls);
            }

            // Идём в другую Мидвару

            await _next.Invoke(context);
            
            
        }
        
    }
}
