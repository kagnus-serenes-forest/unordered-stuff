using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models {
    public class AnimationComponent {

        public static AnimationComponent GetComponentForWeaponType(Animation.WeaponType weaponType) {
            return new AnimationComponent {
                AnimationIndex = 0,
                WeaponType = (byte)weaponType,
                ForAllOfAType = 1,
                Included = weaponType == Animation.WeaponType.Disarmed
            };
        }
        public static AnimationComponent GetComponentForWeapon(Animation.WeaponType weaponType) {
            return new AnimationComponent {
                AnimationIndex = 0,
                WeaponType = (byte)weaponType,
                ForAllOfAType = 0,
                Included = true
            };
        }

        public static AnimationComponent GetComponentForWeaponType(byte index, byte weaponType) {
            return new AnimationComponent {
                AnimationIndex = index,
                WeaponType = weaponType,
                ForAllOfAType = 1
            };
        }
        public static AnimationComponent GetComponentForWeapon(byte index, byte weaponType) {
            return new AnimationComponent {
                AnimationIndex = index,
                WeaponType = weaponType,
                ForAllOfAType = 0
            };
        }

        private AnimationComponent() { }

        public int BinaryForm {
            get {
                return BitConverter.ToInt32(Bytes, 0);
            }
        }

        public byte[] Bytes {
            get {
                if (BitConverter.IsLittleEndian) {
                    return new byte[] { WeaponType, ForAllOfAType, AnimationIndex, 0 };
                }
                else {
                    return new byte[] { 0, AnimationIndex, ForAllOfAType, WeaponType };
                }
            }
        }

        public byte WeaponType { get; set; }

        public byte AnimationIndex { get; set; }

        public byte ForAllOfAType { get; set; }

        public bool Included { get; set; }
    }
}
