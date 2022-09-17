using ResponsabilityChainV6.BL;

// First we define the approvers
Approver Larry = new Director();
Approver Sam = new VicePresident();
Approver Tammy = new President();

// We set the succesors for every approver
Larry.SetSuccessor(Sam);
Sam.SetSuccessor(Tammy);

// We generate some process request orders
PurchaseOrder p = new PurchaseOrder(2034, 350, "Buy some cleaning assets");
Larry.ProcessRequest(p);
Console.WriteLine("===============================================================");

p = new PurchaseOrder(2035, 32590, "New air conditioner for office");
Larry.ProcessRequest(p);
Console.WriteLine("===============================================================");

p = new PurchaseOrder(2036, 122100, "New car for CEO");
Larry.ProcessRequest(p);
Console.WriteLine("===============================================================");