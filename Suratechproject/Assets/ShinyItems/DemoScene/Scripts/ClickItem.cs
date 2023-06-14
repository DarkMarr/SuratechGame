using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItem : MonoBehaviour
{

public Camera camera;
//public AudioSource SoundPlayer;
public GameObject[] CollectedEffect;
public AudioClip[] ItemSounds;

int EffectCount;

void Start()
 {
     
 }
 
 private IEnumerator Countdown(GameObject items, GameObject destroyedEffect)
 {

    yield return new WaitForSeconds(0.9f);
    Destroy (destroyedEffect);
    items.SetActive(true);
 }

    // Start is called before the first frame update
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){

            //Fire raycast
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
            if (Physics.Raycast(ray, out hit)) {
            
            GameObject GameObjectHit = hit.transform.gameObject;

                if (GameObjectHit.tag == "Item"){
                    print (GameObjectHit.tag);
                    GameObjectHit.SetActive(false);


                    //Find collider
                    SphereCollider colPos = GameObjectHit.GetComponent<SphereCollider>();
                    //Offset instantiate position to collider center
                    Vector3 newPos = colPos.center + GameObjectHit.transform.position;
                    //Instantiate random "ItemCollected" effect
                    GameObject newDestroyedEffect = Instantiate(CollectedEffect[EffectCount], newPos, Quaternion.identity);
                    
                    EffectCount ++;
                    if (EffectCount >= CollectedEffect.Length){
                        EffectCount = 0;
                    }

                    //Play random sound
                    AudioSource SoundPlayer = this.GetComponent<AudioSource>();
                    
                    int randSound = Random.Range(0,ItemSounds.Length);
                    SoundPlayer.clip = ItemSounds[randSound];
         
                    SoundPlayer.Play();

                    //Countdown to reactivate item
                    StartCoroutine(Countdown(GameObjectHit, newDestroyedEffect));
                    
                }
                // Do something with the object that was hit by the raycast.
            }
        }
    }

    


}
