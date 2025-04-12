#Library Management System

A windows form application for managing books in a library. Built using C# and SQL server.

##USE!!!
-you'll be find out how to create connection string , write sql query , create command, create crystal reports , filter crystal reports , display Dataset in a Data Grid view, Pass Parameter.

##Features
-Login Form -Book Management System form(Add books, View Books, Add Authors, Book lendings) 
-Access authority using parameters and function(only admin has the access to add books) 
-3 Crytstal reports 
1.Book report 
2.Lending report to show all the details of lending books 
3.member lending report which shows the data filtered.
-Sql Server integration
1.create table for user login (eg.tbluser) 
2.create a table for lending books, Add Books, and Add Author

##NOTE
This project is connected to a Local SQL server database.Due to this:
-the project may not run directly on others systems without swtting up the satabase.
-A backup file or script of the database can be added if needed.

##How to Run(If you want to try)

1.Clone or download the project
2.Open it with Visual Studio2022 64bit. 
3.Create a SQL Server database and update your connection string in 'App.config' or wherever you used it(please note write the columns that you have mentiondd in the data set correctly without spelling mistake)
4.Restore the database using the '.bak' file(if provided). 5.Run the Soultion.












-As you can see these are the simple screen shots that i've got to show you how the code executes sequentially  
create a table in SQl server before desining the form eg.tbluser and enter data to login from the form 
![Image](https://github.com/user-attachments/assets/2071b1d3-c46c-479c-b849-4c24eb93f041)


-then menustrips are added as you can see in the image the file menu strip has logout and exit option 

![Image](https://github.com/user-attachments/assets/6120bc42-8a4c-47d0-a24c-4bf100ebe2c5)


-Manage menu stirp to manage the library books,author and etc.

![Image](https://github.com/user-attachments/assets/19796a96-a969-4c07-8ad5-2d7600e088b8)


-All the crystal reports included in this Report menu strip 
![Image](https://github.com/user-attachments/assets/0c5e28b9-28ca-4751-830c-513a49cc55d3)



-I hope you might have seen the parameter passes in the code. by passing parameter we can give access/permissions.
![Image](https://github.com/user-attachments/assets/10296559-b1ea-4ece-b474-cd7465bea004)


![Image](https://github.com/user-attachments/assets/cb15e2cd-efb4-49a4-9f23-f64f315bde97)

-we have to add a data provider called SqlDataAdapter to create an Data grid view 
![Image](https://github.com/user-attachments/assets/75ada946-bc06-4b1c-a482-ebf4f460599f)


![Image](https://github.com/user-attachments/assets/fb3a3665-79ca-464c-8db3-753690ae3408)


![Image](https://github.com/user-attachments/assets/febda07b-5e72-417f-ac47-e17fe017692e)


![Image](https://github.com/user-attachments/assets/c7678317-549d-4e55-9fc7-194a591b766e)


![Image](https://github.com/user-attachments/assets/7b5c9ee5-fd12-4f4b-8afe-e0b0bad9a9b2)


![Image](https://github.com/user-attachments/assets/f131ae17-9986-4e8c-8513-5bb49e76b6bf)
