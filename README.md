# MzTabM DataModel

A C# data model library for mzTab-M format, providing strongly-typed classes for metabolomics data exchange.

## Installation

### From NuGet.org (Stable Releases)

Install the stable package from NuGet:

```bash
dotnet add package MzTabM.DataModel
```

Or via Package Manager Console:

```powershell
Install-Package MzTabM.DataModel
```

### From GitHub Packages (Development Versions)

Development versions are automatically published to GitHub Packages on every push to the main branch. To use development packages:

1. Add the GitHub Packages source to your project:

```bash
dotnet nuget add source --username YOUR_GITHUB_USERNAME --password YOUR_GITHUB_TOKEN --store-password-in-clear-text --name github "https://nuget.pkg.github.com/kozo2/index.json"
```

2. Install the development package:

```bash
dotnet add package MzTabM.DataModel --version "1.0.0-dev.*" --source github
```

Note: Replace `YOUR_GITHUB_USERNAME` and `YOUR_GITHUB_TOKEN` with your GitHub credentials. The token needs the `read:packages` scope.

## Usage

### Basic Serialization and Deserialization

```csharp
using MzTabM.Model;
using System.Text.Json;

// Create an MzTab object
var mzTab = new MzTab
{
    Metadata = new Metadata
    {
        Prefix = Prefix1.MTD,
        MzTabVersion = "2.0.0-M",
        MzTabID = "MTBLS1234",
        // ... other properties
    },
    SmallMoleculeSummary = new List<SmallMoleculeSummary>(),
    SmallMoleculeFeature = new List<SmallMoleculeFeature>(),
    SmallMoleculeEvidence = new List<SmallMoleculeEvidence>()
};

// Serialize to JSON
string json = mzTab.ToJson();

// Deserialize from JSON
MzTab deserializedMzTab = MzTab.FromJson(json);
```

### Using Extension Methods

The library provides extension methods for JSON serialization that work with any model class:

```csharp
// Serialize any model object
var contact = new Contact 
{ 
    Name = "John Doe", 
    Email = "john@example.com" 
};
string contactJson = contact.ToJson();

// Deserialize
Contact deserializedContact = contactJson.FromJson<Contact>();
```

### Custom JSON Options

You can provide custom JSON serialization options:

```csharp
var options = new JsonSerializerOptions
{
    WriteIndented = false,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

string json = mzTab.ToJson(options);
```

## Model Structure

The library includes all mzTab-M data model classes:

- **MzTab**: Main container class
- **Metadata**: Metadata information including samples, assays, and study variables
- **SmallMoleculeSummary**: Summary information for identified small molecules
- **SmallMoleculeFeature**: Feature-level information
- **SmallMoleculeEvidence**: Evidence supporting identifications
- Supporting classes for parameters, instruments, samples, etc.

## Features

- Strongly-typed C# classes generated from mzTab-M OpenAPI specification
- Built-in JSON serialization/deserialization support
- Data validation attributes
- Nullable reference types support
- .NET Standard 2.0 compatible

## Requirements

- .NET Standard 2.0 or higher
- System.Text.Json 6.0.0 or higher
- System.ComponentModel.Annotations 5.0.0 or higher

## License

This project is licensed under the Apache License 2.0 - see the LICENSE file for details.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Related Links

- [mzTab-M Specification](https://github.com/HUPO-PSI/mzTab)
- [Metabolomics Workbench](https://www.metabolomicsworkbench.org/)
