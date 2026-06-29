# TDD Bank Account - Group Activity

Group project: build a `BankAccount` class in C# using test-driven development (Red-Green-Refactor) with NUnit. Submitted for the *TDD Bank Account Class Activity - Group* assignment in *Programming in C#*.

## Requirements

- All C# files compiled using `dotnet`
- Projects built with .NET 10 SDK
- Tests written and run with **NUnit** (`dotnet test`)

## TDD Workflow

For every behavior, follow **Red → Green → Refactor**:

1. **Red** — write the smallest failing test in `tests/BankAccount.Tests/`.
2. **Green** — add the minimum code in `src/BankAccount/BankAccount.cs` to make it pass.
3. **Refactor** — clean up while green, then move to the next test.

Run a single test cycle:
```bash
dotnet test
```

## Project Structure

```
csharp-tdd-bankaccount/
├── BankAccount.slnx
├── README.md
├── .gitignore
├── misc/
│   ├── TDD_Bank_Account_Class_Activity_Group.md   # Canvas assignment spec
│   └── Group_Activity_BankAccount.txt             # Original activity brief
├── src/
│   └── BankAccount/
│       ├── BankAccount.cs                         # Production class (TDD-driven)
│       └── BankAccount.csproj
└── tests/
    └── BankAccount.Tests/
        ├── BankAccountTests.cs                    # NUnit test suite (you write this)
        └── BankAccount.Tests.csproj
```

## BankAccount Class Spec

Methods to implement (test-first):

- `Deposit(decimal amount)` — increases the balance.
- `Withdraw(decimal amount)` — decreases the balance.
- `GetBalance()` — returns the current balance.

Business rules (must be enforced and covered by tests):

- **No negative deposits** — `Deposit` with `amount <= 0` is rejected.
- **No negative withdrawals** — `Withdraw` with `amount <= 0` is rejected.
- **No overdrafts** — `Withdraw` cannot exceed the current balance.

## Quick Start

```bash
dotnet build
dotnet test
```

## Group Submission Checklist

See `misc/TDD_Bank_Account_Class_Activity_Group.md` for the full deliverable list. Summary:

- [ ] GitHub repo link accessible
- [ ] Video recording link accessible
- [ ] Task Allocation Tracker filled in (group leader has edit access, others have comment access)
- [ ] All NUnit tests pass
- [ ] All business rules covered by tests
