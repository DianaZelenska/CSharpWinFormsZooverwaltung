# Zooverwaltung-Projekt in C#
Ein WinForms-Projekt zur Verwaltung eines Zoos, inklusive Kontinente, Tierarten, Gehege, Tiere und Pfleger. Das System basiert auf einer relationalen Datenbank mit mehreren Tabellen und unterstützt CRUD-Funktionalitäten.

## Funktionen
- **Kontinente**: Hinzufügen, Bearbeiten, Löschen
- **Tierarten**: Hinzufügen, Bearbeiten, Löschen
- **Pfleger**: Hinzufügen, Bearbeiten, Löschen
- **Gehege** (mit Fremdschlüssel zur Kontinente): Hinzufügen, Löschen
- **Tiere** (mit Fremdschlüssel zur Gehege, Tierarten): Hinzufügen, Löschen
- **Gehege-Pfleger** (mit Fremdschlüssel zur Gehege, Pfleger): Zuordnung von Pflegern zu Gehegen (Hauptfleger ja/nein)

## Datenbank
SQL-Datei zur Erstellung der Tabellen befindet sich im Ordner `sql`.

## Technologien
- Sprache: C#
- GUI: Windows Forms
- Datenbank: MySQL
- Visual Studio

## Start
1. Datenbank einrichten
2. Projekt in Visual Studio öffnen und starten



