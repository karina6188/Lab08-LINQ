# Lab08-LINQ

## About This Program
LINQ in Manhattan

Author: Karina Chen

## Description
This program demonstrates how to use LINQ to get and transform data using query expressions. 

## Getting Started
Clone this repository to your local machine.

$ git clone [https://github.com/karina6188/Lab08-LINQ.git]

To run the program from Visual Studio:
Select File -> Open -> Project/Solution

Next navigate to the location you cloned the Repository.

Double click on the Lab08-LINQ directory.

Then select and open lab08-linq.

## To Run This Program
Open the program using Visual Studio and click "Start" button to run this program.

## Resource
Read JSON to file:
https://www.newtonsoft.com/json/help/html/DeserializeWithJsonSerializerFromFile.htm

## Visuals

Application Execution - Query all neighborhoods in the data file

![Alt execution capture](/captures/app_execution1.JPG)

Application Execution - Query neighborhoods that have names

![Alt execution capture](/captures/app_execution2.JPG)

Application Execution - Query neighborhoods without duplicates and sorted alphabetically

![Alt execution capture](/captures/app_execution3.JPG)

Application Execution - Use one single query to get all the results from above 3 queries

![Alt execution capture](/captures/app_execution4.JPG)

Application Execution - Use a LINQ query instead of a LINQ method to get all neighborhoods from the data file

![Alt execution capture](/captures/app_execution5.JPG)

## Change Log

1.1: Set up the program and added json file containing data. - 2019 Oct 24

1.2: Create classes for json data and add constructor functions. - 2019 Oct 24

1.3: Add codes to read json file and use deserializer to convert data into object. - 2019 Oct 24

1.4: Write a method called AllNeighborhoods() to query all neighborhoods are in the data. - 2019 Oct 24

1.5: Write a method called NeighborhoodsHaveName() to query neighborhoods that have names. - 2019 Oct 24

1.6: Add UniqueNeighborhoods() method to query neighborhoods that are not duplicated. - 2019 Oct 24

1.7: Add OneSingleQuery() and OpposingMethod() methods. - 2019 Oct 24

1.8: All the data results are successfully queried and printed to the console window. The program is completed. - 2019 Oct 28
