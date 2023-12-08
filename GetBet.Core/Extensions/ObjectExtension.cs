using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Core.Extensions
{
    public static class ObjectExtension
    {
        public static string ToJson<T>(this T obj, JsonSerializerSettings serializerSettings = null)
        {
            try
            {
                serializerSettings = serializerSettings ?? new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore
                };

                return JsonConvert.SerializeObject(obj, serializerSettings);
            }
            catch (Exception ex)
            {
                string errMessage = $"Error in json serialization.Ex:{ex}";
                return string.Empty;
            }
        }

        public static T ToObject<T>(this string json, JsonSerializerSettings serializerSettings = null)
        {
            try
            {
                serializerSettings = serializerSettings ?? new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore
                };

                return JsonConvert.DeserializeObject<T>(json,serializerSettings);
            }
            catch (Exception ex)
            {
                string errMessage = $"Error in json serialization.Ex:{ex}";

                return default(T);
            }
        }

    }
}
