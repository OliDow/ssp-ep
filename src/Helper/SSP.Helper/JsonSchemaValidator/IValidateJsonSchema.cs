using System.Text.Json;

namespace SSP.Helper.JsonSchemaValidator
{
    internal interface IValidateJsonSchema
    {
         Task<ValidateResponse> ValidateJsonSchemaAsync<TIn1, TIn2>(TIn1 payload,TIn2 schema) where TIn1 : class where TIn2 : class;


    }

    public class ValidateService : IValidateJsonSchema
    {
        //public async Task<ValidateResponse> ValidateServiceAsync(MeterSubmitPayload payload, string meterSchema)
        //{
        //    JSchema schema = JSchema.Parse(meterSchema);
        //    JToken json = JToken.Parse(JsonConvert.SerializeObject(payload));

        //    IList<ValidationError> errors;
        //    bool valid = json.IsValid(schema, out errors);

        //    return await Task.FromResult(new ValidateResponse
        //    {
        //        Valid = valid,
        //        Errors = errors
        //    });
        //}

        public async Task<ValidateResponse> ValidateJsonSchemaAsync<TIn1, TIn2>(TIn1 payload, TIn2 schema) where TIn1 : class where TIn2 : class
        {
            JsonSchema schema = SchemaReader.ReadSchema(test.SchemaText, TestUtil.TestFilePath);
            throw new NotImplementedException();
        }
    }
    public class ValidateResponse
    {
        public bool Valid { get; set; }
        public IList<ValidationError> Errors { get; set; }
    }
}
