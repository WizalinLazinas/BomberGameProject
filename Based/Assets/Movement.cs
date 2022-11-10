using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController _characterController;
    private float _speed = 1;
    [SerializeField] private AnimationCurve _animationCurve;
    private float _timer;
    private int _bombsCount;
    private Vector3 _positionOffset;
    private bool _isPlanting;
    private List<GameObject> _projecTiles= new();
    [SerializeField] private GameObject _projectTile;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //var direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _positionOffset = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _positionOffset *= _speed * Time.deltaTime;
        _characterController.Move(_positionOffset);
        SetTrap();
        ActivateTrap();
    }
    private void SetTrap()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isPlanting)
            {
                _timer += Time.deltaTime;
                Debug.Log(_timer);
                if (_timer > 0.01f)
                {
                    _timer = 0;
                    _isPlanting = false;
                    return;
                }
            }
            else
            {
                if(_bombsCount<3)
                _isPlanting = true;
                var projectTile = Instantiate(_projectTile);
                projectTile.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
                _projecTiles.Add(projectTile);
                _bombsCount++;
            }
        }
    }
    private void ActivateTrap()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(_bombsCount>0)
            {
                var lastItem = _projecTiles[_bombsCount-1];
                _projecTiles.Remove(lastItem);
                Destroy(lastItem);
                _bombsCount--;
            }
        }
    }
}
