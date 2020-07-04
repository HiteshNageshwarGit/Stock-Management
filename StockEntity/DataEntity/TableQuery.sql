--------DELETE FROM CustomerBillBreakup
--------DELETE FROM DealerBillBreakup
--------DELETE FROM CustomerBill
--------DELETE FROM DealerBill
--------DELETE FROM Customer
--------DELETE FROM Dealer
--------DELETE FROM ProductProperty
--------DELETE FROM Product


------ Create Tables on SQLite

----CREATE TABLE KeyValue (
----	Id	INTEGER NOT NULL,
----	Key	TEXT NOT NULL,
----	Value	TEXT NOT NULL,
----	PRIMARY KEY(Id AUTOINCREMENT)
----);
------ Update DB version when making changes in DB schema or including post deployment script
----INSERT INTO KeyValue(Key, Value) VALUES('DBVersion', '1') 
----INSERT INTO KeyValue(Key, Value) VALUES('DBBackupDir', 'D:\StockDBBackup')
----INSERT INTO KeyValue(Key, Value) VALUES('AdminUser', 'Admin')
----INSERT INTO KeyValue(Key, Value) VALUES('AdminPassword', 'Passw0rd')

--CREATE TABLE Product ( 
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	Name				TEXT NOT NULL,
--	Code				Text,
--	Color				TEXT,
--	Remarks				Text
--)

--CREATE TABLE ProductProperty ( 
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	ProductId			INTEGER NOT NULL,
--	Length				INTEGER
--	Height				INTEGER,
--	Width				INTEGER,
--	Depth				INTEGER,	
--	FOREIGN KEY (ProductId) REFERENCES Product(Id)
--)

--CREATE TABLE Dealer (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	Name				TEXT NOT NULL,
--	Address				TEXT,
--	Email				TEXT,
--	Mobile				TEXT,
--	Remarks				Text
--)

--CREATE TABLE CustomerBill (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	CustomerId			INTEGER NOT NULL,
--	BillDate			TEXT NOT NULL,	
--	TotalAmount			REAL NOT NULL,
--	Remarks				TEXT,
--	FOREIGN KEY (CustomerId) REFERENCES Customer(Id)
--)

--INSERT INTO Customer (Name) VALUES('Default')

--CREATE TABLE DealerBill (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	DealerId			INTEGER NOT NULL,
--	BillDate			TEXT NOT NULL,
--	EntryDate		    TEXT NOT NULL,
--	TotalAmount			REAL NOT NULL,
--	Remarks				TEXT,
--	FOREIGN KEY (DealerId) REFERENCES Dealer(Id)
--)

--CREATE TABLE CustomerBill (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	CustomerId			INTEGER NOT NULL,
--	BillDate			TEXT NOT NULL,
--	EntryDate		    TEXT NOT NULL,
--	TotalAmount			REAL NOT NULL,
--	Remarks				TEXT,
--	FOREIGN KEY (CustomerId) REFERENCES Customer(Id)
--)


--CREATE TABLE DealerBillBreakup (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	DealerBillId				INTEGER NOT NULL,
--	EntryDate		    TEXT NOT NULL,
--	ProductId			INTEGER NOT NULL,
--	TotalBoxes			INTEGER,
--	QuantityInBox		INTEGER,
--	TotalQuantity		INTEGER,
--	UnitPrice			REAL NOT NULL,
--	TotalAmount			REAL NOT NULL,
--	AvailableQuantity	INTEGER,
--	UnitSellPrice	    REAL NOT NULL,
--	Remarks				Text,
--	FOREIGN KEY (DealerBillId) REFERENCES DealerBill(Id),
--	FOREIGN KEY (ProductId) REFERENCES Product(Id)
--)

--CREATE TABLE CustomerBillBreakup (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	CustomerBillId		INTEGER NOT NULL,
--	DealerBillBreakupId INTEGER NOT NULL,
--	ProductId			INTEGER NOT NULL,
--	TotalBoxes			INTEGER,
--	QuantityInBox		INTEGER ,
--	TotalQuantity		INTEGER,
--	UnitPrice			REAL NOT NULL,
--	TotalAmount			REAL NOT NULL,
--	Remarks				Text,
--	FOREIGN KEY (CustomerBillId) REFERENCES CustomerBill(Id),
--	FOREIGN KEY (DealerBillBreakupId) REFERENCES DealerBillBreakup(Id),
--	FOREIGN KEY (ProductId) REFERENCES Product(Id)
--)

	
--INSERT INTO Product ( Name, Code, Color, Remarks) 
--				VALUES ('Prod 101', 'PROD101', 'Red', 'Rem 101')

--INSERT INTO Dealer (Name, Address, Email, Mobile, Remarks) 
--			VALUES('Deal101', 'Delr Add 101', 'Dealr101@abc.com', '9874563210', 'Rem Delr 101')

--INSERT INTO DealerBill (DealerId, BillDate, EntryDate, TotalAmount, Remarks)
--			VALUES (1, '2020-03-25', '2020-03-28', 12.32, 'Rem bill 1')

--INSERT INTO DealerBillBreakup (DealerBillId, ProductId, TotalAmount, QuantityInBox, TotalBoxes, TotalQuantity, UnitPrice, EntryDate, Remarks)
--			VALUES (1, 1, 12.32, 2, 3, 6, 6.16, '2020-03-30', 'Rem Bil Details 1')
			
--INSERT INTO Customer (Name, Address, Email, Mobile, Remarks) 
--			VALUES('Custl101', 'Cust Add 101', 'Custdfs@abc.com', '9874563210', 'Rem Cust 101')

--INSERT INTO CustomerBill (CustomerId, BillDate, EntryDate, TotalAmount, Remarks)
--			VALUES (1, '2020-03-25', '2020-03-28', 12.32, 'Rem bill 1')

--INSERT INTO CustomerBillBreakup (CustomerBillId, ProductId, TotalAmount, QuantityInBox, TotalBoxes, TotalQuantity, UnitPrice, EntryDate, Remarks)
--			VALUES (1, 1, 12.32, 2, 3, 6, 6.16, '2020-03-30', 'Rem Bil Details 1')			
			
			


---- Versioning of DB starts here