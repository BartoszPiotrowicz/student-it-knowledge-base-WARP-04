# Bash cheatsheet

## pwd
Wyświetlanie ścieżki bieżącego katalogu.

Przykład: 
```
pwd
```

## ls
Listowanie plików, także ukrytych, w formacie szczegółowym.

Przykład:
```
ls -la
```

## cd
Przechodzenie do katalogu i katalogu nadrzędnego.

Przykład:
```
cd /docs/warp
```

## mkdir
Tworzenie katalogu wraz z brakującymi katalogami nadrzędnymi.

Przykład: 
```

mkdir -p docs/warp
```

## touch
Tworzenie pustego pliku lub aktualizacja czasu jego modyfikacji.

Przykład:
```
touch git.md
```

## cp
Kopiowanie pliku (opcja -r dla katalogów)

Przykład: 
```
cp git.md git-backup.md
```

## mv
Przenoszenie i zmiana nazwy pliku.

Przykład: 
```
mv git-backup.md archive.md
```

## rm
Usuwanie pliku i ostrzeżenie, że operacja omija kosz.

Przykład: 
```
rm archive.md
```

## cat
Wyświetlanie zawartości pliku w terminalu.

Przykład: 
```
cat git.md
```

## clear
Czyszczenie widoku terminala bez usuwania historii poleceń.

Przykład:
```
clear
```