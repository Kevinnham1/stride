﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering.Images
{
    internal static partial class ShaderMixins
    {
        internal partial class LightShaftsEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {

                {
                    var __mixinToCompose__ = (context.GetParam(LightShaftsEffectKeys.LightGroup));
                    var __subMixin = new ShaderMixinSource();
                    context.PushComposition(mixin, "lightGroup", __subMixin);
                    context.Mixin(__subMixin, __mixinToCompose__);
                    context.PopComposition();
                }
                context.Mixin(mixin, "LightShaftsShader", context.GetParam(LightShaftsEffectKeys.SampleCount));
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("LightShaftsEffect", new LightShaftsEffect());
            }
        }
    }
}