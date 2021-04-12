using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace RMS_web_dev_poging3.Pages.Helpers
{
    

    namespace LearnASPNETCoreRazorPagesWithRealApps.Helpers
    {
        public static class SessionHelper
        {
            public static void SetObjectAsJson(this ISession session, string key, object value)
            {
                session.SetString(key, JsonConvert.SerializeObject(value));
            }

            public static T GetObjectFromJson<T>(this ISession session, string key)
            {
                var value = session.GetString(key);
                return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
            }
        }
    }
}