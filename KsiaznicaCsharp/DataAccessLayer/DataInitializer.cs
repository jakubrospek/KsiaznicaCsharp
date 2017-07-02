using KsiaznicaCsharp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KsiaznicaCsharp.DataAccessLayer
{
    public class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            SeedData(context);

            base.Seed(context);
        }

        private void SeedData(DataContext context)
        {
            var books = new List<Book>
            {
                new Book() { BookId=1, BookAuthor="Andrzej Sapkowski", BookTitle="Osatnie życzenie", BookCycle="Wiedźmin", BookVolume="1",
                BookTranslation="---", BookOriginalTitle="---", BookISBN="9788375780635", BookNrPages="332", BookGenre="fantasy", BookLanguage="polski",
                BookDescription=@"Później mówiono, że człowiek ów nadszedł od północy, od Bramy Powroźniczej. Nie był stary, ale włosy miał zupełnie 
                białe. Kiedy ściągnął płaszcz, okazało się, że na pasie za plecami ma miecz. Białowłosego przywiodło do miasta królewskie orędzie: trzy 
                tysiące orenów nagrody za odczarowanie nękającej mieszkańców Wyzimy strzygi. Takie czasy nastały. Dawniej po lasach jeno wilki wyły, teraz 
                namnożyło się rozmaitego paskudztwa – gdzie spojrzysz, tam upiory, bazyliszki, diaboły, żywiołaki, wiły i utopce plugawe. A i niebacznie uwolniony 
                z amfory dżinn, potrafiący zamienić życie spokojnego miasta w koszmar, się trafi. Tu nie wystarczą zwykłe czary ani osinowe kołki. Tu trzeba zawodowca. 
                WIEDŹMINA. Mistrza magii i miecza. Tajemną sztuką wyuczonego, by strzec na świecie moralnej i biologicznej równowagi.", BookCover="OstatnieZycenie.jpg"},

                new Book() { BookId=2, BookAuthor="Andrzej Sapkowski", BookTitle="Miecz przeznaczenia", BookCycle="Wiedźmin", BookVolume="2",
                BookTranslation="---", BookOriginalTitle="---", BookISBN="9788375780642", BookNrPages="400", BookGenre="fantasy", BookLanguage="polski",
                BookDescription=@"Wiedźmiński kodeks stawia tę sprawę w sposób jednoznaczny: wiedźminowi smoka zabijać się nie godzi. To gatunek zagrożony wymarciem. 
                Aczkolwiek w powszechnej opinii to gad najbardziej wredny. Na oszluzgi, widłogony i latawce kodeks polować przyzwala. Ale na smoki – nie. Wiedźmin Geralt 
                przyłącza się jednak do zorganizowanej przez króla Niedamira wyprawy na smoka, który skrył się w jaskiniach Gór Pustulskich. Na swej drodze spotyka trubadura 
                Jaskra oraz – jakżeby inaczej – czarodziejkę Yennefer. Wśród zaproszonych przez króla co sławniejszych smokobójców jest Eyck z Denesle, rycerz bez skazy i zmazy, 
                Rębacze z Cinfrid i szóstka krasnoludów pod komendą Yarpena Zigrina. Motywacje są różne, ale cel jeden. Smok nie ma szans.", BookCover="mieczPrzeznaczenia.jpg"},

                new Book() { BookId=3, BookAuthor="Andrzej Sapkowski", BookTitle="Krew elfów", BookCycle="Wiedźmin", BookVolume="3",
                BookTranslation="---", BookOriginalTitle="---", BookISBN="9788375780659", BookNrPages="340", BookGenre="fantasy", BookLanguage="polski",
                BookDescription=@"Andrzej Sapkowski, arcymistrz światowej fantasy, zaprasza do swojego Neverlandu i przedstawia uwielbianą przez czytelników 
                i wychwalaną przez krytykę wiedźmińską sagę! Tako rzecze Ithlinne, elfia wieszczka i uzdrowicielka: Drżyjcie, albowiem nadchodzi Niszczyciel 
                Narodów. Stratują waszą ziemię i sznurem ją podzielą. Miasta wasze zostaną zburzone i pozbawione mieszkańców. Nietoperz i kruk w domach waszych 
                zamieszkają, drzewo straci liść, zgnije owoc i zgorzknieje ziarno. Zaprawdę powiadam wam, oto nadchodzi czas miecza i topora, wiek wilczej zamieci. 
                Miasto płonie, wąskie uliczki zieją ogniem i żarem. Narasta wrzask, odgłosy zajadłej walki, murem wstrząsają głuche uderzenia taranu. Krzyk, strach. 
                Obezwładniający, paraliżujący, duszący strach.", BookCover="KrewElfów.jpg"},

                new Book() { BookId=4, BookAuthor="Andrzej Sapkowski", BookTitle="Czas pogardy", BookCycle="Wiedźmin", BookVolume="4",
                BookTranslation="---", BookOriginalTitle="---", BookISBN="8370540910", BookNrPages="318", BookGenre="fantasy", BookLanguage="polski",
                BookDescription=@"Świat Ciri i wiedźmina ogarniają płomienie. Nilfgaard najeżdża na sprzymierzone królestwa. Czy spełni się złowroga przepowiednia? 
                Ta proza pójdzie dalej w świat, już tam wystartowała. Odwołuje się przecież do tęsknot, emocji i wartości wspólnych; w swojej klasie jest znakomita i niepowtarzalna... 'Polityka' 
                Chandler zrobił z kryminału moralitet, powieść psychologiczną. Sapkowski podobnie - z opowieści o walkach ze smokami stworzył literaturę najwyższej klasy.", BookCover="czasPogardy.jpg"},

                new Book() { BookId=5, BookAuthor="	Bernard Cornwell", BookTitle="Ostatnie Królestwo", BookCycle="Wojny Wikingów", BookVolume="1",
                BookTranslation="Amanda Bełdowska", BookOriginalTitle="The Last Kingdom", BookISBN="9788362329076", BookNrPages="544", BookGenre="historia", BookLanguage="polski",
                BookDescription=@"Wyspy brytyjskie, dziewiąty wiek, czas wewnętrznych niepokojów, głodu i bezpardonowej walki o władzę. Czas największego najazdu Wikingów w historii. 
                Syn jednego z angielskich wielmożów, Uther, zostaje porwany w wieku 10 lat. Jako jedyny ocalały z pogromu całego rodu dorasta wśród szczęku mieczy, pod czułą opieką śmiertelnych wrogów. 
                Choć nauczył się żyć w zgodzie z zasadami Wikingów, w głębi duszy pozostaje synem Brytanii. Na jego oczach upadają kolejne królestwa, dokonują się zdrady, przewroty i krwawe rzezie… 
                Pewnego dnia będzie musiał podjąć decyzję, kim jest i któremu panu będzie służył. Los zwiąże go z Alfredem, władcą ostatniego opierającego się Wikingom królestwa, i da sposobność, by stawił czoła legendarnym wikińskim wojom, 
                przed którymi drży cała średniowieczna Europa. Spętany więzami honoru, lojalności i miłości, Uther stanie się tym, od którego zależeć będą losy całej Brytanii. Cornwell zanurza czytelnika w okrutnym świecie Ragnara, Ubby i innych 
                legendarnych wikińskich wojów, przed którymi drży cała Europa. Kolejnym tomem w cyklu jest Zwiastun burzy.", BookCover="OK.jpg"}
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}