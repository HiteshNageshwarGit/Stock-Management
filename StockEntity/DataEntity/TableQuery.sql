
-- Create Tables on SQLite

CREATE TABLE KeyValue (
	Id			INTEGER NOT NULL,
	Key			TEXT NOT NULL,
	Value		TEXT NOT NULL,
	TimeStamp	TEXT NOT NULL,
	PRIMARY KEY(Id AUTOINCREMENT)
);
-- Update DB version when making changes in DB schema or including post deployment script
INSERT INTO KeyValue(Key, Value, TimeStamp) VALUES('DBVersion', '1', '') 
INSERT INTO KeyValue(Key, Value, TimeStamp) VALUES('DBBackupDir', 'D:\StockDBBackup','')
INSERT INTO KeyValue(Key, Value, TimeStamp) VALUES('AdminUser', 'Admin','')
INSERT INTO KeyValue(Key, Value, TimeStamp) VALUES('AdminPassword', 'Passw0rd','')

CREATE TABLE Product ( 
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	Name				TEXT NOT NULL,
	Code				Text,
	Color				TEXT,
	Remarks				Text,
	TimeStamp			TEXT NOT NULL
)

CREATE TABLE ProductProperty ( 
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	ProductId			INTEGER NOT NULL,
	Length				INTEGER
	Height				INTEGER,
	Width				INTEGER,
	Depth				INTEGER,
	TimeStamp			TEXT NOT NULL,
	FOREIGN KEY (ProductId) REFERENCES Product(Id)
)

CREATE TABLE Dealer (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	Name				TEXT NOT NULL,
	Address				TEXT,
	Email				TEXT,
	Mobile				TEXT,
	Remarks				Text,
	TimeStamp			TEXT NOT NULL
)
INSERT INTO Dealer (Name, TimeStamp) VALUES('Default', '')

-- Entry date is required
CREATE TABLE DealerBill (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	DealerId			INTEGER NOT NULL,
	BillDate			TEXT NOT NULL,
	EntryDate		    TEXT NOT NULL,
	TotalAmount			REAL NOT NULL,
	Remarks				TEXT,
	TimeStamp			TEXT NOT NULL,
	FOREIGN KEY (DealerId) REFERENCES Dealer(Id)
)

-- Entry date is required
CREATE TABLE DealerBillBreakup (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	DealerBillId				INTEGER NOT NULL,
	EntryDate		    TEXT NOT NULL,
	ProductId			INTEGER NOT NULL,
	TotalBoxes			INTEGER,
	QuantityInBox		INTEGER,
	TotalQuantity		INTEGER,
	UnitPrice			REAL NOT NULL,
	TotalAmount			REAL NOT NULL,
	AvailableQuantity	INTEGER,
	UnitSellPrice	    REAL NOT NULL,
	Remarks				Text,
	TimeStamp			TEXT NOT NULL,
	FOREIGN KEY (DealerBillId) REFERENCES DealerBill(Id),
	FOREIGN KEY (ProductId) REFERENCES Product(Id)
)

CREATE TABLE Customer (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	Name				TEXT NOT NULL,
	Address				TEXT,
	Email				TEXT,
	Mobile				TEXT,
	Remarks				Text,
	TimeStamp			TEXT NOT NULL
)
INSERT INTO Customer (Name, TimeStamp) VALUES('Default','')

-- No entry date is required
CREATE TABLE CustomerBill (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	CustomerId			INTEGER NOT NULL,
	BillDate			TEXT NOT NULL,
	TotalAmount			REAL NOT NULL,
	Remarks				TEXT,
	TimeStamp			TEXT NOT NULL,
	FOREIGN KEY (CustomerId) REFERENCES Customer(Id)
)

-- No entry date is required
CREATE TABLE CustomerBillBreakup (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	CustomerBillId		INTEGER NOT NULL,
	DealerBillBreakupId INTEGER NOT NULL,
	ProductId			INTEGER NOT NULL,
	TotalBoxes			INTEGER,
	QuantityInBox		INTEGER ,
	TotalQuantity		INTEGER,
	UnitPrice			REAL NOT NULL,
	TotalAmount			REAL NOT NULL,
	-- Remarks				Text,
	TimeStamp			TEXT NOT NULL,
	FOREIGN KEY (CustomerBillId) REFERENCES CustomerBill(Id),
	FOREIGN KEY (DealerBillBreakupId) REFERENCES DealerBillBreakup(Id),
	FOREIGN KEY (ProductId) REFERENCES Product(Id)
)	

 -- Versioning of DB starts here

UPDATE KeyValue SET Value = 2 WHERE Key = 'DBVersion'
ALTER TABLE Product ADD COLUMN LowerLimit INTEGER;
ALTER TABLE Product ADD COLUMN UpperLimit INTEGER;
UPDATE Product SET LowerLimit = 0 WHERE LowerLimit IS NULL
UPDATE Product SET UpperLimit = 0 WHERE UpperLimit IS NULL