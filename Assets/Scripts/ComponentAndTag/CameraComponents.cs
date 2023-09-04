using Unity.Entities;
using Unity.Mathematics;

namespace SpaceSurvival
{
    public struct FollowOffset : IComponentData
    {
        public float3 Position;
        public float3 Rotation;
    }
}