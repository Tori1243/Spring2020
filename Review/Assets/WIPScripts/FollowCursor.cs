using System.Collections;
using UnityEngine;

public class FollowCursor: MonoBehaviour
{
    private bool isFollowing;
    
    public void StartFollow(){
        isFollowing = true;
        StartCoroutine(Follow());

    }

    IEnumerator Follow(){
        while(isFollowing){
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            yield return null;
        }
    }

    public void StopFollow(){
        isFollowing = false;
    }
}