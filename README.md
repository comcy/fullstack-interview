# fullstack-interview
A sample project to use for challenging some volunteers during job interviews.

## Aufgabe

Die Aufgabe des Entwicklers ist das Erstellen eines Frontends mit Hilfe des Angular Frameworks für eine bereits existierende Backend-Lösung, die zur Verwaltung von Protokollen dient, sowie die Erweiterung des Backends.

Im Detail soll das Frontend folgende Anforderungen erfüllen:
  - Eine Ansicht für den Benutzer um alle vorhandenen Datensätze zu sichten
    * Es sollen Metdaten der Protokolle in Tabellen (auch ein  Grid ist denkbar)-Format dargestellt werden
    * Die Tabelle soll über Metadaten filter- und sortierbar sein
    * Das Laden sehr vieler Daten soll durch eine Pagination / Infinite scrolling gestützt werden
  - In der letzten Spalte der Tabelle befinden sich zwei Marker (Icon oder Text) mit denen der Benutzer die folgenden zwei Aktionen ausführen kann:
    - Löschen eines Datensatzes
    - da zu jedem vorhandenem Datensatz jeweils ein PDF-Dokument gehört, soll der Benutzer hier die Möglichkeit zum Öffnen des PDFs in einer Webansicht haben
  - Der Benutzer soll die Möglichkeit haben einen Datensatz im Detail zu betrachten. Dazu soll beim Klick auf den Namen eines Datensatz eine neue Seite erscheinen die detailierte Informationen zum Datensatz darstellt _(Felder können frei gewählt werden)_

Das Backend soll um folgende Funktionen erweitert werden:
  - Der Benutzer hat die Möglichkeit nach einem Datensatz zu suchen (vereinfacht bspw. über den Namen oder die anderen vorhandenen Werte). Dazu befindet sich ein Suchfeld über der Tabelle
  - Den bereits vorhandenen Endpunkt \protocols erweitern um ein bestimmtes Protokoll abzufragen -> \protocols\1 für das Protokoll mit ID 1
  - Einen Endpunkt hinzufügen (Name beliebig wählbar) um das PDF Dokument abfragen zu können
  
  Optional:
  - Einen einfachen Benutzerlogin realisieren damit nur noch angemeldete Benutzer auf die API zugreifen können. Ein Denmobenutzer reicht aus
  - Fehlerhandling wie zB ein 404 Response wenn die API mit \protocols\7 aufgerufen wird
 
## Hilfsmittel

- Alle "Bordmittel" des Angular-Frameworks
- Lizenzrechtlich nicht in Konflikt stehende Komponenten- und/oder Style Frameworks
-    
