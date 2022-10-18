
using ASSETTRACKING;


myDbcontext1 Context = new myDbcontext1();


Item NewItem = new Item();
NewItem.catagory = "Phone";
NewItem.brand ="iphone";
NewItem.model = "asus";
NewItem.purchaseDate = 2018-12-13;
NewItem.office = "Sweden";
NewItem.purchasePrice = 1250;
NewItem.currency = "SEK";
NewItem.exchangeRate = 12.5 ;

Context.Items.Add(NewItem);
Context.SaveChanges();

Item Item1 = new Item();
Item1.catagory = "Computer";
Item1.brand = "hp";
Item1.model = "Elitebook";
Item1.purchaseDate = 2019-06-01;
Item1.office = "Spain";
Item1.purchasePrice = 1400;
Item1.currency = "EUR";
Item1.exchangeRate= 10;

Context.Items.Add(Item1);



Context.SaveChanges();
Console.WriteLine(Item1.model);