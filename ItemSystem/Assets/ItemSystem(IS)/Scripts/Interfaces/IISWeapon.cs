using UnityEngine;
using System.Collections;

namespace Drottin.ItemSystem
{
    public interface IISWeapon
    {
        int MinDamage { get; set; }
        int Attack();

    }
}
