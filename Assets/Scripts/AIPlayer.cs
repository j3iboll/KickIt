using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : Player
{
    protected new void Awake()
    { 
        base.Awake();
    }
    
    // Start is called before the first frame update
    protected new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected new void Update()
    {
        base.Update();

        if (Game.Instance.GameState == GameState_.BringingBallIn)
        {
            if (HasBall)
            {
                Game.Instance.AIPlayerDestination = (AIPlayer)Game.Instance.GetClosestPlayerOfSameTeam(this);
                if (DoingKick)
                {
                    SetPlayerAction(ActionType_.Pass);
                }
                if (DoingThrow)
                {
                    SetPlayerAction(ActionType_.ThrowinPass);
                }
            }
        }
    }
}
