# Seminarski rad - Objektno orijentirano modeliranje
## Metoda predloška (Template Method) za logiranje poruka u različitim formatima

Treba napraviti dvije klase: TextLogger i XmlLogger koje će omogućavati zapisivanje log poruka u tekstovnom obliku, npr.:

``` console
Log: Information, 2020-05-02 23:22:11, Enter function A 
Log: Error, 2020-05-02 23:22:15, Function A failed
```
odnosno u XML formatu:

``` console
<log type="Information" datetime="2020-05-02 23:22:11">Enter function A</log>
<log type="Error" datetime="2020-05-02 23:22:15">Function A failed</log>
```

Datum i vrijeme su trenutni datumi (u trenutku zapisivanja poruke). 
Definirati baznu apstraktnu klasu Logger u kojoj su postavljeni osnovni koraci pri zapisivanju poruke, 
a izvedene klase TextLogger i XmlLogger trebaju samo implementirati specifične korake algoritma. 
Napraviti oglednu aplikaciju koja će omogućiti provjeru funkcionalnosti.
