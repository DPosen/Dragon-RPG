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

        public override AbilityBehaviour GetBehaviourComponent(GameObject objectToAttachTo) // overrides the method in the inherited class
        {
            return objectToAttachTo.AddComponent<SelfHealBehaviour>();
        }

        public float GetExtraHealth()
        {
            return extraHealth;
        }
    }
}