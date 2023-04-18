using Uamazing.Utils.Validate;

namespace Uamazing.Utils.Web.ResponseModel
{
    /// <summary>
    /// 用于在控制器中方便返回结果值
    /// </summary>
    public class ResponseResult<T> : Result<T>
    {
        /// <summary>
        /// 错误代码，前端可以根据这些代码作不同的操作
        /// 不认成功或失败，只要没有特殊需求，它都为200
        /// </summary>
        public ResponseCode Code { get; set; } = ResponseCode.Ok;
    }
}
