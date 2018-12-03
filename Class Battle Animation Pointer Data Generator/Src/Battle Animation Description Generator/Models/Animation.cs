using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models {
    public class Animation {
        public enum WeaponType {
            Sword = 0,
            Lance = 1,
            Axe = 2,
            Bow = 3,
            Staff = 4,
            Anima = 5,
            Light = 6,
            Dark = 7,
            // DragonStone = 8, //? Not Sure
            Disarmed = 9
        };
        private List<AnimationComponent> mComponents = new List<AnimationComponent> {
            AnimationComponent.GetComponentForWeaponType(WeaponType.Sword),
            AnimationComponent.GetComponentForWeaponType(WeaponType.Lance),
            AnimationComponent.GetComponentForWeaponType(WeaponType.Axe),
            AnimationComponent.GetComponentForWeaponType(WeaponType.Bow),
            AnimationComponent.GetComponentForWeaponType(WeaponType.Staff),
            AnimationComponent.GetComponentForWeaponType(WeaponType.Anima),
            AnimationComponent.GetComponentForWeaponType(WeaponType.Light),
            AnimationComponent.GetComponentForWeaponType(WeaponType.Dark),
            null,
            AnimationComponent.GetComponentForWeaponType(WeaponType.Disarmed)
        };
        private List<AnimationComponent> ExtraComponents = new List<AnimationComponent>();

        public AnimationComponent[] DefaultComponents() {
            return mComponents.ToArray();
        }

        public Animation() {
        }
    }
}
