using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SimpleAttach : MonoBehaviour
{

    private Interactable interactable;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }


    public void OnHandHoverBegin(Hand hand){
        hand.ShowGrabHint();
    }

    public void OnHandHoverEnd(Hand hand){
        hand.HideGrabHint();
    }

    public void HandHoverUpdate(Hand hand){
        GrabTypes grabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(gameObject);

        //Grab the Object
        if(interactable.attachedToHand == null && grabType != GrabTypes.None){
            hand.AttachObject(gameObject, grabType);
            hand.HoverLock(interactable);
            hand.HideGrabHint();

        //Releasea the Object
        }else if(isGrabEnding){
            hand.DetachObject(gameObject);
            hand.HoverUnlock(interactable);
        }
    }

}
