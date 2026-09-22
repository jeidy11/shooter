using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons/New Weapon")]
public class Guns : ScriptableObject 
{
    // Start is called before the first frame update
    //[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons/New Weapon")]
    public float range;
    public int verticalRange;
    public int horizontalRange;
    public float fireRate;
    public int damage;
    public AudioClip sound; 

}
