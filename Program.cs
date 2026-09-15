using C__Preply;
 
var flowerSunflower = new Flower
 {
     Type = "Sunflower",
     Colour = "Yellow",
     Amount = 8
     
 };
 
 var flowerRose = new Flower
 {
     Type = "Rose",
     Colour = "White",
     Amount = 23
 };
 
 
flowerRose.FlowerInfo();
flowerRose.IsReadyForSale();
Console.WriteLine();
flowerSunflower.AddFlowers(10);
flowerSunflower.FlowerInfo();
flowerSunflower.IsNotBlossomed();

 