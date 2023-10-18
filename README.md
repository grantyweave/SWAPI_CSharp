# SWAPI Planets Console App

The SWAPI Planets Console App is a simple C# application that retrieves and prints a list of planets from the Star Wars API (SWAPI). It uses the SWAPI API to fetch data and display planet information in the console.

## Prerequisites

Before running this application, make sure you have the following prerequisites installed:

- .NET Core SDK
- Visual Studio (optional but recommended for development)
- Newtonsoft.Json NuGet package (installed as described in the previous code example)

## Getting Started

1. Clone this repository to your local machine or download the source code.

2. Open the project in your preferred C# development environment, such as Visual Studio.

3. Ensure that you have installed the Newtonsoft.Json NuGet package, as shown in the code example.

4. Run the application to retrieve and print a list of planets from SWAPI.

## Usage

When you run the SWAPI Planets Console App, it will make an HTTP request to SWAPI to fetch a list of planets and display the following information for each planet:

- Name
- Climate
- Terrain

The information will be printed to the console.

## Example Output

Here's an example of what the output might look like:

```plaintext
List of Planets from SWAPI:
Tatooine
Alderaan
Yavin IV
Hoth
Dagobah
Bespin
Endor
Naboo
Coruscant
Kamino
```
## Customization

You can customize this application by modifying the code in the `Program.cs` file. For example, you can change the SWAPI URL or adapt the data model to retrieve and display additional planet information.

## Dependencies

- [Newtonsoft.Json](https://www.newtonsoft.com/json): A popular JSON parsing library for C# used to deserialize SWAPI's JSON responses.

## Acknowledgments

- SWAPI (Star Wars API) for providing the data used in this application.

Feel free to contribute to or modify this project as needed. If you encounter any issues or have suggestions for improvement, please open an issue or create a pull request.
