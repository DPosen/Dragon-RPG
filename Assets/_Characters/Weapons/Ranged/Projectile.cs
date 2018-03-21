using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Core; // TODO consider re-wiring

namespace RPG.Characters
{
    public class Projectile : MonoBehaviour
    {

        [SerializeField] float projectileSpeed;
        [SerializeField] GameObject shooter; // so can inspect when paused

        const float DESTROY_DELAY = 0.01f;
        float damageCaused;

        public void SetShooter(GameObject shooter)
        {
            this.shooter = shooter;
        }

        public void SetDamage(float damage)
        {
            damageCaused = damage;
        }

        public float GetProjectileLaunchSpeed()
        {
            return projectileSpeed;
        }

        private void OnCollisionEnter(Collision collision)
        {
            var layerCollidedWith = collision.gameObject.layer;
            if (shooter && layerCollidedWith != shooter.layer)
            {
               // DamageIfDamageable(collision);
            }
        }

        // todo re-implament

        //private void DamageIfDamageable(Collision collision)
        //{
        //    Component damageableComponent = collision.gameObject.GetComponent(typeof(IDamageable));
        //    if (damageableComponent)
        //    {
        //        (damageableComponent as IDamageable).TakeDamage(damageCaused);
        //    }
        //    Destroy(gameObject, DESTROY_DELAY);
        //}
    }
}