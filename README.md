# TalentEase

TalentEase is an HR Management tool designed to streamline and simplify HR processes. Currently it shows and display a table list of employees. 

### Tech Stack 
- Server: ASP.NET Core Web Api
- Client: Blazor WebAssembly Standalone App
- UI: Blazor Bootstrap 3.0.0
- Other: .NET 8, Entity Framework

### Installation Instructions

1. **Clone the Repository**:
   ```bash
   git clone <repository-url>
   ```

2. **Set Up Database and Connection String**:
   - Configure your database and connection string in the appsettings.json. You can name your connection string anything you like. For example, `HRData`.
   - Make sure to add appsettings.json to .gitnore for security reasons. I left it in the repository so that whoever clones it would not have to create a new one. 

3. **Set Application Target to Multiple**:
   - Ensure that both the client and API are set to run simultaneously.
   - Set startup project to multiple and the action to start or both

4. **Build and Run the Application**:
   - Build the project and run the application.

### Example Connection String Configuration

In your `appsettings.json` file, configure the connection string as follows:
```json
{
  "ConnectionStrings": {
    "HRData": "YourConnectionStringHere"
  }
}
```

### Running the Application

Press start or cntrl + f5 in VS

