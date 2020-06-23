---- Create Tables on SQLite

--CREATE TABLE ProductDetail ( 
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	Name				TEXT 
--)

--CREATE TABLE Dealer (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	Name				TEXT NOT NULL,
--	Address				TEXT,
--	Email				TEXT,
--	Mobile				TEXT,
--	Remarks				Text
--)

--CREATE TABLE Bill (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	DealerId			INTEGER NOT NULL,
--	BillDate			TEXT NOT NULL,
--	EntryDate		TEXT NOT NULL,
--	TotalAmount			REAL NOT NULL,
--	Remarks				TEXT,
--	FOREIGN KEY (DealerId) REFERENCES Dealer(Id)
--)

--CREATE TABLE BillDetail (
--	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
--	BillId				INTEGER NOT NULL,
--	ProductId			INTEGER NOT NULL,
--	TotalAmount			REAL NOT NULL,
--	QuantityInBox		INTEGER ,
--	TotalBoxes			INTEGER,
--	TotalQuantity		INTEGER,
--	EntryDate		    TEXT NOT NULL,
--	FOREIGN KEY (BillId) REFERENCES Bill(Id),
--	FOREIGN KEY (ProductId) REFERENCES ProductDetail(Id)
--)
