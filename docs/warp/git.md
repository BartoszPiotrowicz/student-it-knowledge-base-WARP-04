# Git cheatsheet

## git clone
Pobranie repozytorium i utworzenie lokalnego katalogu.

Przykład:
```
git clone URL
```

## git status
Sprawdzenie gałęzi oraz plików zmienionych i przygotowanych.

Przykład: 
```
git status
```

## git add
Dodanie konkretnego pliku do obszaru staging.

Przykład: 
```
git add docs/warp/git.md
```

## git commit
Zapis przygotowanych zmian z czytelnym komunikatem.

Przykład: 
```
git commit -m "docs: add Git cheatsheet"
```

## git push
Publikacja nowej gałęzi i ustawienie śledzenia.

Przykład: 
```
git push -u origin feature/git-cheatsheet
```

## git pull
Pobranie zmian bez tworzenia nieoczekiwanego merge commita.

Przykład: 
```
git pull --ff-only origin main
```

## git fetch
Pobranie informacji o zmianach bez modyfikowania plików roboczych.

Przykład: 	
```
git fetch origin
```

## git branch
Wyświetlenie lokalnych gałęzi i oznaczenie aktywnej.

Przykład: 
```
git branch
```

## git switch
Utworzenie gałęzi roboczej i przełączenie na nią.

Przykład:

```
git switch -c feature/nazwa
```

## git log
Skrócony podgląd pięciu ostatnich commitów.

Przykład:

```
git log --oneline -5
```