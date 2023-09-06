using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuilderWeapon
{
    public class Holder :MonoBehaviour
    {
        [SerializeField] private int _countBullets;
        public int CountBullets { get => _countBullets; }


        private void OnValidate()
        {
            if (_countBullets < 0)
                throw new ArgumentException(nameof(_countBullets), "\r\nCannot be less than zero");
        }

    }
}