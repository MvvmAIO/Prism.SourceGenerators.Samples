# Prism.SourceGenerators.Samples

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md)

**[MvvmAIO/Prism.SourceGenerators](https://github.com/MvvmAIO/Prism.SourceGenerators)** 的範例應用程式與**無頭 ViewModel 類別庫**。

## 產生器參考：NuGet 或本機儲存庫

**`Directory.Build.props`** 會檢查同層目錄 **`../Prism.SourceGenerators`**。若該資料夾包含 Core 專案檔，範例將改用對 `Prism.SourceGenerators.Core` 與對應 Roslyn 分析器組件的**專案參考**，而非 **`MvvmAIO.Prism.SourceGenerators`** NuGet 套件。若缺少同層主儲存庫（常見於 CI），範例會退回使用 **NuGet**。

覆寫方式：`dotnet build -p:UseLocalPrismSourceGenerators=false`（強制 NuGet）或 `=true`（強制本機）。詳情請見 **`build/README-LocalSourceGenerators.md`**。

## 專案清單

| 專案 | 目標架構 | 平台 | 說明 |
|------|----------|------|------|
| **Prism.SourceGenerators.Samples.Prism8** | `net8.0` | Avalonia | Prism 8.1.97 + **`MvvmAIO.Prism.Bcl.Commands`**。 |
| **Prism.SourceGenerators.Samples.Prism9** | `net10.0` | Avalonia | Prism 9；包含驗證、區域導覽與對話框示範。 |
| **Prism.SourceGenerators.Samples.Wpf** | `net8.0-windows` | WPF | 精簡外殼；欄位支援的 `[ObservableProperty]`。 |
| **Prism.SourceGenerators.Samples.Maui** | `net9.0` | .NET MAUI (ViewModels) | 無頭類別庫；可接上 `Prism.DryIoc.Maui`。參閱專案內 **`README.md`**。 |
| **Prism.SourceGenerators.Samples.Uno** | `net9.0` | Uno / WinUI (ViewModels) | 搭配 `[NavigationAware]` 的無頭相容性類別庫。 |

CI：**Linux** 建置 Avalonia 與無頭類別庫；**Windows** 建置 WPF。請參閱 **`build/README-PlatformSamples.md`**。

使用 **NuGet** 時，採用新版本請一併升級 **`MvvmAIO.Prism.SourceGenerators`**（Prism 8 亦需升級 **`MvvmAIO.Prism.Bcl.Commands`**）。

## 建置

需要 **.NET 10 SDK**（Prism 9 範例）以及用於 `net8.0` / WPF 的 **.NET 8**。

```bash
dotnet build Prism.SourceGenerators.Samples.slnx
```

在 Linux 上請排除 WPF，或僅於 Windows 上建置。

## 相關連結

- [文件網站](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/)
- [生態系定位](https://mvvmaio.github.io/Prism.SourceGenerators.Docs/positioning)

## 建議模式

- **區域導覽：** 建議將 **`[RegisterForNavigation]`** 標註於**檢視程式碼後置檔案（code-behind）**（而非 ViewModel）以註冊導覽檢視。Prism 9 範例於 `DashboardView.axaml.cs`、`CommandsView.axaml.cs` 等檔案示範了此做法。
- **對話框：** 在對話框檢視的 code-behind 上使用 **`[RegisterDialog]`**，向容器註冊對話框 ViewModel。

## 授權條款

MIT — 請參閱 [LICENSE](LICENSE)。
