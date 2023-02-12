using Microsoft.AspNetCore.Components;

namespace Common
{
    public interface IComponent
    {
        [Parameter] public ContextDataModel ContextDataModel { get; set; }
    }
}
