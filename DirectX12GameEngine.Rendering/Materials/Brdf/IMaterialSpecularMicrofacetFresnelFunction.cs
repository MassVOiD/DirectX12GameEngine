﻿using System.Numerics;

namespace DirectX12GameEngine.Rendering.Materials.Brdf
{
    public interface IMaterialSpecularMicrofacetFresnelFunction : IMaterialSpecularMicrofacetFunction
    {
        Vector3 Compute(in MaterialShadingContext context);
    }
}
