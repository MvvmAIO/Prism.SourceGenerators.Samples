# Prism.SourceGenerators.Samples

Sample applications and **headless ViewModel libraries** for **[MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)**.

## Generator reference: NuGet or local repo

**`Directory.Build.props`** checks for a **sibling clone** at **`../Prism.SourceGenerators`**. If that folder contains the Core project file, samples use **project references** to `Prism.SourceGenerators.Core` and the matching Roslyn analyzer assembly instead of the **`MvvmAIO.Prism.SourceGenerators`** NuGet package. If the sibling repo is missing (typical CI), samples fall back to **NuGet**.

Override: `dotnet build -p:UseLocalPrismSourceGenerators=false` (force NuGet) or `=true` (force local). Details: **`build/README-LocalSourceGenerators.md`**.

## Projects

| Project | Target | Platform | Notes |
|---------|--------|----------|--------|
| **Prism.SourceGenerators.Samples.Prism8** | `net8.0` | Avalonia | Prism 8.1.97 + **`MvvmAIO.Prism.Bcl.Commands`**. |
| **Prism.SourceGenerators.Samples.Prism9** | `net10.0` | Avalonia | Prism 9; validation demos with `BindableValidator`. |
| **Prism.SourceGenerators.Samples.Wpf** | `net8.0-windows` | WPF | Minimal shell; field-backed `[ObservableProperty]`. |
| **Prism.SourceGenerators.Samples.Maui** | `net9.0` | .NET MAUI (ViewModels) | Headless library; wire into `Prism.DryIoc.Maui`. See project **`README.md`**. |
| **Prism.SourceGenerators.Samples.Uno** | `net9.0` | Uno / WinUI (ViewModels) | Headless compatibility library with `[NavigationAware]`. |

CI: **Linux** builds Avalonia + headless libraries; **Windows** builds WPF. See **`build/README-PlatformSamples.md`**.

When using **NuGet**, bump **`MvvmAIO.Prism.SourceGenerators`** (and **`MvvmAIO.Prism.Bcl.Commands`** on Prism 8) when adopting a new release.

## Build

Requires **.NET 10 SDK** (Prism 9 sample) and **.NET 8** for `net8.0` / WPF.

```bash
dotnet build Prism.SourceGenerators.Samples.slnx
```

On Linux, exclude WPF or build it on Windows only.

## Related

- [Documentation site](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/)
- [Ecosystem positioning](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/positioning)

## License

MIT — see [LICENSE](LICENSE).
