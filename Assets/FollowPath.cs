using UnityEngine;

// TODO: keyboard control...
public class FollowPath : MonoBehaviour
{
    private Transform[] points;
    private float _movementSpeed = 3f;
    public bool atEnd;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Init(Transform[] _points, float movementSpeed)
    {
        _movementSpeed = movementSpeed;
        points = _points;
        transform.position = points[0].position;
        index = 0;
        atEnd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject == null || !atEnd)
        {
            return;
        }

        if (points[index] == null)
        {
            Destroy(gameObject);
            atEnd = false;
            return;
        }

        if (transform.position == points[index].position)
        {
            GoToNextPoint();
        }
        if(transform!=null)
        {
            if (Vector2.Distance(transform.position, points[index].position) < _movementSpeed * Time.deltaTime)
            {
                transform.position = points[index].position;
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, points[index].position, _movementSpeed * Time.deltaTime);
            }
        }
    }

    void GoToNextPoint()
    {
        if(index<points.Length-1)
        {
            index++;
        }
        else if(index >= points.Length-1 && atEnd)
        {
            atEnd = false;
        }
    }
}
