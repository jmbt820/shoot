﻿Shader "Hidden/Beam"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			sampler2D _MainTex;

			float metaball(float2 uv, float2 center, float2 size)
			{
    			return size / length(uv - center);
			}
			fixed4 frag (v2f i) : SV_Target
			{
    			fixed4 col = tex2D(_MainTex, i.uv);
    			float2 center = float2(0.5, 0.5);
    			col += metaball(i.uv, float2(0.5, 0.5), 0.02);
    			col += metaball(i.uv, float2(0.7, 0.5), 0.04);
    			col += metaball(i.uv, float2(0.9, 0.5), 0.08);
    			return col;
			}
			ENDCG
		}
	}
}
