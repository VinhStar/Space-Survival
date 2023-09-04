using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace SpaceSurvival
{
    public class PlayerAuthoring : MonoBehaviour
    {
        public float MoveSpeed;
        [Range(0, 1)] public float RotationSpeed;
        public class PlayerBaker : Baker<PlayerAuthoring>
        {
            public override void Bake(PlayerAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent<PlayerTag>(entity);

                AddComponent(entity, new MoveDirection
                {
                    Value = new float3(0, 0, 0),
                });
                AddComponent(entity, new MoveSpeed
                {
                    Value = authoring.MoveSpeed,
                });
                AddComponent(entity, new TargetRotationDirection
                {
                    Value = new float3(0, 0, 0),
                });
                AddComponent(entity, new RotationSpeed
                {
                    Value = authoring.RotationSpeed,
                });
            }
        }
    }
}