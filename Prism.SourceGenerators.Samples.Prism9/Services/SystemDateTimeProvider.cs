namespace Prism.SourceGenerators.Samples.Prism9.Services;

public sealed partial class SystemDateTimeProvider : IDateTimeProvider
{
    public DateTimeOffset Now => DateTimeOffset.Now;
}
