using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformUtility
{
    public static Transform SearchOrderTrans(Transform _transRoot,string _targetName)
    {
        for (int i = 0; i < _transRoot.childCount; i++)
        {
            var child = _transRoot.GetChild(i);
            if (child.name == _targetName)
                return child;
            else
            {
                var ch = SearchOrderTrans(child, _targetName);
                if (ch != null)
                    return ch;
            }

        }
        return null;
    }
}
