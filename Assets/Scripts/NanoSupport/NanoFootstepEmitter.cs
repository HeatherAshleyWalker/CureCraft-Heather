using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NanoFootstepEmitter : MonoBehaviour {



    public void ExecuteFootstep() {

        EventManager.TriggerEvent<NanoFootstepEvent, Vector3>(transform.position);
    }
}
