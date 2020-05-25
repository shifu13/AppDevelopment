# AppDevelopment
 
#Github link
https://github.com/shifu13/AppDevelopment.git

#Link til youtube (fremvisning af produkt)
https://www.youtube.com/watch?v=jHyhU36SQJ4

## Beskrivelse af produktet
Produktet har til formål at vise data over Ringenes Herre ift. bøger, film, samt quotes.

#Mobile-dev-exam projekt beskrivelse 

#### 1. Der skal laves minimum en content page pr. gruppemedlem
Jeg har været alene om projektet

#### 2. Der skal udarbejdes en kort oversigt over, hvilke content pages der findes samt hvem der har lavet dem, som skal afleveres. Der skal noteres, hvilke af nedenstående point bliver opfyldt at hvilke content pages.
Der er udviklet følgende content pages:
* MainPage (Simon) - Benyttet XAML, navigation, crossplatform (baggrundsbillede)
* BookPage (Simon) - Databinding, navigation, opkobling til API, benyttet XAML
* MoviePage (Simon) - Databinding, Design impementering, benyttet XAML, navigation
* QuotePage (Simon) - Databinding, Design impementering, benyttet XAML, navigation
* MyMoviePageDetail (Simon) - benyttet XAML
* MyQuotePageDetail (Simon) - benyttet XAML
* FirstBook (Simon) - benyttet XAML, navigation

#### 3. Koden til projektet kan afleveres i git, anden versionsstyring eller link til filerne online
https://github.com/shifu13/AppDevelopment.git

#### 4a. Databinding
Databinding er blevet benyttet forskellige steder rundt omkring. Den primære databinding ligger i BookPage, da det er her man binder dataen fra sit API.

#### 4b. Opkobling til API
Der er blevet opkoblet til et API når man skal hente data fra listen af bøger. Der er så blevet opstillet statisk data til filmene og quotes, da jeg ikke kunne få authorization bearer token til at virke gennem postman. jeg fik det så til at virke meget sent gennem postman, og dermed ikke fået implementeret det - trods at det er en god idé ift. at hente data fra API.

#### 4c. Design implementering
Der er ikke blevet lavet det helt vilde design implementering, da projektet primært benytter visning af data gennem lister. Der kunne have været mere fokus på visningen af dataen ved det enkelte element i listen (når man ser detaljerne), men der har fokus været på at kunne hente den valgte data og smide ud.

#### 4d. Brugen af XAML i projektet
Der blevet benyttet større og mindre grad af XAML gennem hele projektet.

#### 4e. Crossplatform udvikling
Der er ikke blevet lavet det helt store crossplatform. Der er noget ved baggrundsbillede, ydermere har jeg prøvet at skrive noget internet permision under AndroidManifest.xml og kunne ikke finde stedet hvor man skrev det ved info.plist for IOS.

#### 4f. Navigation
Der er blevet benyttet Hierachical Navigation, hvor det bruges for at komme frem og tilbage mellem siderne. Der er blevet sendt data videre fra siderne ved Navigataion.PushAsync, hvor man har nogle forskellige parametere til næste side.
