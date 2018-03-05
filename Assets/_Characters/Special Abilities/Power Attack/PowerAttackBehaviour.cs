﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    public class PowerAttackBehaviour : MonoBehaviour, ISpecialAbility // Inheriting from MonoBehaviour and ISpecialAbility
    {
        PowerAttackConfig config;

        public void SetConfig(PowerAttackConfig configToSet)
        {
            this.config = configToSet;
        }

        // Use this for initialization
        void Start()
        {
            print("Power attack behaviour script attached to " + gameObject.name);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Use(AbilityUseParams useParams)
        {
            print("Power Attack used by: " + gameObject.name);
            float damageToDeal = useParams.baseDamage + config.GetExtraDamage();
            useParams.target.TakeDamage(damageToDeal);
        }
    }
}