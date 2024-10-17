# AI Powered Coding - Live Course

This repository is used as part of an [O'Reilly](https://www.oreilly.com/) live
course named **AI-powered-Coding**, idealized by [Fernando J Vieira](https://www.linkedin.com/in/fernandojvieira/).

The proposed exercises are meant to be used as part of the course, being the code
(with its imperfections) created only for educational purposes.

## Setup

- If you have a GitHub Copilot license, enjoy the convenience of GitHub Codespaces (60
free hours per month for a 2-core instance). Simply create a new Codespace from the
repository, ensuring you select the correct branch before proceeding.
  - **Sometimes is necessary to run the build task once the Codespace finishes its initialization.**

- If you prefer local development or want to try another AI assistant, follow these steps:
  - Install [.NET 8.0 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0).
  - Have Visual Studio Code  with the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit).
  - For AI assistance: Install extensions for your preferred tool (e.g., Copilot, Codeium, Tabnine) and sign in if needed.

## Exercises

- Explain:
  - [A](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\explain\A.cs)
  - [B](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\explain\B.cs)
- Write:
  - [DNA](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\write\DNA.cs) and [DNATest](AI-Powered-Coding.Test\test\com\fjvieira\aipoweredcoding\write\DNATest.cs)
  - [LoyaltyProgram](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\write\LoyaltyProgram.cs) and [LoyaltyProgramTest](AI-Powered-Coding.Test\test\com\fjvieira\aipoweredcoding\write\LoyaltyProgramTest.cs)
- Unit testing:
  - [CarRules](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\unittesting\CarRules.cs) and [CarRulesTest](AI-Powered-Coding.Test\test\com\fjvieira\aipoweredcoding\unittesting\CarRulesTest.cs)
- TDD:
  - [SingleStreetController](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\tdd\SingleStreetController.cs) and[SingleStreetControllerTest](AI-Powered-Coding.Test\test\com\fjvieira\aipoweredcoding\tdd\SingleStreetControllerTest.cs)
  - [RiskAnalisys](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\tdd\RiskAnalisys.cs) and [RiskAnalisysTest](AI-Powered-Coding.Test\test\com\fjvieira\aipoweredcoding\tdd\RiskAnalisysTest.cs)
  - [LoyaltyProgramRules](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\tdd\LoyaltyProgramRules.cs) and [LoyaltyProgramRulesTest](AI-Powered-Coding.Test\test\com\fjvieira\aipoweredcoding\tdd\LoyaltyProgramRulesTest.cs)
  - [Insurance](AI-Powered-Coding.App\src\com\fjvieira\aipoweredcoding\tdd\Insurance.cs) and [InsuranceTest](AI-Powered-Coding.Test\test\com\fjvieira\aipoweredcoding\tdd\InsuranceTest.cs)
