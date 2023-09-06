using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuilderWeapon
{
    public abstract class GunshotWeaponBuilder:MonoBehaviour
    {
        protected abstract void InitializationAim(Aim aimPrefab);
        protected abstract void InitializationHolder(Holder holderPrefab);

        protected abstract void InitializationSilencer(Silencer silencerPrefab);

        public abstract void GunShotCreateModofication(Aim aimPrefab, Holder holderPrefab, Silencer silencerPrefab);
    }
}
