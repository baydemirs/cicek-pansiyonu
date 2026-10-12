# Çiçek Pansiyonu

**A Windows desktop application for guesthouse administration, built with C# and Windows Forms.**

Guest records · Room occupancy · Personnel · Stock and invoices · Customer messages

> This repository contains an existing desktop application and its MSI setup project. Build and runtime verification are currently incomplete; see [Known Limitations](#known-limitations) before using it with operational data.

## Project Overview

Çiçek Pansiyonu provides a Turkish-language interface for managing day-to-day guesthouse records. The application stores data in a user-selected SQLite database and uses DevExpress controls for its desktop interface.

This is a single WinForms application, not a web service. UI event handlers contain validation and direct ADO.NET database operations. The solution also includes a separate Visual Studio setup project for packaging the application.

## Features

The following workflows are present in the source code; they have not been verified end to end in this review:

- User login, account registration and security-question-based password recovery.
- Guest creation, listing, filtering, updating and deletion.
- Room pricing and occupancy display/update, with nine room records in the included database.
- Personnel records, working hours and wage calculations.
- Stock and invoice record management.
- Customer message creation, search, update and deletion.
- Music title/URL management and opening a selected URL in an embedded WebView2 control.
- Database file selection and a connection check at startup.

## Technologies Used

| Technology | Version / role |
| --- | --- |
| C# / Windows Forms | Windows desktop application; `WinExe` output |
| .NET Framework | **4.7.2**, traditional non-SDK `.csproj` |
| DevExpress | Primarily **21.2.6**; UI controls and referenced components |
| DevExpress Dashboard CustomItemExtension | **21.2.0.1**, declared package/reference |
| System.Data.SQLite | **1.0.119.0**, runtime database access |
| Microsoft WebView2 | **1.0.2903.40**, embedded browser |
| Entity Framework | **6.5.1**, declared references/provider configuration; the reviewed form workflows use direct SQLite commands |
| Newtonsoft.Json | **13.0.3**, declared dependency |
| NuGet | `packages.config`, 70 declared packages including framework support libraries |
| Visual Studio Installer Projects | `.vdproj` MSI setup project |

`packages.config` is the dependency inventory. A package being declared does not establish that every component is used by application workflows.

## Project Structure

```text
.
├── cicek-pansiyonu.sln             # Application + setup project
├── cicek-pansiyonu/               # C# WinForms application
│   ├── cicek-pansiyonu.csproj
│   ├── Program.cs                # Starts Form_AStarter
│   ├── ProgramDatabaseConfig.cs  # Database picker / connection setup
│   ├── Form_*.cs                 # UI workflows and database operations
│   ├── Form_*.Designer.cs        # Generated control definitions
│   ├── Form_*.resx               # Form resources
│   ├── Properties/               # Assembly, resources, settings, licenses
│   ├── Resources/                # Icons and illustrations
│   ├── *DataSet.*                # Legacy SQL Server typed datasets
│   ├── App.config
│   └── packages.config
├── Cicek Pansiyonu/               # Separate installer, not duplicate app code
│   └── Cicek Pansiyonu.vdproj
├── veritabanı/
│   ├── cicekpansiyon2024.db       # Existing SQLite database with records
│   └── cicekpansiyon2024.sqbpro   # DB Browser for SQLite project settings
└── docs/                         # Local only; excluded from publication
    └── REPOSITORY_REVIEW.md       # Review findings and verification (Turkish)
```

The setup project references the application project GUID and built output. Both projects belong to the solution and should be preserved. The two typed dataset families refer to different legacy SQL Server database names; they are not interchangeable copies of the SQLite database.

## Requirements

- Windows with the .NET Framework 4.7.2 runtime or a compatible later .NET Framework 4.x runtime.
- Visual Studio with the **.NET desktop development** workload and **.NET Framework 4.7.2 Developer/Targeting Pack** for compilation. The solution records Visual Studio 17 (2022) metadata.
- Authorized access to the DevExpress 21.2.6 assemblies/packages and the applicable development license. `Properties/licenses.licx` references DevExpress controls; `DevExpress.BonusSkins.v21.2` has no package `HintPath` and must resolve through an authorized installation or a reviewed reference fix.
- NuGet access to public packages and the authorized DevExpress package source, as needed. Keep feed credentials in your user configuration, outside Git.
- Microsoft Edge WebView2 Runtime for the embedded browser workflow.
- Visual Studio Installer Projects extension compatible with your IDE, **only if building the MSI**.

A modern .NET SDK alone does not replace the .NET Framework targeting pack. SQLite native/managed assembly architecture must match the application process; the current project contains an x86 SQLite reference despite AnyCPU configurations.

## Installation & Setup

1. Clone the repository and open its root:

   ```powershell
   git clone https://github.com/baydemirs/cicek-pansiyonu.git
   Set-Location cicek-pansiyonu
   ```

2. Install the development requirements above. Configure your authorized DevExpress package feed in Visual Studio's NuGet package settings, without committing its credentials.
3. Open `cicek-pansiyonu.sln`. If the setup project is unavailable, install the Installer Projects extension; the application `.csproj` can also be opened separately.
4. Restore NuGet packages. The application expects a `packages/` folder at repository root. With NuGet CLI installed, an alternative from the root is:

   ```powershell
   nuget restore .\cicek-pansiyonu.sln -PackagesDirectory .\packages
   ```

5. Set `cicek-pansiyonu` as the startup project. Use **Debug | Any CPU**, which is defined in the solution, and address the SQLite architecture issue described below if it prevents build or startup.
6. Create a private working copy of the database before running. The suggested `local-data/` directory is ignored by Git.

These are source-derived setup instructions, not a claim that a clean installation has passed.

## Database Configuration

The active workflows use SQLite. `Program.cs` starts `Form_AStarter`, which calls `ProgramDatabaseConfig.SelectAndInitializeDatabase()` and asks you to select a `.db` file. The selected path becomes `Data Source=<selected path>;Version=3;` for that process. Selection is repeated on the next launch; there is no configured server password or API key in this runtime connection string. `App.config` contains an empty `<connectionStrings />` element.

Use a **private copy** of `veritabanı/cicekpansiyon2024.db`, preferably under `local-data/`. The committed database contains populated account, recovery-answer, customer contact and identity fields. Their authenticity is unknown; treat them as sensitive and do not use the included accounts for operational access. No account credentials are documented here.

| SQLite table | Purpose |
| --- | --- |
| `Kullanıcılar` | Accounts, password values, recovery questions/answers and role field |
| `Müşteriler` | Guest identity/contact, assigned room, price and stay dates |
| `Odalar` | Room names, prices and occupancy |
| `Personel` | Personnel working hours, rates and employment dates |
| `Stok` / `Faturalar` | Stock and invoice records |
| `MüşteriMesajları` | Customer-linked messages |
| `Müzik` | Music titles and URLs |
| `GelirGider` | Income/expense schema and records; no dedicated UI workflow confirmed |

The `.sqbpro` file is a DB Browser for SQLite workspace, not the runtime database. SQL Server dataset artifacts remain in the project, but their generated connections have no connection string; they do not configure the active SQLite workflows. No standalone schema/seed migration script is supplied, so selecting an empty database is insufficient. The startup check opens the connection but does not validate required tables or migrate the schema.

## How to Run

In Visual Studio, build the **application project**, then press **F5** or **Ctrl+F5**. Select your private database copy when prompted; successful selection opens the login form.

From a Visual Studio Developer PowerShell, after restoring packages:

```powershell
MSBuild.exe .\cicek-pansiyonu\cicek-pansiyonu.csproj /t:Build /p:Configuration=Debug /p:Platform=AnyCPU
& .\cicek-pansiyonu\bin\Debug\cicek-pansiyonu.exe
```

The executable path follows the project's Debug output configuration. Run it only after a successful build. This traditional .NET Framework application is not set up for `dotnet run`.

For MSI packaging, use Visual Studio and the Installer Projects extension to build `Cicek Pansiyonu`. The setup project specifies `Debug/Cicek Pansiyonu.msi` and `Release/Cicek Pansiyonu.msi`; it also references an icon outside the repository (`Downloads/icon.ico`). Installer generation and installation have not been validated.

## Screenshots

No verified application screenshots were found. The PNG files under `Resources/` are UI assets and are not presented as screenshots. Capture actual running screens using synthetic data before adding images here.

## Known Limitations

- **Verification on 2026-10-12:** restore failed because access to the user NuGet configuration was denied in the review environment. An isolated configuration retry also remained blocked. Build failed with **MSB3644** because .NET Framework 4.7.2 reference assemblies were unavailable. No successful application or MSI build, UI run or end-to-end test is claimed.
- The checkout initially had no restored `packages/` directory; all 75 explicit DLL `HintPath` targets were absent. Dependency resolution, licensed components and compiler diagnostics beyond the initial build failure remain unverified.
- No automated test project was found. The existing database passed a read-only SQLite `quick_check`, but `foreign_key_check` returned **10 orphaned customer-message references**. No database records were modified.
- Account registration is reachable from login and creates `admin` records. Login does not enforce the role field. Password hashing uses unsalted SHA-256; the bundled password field contains mixed formats. Password recovery relies on stored answers and UI state rather than a verified account-bound authorization check at update time.
- Guest creation and occupancy updates are separate writes; concurrent room assignment and partial updates are possible. Database calls run synchronously in UI handlers, and several lists load all rows.
- SQLite packages include several overlapping variants; the direct SQLite DLL reference is x86, while the solution builds AnyCPU and the MSI targets x86. Architecture compatibility needs an explicit reviewed decision.
- Stored music URLs are opened without a scheme/host policy. Raw exception messages are shown to users in several workflows.
- No production deployment, data sanitization, multi-user load validation or full historical secret audit has been completed. A technical review is retained locally and is not included in the published repository.
