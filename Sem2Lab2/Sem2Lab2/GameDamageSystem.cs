using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab2
{
    public class DamageEventArgs : EventArgs
    {
        public int DamageAmount { get; }
        public int CurrentHP { get; }

        public DamageEventArgs(int damageAmount, int currentHP)
        {
            DamageAmount = damageAmount;
            CurrentHP = currentHP;
        }
    }

    public class Player
    {
        public event EventHandler<DamageEventArgs> OnDamageTaken;

        public int HP { get; private set; } = 100;
        public bool IsDead => HP <= 0;

        public void TakeDamage(int damage)
        {
            if (IsDead) return;

            HP -= damage;
            if (HP < 0) HP = 0;

            Console.WriteLine($"\n[Player]: Отримано урон -{damage}. Поточне HP: {HP}");

            OnDamageTaken?.Invoke(this, new DamageEventArgs(damage, HP));
        }
    }

    public class UIHealthBar
    {
        public void OnPlayerDamage(object sender, DamageEventArgs e)
        {
            Console.WriteLine($"[UI HealthBar]: Оновлення індикатора здоров'я -> {e.CurrentHP}%");
        }
    }

    public class SoundSystem
    {
        public void OnPlayerDamage(object sender, DamageEventArgs e)
        {
            Console.WriteLine("[SoundSystem]: Грає звук: 'Ouch! (Отримання урону)'");

            if (e.CurrentHP <= 20 && e.CurrentHP > 0)
            {
                Console.WriteLine("[SoundSystem]: Грає звук: 'Серцебиття (Критичний стан!)'");
            }
        }
    }

    public class AchievementSystem
    {
        private bool _halfHealthUnlocked = false;
        private bool _firstDeathUnlocked = false;

        public void OnPlayerDamage(object sender, DamageEventArgs e)
        {
            if (e.CurrentHP <= 50 && e.CurrentHP > 0 && !_halfHealthUnlocked)
            {
                Console.WriteLine("[AchievementSystem]: ДОСЯГНЕННЯ ОТРИМАНО: 'Half Health'!");
                _halfHealthUnlocked = true;
            }

            if (e.CurrentHP <= 0 && !_firstDeathUnlocked)
            {
                Console.WriteLine("[AchievementSystem]: ДОСЯГНЕННЯ ОТРИМАНО: 'First Death'!");
                _firstDeathUnlocked = true;
            }
        }
    }

    public class GameLogger
    {
        public void OnPlayerDamage(object sender, DamageEventArgs e)
        {
            Console.WriteLine($"[GameLogger]: [LOG] Нанесено урону: {e.DamageAmount}. Залишок HP персонажа: {e.CurrentHP}.");
        }
    }
}
