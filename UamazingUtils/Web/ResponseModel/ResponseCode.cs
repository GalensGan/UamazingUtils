namespace Uamazing.Utils.Web.ResponseModel
{
    /// <summary>
    /// 返回的代码集合
    /// </summary>
    public enum ResponseCode
    {
        /// <summary>
        /// 正常返回，默认为 200
        /// </summary>
        Ok = 200,

        /// <summary>
        /// 返回错误
        /// </summary>
        Error = 500,

        /// <summary>
        /// 资源不存在
        /// </summary>
        NotFound = 404,
    }
}
