Shader "Custom/MagicCube"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
		_DesiredColor("Desired Color ", Color) = (0,0,0,1)
	}
		SubShader
	{
		Tags { "RenderType" = "Opaque" }
		LOD 100

		//Blend One One
		//ZTest Always
		Pass
		{
			CGPROGRAM
			#pragma vertex      vert
			#pragma fragment    frag

			#include "UnityCG.cginc"

			float4 _DesiredColor;

			struct appdata
			{
				float4 vertex   : POSITION;
				float2 uv       : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv       : TEXCOORD0;
				float4 vertex   : SV_POSITION;
			};

			float movement;

			v2f vert(appdata v)
			{
				v2f output;

				float4 localSpace = v.vertex;
				localSpace.y += sin(movement);

				output.vertex = UnityObjectToClipPos(localSpace);
				output.uv = v.uv;
				return output;
			}

			sampler2D   _MainTex;

			fixed4 frag(v2f input) : SV_Target
			{
				//fixed4 col = tex2D(_MainTex, input.uv);

				return _DesiredColor;
			}
			ENDCG
		}
	}
}
