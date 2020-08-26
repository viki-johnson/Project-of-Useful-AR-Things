Shader "ARWindow/WindowPane"
{
    Properties
    {
        _StencilMask("Stencil mask", Int) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue" = "Geometry-1"}
        ZWrite off
        LOD 100

        Stencil
        {
            Ref [_StencilMask]
            Comp Always
            Pass Replace
        }

        Pass
        {
        }
    }
}
