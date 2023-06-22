using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test111 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TestCorutine());
    }

    private IEnumerator TestCorutine()
    {
        Debug.Log($"TestCorutine1: {Time.frameCount}");
        yield return null;
        Debug.Log($"TestCorutine2: {Time.frameCount}");
        yield return new WaitForSeconds(1);
        Debug.Log($"TestCorutine3: {Time.frameCount}");
        while (true)
        {
            //    yield return new WaitUntil(() => _wasPress);
            if (Input.GetKey(KeyCode.Q))
            {
                yield break;
            }

            if (Input.GetKey((KeyCode.Space)))
            {
                Debug.Log($"TestCorutin4: {Time.frameCount}");
            }

            yield return null;
        }
    }
}