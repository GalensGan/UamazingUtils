using Uamazing.Utils.Web.ResponseModel;

namespace Uamazing.Utils.Web.Extensions
{
    /// <summary>
    /// IResult 相关的转换器
    /// </summary>
    public static class ToResponseExtension
    {
        /// <summary>
        /// 封装成请求成功的返回值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ResponseResult<T> ToSuccessResponse<T>(this T data)
        {
            return new SuccessResponse<T>(data);        
        }

        /// <summary>
        /// 封装成请求失败的返回值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static ResponseResult<T> ToErrorResponse<T>(this T data,string errorMessage)
        {
            return new ErrorResponse<T>(errorMessage,data);
        }
    }
}
