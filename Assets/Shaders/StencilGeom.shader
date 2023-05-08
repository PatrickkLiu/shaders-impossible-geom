Shader "Examples/Stencil"
{
    Properties
    {
		_Color ("Color", Color) = (0,0,0,1) //source alpha
		[IntRange] _StencilID ("Stencil ID", Range(0, 255)) = 0
    }
	SubShader
    {
        Tags 
		{ 
			"RenderType" = "Opaque" //key 1 --> send alpha to framebuffer?
			"Queue" = "Geometry" //key 2 
			"RenderPipeline" = "UniversalPipeline"
		}

        Pass
        {
			//Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha//Blend One One //remove the source value, use the destination value | frame buffer is destination
			Blend Zero One
			ZWrite Off  //key 2 - disable depth

	
			Stencil
			{
				Ref [_StencilID]
				Comp Always
				Pass Replace
				Fail Keep
			}
			
        }
    }
}


