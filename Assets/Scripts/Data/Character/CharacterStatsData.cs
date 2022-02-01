﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Data.Character
{
    public class CharacterStats : MonoBehaviour
    {
        public CharacterStatsData statsData;

        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public int attackDamage { get; set; }
        public int attackSpeed { get; set; }
        public int movementSpeed { get; set; }
        public int armor { get; set; }

        public void AssignData()
        {
            currentHealth = statsData.maxHealth;
            attackDamage = statsData.attackDamage;
            attackSpeed = statsData.attackSpeed;
            movementSpeed = statsData.movementSpeed;
            armor = statsData.armor;
        }

        public void Init()
        {
            AssignData();
        }
    }

    public class CharacterStatsData : MonoBehaviour
    {
        public int maxHealth;
        public int attackDamage;
        public int attackSpeed;
        public int movementSpeed;
        public int armor;
    }
}