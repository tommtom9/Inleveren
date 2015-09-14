using UnityEngine;
using System.Collections;

public class Rotate : Coin {

    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);

        _GO.Rotate();
    }

}
