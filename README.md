# MzTabM DataModel

A C# data model library for mzTab-M format, providing strongly-typed classes for metabolomics data exchange.

## Installation

Install the package from NuGet:

```bash
dotnet add package MzTabM.DataModel
```

Or via Package Manager Console:

```powershell
Install-Package MzTabM.DataModel
```

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
