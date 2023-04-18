using Newtonsoft.Json.Linq;
using System;
using Uamazing.Utils.Validate;

namespace Uamazing.Utils.Extensions
{
    /// <summary>
    /// json 的扩展类
    /// </summary>
    public static class Json
    {
        /// <summary>
        /// 从 JToken 中获取值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jToken"></param>
        /// <param name="path"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T ValueOrDefault<T>(this JToken jToken, string path, T defaultValue)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path为空");

            var result = jToken.SelectToken(path, false);
            if (result == null) return default;

            var resultValue = result.ToObject<T>();
            if (resultValue == null) throw new ArgumentException($"结果转换为{typeof(T).Name}失败");

            return resultValue;
        }
    }
}
