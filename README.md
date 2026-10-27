# QuickXorHash CLI

This project is a command line application that computes a hash value for binary or text files using the QuickXorHash algorithm.  The implementation here comes direct from [Microsoft docs](https://learn.microsoft.com/en-us/onedrive/developer/code-snippets/quickxorhash) (accessed 2026-08-04).

## Getting Started

### Prerequisites

- .NET SDK (version 5.0 or later)

### Building

To build the project, navigate to the project directory and run the following command:

```bash
dotnet build
```

### Test

To run the application, use the following command:

```bash
dotnet run -- <path_to_file>
```

Replace `<path_to_file>` with the path to the binary or text file you want to hash.

The application will output the computed hash value as a base64 string.

### Publish executable

Compile the application to a single, portable executable:

```bash
dotnet publish -c Release -r osx-arm64 --self-contained true

# Move to a PATH location e.g.,
cp bin/Release/net10.0/osx-arm64/publish/quickxorhash ~/bin/
```

