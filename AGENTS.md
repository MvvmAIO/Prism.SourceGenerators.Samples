# AGENTS.md (Samples)

Companion demos for [MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators). **Canonical repo constraints** live in the main repository [**AGENTS.md**](https://github.com/MvvmAIO/Prism.SourceGenerators/blob/master/AGENTS.md).

## Layout

| Path | Purpose |
|------|---------|
| **`Prism.SourceGenerators.Samples.slnx`** | Solution entry (prefer SLNX) |
| **`Prism.SourceGenerators.Samples.Prism8/`** | Prism **8.1.97** + Avalonia; needs **`MvvmAIO.Prism.Bcl.Commands`** for async commands |
| **`Prism.SourceGenerators.Samples.Prism9/`** | Prism **9.x**; uses built-in `AsyncDelegateCommand` from Prism.Core |

## NuGet vs local generators

- Default: consume **`MvvmAIO.Prism.SourceGenerators`** (and Bcl.Commands on Prism8) from NuGet.
- Local generator dev: set MSBuild property **`UseLocalPrismSourceGenerators=true`** and **`PrismSourceGeneratorsRepoRoot`** to your main-repo clone (see Prism8/9 `.csproj`).

## Dependabot

[`.github/dependabot.yml`](.github/dependabot.yml) may **ignore** package bumps that must stay aligned with the main repo release train (e.g. generator package version). Bump generator/Bcl versions in a deliberate PR after the main package is on NuGet.

## CI

`dotnet build Prism.SourceGenerators.Samples.slnx` — workflow [`.github/workflows/dotnet.yml`](.github/workflows/dotnet.yml).
