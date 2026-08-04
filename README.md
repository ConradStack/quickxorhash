# QuickXorHash CLI

This project is a command line application that computes a hash value for binary or text files using the QuickXorHash algorithm.  The implementation here comes direct from [Microsoft docs](https://learn.microsoft.com/en-us/onedrive/developer/code-snippets/quickxorhash) (acccessed 2026-08-04).

## Getting Started

### Prerequisites

- .NET SDK (version 5.0 or later)

### Building the Project

To build the project, navigate to the project directory and run the following command:

```
dotnet build
```

### Running the Application

To run the application, use the following command:

```
dotnet run -- <path_to_file>
```

Replace `<path_to_file>` with the path to the binary or text file you want to hash.

### Example Usage

For example, to compute the hash of a file named `example.txt`, you would run:

```
dotnet run -- example.txt
```

### Output

The application will output the computed hash value in a hexadecimal format.

## License

This project is licensed under the MIT License. See the LICENSE file for details.