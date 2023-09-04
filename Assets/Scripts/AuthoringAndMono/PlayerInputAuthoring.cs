using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace SpaceSurvival
{
    public class PlayerInputAuthoring : MonoBehaviour
    {
        public class PlayerInputBaker : Baker<PlayerInputAuthoring>
        {
            public override void Bake(PlayerInputAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.None);
                AddComponent(entity, new MoveInput
                {
                    Value = new float2(0, 0),
                });
                AddComponent(entity, new LookInput
                {
                    Value = new float2(0, 0),
                });
                AddComponent<FireInput>(entity);
                AddComponent<UseInput>(entity);
                SetComponentEnabled<FireInput>(entity, false);
                SetComponentEnabled<UseInput>(entity, false);
            }
        }
    }
}