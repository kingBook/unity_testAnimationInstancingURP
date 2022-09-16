﻿using System;
using UnityEngine;


public class Box : MonoBehaviour {

    /// <summary>  Box 对齐的目标（跟随移动、缩放、旋转） </summary>
    public Transform target;

    private MeshRenderer m_meshRenderer;
    private static readonly int s_localToWorldMatrix = Shader.PropertyToID("_LocalToWorldMatrix");

    private void Start() {
        m_meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        m_meshRenderer.material.SetMatrix(s_localToWorldMatrix, target.localToWorldMatrix);
    }
}