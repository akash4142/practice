using System;
class book{ 
  public 
  string title;
  string author;
  int pages;
  
  public book (string atitle, string anauthor,int apages){
    title = atitle;
     author= anauthor;
    pages =apages;
  }
  
}

class Program {
  public static void Main (string[] args) {
    book book1=new book("premchand","premchand",120);
    book book2= new book("haliram","hary",231);
    Console.WriteLine(book2.title);
    Console.ReadLine();
  }
}
