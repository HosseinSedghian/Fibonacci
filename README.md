## Fibonacci Console Application

This is a simple C# console application that generates a Fibonacci sequence up to a specified number of terms. The application prompts the user to enter the number of terms they wish to generate and then outputs the sequence to the console.

### Features

- **User Input**: The application allows the user to specify the number of terms in the Fibonacci sequence.
- **Dynamic Calculation**: It calculates the Fibonacci sequence dynamically using a list to store the sequence.
- **Console Output**: Outputs the sequence in a comma-separated format.

### Getting Started

To get started with this application, you need to have .NET installed on your machine. Follow the instructions below to run the application.

#### Prerequisites

- .NET SDK

#### Running the Application

1. **Clone the Repository**: Clone this repository to your local machine using:
   ```bash
   git clone <repository-url>
   ```

2. **Navigate to the Project Directory**: 
   ```bash
   cd <repository-directory>
   ```

3. **Build the Application**: Run the following command to build the application:
   ```bash
   dotnet build
   ```

4. **Run the Application**: Execute the application using:
   ```bash
   dotnet run
   ```

5. **Enter the Number of Terms**: When prompted, enter the number of terms you want in the Fibonacci sequence.

### Example

```
Enter a number of sequences : 10
0, 1, 1, 2, 3, 5, 8, 13, 21, 34
```

### Code Explanation

- **Main Method**: The entry point of the application which handles user input and displays the Fibonacci sequence.
- **List<int> FiboList**: A list that stores the Fibonacci sequence.
- **Loop**: A `for` loop calculates each term in the sequence by summing the two preceding terms.

### Contributing

If you wish to contribute to this project, feel free to fork the repository and submit a pull request.

### License

This project is open-source and available under the [MIT License](LICENSE).

### Contact

For any questions or suggestions, please contact [Your Name] at [Your Email].
