# Personal Expense Tracker

A comprehensive personal expense tracking application built with .NET Core MVC, featuring user authentication and PostgreSQL database integration via Supabase.

## Features

✨ **User Authentication**
- User registration and login
- Secure password requirements
- Session management with ASP.NET Core Identity

💰 **Expense Management**
- Create, read, update, and delete expenses
- Categorize expenses
- Add descriptions and dates
- Per-user data isolation

📊 **Analytics & Statistics**
- Total expense calculations
- Monthly and daily expense summaries
- Category-wise expense breakdown
- Monthly spending trends

🎨 **Modern UI**
- Bootstrap-based responsive design
- Clean and intuitive interface
- Mobile-friendly layout

## Technology Stack

- **Backend**: ASP.NET Core 8.0 MVC
- **Database**: PostgreSQL (Supabase)
- **ORM**: Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **Frontend**: Bootstrap 5, HTML5, CSS3
- **Icons**: Bootstrap Icons

## Prerequisites

- .NET 8.0 SDK
- PostgreSQL database (Supabase account recommended)
- Visual Studio 2022 or VS Code

## Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/RickDoyoonKim/dotnet-expense-tracker.git
   cd dotnet-expense-tracker
   ```

2. **Update connection string**
   - Open `PersonalExpenseTracker/appsettings.json`
   - Replace the placeholder connection string with your Supabase PostgreSQL connection string:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=your-supabase-host;Database=postgres;Username=postgres;Password=your-password;SSL Mode=Require;Trust Server Certificate=true"
     }
   }
   ```

3. **Install dependencies**
   ```bash
   cd PersonalExpenseTracker
   dotnet restore
   ```

4. **Run database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Run the application**
   ```bash
   dotnet run
   ```

6. **Access the application**
   - Open your browser and navigate to `https://localhost:5001`
   - Register a new account or login with existing credentials

## Project Structure

```
PersonalExpenseTracker/
├── Controllers/           # MVC Controllers
│   ├── AccountController.cs
│   └── ExpensesController.cs
├── Data/                 # Database Context
│   └── ApplicationDbContext.cs
├── Models/               # Entity Models
│   ├── ApplicationUser.cs
│   └── Expense.cs
├── ViewModels/           # View Models
│   ├── AccountViewModels.cs
│   └── ExpenseViewModel.cs
├── Views/                # Razor Views
│   ├── Account/
│   ├── Expenses/
│   └── Shared/
├── wwwroot/              # Static Files
├── Migrations/           # EF Core Migrations
├── Program.cs            # Application Entry Point
├── appsettings.json      # Configuration
└── PersonalExpenseTracker.csproj
```

## Key Features Explained

### User Authentication
The application uses ASP.NET Core Identity for secure user management:
- Password requirements (8+ characters, uppercase, lowercase, digit, special character)
- Secure cookie-based authentication
- User registration with email validation

### Expense Management
Each user can manage their personal expenses with:
- **Amount**: Decimal precision for accurate financial tracking
- **Category**: Organize expenses by type (Food, Transportation, Entertainment, etc.)
- **Description**: Optional notes for expense details
- **Date**: When the expense occurred
- **User Isolation**: Each user only sees their own expenses

### Database Design
- **UTC Date Handling**: All dates stored in UTC for consistency
- **Proper Relationships**: Foreign key constraints between users and expenses
- **Decimal Precision**: Accurate monetary value storage
- **Cascade Deletion**: User deletion removes associated expenses

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is open source and available under the [MIT License](LICENSE).

## Support

If you encounter any issues or have questions, please open an issue on GitHub.

---

**Built with ❤️ using .NET Core MVC**