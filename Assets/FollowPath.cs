using UnityEngine;

// TODO: keyboard control...
public class FollowPath : MonoBehaviour
{
    private LevelController _levelController;
    private Transform[] points;
    private float _movementSpeed = 3f;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        _levelController = GameObject.FindGameObjectWithTag("LevelGrid").GetComponent<LevelController>();
    }

    public void Init(Transform[] _points, float movementSpeed)
    {
        _movementSpeed = movementSpeed;
        points = _points;
        transform.position = points[0].position;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (points[index] == null)
        {
            Destroy(gameObject);
            return;
        }

        if (transform.position == points[index].position)
        {
            GoToNextPoint();
        }
        if(transform!=null)
        {
            transform.position = Vector2.MoveTowards(transform.position, points[index].position, _movementSpeed * Time.deltaTime);
        }
    }

    void GoToNextPoint()
    {
        if(index<points.Length-1)
        {
            index++;
        }
        else if(index==points.Length-1)
        {
            _levelController.targetsRemaining -= 1;
            Destroy(gameObject);
        }
    }
}
