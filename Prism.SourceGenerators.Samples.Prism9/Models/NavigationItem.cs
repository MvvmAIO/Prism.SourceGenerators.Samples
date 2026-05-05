namespace Prism.SourceGenerators.Samples.Prism9.Models;

/// <summary>Sidebar entry; <see cref="Key"/> matches the string passed to <c>RegisterForNavigation</c> in <c>App.RegisterTypes</c>.</summary>
public sealed record NavigationItem(string Key, string Title, string Description);
