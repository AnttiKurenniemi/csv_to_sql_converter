# CSV to SQL converter

C# class and a small sample app for converting CSV files to SQL clauses

Sometimes you just need to insert some data from a CSV file to a database.
Sometimes you just don't want to start scripting or making a big thing, you
just want some simple data in a database, plain and simple, and all you've got
is a CSV file (or an Excel file from which you can export to CSV). This app 
is my own little helper that I've used a bunch of times for just such a 
situation. Nothing fancy, it just takes a CSV file and generates SQL statements.

This app can convert a CSV file to a series of SQL clauses. You give it an SQL 
clause template with placeholders in the format of {0}, {1} and so on, which 
correspond to field index in a CSV file, and the app (class) goes through all
lines in the CSV document and generates an SQL clause from the template, with
values from the CSV document.

For example, consider the following CSV file:

```
ID;Company;City;Registration number;Contact person;Email
1;ACME Inc;New York;24354326;Daniel Wassup;daniel.wassup@acme.com
2;Muchos Burritos Ltd;Texas;962351233;Pedro Burrito;pedro.burrito@muchosburritos.com
3;Mom's Burrito Shack;Gainsville;23534643;Momma Murphy;momma.burrito@momsburrito.com
4;Arnold's Auto Repair and Demolition;Longgone;3456867;Ahnold Pencilneck;ahnold.pencilneck@autorepair.com
5;Backwater Boating Ltd;Hushington;34575967;Dave;dave@backwaterboating.com
```

If you want to insert companies to a database but only care about the name and
city, you could provide the following SQL template clause:

```
insert into company(name, city) values('{1}', '{2}')
```

And the app would generate the following bunch of SQL statements for you:

```
insert into company(name, city) values('ACME Inc', 'New York')
insert into company(name, city) values('Muchos Burritos Ltd', 'Texas')
insert into company(name, city) values('Mom''s Burrito Shack', 'Gainsville')
insert into company(name, city) values('Arnold''s Auto Repair and Demolition', 'Longgone')
insert into company(name, city) values('Backwater Boating Ltd', 'Hushington')
```

So basically it just does a bunch of string replace calls. About the only "clever" thing 
there is that it replaces single quotes with double quotes so as to not break the SQL.

All the actual work is done in the class `CSVtoSQLconvert`. If you want to use it in your
own app, just copy that class and that's all there is to it - no dependencies to anything
else.
