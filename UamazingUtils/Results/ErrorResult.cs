using Uamazing.Utils.Validate;

namespace Uamazing.Utils.Validate
{
    public class ErrorResult<T> : Result<T>
    {
        public ErrorResult(T data, string error) : base(false, error,data)
        {

        }

        public ErrorResult(string error) : base(false, error,default)
        {

        }
    }
}
