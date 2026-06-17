# .NET MAUI sample (ViewModel library)

This project is a **headless ViewModel library** for **.NET MAUI** + **Prism 9** integration. It compiles on Linux CI and documents the same generator patterns you wire into a `Prism.DryIoc.Maui` app shell.

## Patterns demonstrated

- `[ObservableProperty]` on **partial properties** (C# 14 / `field` keyword)
- `[DelegateCommand]` on `BindableBase`

## Wiring into a MAUI app

1. Create a .NET MAUI app with `Prism.DryIoc.Maui` and reference this library (or copy `MainViewModel.cs`).
2. Register `MainViewModel` in `RegisterTypes`.
3. Set `BindingContext` on your `ContentPage`.

See the [documentation site](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/samples) for Avalonia, WPF, and cross-platform samples.
