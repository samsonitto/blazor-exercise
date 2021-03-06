## Info
* Tekijä: Samson Azizyan
* Versio: 0.1
* Linkki sovellukseen: http://blazor.codesamson.com

# Sisällysluettelo

* [Tehtävänanto](#tehtävänanto)
* [Käytetyt teknologiat](#käytetyt-teknologiat)
* [Yheenveto](#yhteenveto)
    * [Kohdatut ongelmat](#kohdatut-ongelmat)
    * [Käytetty aika](#käytetty-aika)

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
Kyseistä tehtävää oli mukavaa toteuttaa, tämän tapaiset projektit ovat minun suosikkeja. Blazor ja ASP.NET core olivat minulle ihan täysin uudet teknologiat. Kyseiset teknologiat ovat todella järkeviä ja niitä oli helppoa ja mukava opetella. Piti myös kerrata C#, koska viimeksi työskentelin C#:lla viime keväällä "Käyttöliittymien ohjelmointi" - kurssilla, kuitenkin kaikki palasi nopeasti mieleeni. Sain toteutettu toiminnallisuudet jo tehtävänannon vastaanottamisesta seuraavana päivänä. Sen jälkeen tuli omat koulutyöt vastaan, jouduin pitämään toteutuksesta taukoa. Toiminnallisuuden jälkeen parantelin käyttöliittymän ulkoasua, lisäsin virheiden käsittelyt ja ajoin yksikkötestit. Puskin säännöllisesti projektin GitHubiin. Toteutin sovelluksen englannin kielellä ja kommentit ovat myös englannin kielellä.

## Kohdatut ongelmat
* Käytin paljon aikaa html käyttöliittymän asetteluun.
* JSON rajapinnassa joissain otteluissa MatchEvents on tyhjä, siinä vaiheessa käyttäjälle tulostuu ottelusivulle ilmoitus: "This match does not have recorded match events".
* Sovelluksen julkaisu omalle DigitalOcean Ubuntu 18.04 Apache2 palvelimelle oli todella haastavaa, sain kuitenkin julkaistua. [Tästä pääsee sovellukseen.](http://blazor.codesamson.com) En saanut kuitenkaan valitettavasti lisättyä SSL-sertifikaattia. Olisi helpompaa julkaistaa Azureen. Täytyy tutustua ensin Azureen paremmin, jotta voi tulevaisuudessa julkaistaa sinne ASP.NET core sovelluksia. Tämä ei kuitenkaan kuulunut tehtävänantoon.

## Käytetty aika

| Osa-alue | Aika (h) | Muuta |								
|:-:|:-:|:-:|
| Toiminnallisuus | 4 ||
| Ympäristön opettelu ja C# kertaus | 3 ||
| Käyttöliittymä | 4 ||
| Yksikkötestit | 1 ||
| Virheiden käsittely | 0.5 ||
| Dokumentointi | 1 ||
| Sovelluksen julkaisu omalle palvelimelle | 3 | Ei kuulunut tehtävänantoon. http://blazor.codesamson.com |
| Yhteensä | 16.5 || 