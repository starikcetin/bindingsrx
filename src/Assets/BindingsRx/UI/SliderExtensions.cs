﻿using System;
using BindingsRx.Exceptions;
using BindingsRx.Filters;
using BindingsRx.Generic;
using UniRx;
using UnityEngine.UI;

namespace BindingsRx.UI
{
    public static class SliderExtensions
    {
        public static IDisposable BindValueTo(this Slider input, IReactiveProperty<float> property, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.OnValueChangedAsObservable(), x => input.maxValue = x, property, bindingType, filters); }

        public static IDisposable BindValueTo(this Slider input, Func<float> getter, Action<float> setter, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.OnValueChangedAsObservable(), x => input.maxValue = x, getter, setter, bindingType, filters); }

        public static IDisposable BindMaxValueTo(this Slider input, IReactiveProperty<float> property, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.maxValue, x => input.maxValue = x, property, bindingType, filters); }

        public static IDisposable BindMaxValueTo(this Slider input, Func<float> getter, Action<float> setter, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.maxValue, x => input.maxValue = x, getter, setter, bindingType, filters); }

        public static IDisposable BindMinValueTo(this Slider input, IReactiveProperty<float> property, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.minValue, x => input.minValue = x, property, bindingType, filters); }

        public static IDisposable BindMinValueTo(this Slider input, Func<float> getter, Action<float> setter, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.minValue, x => input.minValue = x, getter, setter, bindingType, filters); }
        
        public static IDisposable BindNormalizedValueTo(this Slider input, IReactiveProperty<float> property, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.normalizedValue, x => input.normalizedValue = x, property, bindingType, filters); }

        public static IDisposable BindNormalizedValueTo(this Slider input, Func<float> getter, Action<float> setter, BindingTypes bindingType = BindingTypes.Default, params IFilter<float>[] filters)
        { return GenericBindings.Bind(() => input.normalizedValue, x => input.normalizedValue = x, getter, setter, bindingType, filters); }
    }
}