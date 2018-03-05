using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    [CreateAssetMenu(menuName = ("RPG/Special Ability/Power Attack"))]
    public class PowerAttackConfig : SpecialAbility
    {
        [Header("Power Attack Specific")]
        [SerializeField]float extraDamage = 10f;

        public override void AttachComponentTo(GameObject gameObjectToattachTo) // overrides the method in the inherited class
        {
            var behaviourCompenent = gameObjectToattachTo.AddComponent<PowerAttackBehaviour>();
            behaviourCompenent.SetConfig(this);
            behaviour = behaviourCompenent;
        }

        public float GetExtraDamage()
        {
            return extraDamage;
        }
    }
}