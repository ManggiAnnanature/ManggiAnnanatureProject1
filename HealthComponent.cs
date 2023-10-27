using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrew.Components
{
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private UnityEvent _onDamage;
		[SerializeField] private UnityEvent _onHeal;
		[SerializeField] private UnityEvent _onDie;
        public void ApplyDamage(int damageValue)
        {
            _health -= damageValue;
            _onDamage?.Invoke();
            if(_health<=0)
            {
                _onDie?.Invoke();
            }
		}
        public void ApplyHeal(int healValue)
        {
			_health += healValue;
            _onHeal?.Invoke();
		}
    }
}
