using Uamazing.Utils.Validate;

namespace Uamazing.Utils.Validate
{
    public class SuccessResult<T> : Result<T>
    {
        public SuccessResult(T data) : base(true, "success",data)
        {
        }
    }
}
