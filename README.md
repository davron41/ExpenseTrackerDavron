# 💰 ExpenseTracker

## 📖 Description

**ExpenseTracker** is a powerful web application designed to help you effectively track your expenses and income. With features like wallet management, expense categorization, and secure transfers, managing your finances has never been easier! 🌟

## 🌟 Key Features

- **Expense and Income Tracking**: Easily add and view your expenses and income.
- **Wallet Creation**: Create and manage multiple wallets for different purposes.
- **Expense Categorization**: Assign categories to your expenses for better financial insights.
- **Transfers Between Wallets**: Perform seamless transfers between different wallets. 🔄
- **Authentication and Authorization**: Secure your application with robust authentication and authorization mechanisms. 🔐
- **Email Notifications**: Receive notifications via email for important actions and updates. 📧

## ⚙️ Technologies Used

- **Frontend**: HTML, CSS, JavaScript
- **Backend**: ASP.NET Core MVC
- **Database**: Microsoft SQL Server (MS SQL)
- **ORM**: Entity Framework Core

## 🚀 Installation

To set up the project locally, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your_username/ExpenseTracker.git
2. **Navigate to the project folder:**
   ```bash
   cd ExpenseTracker
3. **Install the necessary dependencies:**
   ```bash
   # Run this command inside the project folder:
   dotnet restore
4. **Set up the database:**
   ```bash
   # 1.Update the connection string in the appsettings.json file to connect to your MS SQL database:
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=ExpenseTrackerDB;User Id=sa;Password=YourPassword;TrustServerCertificate=True;"
   }
   
   # 2.Then, apply migrations to create the database schema:
   dotnet ef database update
5. **Run the application:**
   ```bash
   dotnet run
## 🛠️ Usage

1. **Register or log in to your account.**
2. **Create wallets to manage your finances effectively.**
3. **Add income and expenses, categorizing them as needed.**
4. **Perform transfers between wallets for smooth financial management.**
5. **Enjoy email notifications for key actions and updates! 🎉**

## 🤝 Contributing

Contributions are welcome! If you would like to contribute to this project, please follow these steps:
1. **Fork the repository.**
   ```bash
   git clone https://github.com/your_username/ExpenseTracker.git
2. **Create a new branch for your feature or bug fix:**
   ```bash
   git checkout -b feature/YourFeature
3. **Make your changes and commit them:**
   ```bash
   git commit -m "Add your message here"
4. **Push your changes to your forked repository:**
   ```bash
   git push origin feature/YourFeature
4. **Create a pull request.**

## 📝 License
This project is licensed under the MIT License.
