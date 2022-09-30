using Avalonia.Web.Blazor;

namespace TemplateProject.Web
{
    public partial class App
    {
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            WebAppBuilder.Configure<TemplateProject.App>()
                .SetupWithSingleViewLifetime();
        }
    }
}