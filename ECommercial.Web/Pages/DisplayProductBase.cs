using ECommercial.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace ECommercial.Web.Pages
{
    public class DisplayProductBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
