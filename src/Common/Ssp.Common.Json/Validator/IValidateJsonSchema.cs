namespace Ssp.Common.Json.Validator
{
    internal interface IValidateJsonSchema
    {
         Task<ValidateResponse> ValidateJsonSchemaAsync<TIn1, TIn2>(TIn1 payload,TIn2 schemaReference) where TIn1 : struct where TIn2 : class;


    }
}
