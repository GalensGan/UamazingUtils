using System;

namespace Uamazing.Utils.Extensions
{
    /// <summary>
    /// 时间相关的扩展
    /// </summary>
    public static class Ex_DateTime
    {
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long ToTimestamp(this DateTime dateTime)
        {
           return new DateTimeOffset(TimeZoneInfo.ConvertTimeToUtc(dateTime)).ToUnixTimeMilliseconds();
        }
    }
}
