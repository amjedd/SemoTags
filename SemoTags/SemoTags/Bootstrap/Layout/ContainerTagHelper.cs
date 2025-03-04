using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.Bootstrap.Layout.Options;

namespace SemoTags.Bootstrap;

public partial class ContainerTagHelper : TagHelper
{
    public CSize Size { get; set; } =  CSize.Default;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";

        BuildSize(ref output, Size);
        output.Content.SetHtmlContent(await output.GetChildContentAsync());
    }

    private void BuildSize(ref TagHelperOutput output, CSize size)
    {
        if (Size ==CSize.Large)
        {
            output.Attributes.Add("class", "container-lg");
        }
        else if (Size ==CSize.Small)
        {
            output.Attributes.Add("class", "container-sm");
        }
        else if (Size ==CSize.ExtraSmall)
        {
            output.Attributes.Add("class", "container-xs");
        }
        else if (Size ==CSize.ExtraLarge)
        {
            output.Attributes.Add("class", "container-xl");
        }
        else
        {
            output.Attributes.Add("class", "container");
        }
    }
}