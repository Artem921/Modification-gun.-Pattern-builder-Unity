using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
namespace BuilderWeapon
{
    public class BuilderModification : GunshotWeaponBuilder {

        [SerializeField] private Transform containerAim;
        [SerializeField] private Transform containerHolder;
        [SerializeField] private Transform containerSilencer;
        [SerializeField] private Gun shotWeapon;

         private Silencer silencerPrefab;
         private Holder holderPrefab;
         private Aim aimPrefab;
       

    

        protected override void InitializationAim(Aim aimPrefab)
        {
           
            this.aimPrefab = aimPrefab;
            this.aimPrefab =GameObject.Instantiate(aimPrefab,containerAim.transform.position,containerAim.rotation);
            this.aimPrefab.gameObject.transform.parent = containerAim.transform;

        }

        protected override void InitializationHolder(Holder holderPrefab)
        {
            this.holderPrefab = holderPrefab;
            this.holderPrefab= GameObject.Instantiate(holderPrefab,containerHolder.transform.position,containerHolder.rotation);
            this.holderPrefab.gameObject.transform.parent = containerHolder.transform;

        }

        protected override void InitializationSilencer(Silencer silencerPrefab)
        {
            
            this.silencerPrefab = silencerPrefab;
            this.silencerPrefab= GameObject.Instantiate(silencerPrefab,containerSilencer.transform.position, containerSilencer.rotation);
            this.silencerPrefab.gameObject.transform.parent = containerSilencer.transform;

        }

        public void Reset()
        {
            if(this.aimPrefab != null) 
                Destroy(containerAim.GetChild(0).gameObject);

            if (this.holderPrefab != null)
                Destroy(containerHolder.GetChild(0).gameObject);

            if (this.silencerPrefab != null)
                Destroy(containerSilencer.GetChild(0).gameObject);

            GC.Collect();
        }


        public override void GunShotCreateModofication(Aim aimPrefab, Holder holderPrefab, Silencer silencerPrefab)
        {
            Reset();
            InitializationAim(aimPrefab);
            InitializationHolder(holderPrefab);
            InitializationSilencer(silencerPrefab);
            shotWeapon.SetAim(aimPrefab);
            shotWeapon.SetHolder(holderPrefab);
            shotWeapon.SetSilencer(silencerPrefab);
            Debug.Log(shotWeapon);
           
        }
    }
}
