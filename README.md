# Prism.SourceGenerators.Samples

Avalonia sample applications for **[MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)**.

## Generator reference: NuGet or local repo

**`Directory.Build.props`** checks for a **sibling clone** at **`../Prism.SourceGenerators`**. If that folder contains the Core project file, samples use **project references** to `Prism.SourceGenerators.Core` and the matching Roslyn analyzer assembly instead of the **`MvvmAIO.Prism.SourceGenerators`** NuGet package. If the sibling repo is missing (typical CI), samples fall back to **NuGet**.

Override: `dotnet build -p:UseLocalPrismSourceGenerators=false` (force NuGet) or `=true` (force local). Details: **`build/README-LocalSourceGenerators.md`**.

**NuGet-only** (no sibling repo): the Prism 9 **Validation** sample uses **`BindableValidator`** and **`[NotifyDataErrorInfo]`** from **`MvvmAIO.Prism.Core`**. If your installed **`MvvmAIO.Prism.SourceGenerators`** / Core version is older than that API, clone **[Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)** next to this repo or bump package versions.

## Projects

| Project | Target | Prism | Notes |
|---------|--------|-------|--------|
| **Prism.SourceGenerators.Samples.Prism8** | `net8.0` | Prism.DryIoc.Avalonia 8.x + Prism.Core 8.1.97 | Includes **`MvvmAIO.Prism.Bcl.Commands`** for `AsyncDelegateCommand`. |
| **Prism.SourceGenerators.Samples.Prism9** | `net10.0` | Prism 9 + Prism.Core 9.x | Framework `AsyncDelegateCommand`. **Validation** region: `BindableValidator`, `[NotifyDataErrorInfo]`, DataAnnotations. |

When using **NuGet** for the generators package, bump **`MvvmAIO.Prism.SourceGenerators`** (and **`MvvmAIO.Prism.Bcl.Commands`** on Prism 8) in each `.csproj` when you adopt a newer release.

The Prism 9 app uses **explicit** `IContainerRegistry` registrations in `App.axaml.cs` (same style as the Prism 8 sample). Attribute-driven registration demos also live in the [generator repository](https://github.com/MvvmAIO/Prism.SourceGenerators) tests and sources.

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
