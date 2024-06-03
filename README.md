# Dating Chat Application

## Description

A modern dating chat application built using Angular for the frontend and .NET Core for the backend. The application allows users to create profiles, match with other users, and chat in real-time.

## Features

- User authentication and authorization
- Profile creation and editing
- Matching algorithm to find potential matches
- Real-time chat functionality
- Notifications for new matches and messages
- User-friendly and responsive UI

## Technologies Used

### Frontend

- Angular
- TypeScript
- HTML5
- CSS3
- Angular Material

### Backend

- .NET Core
- ASP.NET Core Web API
- Entity Framework Core
- SignalR (for real-time chat)
- SQL Server

## Prerequisites

Before you begin, ensure you have met the following requirements:

- Node.js and npm installed
- Angular CLI installed
- .NET Core SDK installed
- SQL Server installed and running

## Installation

### Backend

1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/dating-chat-app.git
2. Navigate to the backend directory
   
cd dating-chat-app/backend

3. Restore the .NET Core dependencies
   ```sh
   dotnet restore

4. Update the appsettings.json file with your SQL Server connection string
  
      {
  "ConnectionStrings": {
    "DefaultConnection": "YourConnectionStringHere"
  }
}

5. Apply the database migrations:
   ```sh

    dotnet ef database update

 7. Run the backend server
    ```sh
    dotnet run
    
### Frontend

1. Navigate to the frontend directory:

2. Install Angular dependencies
   ```sh

   npm install

3. Run the frontend server
   ```sh
   ng serve

## Usage
- Open your web browser and navigate to http://localhost:4200.
- Register a new user account.
- Create and customize your profile.
- Start matching with other users and enjoy chatting!
Contributing
- Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

- Fork the Project
- Create your Feature Branch (git checkout -b feature/AmazingFeature)
- Commit your Changes (git commit -m 'Add some AmazingFeature')
- Push to the Branch (git push origin feature/AmazingFeature)
- Open a Pull Request
License
- Distributed under the MIT License. See LICENSE for more information.

## Acknowledgements
- Angular
- ASP.NET Core
- Entity Framework Core
- SignalR
- Angular Material

