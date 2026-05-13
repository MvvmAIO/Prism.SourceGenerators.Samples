# Local `Prism.SourceGenerators` reference

The sample `.csproj` files choose **`MvvmAIO.Prism.SourceGenerators`** from NuGet **only when** the sibling generator repo is not present.

If you clone **[MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)** as a **sibling folder** next to this repository (same parent directory), **`Directory.Build.props`** sets **`UseLocalPrismSourceGenerators=true`** automatically and the samples **project-reference** `Prism.SourceGenerators.Core` plus the matching Roslyn analyzer project instead of the NuGet package.

To **force NuGet** even when the sibling repo exists:

```bash
dotnet build -p:UseLocalPrismSourceGenerators=false
```

To **force local** (e.g. CI with a checked-out generator repo):

```bash
dotnet build -p:UseLocalPrismSourceGenerators=true
```

In **GitHub Actions**, the workflow checks out **Prism.SourceGenerators** beside this repository so the same sibling layout is used on every CI run.
