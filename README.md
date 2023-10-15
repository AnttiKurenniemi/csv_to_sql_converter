# CSV to SQL converter

C# class and a small app for converting CSV files to SQL clauses

This app can convert a CSV file to a series of SQL clauses. You give it an SQL 
clause template with placeholders in the format of {0}, {1} and so on, which 
correspond to field index in a CSV file, and the app (class) goes through all
lines in the CSV document and generates an SQL clause from the template, with
values from the CSV document.

