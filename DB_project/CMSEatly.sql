create table Manager(
ManagerID int,
Fname varchar(25),
Lname varchar(25),
PhoneNumber varchar(11),
Username varchar(50),
Password varchar(50)
primary key(ManagerID)
);

create table Cafe(
CafeID int,
Name varchar(50),
Location varchar(25),
PhoneNumber varchar(11),
ManagerID int,
primary key(CafeID),
foreign key(ManagerID) references Manager(ManagerID)
);

create table MenuCategory(
CategoryID int,
Name varchar(25),
CafeID int,
primary key(CategoryID),
foreign key(CafeID) references Cafe(CafeID)
);

create table MenuItem(
ItemID int,
Name varchar(25),
Description varchar(255),
Price int,
NutritionalInfo varchar(255),
CategoryID int,
primary key(ItemID),
foreign key(CategoryID) references MenuCategory(CategoryID)
);

create table Customer(
CustomerID int,
Fname varchar(25),
Lname varchar(25),
PhoneNumber varchar(11),
Username varchar(50),
Password varchar(50)
primary key(CustomerID)
);

create table Cashier(
CashierID int,
Fname varchar(25),
Lname varchar(25),
PhoneNumber varchar(11),
Username varchar(50),
Password varchar(50)
primary key(CashierID)
);

create table Orders(
OrderID int,
Time time, 
Date date, 
Amount int,
CustomerID int,
CashierID int,
primary key(OrderID),
foreign key(CustomerID) references Customer(CustomerID),
foreign key(CashierID) references Cashier(CashierID)
);

create table Payment(
PaymentID int,
Method varchar(25),
Amount int,
CustomerID int,
OrderID int,
primary key(PaymentID),
foreign key(CustomerID) references Customer(CustomerID),
foreign key(OrderID) references Orders(OrderID)
);

create table OrderItem(
OrderItemID int, 
Subtotal int,
Quantity int,
OrderID int,
primary key(OrderItemID),
foreign key(OrderID) references Orders(OrderID)
);

create table Vendor(
VendorID int,
Name varchar(25),
PhoneNumber varchar(11),
primary key(VendorID)
);

create table InventoryManager(
ManagerID int,
Fname varchar(25),
Lname varchar(25),
PhoneNumber varchar(11),
Username varchar(50),
Password varchar(50)
primary key(ManagerID)
);

create table InventoryItem(
ID int,
Name varchar(25),
UnitPrice int,
AvailableQuantity int,
VendorID int,
ManagerID int,
primary key(ID),
foreign key(VendorID) references Vendor(VendorID),
foreign key(ManagerID) references InventoryManager(ManagerID)
);

create table ReportAnalysis(
ReportID int, 
Type varchar(100),
DateGenerated date,
Content varchar(255),
ManagerID int,
primary key(ReportID),
foreign key(ManagerID) references Manager(ManagerID)
);

create table CustomerLoyaltyProgram(
LoyaltyProgID int, 
Points int,
CustomerID int,
primary key(LoyaltyProgID),
foreign key(CustomerID) references Customer(CustomerID)
);

create table part_of(
ItemID int, 
OrderID int,
primary key(ItemID,OrderID),
foreign key(ItemID) references MenuItem(ItemID),
foreign key(OrderID) references Orders(OrderID)
);

create table updates(
ID int, 
OrderID int,
primary key(ID,OrderID),
foreign key(ID) references InventoryItem(ID),
foreign key(OrderID) references Orders(OrderID)
);

select * from Manager
select * from Cafe
select * from MenuCategory
select * from MenuItem
select * from Customer
select * from Cashier
select * from Orders
select * from Payment
select * from OrderItem
select * from Vendor
select * from InventoryManager
select * from InventoryItem
select * from ReportAnalysis
select * from CustomerLoyaltyProgram
select * from part_of
select * from updates