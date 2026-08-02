using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlatFadeIn : MonoBehaviour
{
    // Start is called before the first frame update
    public void FadeInImage()
    {
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn()
    {

        float duration = 1f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            transform.position = new Vector3(Mathf.Lerp(-2000f, 1200f, elapsedTime / duration), transform.position.y, transform.position.z);
            yield return null;
        }

    }
}
