using System.ComponentModel.DataAnnotations;

namespace ColorDropdown.Client.Shared.Components
{
    [AttributeUsage(AttributeTargets.Field)]
    public partial class ColorIndicators : Attribute { }
    [AttributeUsage(AttributeTargets.Field)]
    public partial class ColorIndicatorExecutions : Attribute { }

    public enum ColorIndicator
    {
        [ColorIndicatorExecutions]
        [ColorIndicators]
        [Display(ResourceType = typeof(ColorIndicatorResource), Name = "Green")]
        Green = 0,
        [ColorIndicators]
        [Display(ResourceType = typeof(ColorIndicatorResource), Name = "Yellow")]
        Yellow = 1,
        [ColorIndicatorExecutions]
        [ColorIndicators]
        [Display(ResourceType = typeof(ColorIndicatorResource), Name = "Red")]
        Red = 2,
        [ColorIndicators]
        [Display(ResourceType = typeof(ColorIndicatorResource), Name = "Gray")]
        Gray = 3
    }
}
