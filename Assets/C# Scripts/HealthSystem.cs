using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    //this code draws all of the ghosts
    [SerializeField] GameObject fullprefab;
    [SerializeField] GameObject emptyprefab;

    public void DrawGhost(int ghosts, int maxGhosts){
        foreach (Transform child in transform){
            Destroy(child.gameObject);

        }
        for (int i = 0; i < maxGhosts; i++){
            if (i + 1 <= ghosts){
                GameObject ghost = Instantiate(fullprefab, transform.position, Quaternion.identity);
                ghost.transform.parent = transform;
            }
            else{
                GameObject ghost = Instantiate(emptyprefab, transform.position, Quaternion.identity);
                ghost.transform.parent = transform;
            }
        }
    }
}
