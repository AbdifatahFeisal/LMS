# LMS
We developed a Library Service System for a university. The system is specifically designed for librarians, students, and academic staffs. Once the system is opened, the user must enter their unique ID number and password. Upon login, the system should display the user’s actual name on the system’s user interface. For students and academic staffs, they are allowed to make transaction for borrowing, renewing or returning book only. However they should not have access to the reports, as the reports are for librarian view.
The system must have the following functionalities:

a.	Borrowing
All staffs and students of the university are entitled to borrow all library items by using their ID number. The borrowing privileges depend on their status at the university. Therefore the validation should be done based on the condition described below:


For Certificate, Foundation, Diploma and Degree students, maximum allowed items should be 4 
For Masters and  PhD students maximum items allowed are	10
while for the Academic staffs	maximum of 20 Items should be allowed

The system should also calculate the return date based on different types of material. The loan duration for each material is listed as follows:


b.	Renewal
The borrower may renew their book to extend the loan duration, provided it is done on or before the expiry date. The system should check whether the item is overdue first before making any changes to the loan item.

c.	Fines
An item will become overdue if it is not returned or renewed on or before the expiry date. In case a borrower is unable to return the item on time, the system will automatically compute the corresponding fine. The current fine rates for late return of items are RM1 per day. The system should compare the current date with the loan due date in the database in order to calculate the fine amount.

d.	Report
The system should produce a status report of all borrowed books based on the current date which includes the borrower id, the borrower’s name, book id, book’s title, date of borrowed, and the return date.



Detailed system features of the system include the following:
	Flexible search capabilities to enable quick retrieval of books 
	Efficient selection method for book/s. 
	Report generation for Manager on daily borrowing activities which should be generated using Microsoft Visual Studio Report Viewer / Data Grid View. The report should be visible only by Manager, and no other staff should be able to access it.

