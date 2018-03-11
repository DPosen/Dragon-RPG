using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    [CreateAssetMenu(menuName = ("RPG/Special Ability/Self Heal"))]
    public class SelfHealConfig : AbilityConfig
    {
        [Header("Self Heal Specific")]
        [SerializeField] float extraHealth = 50f;

        public override void AttachComponentTo(GameObject gameObjectToattachTo) // overrides the method in the inherited class
        {
            var behaviourCompenent = gameObjectToattachTo.AddComponent<SelfHealBehaviour>();
            behaviourCompenent.SetConfig(this);
            behaviour = behaviourCompenent;
        }

        public float GetExtraHealth()
        {
            return extraHealth;
        }
    }
}