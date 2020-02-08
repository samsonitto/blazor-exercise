# Sisällysluettelo

* [Tehtävänanto](#tehtavananto)
* [Käytetyt teknologiat](#kaytetyt-teknologiat)
* [Yheenveto](#yhteenveto)
    * [Kohdatut ongelmat](#kohdatut-ongelmat)
    * [Paranneltavaa](#paranneltavaa)

# Tehtävänanto

## Blazor & .NET Core Exercise
The point of this exercise it to create an ASP.NET Core 3 based website which displays football match
results using Blazor.
The data for the site is available from the following API:
https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json

### Functional Requirements
The web app should include two web pages: One for showing a list of matches and one for showing details
of a single match. For both pages, clean and modern UI is preferred though not required.

#### List of matches
The list view (which can be implemented as a table or as a list of some sorts) should contain all the matches
available from the API. The following info should be available for each match: Date, Teams, Score.
The match in the list view should be clickable or each match should contain “Details”-button. When user
clicks the match/the details button, web app should move to the match details page.
Optionally, the user should be able to filter the match list using a single textbox. In the textbox user could
write the name of the team (or part of it), for example “IFK” and the list would filter out all the games
except those where “IFK Mariehamn” or “HIFK” has played.

#### Details of a single match
The details page of a single match should contain the following information about the selected match:
Date, Teams, Team Logos, Score, List of match events (EventMinute, EventTypeIcon and Description is
enough).

### Implementation
Required technologies are C# and ASP.NET Core 3’s Blazor. You can create a single web app which handles
everything, or you can split the app into two ASP.NET Core projects: One for the backend (Web Api server)
and one for the UI (Blazor).

Tests are optional.

It’s OK to use 3rd party libraries and Nuget packages. You can use CSS frameworks if you want. Blazor
templates by default use Bootstrap 4.

### Tools
JSONLint can be used to understand the structure of the data:
https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json.
Latest version of Visual Studio 2019 is needed. Community Version is available for free. Blazor
documentation is available from https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-
3.0

### Publishing the Exercise
Version control is part of this practice so application is returned using Github. You can either use a Public repository or a Private repository:

#### Public repository
1. Publish the results into a public repository.
2. Send the link to the repository to ura@adafy.com

#### Private repository
1. Publish the results into a private repository
2. Invite “mikoskinen” and “panuoksala” as collaborators to the repository (Settings - Collaborators

If you have any questions, please send an email to ura@adafy.com.

# Käytetyt teknologiat

* Visual Studio 2019
* Blazor
* ASP.NET Core 3
* C#
* HTML
* Bootstrap 4
* DigitalOcean Ubuntu 18.04 Virtual Machine
* Apache 2 server

# Yhteenveto

## Kohdatut ongelmat

## Paranneltavaa