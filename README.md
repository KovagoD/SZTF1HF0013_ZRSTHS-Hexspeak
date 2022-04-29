# SZTF1HF0013_ZRSTHS-Hexspeak

Ha bármilyen lefordított Java .class fájlt megnyitunk egy szövegszerkesztőben, akkor a fájl legelején
a ”CAFEBABE” varázsszót olvashatjuk hexadecimálisan. Ezt, vagyis, hogy a hexadecimális számokat
használunk szavak  írásához Hexspeak-nek nevezzük.

A tizenhatos (hexadecimális) számrendszer a 0, .., 9 számjegyeken kívül az A, B, C, D, E, F betűket
használja, melyek segítségével  ábrázolhatók a valós  ́es a komplex számok. Például a 235D szám
hexadecimálisan EBH , ugyanis 235 = 14 ∗ 16 + 11, ahol a 14-et az E, a 11-et a B betűvel kell írni.

Ebben a feladatban nyolc különböző betűt kell használni: az A - F betűk mellett a 0-ás számjegyet
O betűként, az 1-es számjegyet pedig I betűként értelmezzük. Ez alapján minden olyan szó, amely
csak az ABCDEFIO betűkből áll, hexadecimális számként értelmezhetünk. Az ilyen szavakat érvényes
Hexspeak szavaknak tekintjük.

A feladat, hogy az adott N számot konvertálja hexadecimálisra. Ha egy érvényes Hexspeak szó
reprezentációját kapja, akkor jelenítse meg, ellenkező esetben az error szót kell megjeleníteni. Más
szóval az error legyen az eredmény, ha a bemeneti szám hexadecimális ábrázolása a 2 és 9 közötti
számjegy valamilyen előfordulását tartalmazza.

Bemenet (Console)
- a felhasználó által megadott egyetlen szám, az N

Kimenet (Console)
- a felhasználó által megadott N számhoz tartozó Hexspeak szó (vagy az error, ha nem lehetséges
az átalakítás)

Megkötés(ek)
- 1 ≤ N ≤ 1018
- N ∈ {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
- az N szám nem tartalmaz vezérlőnullákat

![image](https://user-images.githubusercontent.com/25224122/165916005-f3853afc-32f4-427d-8979-ac952afd02af.png)

