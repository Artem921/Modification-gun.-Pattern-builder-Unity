using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BuilderWeapon
{
    public class Gun : MonoBehaviour
 {
         private Aim aimPrefab;
         private Holder holderPrefab;
         private Silencer silencerPrefab;
         public Silencer silencer { get => silencerPrefab; }
         public Holder Holder { get => holderPrefab; }
         public Aim Aim { get => aimPrefab; }

        public void SetAim(Aim aim)
        {
            this.aimPrefab = aim;
        }


        public void SetHolder(Holder holder)
        {
            this.holderPrefab = holder;
        }


        public void SetSilencer(Silencer silencer)
        {
            this.silencerPrefab = silencer;
        }

          

        public override string ToString()
        {
            var info = $"Aim feature effective range :{aimPrefab.EffectiveRange}  Holder feature volume :{holderPrefab.CountBullets} Silencer feature : Lenght-{silencerPrefab.Length} Diameter-{silencerPrefab.Diameter}";
            return info;
        }


    }
}
