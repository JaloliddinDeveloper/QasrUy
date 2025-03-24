using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace QasrUy.Api.Models
{
    public class IgnorePropertySchemaFilter: ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema.Properties.ContainsKey("House"))
            {
                schema.Properties.Remove("House");
            }
        }
    }
}
