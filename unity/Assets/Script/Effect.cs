﻿using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour
{
	public Material material;
	void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Graphics.Blit(source, destination , material);
	}
}