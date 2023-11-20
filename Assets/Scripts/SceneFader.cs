using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SceneFader : MonoBehaviour
{
    public Image fadeImage;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        Color startColor = fadeImage.color;
        Color targetColor = new Color(startColor.r, startColor.g, startColor.b, 0.0f);

        float timer = 0f;
        float animationTime = 8f;

        while (timer < animationTime)
        {
            timer += Time.deltaTime;

            float t = timer / animationTime;
            t = t * t * (3f - 2f * t);

            fadeImage.color = Color.Lerp(startColor, targetColor, t);
            yield return null;
        }

        // Optionally, you can load a new scene here or perform any other action.
    }
}
