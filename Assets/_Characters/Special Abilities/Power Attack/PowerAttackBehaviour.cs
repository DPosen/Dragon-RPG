using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    public class PowerAttackBehaviour : MonoBehaviour, ISpecialAbility // Inheriting from MonoBehaviour and ISpecialAbility
    {
        PowerAttackConfig config;
        AudioSource audioSource = null;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void SetConfig(PowerAttackConfig configToSet)
        {
            this.config = configToSet;
        }

        public void Use(AbilityUseParams useParams)
        {
            DealDamage(useParams);
            PlayParticleEffect(); // TODO find way of moving audio to parent class
            audioSource.clip = config.GetAudioClip(); 
            audioSource.Play();
        }

        private void PlayParticleEffect()
        {
            var prefab = Instantiate(config.GetParticlePrefab(), transform.position, Quaternion.identity);
            // TODO decide if particle system attaches to player
            ParticleSystem myParticleSystem = prefab.GetComponent<ParticleSystem>();
            myParticleSystem.Play();
            Destroy(prefab, myParticleSystem.main.duration);
        }

        private void DealDamage(AbilityUseParams useParams)
        {
            float damageToDeal = useParams.baseDamage + config.GetExtraDamage();
            useParams.target.TakeDamage(damageToDeal);
        }
    }
}