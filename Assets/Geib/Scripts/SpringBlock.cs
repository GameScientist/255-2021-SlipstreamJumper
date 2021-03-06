using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geib
{

    public class SpringBlock : OverlapObject
    {

        public override void OnOverlap(PlayerMovement pm)
        {
            pm.LaunchPlayer(new Vector3(0, 20, 0));
            SoundEffectBoard.PlaySpring();
        }
    }
}
