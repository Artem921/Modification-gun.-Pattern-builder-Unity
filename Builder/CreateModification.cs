using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BuilderWeapon
{
    public class CreateModification : MonoBehaviour
    {
       [SerializeField]  private Silencer silencerPrefab;
       [SerializeField]  private Holder holderPrefab;
       [SerializeField]  private Aim aimPrefab;
       [SerializeField] private BuilderModification builder;


     


        public void CreateNewModification()
        {
            builder.GunShotCreateModofication(aimPrefab, holderPrefab, silencerPrefab);
        }


    }
}