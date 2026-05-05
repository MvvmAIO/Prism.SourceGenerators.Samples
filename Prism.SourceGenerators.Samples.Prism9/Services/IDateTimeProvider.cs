namespace Prism.SourceGenerators.Samples.Prism9.Services;

/// <summary>Sample clock abstraction registered in <c>App.RegisterTypes</c>.</summary>
public interface IDateTimeProvider
{
    DateTimeOffset Now { get; }
}
