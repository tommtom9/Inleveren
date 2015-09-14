using UnityEngine;
using System.Collections;

public class SlowDown : Coin {

    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);
        _GO.Slow();
    }
}
