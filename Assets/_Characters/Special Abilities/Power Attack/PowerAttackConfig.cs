﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    [CreateAssetMenu(menuName = ("RPG/Special Ability/Power Attack"))]
    public class PowerAttackConfig : AbilityConfig
    {
        [Header("Power Attack Specific")]
        [SerializeField]float extraDamage = 10f;

        public override AbilityBehaviour GetBehaviourComponent(GameObject objectToAttachTo) // overrides the method in the inherited class
        {
            return objectToAttachTo.AddComponent<PowerAttackBehaviour>();
        }

        public float GetExtraDamage()
        {
            return extraDamage;
        }
    }
}