using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets
{
    public class Actions : MonoBehaviour
    {
        [SerializeField] private GameObject _projectTile;
        private List<GameObject> _projecTiles = new();
        private float _timer;
        private int _bombsCount;
        private bool _isPlanting;
        public void SetBomb()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_isPlanting)
                {
                    _timer += Time.deltaTime;
                    if (_timer > 0.01f)
                    {
                        _timer = 0;
                        _isPlanting = false;
                        return;
                    }
                }
                else
                {
                    if (_bombsCount < 3)
                        _isPlanting = true;
                    var projectTile = Instantiate(_projectTile);
                    projectTile.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
                    _projecTiles.Add(projectTile);
                    _bombsCount++;
                }
            }
        }
        public void BlowBomb()
        {
            if (_bombsCount > 0)
            {
                var lastItem = _projecTiles[_bombsCount - 1];
                _projecTiles.Remove(lastItem);
                Destroy(lastItem);
                _bombsCount--;
            }
        }
    }
}
