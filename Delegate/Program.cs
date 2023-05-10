
using Delegate;

delegate1 del = new delegate1();

Message message = del.Hello2;
message += del.HowAreYou2;  // теперь message указывает на два метода


message += delegate1.Hello;



message(100500, "Михаил");              // вызываются оба метода - Hello и HowAreYou