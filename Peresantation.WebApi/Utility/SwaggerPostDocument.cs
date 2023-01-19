using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Peresantation.WebApi.Utility
{
    public class SwaggerPostDocument : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;
        public SwaggerPostDocument(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }
        public void Configure(SwaggerGenOptions options)
        {
            foreach (var item in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(item.GroupName,
      new OpenApiInfo()
      {
          Title = $"Post Api Version {item.ApiVersion}",
          Version = item.ApiVersion.ToString()
      });
            }

            var pathComment = Path.Combine(AppContext.BaseDirectory, "SwaggerComment.xml");
            options.IncludeXmlComments(pathComment);
        }
    }
}
