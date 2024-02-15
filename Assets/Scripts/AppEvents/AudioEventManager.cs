using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioEventManager : MonoBehaviour
{

    public EventSound3D eventSound3DPrefab;

    public AudioClip[] nanoFootstepAudio;

    private UnityAction<Vector3> nanoFootstepEventListener;

    void Awake()
    {

        nanoFootstepEventListener = new UnityAction<Vector3>(nanoFootstepEventHandler);

    }


    // Use this for initialization
    void Start()
    {


        			
    }


    void OnEnable()
    {

        EventManager.StartListening<NanoFootstepEvent, Vector3>(nanoFootstepEventListener);

    }

    void OnDisable()
    {

        EventManager.StopListening<NanoFootstepEvent, Vector3>(nanoFootstepEventListener);
    }


	
 

    // void boxCollisionEventHandler(Vector3 worldPos, float impactForce)
    // {
    //     //AudioSource.PlayClipAtPoint(this.boxAudio, worldPos);

    //     const float halfSpeedRange = 0.2f;

    //     EventSound3D snd = Instantiate(eventSound3DPrefab, worldPos, Quaternion.identity, null);

    //     snd.audioSrc.clip = this.boxAudio[Random.Range(0,boxAudio.Length)];

    //     snd.audioSrc.pitch = Random.Range(1f-halfSpeedRange, 1f+halfSpeedRange);

    //     snd.audioSrc.minDistance = Mathf.Lerp(1f, 8f, impactForce /200f);
    //     snd.audioSrc.maxDistance = 100f;

    //     snd.audioSrc.Play();
    // }

    // void playerLandsEventHandler(Vector3 worldPos, float collisionMagnitude)
    // {
    //     //AudioSource.PlayClipAtPoint(this.explosionAudio, worldPos, 1f);

    //     if (eventSound3DPrefab)
    //     {
    //         if (collisionMagnitude > 300f)
    //         {

    //             EventSound3D snd = Instantiate(eventSound3DPrefab, worldPos, Quaternion.identity, null);

    //             snd.audioSrc.clip = this.playerLandsAudio;

    //             snd.audioSrc.minDistance = 5f;
    //             snd.audioSrc.maxDistance = 100f;

    //             snd.audioSrc.Play();

    //             if (collisionMagnitude > 500f)
    //             {

    //                 EventSound3D snd2 = Instantiate(eventSound3DPrefab, worldPos, Quaternion.identity, null);

    //                 snd2.audioSrc.clip = this.gruntAudio;

    //                 snd2.audioSrc.minDistance = 5f;
    //                 snd2.audioSrc.maxDistance = 100f;

    //                 snd2.audioSrc.Play();
    //             }
    //         }


    //     }
    // }

    // void jumpEventHandler(Vector3 worldPos)
    // {
    //     //AudioSource.PlayClipAtPoint(this.explosionAudio, worldPos, 1f);

    //     if (eventSound3DPrefab)
    //     {

    //         EventSound3D snd = Instantiate(eventSound3DPrefab, worldPos, Quaternion.identity, null);

    //         snd.audioSrc.clip = this.jumpAudio;

    //         snd.audioSrc.minDistance = 5f;
    //         snd.audioSrc.maxDistance = 100f;

    //         snd.audioSrc.Play();
    //     }
    // }

    // void deathEventHandler(GameObject go)
    // {
    //     //AudioSource.PlayClipAtPoint(this.explosionAudio, worldPos, 1f);

    //     if (eventSound3DPrefab)
    //     {

    //         EventSound3D snd = Instantiate(eventSound3DPrefab, go.transform);

    //         snd.audioSrc.clip = this.deathAudio;

    //         snd.audioSrc.minDistance = 5f;
    //         snd.audioSrc.maxDistance = 100f;

    //         snd.audioSrc.Play();
    //     }
    // }

    // void minionDeathEventHandler(Vector3 pos, MinionScript ms)
    // {
  
    //     if (minionDeathAudio)
    //     {

    //         EventSound3D snd = Instantiate(eventSound3DPrefab, pos, Quaternion.identity, null);

    //         snd.audioSrc.clip = this.minionDeathAudio;

    //         snd.audioSrc.minDistance = 5f;
    //         snd.audioSrc.maxDistance = 100f;

    //         snd.audioSrc.Play();
    //     }

    // }


    // void minionOuchEventHandler(Vector3 pos)
    // {


    //     if (punchAudio)
    //     {

    //         EventSound3D snd = Instantiate(eventSound3DPrefab, pos, Quaternion.identity, null);

    //         snd.audioSrc.clip = this.punchAudio;

    //         snd.audioSrc.minDistance = 5f;
    //         snd.audioSrc.maxDistance = 100f;

    //         snd.audioSrc.Play();
    //     }

  
    //     if (minionOuchAudio)
    //     {

    //         EventSound3D snd2 = Instantiate(eventSound3DPrefab, pos, Quaternion.identity, null);

    //         snd2.audioSrc.clip = this.minionOuchAudio;

    //         snd2.audioSrc.minDistance = 5f;
    //         snd2.audioSrc.maxDistance = 100f;

    //         snd2.audioSrc.Play();
    //     }
    // }


    // void minionSpawnEventHandler(MinionScript minion) {

    //     if (minionSpawnAudio)
    //     {

    //         EventSound3D snd = Instantiate(eventSound3DPrefab, minion.transform.position, Quaternion.identity, null);

    //         snd.audioSrc.clip = this.minionSpawnAudio;

    //         snd.audioSrc.minDistance = 5f;
    //         snd.audioSrc.maxDistance = 100f;

    //         snd.audioSrc.Play();
    //     }


    // }


    void nanoFootstepEventHandler(Vector3 pos) {

        EventSound3D snd = Instantiate(eventSound3DPrefab, pos, Quaternion.identity, null);

        snd.audioSrc.clip = this.nanoFootstepAudio[Random.Range(0, nanoFootstepAudio.Length)];

        snd.audioSrc.minDistance = 5f;
        snd.audioSrc.maxDistance = 100f;

        snd.audioSrc.Play();

    }
}
