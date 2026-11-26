# Prism.SourceGenerators.Samples

Avalonia sample applications for [MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators). Generator and analyzer changes belong in the main repository.

## Build & Verify

```powershell
dotnet build Prism.SourceGenerators.Samples.slnx
```

- `Prism.SourceGenerators.Samples.Prism8/` targets Prism 8.1.97 and consumes `MvvmAIO.Prism.Bcl.Commands`.
- `Prism.SourceGenerators.Samples.Prism9/` targets Prism 9.x and uses Prism.Core's built-in `AsyncDelegateCommand`.
- Default builds consume NuGet packages; for local generator testing, pass `-p:UseLocalPrismSourceGenerators=true` and `-p:PrismSourceGeneratorsRepoRoot=<path-to-main-repo>` (see project files and `build/README-LocalSourceGenerators.md`).

## Version Sync

- `.github/dependabot.yml` ignores generator and `Bcl.Commands` package updates that must track main-repo releases; bump them in a dedicated PR after the NuGet packages are published.

## Conventions

- Prefer `.slnx` (`Prism.SourceGenerators.Samples.slnx`).
- Commit messages, issues, and PR text: **English**.
- Do not commit or push unless explicitly requested.
