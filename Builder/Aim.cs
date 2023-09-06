using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuilderWeapon
{
    public class Aim : MonoBehaviour
    {

        [SerializeField] private float _effectiveRange;
        public float EffectiveRange { get => _effectiveRange; }

        private void OnValidate()
        {
            if (_effectiveRange < 0f) throw new ArgumentException(nameof(_effectiveRange), "\r\nCannot be less than zero");
        }


    }
}