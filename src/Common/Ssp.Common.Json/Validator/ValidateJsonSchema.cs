using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Ssp.Common.Json.Validator;

public class ValidateJsonSchema : IValidateJsonSchema
{
    public async Task<ValidateResponse> ValidateJsonSchemaAsync<TIn1, TIn2>(TIn1 payload, TIn2 schemaReference) where TIn1 : struct where TIn2 : class
    {
        ;
        JSchema schema = JSchema.Parse(JsonConvert.SerializeObject(schemaReference));
        JToken json = JToken.Parse(JsonConvert.SerializeObject(payload));

        bool valid = json.IsValid(schema, out IList<ValidationError> errors);

        return await Task.FromResult(new ValidateResponse
        {
            Valid = valid,
            Errors = errors
        });
    }
}