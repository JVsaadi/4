using UnityEngine;

public class CollisionBox : MonoBehaviour
{
    public Color boxColor = Color.red;
    public int boxWidth = 50;
    public int boxHeight = 50;
    public int velocityX = 1;
    public int velocityY = 1;

    private int positionX = 0;
    private int positionY = 0;

    private void FixedUpdate()
    {
        // Update the position using integer arithmetic
        positionX += velocityX;
        positionY += velocityY;

        // Ensure the position is within bounds
        positionX = Mathf.Clamp(positionX, 0, 100);
        positionY = Mathf.Clamp(positionY, 0, 100);
    }
 private void OnCollisionEnter2D(Collision2D collision)
    {
        // Stop the object from moving when it collides with another object
        velocityX = 0;
        velocityY = 0;
    }
    private void OnDrawGizmos()
    {
        // Draw the collision box at the updated position
        Gizmos.color = boxColor;
        Vector3 position = transform.position; // Oppdater posisjonen til kollisjonsboksen
        Gizmos.DrawWireCube(position, new Vector3(boxWidth, boxHeight, 0));
    }
}
