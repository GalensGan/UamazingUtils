using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uamazing.Utils.Web.ResponseModel
{
    /// <summary>
    /// 响应成功
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SuccessResponse<T> : ResponseResult<T>
    {
        public SuccessResponse()
        {
            Code = ResponseCode.Ok;
        }

        public SuccessResponse(T data):this()
        {
            Data = data;
        }
    }
}
