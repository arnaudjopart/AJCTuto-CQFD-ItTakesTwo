using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class RigManipulator : MonoBehaviour
{
    public RigBuilder m_rigBuilder;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateAimingRig()
    {
        var sequence = DOTween.Sequence();

        sequence.Join(DOTween.To(() => m_rigBuilder.layers[3].rig.weight, x => m_rigBuilder.layers[3].rig.weight = x, 1, .2f)); //Right hand
        sequence.Append(DOTween.To(() => m_rigBuilder.layers[2].rig.weight, x => m_rigBuilder.layers[2].rig.weight = x, 1, .3f)); //Aim
        sequence.Join(DOTween.To(() => m_rigBuilder.layers[4].rig.weight, x => m_rigBuilder.layers[4].rig.weight = x, 1, .3f)); //Left hand
        sequence.Join(DOTween.To(() => m_rigBuilder.layers[0].rig.weight, x => m_rigBuilder.layers[0].rig.weight = x, 1, .3f)); //Body
    }

    public void DeactivateAimingRig()
    {
        var sequence = DOTween.Sequence();

        sequence.Join(DOTween.To(() => m_rigBuilder.layers[4].rig.weight, x => m_rigBuilder.layers[4].rig.weight = x, 0, .4f)); //Left hand
        sequence.Join(DOTween.To(() => m_rigBuilder.layers[2].rig.weight, x => m_rigBuilder.layers[2].rig.weight = x, 0, .3f)); //Aim
        sequence.Join(DOTween.To(() => m_rigBuilder.layers[0].rig.weight, x => m_rigBuilder.layers[0].rig.weight = x, 0, .3f)); //Body
        sequence.Append(DOTween.To(() => m_rigBuilder.layers[3].rig.weight, x => m_rigBuilder.layers[3].rig.weight = x, 0, .2f)); //Right hand
    }
}
