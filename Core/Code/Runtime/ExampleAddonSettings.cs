using UFlow.Core.Runtime;
using UnityEngine;

namespace UFlowAddons.Example.Core.Code.Runtime
{
    [CreateAssetMenu(menuName = MENU_NAME + nameof(ExampleAddonSettings), fileName = nameof(ExampleAddonSettings))]
    public class ExampleAddonSettings : BaseAddonSettings
    {
        public string exampleSetting;
        public override string AddonName => "Example";
    }
}