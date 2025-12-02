using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform spawnPosition;
    public void SpawnTarget()
    {
        //Instantiate(targetPrefab);
        Instantiate(targetPrefab, transform.position, Quaternion.identity); // 이것과 Instantiate(targetPrefab); 은 동일한 코드, 축약형과 기본형의 차이
    }
}
