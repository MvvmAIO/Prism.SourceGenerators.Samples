# Prism.SourceGenerators.Samples

Avalonia sample applications for **[MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)**. They consume the published NuGet packages only (no submodule of the generator repo).

## Projects

| Project | Target | Prism | Notes |
|---------|--------|-------|--------|
| **Prism.SourceGenerators.Samples.Prism8** | `net8.0` | Prism.DryIoc.Avalonia 8.x + Prism.Core 8.1.97 | Includes **`MvvmAIO.Prism.Bcl.Commands`** for `AsyncDelegateCommand`. |
| **Prism.SourceGenerators.Samples.Prism9** | `net10.0` | Prism 9 + Prism.Core 9.x | Uses framework `AsyncDelegateCommand` (no Polyfill). |

Both reference **`MvvmAIO.Prism.SourceGenerators`** from NuGet (version in each `.csproj`; bump when you adopt a newer release).

The Prism 9 app uses **explicit** `IContainerRegistry` registrations in `App.axaml.cs` (same style as the Prism 8 sample) so the samples build against the **currently published** `MvvmAIO.Prism.Core` on NuGet. Attribute-driven `RegisterSingleton` / `RegisterForNavigation` / `RegisterGeneratedTypes()` demos live in the [main generator repository](https://github.com/MvvmAIO/Prism.SourceGenerators) tests and sources until a newer package aligns.

## Build

Requires a **.NET 10 SDK** (for the Prism 9 sample) and **.NET 8** workload/runtime as needed for `net8.0`.

```bash
dotnet build Prism.SourceGenerators.Samples.slnx
```

Open **`Prism.SourceGenerators.Samples.slnx`** in Visual Studio 2022 **17.13+** or Rider (`.slnx` support).

## Related

- Generator repo & documentation: [Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)  
- Wiki (中文): [Prism.SourceGenerators Wiki](https://github.com/MvvmAIO/Prism.SourceGenerators/wiki)

## License

MIT — see [LICENSE](LICENSE).
