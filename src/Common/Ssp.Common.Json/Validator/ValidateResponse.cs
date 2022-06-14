using Newtonsoft.Json.Schema;

namespace Ssp.Common.Json.Validator;

public class ValidateResponse
{
    public bool Valid { get; set; }
    public IList<ValidationError> Errors { get; set; }
}