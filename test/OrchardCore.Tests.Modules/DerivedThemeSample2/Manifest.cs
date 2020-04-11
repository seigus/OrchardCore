using OrchardCore.DisplayManagement.Manifest;
using OrchardCore.Modules.Manifest;

[assembly: Theme(
    Name = "Derived Theme Sample 2",
    Author = "Nicholas Mayne",
    Website = ManifestConstants.OrchardCoreWebsite,
    Version = "2.0.0",
    Description = "Derived Theme Sample 2.",
    Category = "Test",
    BaseTheme = "BaseThemeSample2"
)]
