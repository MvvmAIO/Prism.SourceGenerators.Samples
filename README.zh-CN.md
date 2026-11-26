# Prism.SourceGenerators.Samples

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md)

**[MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)** 的示例应用与**无头 ViewModel 类库**。

## 生成器引用：NuGet 或本地仓库

**`Directory.Build.props`** 会检查同级目录 **`../Prism.SourceGenerators`**。若该目录包含 Core 项目文件，示例将使用对 `Prism.SourceGenerators.Core` 及对应 Roslyn 分析器程序集的**项目引用**，而非 **`MvvmAIO.Prism.SourceGenerators`** NuGet 包。若本地不存在同级主仓（如常规 CI），示例会回退到 **NuGet**。

覆盖方式：`dotnet build -p:UseLocalPrismSourceGenerators=false`（强制 NuGet）或 `=true`（强制本地）。详情见 **`build/README-LocalSourceGenerators.md`**。

## 项目列表

| 项目 | 目标框架 | 平台 | 说明 |
|------|----------|------|------|
| **Prism.SourceGenerators.Samples.Prism8** | `net8.0` | Avalonia | Prism 8.1.97 + **`MvvmAIO.Prism.Bcl.Commands`**。 |
| **Prism.SourceGenerators.Samples.Prism9** | `net10.0` | Avalonia | Prism 9；包含验证、区域导航与对话框示例。 |
| **Prism.SourceGenerators.Samples.Wpf** | `net8.0-windows` | WPF | 最小化壳应用；演示基于字段的 `[ObservableProperty]`。 |
| **Prism.SourceGenerators.Samples.Maui** | `net9.0` | .NET MAUI (ViewModels) | 无头类库；可接入 `Prism.DryIoc.Maui`。见项目内 **`README.md`**。 |
| **Prism.SourceGenerators.Samples.Uno** | `net9.0` | Uno / WinUI (ViewModels) | 演示 `[NavigationAware]` 的无头兼容类库。 |

CI：**Linux** 构建 Avalonia 与无头类库；**Windows** 构建 WPF。详见 **`build/README-PlatformSamples.md`**。

使用 **NuGet** 时，升级新版本请同步更新 **`MvvmAIO.Prism.SourceGenerators`**（Prism 8 还需更新 **`MvvmAIO.Prism.Bcl.Commands`**）。

## 构建

需要 **.NET 10 SDK**（Prism 9 示例）以及用于 `net8.0` / WPF 的 **.NET 8**。

```bash
dotnet build Prism.SourceGenerators.Samples.slnx
```

在 Linux 上请排除 WPF，或仅在 Windows 上构建。

## 相关链接

- [文档站点](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/)
- [生态定位](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/positioning)

## 推荐模式

- **区域导航：** 建议在**视图后台代码（code-behind）**（而非 ViewModel）上标注 **`[RegisterForNavigation]`** 来注册导航视图。Prism 9 示例中的 `DashboardView.axaml.cs`、`CommandsView.axaml.cs` 等展示了该用法。
- **对话框：** 在对话框视图后台代码上使用 **`[RegisterDialog]`**，向容器注册对话框 ViewModel。

## 许可证

MIT — 见 [LICENSE](LICENSE)。
