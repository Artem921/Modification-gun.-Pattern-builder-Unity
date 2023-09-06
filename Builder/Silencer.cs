using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace BuilderWeapon
{
    public class Silencer : MonoBehaviour
    {
        [SerializeField] private float _lenght;
        [SerializeField] private float _diameter;

        public float Length { get => _lenght; }
        public float Diameter { get=>_diameter;}


        private void OnValidate()
        {
            if (_lenght < 0 && _diameter < 0)
            {
                throw new ArgumentException(nameof(_lenght), "\r\nCannot be less than zero");
                throw new ArgumentException(nameof(_diameter), "\r\nCannot be less than zero");
            }
        }
    }
}
