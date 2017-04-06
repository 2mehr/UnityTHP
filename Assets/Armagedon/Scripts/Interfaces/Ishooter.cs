using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface Ishooter  {
       int CurrentWeaponID { get; set; }
   
    List<Weapen> Weapones { get; set; }

   
   
    Transform AtackPont();

    bool IsMelee();


    void ChooseWepons();

    void Shoot();
   
}
public enum CType
{
    Player,
    Enamey,
    Frends

};
