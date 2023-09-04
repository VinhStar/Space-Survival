using Unity.Entities;
using Unity.Mathematics;

namespace SpaceSurvival
{
    public struct MoveInput : IComponentData
    {
        public float2 Value;
    }

    public struct LookInput : IComponentData
    {
        public float2 Value;
    }

    public struct FireInput : IComponentData, IEnableableComponent { }

    public struct UseInput : IComponentData, IEnableableComponent { }
}