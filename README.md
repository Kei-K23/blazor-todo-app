# Blazor Todo App

## Overview

This is a simple Todo application built with Blazor Server (.NET 8) that allows users to manage their tasks effectively. The app supports adding, editing, deleting, and marking tasks as complete or incomplete. It also provides filtering options to view all tasks, only completed tasks, or only incomplete tasks.

## Features

- **Add Todos**: Users can add new tasks with a title, description, and due date.
- **Edit Todos**: Users can edit the details of an existing task.
- **Delete Todos**: Users can remove tasks that are no longer needed.
- **Mark as Complete/Incomplete**: Users can toggle the completion status of tasks.
- **Filter Todos**: Users can filter tasks by their completion status:
  - **All**: Shows all tasks.
  - **Not Complete**: Shows only tasks that are not completed.
  - **Completed**: Shows only completed tasks.

## Technologies Used

- **Blazor Server**: The app is built using Blazor Server, a web framework for building interactive web UIs using C# and .NET.
- **.NET 8**: The latest version of the .NET framework.
- **C#**: The programming language used to implement the app's functionality.
- **TailwindCSS**: For styling the user interface.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine.

### Running the App

1. Clone the repository:

```bash
git clone https://github.com/Kei-K23/blazor-todo-app.git
```

2. Navigate to the project directory:

```bash
cd blazor-todo-app
```

3. Run the application:

```bash
dotnet run
# Or
dotnet watch
```

### Docker Support

You can also run the application in a Docker container. Follow these steps:

1. Build the Docker image:

```bash
docker build -t blazor-todo-app .
```

2. Run the Docker container:

```bash
docker run -d -p 5000:80 --name blazor-todo-app blazor-todo-app
```

## Customization

You can easily customize the application by modifying the Razor components, services, or models to fit your specific requirements.

## Contributing

If you'd like to contribute to this project, feel free to fork the repository and submit a pull request. Contributions are welcome!

## License

This project is licensed under the MIT License. See the [LICENSE](/LICENSE) file for more details.
