using System.Collections;

namespace Uamazing.Utils.Validate
{
    /// <summary>
    /// 返回的结果值
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T> : ResultFlag
    {
        /// <summary>
        /// 默认为 true
        /// </summary>
        public Result()
        {
            Ok = true;
        }

        /// <summary>
        /// 仅传入 ok 值进行初始化
        /// </summary>
        /// <param name="ok"></param>
        public Result(bool ok)
        {
            Ok=ok;
        }

        /// <summary>
        /// 传入 ok 和 message 进行初始化
        /// </summary>
        /// <param name="ok"></param>
        /// <param name="message"></param>
        public Result(bool ok,string message)
        {
            Ok=ok;
            Message=message;
        }

        /// <summary>
        /// 创建一个实例
        /// </summary>
        /// <param name="ok"></param>
        /// <param name="data"></param>
        /// <param name="error"></param>
        public Result(bool ok, string error, T data)
        {
            Data = data;
            Ok = ok;
            Message = error;
        }

        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }

        public override object GetData()
        {
            return Data;
        }

        /// <summary>
        /// 将数据更改成另一个数据
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public Result<T1> ConvertTo<T1>(T1 data)
        {
            return new Result<T1>()
            {
                Data = data,
                Message = Message,
                Ok = Ok,
            };
        }

        /// <summary>
        /// 转置结果
        /// </summary>
        /// <returns></returns>
        public Result<T> Reverse()
        {
            Ok = !Ok;
            return this;
        }
    }
}
