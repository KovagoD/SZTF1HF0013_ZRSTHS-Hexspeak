# SZTF1HF0013_ZRSTHS-Hexspeak

Ha bármilyen lefordított Java .class fájlt megnyitunk egy szövegszerkesztőben, akkor a fájl legelején
a ”CAFEBABE” varázsszót olvashatjuk hexadecimálisan. Ezt, vagyis, hogy a hexadecimális számokat
használunk szavak  írásához Hexspeak-nek nevezzük.

A tizenhatos (hexadecimális) sz ́amrendszer a 0, .., 9 sz ́amjegyeken k ́ıv ̈ul az A, B, C, D, E, F bet ̋uket
haszn ́alja, melyek seg ́ıts ́eg ́evel  ́abr ́azolhat ́ok a val ́os  ́es a komplex sz ́amok. P ́eld ́aul a 235D sz ́am
hexadecim ́alisan EBH , ugyanis 235 = 14 ∗ 16 + 11, ahol a 14-et az E, a 11-et a B bet ̋uvel kell  ́ırni.
Ebben a feladatban nyolc k ̈ul ̈onb ̈oz ̋o bet ̋ut kell haszn ́alni: az A - F bet ̋uk mellett a 0- ́as sz ́amjegyet
O bet ̋uk ́ent, az 1-es sz ́amjegyet pedig I bet ̋uk ́ent  ́ertelmezz ̈uk. Ez alapj ́an minden olyan sz ́o, amely
csak az ABCDEFIO bet ̋ukb ̋ol  ́all, hexadecim ́alis sz ́amk ́ent  ́ertelmezhet ̈unk. Az ilyen szavakat  ́erv ́enyes
Hexspeak szavaknak tekintj ̈uk.
A feladat, hogy az adott N sz ́amot konvert ́alja hexadecim ́alisra. Ha egy  ́erv ́enyes Hexspeak sz ́o
reprezent ́aci ́oj ́at kapja, akkor jelen ́ıtse meg, ellenkez ̋o esetben az error sz ́ot kell megjelen ́ıteni. M ́as
sz ́oval az error legyen az eredm ́eny, ha a bemeneti sz ́am hexadecim ́alis  ́abr ́azol ́asa a 2  ́es 9 k ̈oz ̈otti
sz ́amjegy valamilyen el ̋ofordul ́as ́at tartalmazza.
Bemenet (Console)
- a felhaszn ́al ́o  ́altal megadott egyetlen sz ́am, az N
Kimenet (Console)
- a felhaszn ́al ́o  ́altal megadott N sz ́amhoz tartoz ́o Hexspeak sz ́o (vagy az error, ha nem lehets ́eges
az  ́atalak ́ıt ́as)
Megk ̈ot ́es(ek)
- 1 ≤ N ≤ 1018
- N ∈ {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
- az N sz ́am nem tartalmaz vez ́erl ̋o null ́akat
