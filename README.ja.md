# Prism.SourceGenerators.Samples

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語**

**[MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)** 向けのサンプルアプリケーションおよび**ヘッドレス ViewModel ライブラリ**集です。

## ジェネレーター参照：NuGet またはローカルリポジトリ

**`Directory.Build.props`** は兄弟ディレクトリ **`../Prism.SourceGenerators`** の有無を確認します。そこに Core プロジェクトファイルが存在する場合、サンプルは **`MvvmAIO.Prism.SourceGenerators`** NuGet パッケージではなく `Prism.SourceGenerators.Core` と対応する Roslyn アナライザーアセンブリへの**プロジェクト参照**を使用します。兄弟リポジトリがない場合（通常の CI 環境など）は **NuGet** にフォールバックします。

上書き方法：`dotnet build -p:UseLocalPrismSourceGenerators=false`（NuGet を強制）または `=true`（ローカルを強制）。詳細は **`build/README-LocalSourceGenerators.md`** を参照してください。

## プロジェクト一覧

| プロジェクト | ターゲット | プラットフォーム | 備考 |
|---|---|---|---|
| **Prism.SourceGenerators.Samples.Prism8** | `net8.0` | Avalonia | Prism 8.1.97 + **`MvvmAIO.Prism.Bcl.Commands`**。 |
| **Prism.SourceGenerators.Samples.Prism9** | `net10.0` | Avalonia | Prism 9；検証・リージョンナビゲーション・ダイアログのデモ。 |
| **Prism.SourceGenerators.Samples.Wpf** | `net8.0-windows` | WPF | 最小構成シェル；フィールドベースの `[ObservableProperty]`。 |
| **Prism.SourceGenerators.Samples.Maui** | `net9.0` | .NET MAUI (ViewModels) | ヘッドレスライブラリ；`Prism.DryIoc.Maui` と連携可能。プロジェクト内の **`README.md`** を参照。 |
| **Prism.SourceGenerators.Samples.Uno** | `net9.0` | Uno / WinUI (ViewModels) | `[NavigationAware]` を備えたヘッドレス互換ライブラリ。 |

CI：**Linux** では Avalonia とヘッドレスライブラリをビルドし、**Windows** では WPF をビルドします。詳細は **`build/README-PlatformSamples.md`** を参照してください。

**NuGet** を使用する場合は、新リリースに合わせて **`MvvmAIO.Prism.SourceGenerators`**（Prism 8 では **`MvvmAIO.Prism.Bcl.Commands`** も）を更新してください。

## ビルド

**.NET 10 SDK**（Prism 9 サンプル用）および `net8.0` / WPF 向けの **.NET 8** が必要です。

```bash
dotnet build Prism.SourceGenerators.Samples.slnx
```

Linux では WPF を除外するか、Windows 上でのみビルドしてください。

## 関連リンク

- [ドキュメントサイト](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/)
- [エコシステム上の位置付け](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/positioning)

## 推奨パターン

- **リージョンナビゲーション：** ナビゲーション用ビューの登録には、ViewModel ではなく**ビューのコードビハインド**に **`[RegisterForNavigation]`** を付与することを推奨します。Prism 9 サンプルの `DashboardView.axaml.cs` や `CommandsView.axaml.cs` で確認できます。
- **ダイアログ：** ダイアログビューのコードビハインドに **`[RegisterDialog]`** を付与して、ダイアログ用 ViewModel をコンテナへ登録してください。

## ライセンス

MIT — [LICENSE](LICENSE) を参照してください。
