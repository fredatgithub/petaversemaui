﻿using petaverse.frontend.mauiapp.Animations;

namespace petaverse.frontend.mauiapp.Triggers;

public abstract class AnimationBaseTrigger<T> : TriggerAction<VisualElement>
{
    public T From { get; set; } = default(T);
    public T To { get; set; } = default(T);
    public uint Duration { get; set; } = 1000;
    public int Delay { get; set; } = 0;
    public EasingType Easing { get; set; } = EasingType.Linear;
    public BindableProperty TargetProperty { get; set; } = default(BindableProperty);

    protected override void Invoke(VisualElement sender)
    {
        throw new NotImplementedException("Please Implement Invoke() in derived-class");
    }

    protected void SetDefaultFrom(T property)
    {
        From = (From == null || From.Equals(default(T))) ? property : From;
    }
}