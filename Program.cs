//initialize variables

int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;
double orderCost;

//initialize variables
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());
System.Console.WriteLine(numberOfSandwiches + " Sandwiches");

System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine(numberOfToppings + " Toppings");

System.Console.WriteLine("How much would you like to tip (%)?");
tip = double.Parse(Console.ReadLine());
System.Console.WriteLine(tip + " % Tip");

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;

totalToppingCost = COST_OF_TOPPING * numberOfToppings;

baseCost = totalSandwichCost + totalToppingCost;

double discountAmount = baseCost * (1 - DISCOUNT_AMOUNT);

double tipPercent = discountAmount * (tip/100);

orderCost = tipPercent + baseCost * (1-DISCOUNT_AMOUNT);

System.Console.WriteLine("Your sandwich costs " + orderCost);