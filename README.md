:boom:
# **Project of SE 307**

## **Authors:**
### Merve Nur TELLİ
-------------------------



## **Library System**

### *Project Description*

This project is a kind of personal library system. In this system, the user can read or holds view boks. Also, the user can add a new book with the author to the list if they wish. In the library system, the title of the book, the information of the author of the book and briefly the type and subject of the book are kept. while listing the name of books are displayed in alphabetical order. On the other hand, the users can mark the books they read as read.

### *Technical Details*
I am going to implement the program in C#.NET. The simple interface of the application will be designed with windows form. The title, author and information about the book will be kept in a database, information will be pulled from there and added there. Microsoft SQL server management studio will be used as database system. It will be used the set and get methods while pulling the book information from the database.


### *Example Library Screen;*

<img src="https://user-images.githubusercontent.com/61708140/101086691-49062880-35c2-11eb-85f6-df35453ff3b5.PNG" width="45%"></img>

----------------------------------------------------------------------------------------------------------------------------------------------------------

# **LIBRARY SYSTEM**

### *Project Explanation*

In this project I developed personal a Library System which. We implemented the program in C#.NET and used Microsoft Access for the database storage. Database include information about books (book name, book author, book’ link). When the program firstly executed, a home screen appears. In this screen there is book list on the left and there are buttons for the operation we will do. On the right, there is book’ pdf that we can read.

<img src="https://user-images.githubusercontent.com/61708140/109543204-15f70680-7ad7-11eb-8970-c5fba053d0bc.JPG" width="45%"></img> 

**Figure 1:** Library System Main Screen

<img src="https://user-images.githubusercontent.com/61708140/109543211-168f9d00-7ad7-11eb-8160-5a2b5a57ebe2.JPG" width="45%"></img> 

**Figure 2:** Microsoft Access Database

If an ‘List Button’ is clicked on that screen, book list. This book list shows information about book like book name, book author, id, link. Also, I double click on the line that we want to read, book is opened on the right side. I had created three records before in database.

<img src="https://user-images.githubusercontent.com/61708140/109543214-17283380-7ad7-11eb-87cf-9b105a199492.JPG" width="45%"></img> 

**Figure 3:** List Button Using


<img src="https://user-images.githubusercontent.com/61708140/109543217-17c0ca00-7ad7-11eb-905d-500dab920ebd.JPG" width="45%"></img> 

**Figure 4:** Double Click on The Line

I got links from site that share free e-book [1]. I copied pdf link and paste in link part. Let we create new register.

<img src="https://user-images.githubusercontent.com/61708140/109543221-18596080-7ad7-11eb-8882-8dc6769a7f94.JPG" width="45%"></img> <img src="https://user-images.githubusercontent.com/61708140/109543225-18f1f700-7ad7-11eb-8e99-dce7b7141bb8.JPG" width="45%"></img> 

**Figure 5-6:** Adding New Book


<img src="https://user-images.githubusercontent.com/61708140/109543229-198a8d80-7ad7-11eb-996f-8ff14c3b1cb2.JPG" width="45%"></img> <img src="https://user-images.githubusercontent.com/61708140/109543232-1abbba80-7ad7-11eb-88d6-2decc0c43fb7.JPG" width="45%"></img> 

**Figure 7-8:** Deleting Book that Selected

We can also enlarge the window instead of zooming the pdf when we press the ‘Full Screen’ button, and then we press ESC key so window returns to its original size.

This project can also become a school library. It takes some time to get the pdf of the books we have always wanted. If we save our books here, we can reach them to study at any time.

I made project using the list structure and oop basics, I did the database operations over the class.

<img src="https://user-images.githubusercontent.com/61708140/109544257-6458d500-7ad8-11eb-8a29-508e4338409a.JPG" width="90%"></img> 

I create ‘BookVT’ class for connection of database and I wrote some method like a ‘KitapEkle’, ’KitapSil’. I performed the operations in ‘Form1’ class by calling the methods I created in ‘BookVT’ class.
