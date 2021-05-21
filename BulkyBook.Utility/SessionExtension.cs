using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utility
{
   public static class SessionExtension
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObject<T>(this ISession session, string Key)
        {
            var value = session.GetString(Key);
            return value ==null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
