Awesome! Here's a handy **.NET CLI Cheat Sheet** 📄 — with commonly used commands categorized for easy reference.

---

## ✅ **.NET CLI Cheat Sheet**

### 🔹 GENERAL

| Command | Description |
|--------|-------------|
| `dotnet --info` | Display installed SDKs and runtime info |
| `dotnet --version` | Show the current .NET SDK version |
| `dotnet help` | List available commands |

---

### 🆕 **PROJECT CREATION**

| Command | Description |
|--------|-------------|
| `dotnet new` | List all available templates |
| `dotnet new console` | Create a new console app |
| `dotnet new webapi` | Create a new Web API project |
| `dotnet new mvc` | Create an ASP.NET Core MVC project |
| `dotnet new classlib` | Create a class library |
| `dotnet new xunit` | Create a unit test project (xUnit) |
| `dotnet new sln` | Create a solution file |
| `dotnet new <template> -n <name>` | Specify project name |

---

### 🔧 **BUILD & RUN**

| Command | Description |
|--------|-------------|
| `dotnet build` | Compile the project |
| `dotnet run` | Run the app |
| `dotnet clean` | Clean the build output |
| `dotnet publish` | Compile and prepare app for deployment |

---

### 📦 **DEPENDENCY MANAGEMENT**

| Command | Description |
|--------|-------------|
| `dotnet restore` | Restore NuGet packages |
| `dotnet add package <pkg>` | Add a NuGet package |
| `dotnet remove package <pkg>` | Remove a package |
| `dotnet list package` | List installed packages |

---

### 🧪 **TESTING**

| Command | Description |
|--------|-------------|
| `dotnet new xunit` | Create test project (or use `mstest`/`nunit`) |
| `dotnet test` | Run unit tests in the project |

---

### 🗃️ **SOLUTION MANAGEMENT**

| Command | Description |
|--------|-------------|
| `dotnet new sln` | Create a new solution file |
| `dotnet sln <solution>.sln add <project>.csproj` | Add a project to solution |
| `dotnet sln <solution>.sln remove <project>.csproj` | Remove a project from solution |

---

### 🔍 **TOOL MANAGEMENT**

| Command | Description |
|--------|-------------|
| `dotnet tool list -g` | List globally installed tools |
| `dotnet tool install -g <tool>` | Install a global tool |
| `dotnet tool update -g <tool>` | Update a tool |
| `dotnet tool uninstall -g <tool>` | Remove a tool |

---

### 🌐 **ASP.NET CORE-SPECIFIC**

| Command | Description |
|--------|-------------|
| `dotnet watch run` | Watch for changes and auto-restart app |
| `dotnet dev-certs https --trust` | Trust HTTPS cert for local dev |
| `dotnet user-secrets init` | Initialize user secrets for project |
| `dotnet user-secrets set <key> <value>` | Add secrets securely |

---

### 🧳 **PUBLISHING**

| Command | Description |
|--------|-------------|
| `dotnet publish -c Release -o ./publish` | Publish app (Release mode) to folder |
| `dotnet publish -r win-x64 --self-contained` | Publish self-contained Windows app |

---

Want this as a downloadable PDF or printable one-pager with examples? Let me know, I can generate it for you!