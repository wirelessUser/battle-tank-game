using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="BulletSo",menuName = "ScriptableObject/BulletType")]
public class BulletSo : ScriptableObject
{
    public string BulletName;
    public  float Speed;
    public float damageAmount;
}
