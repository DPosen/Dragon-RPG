using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    public class SelfHealBehaviour : AbilityBehaviour
    {
        Player player = null;

        private void Start()
        {
            player = GetComponent<Player>();
        }

        public void SetConfig(SelfHealConfig configToSet)
        {
            this.config = configToSet;
        }

        public override void Use(AbilityUseParams useParams)
        {
            PlayAbilitySound();
            player.Heal((config as SelfHealConfig).GetExtraHealth());
            PlayParticleEffect();
        }
    }
}