-- Create Tables on SQLite

CREATE TABLE Product ( 
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	Name				TEXT NOT NULL,
	Code				Text,
	Color				TEXT,
	Remarks				Text
)

CREATE TABLE ProductProperty ( 
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	ProductId			INTEGER NOT NULL,
	Length				INTEGER
	Height				INTEGER,
	Width				INTEGER,
	Depth				INTEGER,
	-- Remarks				Text -- only to make compliant to EF
	FOREIGN KEY (ProductId) REFERENCES Product(Id)
)

CREATE TABLE Dealer (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	Name				TEXT NOT NULL,
	Address				TEXT,
	Email				TEXT,
	Mobile				TEXT,
	Remarks				Text
)

CREATE TABLE Bill (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	DealerId			INTEGER NOT NULL,
	BillDate			TEXT NOT NULL,
	EntryDate		    TEXT NOT NULL,
	TotalAmount			REAL NOT NULL,
	Remarks				TEXT,
	FOREIGN KEY (DealerId) REFERENCES Dealer(Id)
)

CREATE TABLE BillDetail (
	Id					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	BillId				INTEGER NOT NULL,
	ProductId			INTEGER NOT NULL,
	TotalAmount			REAL NOT NULL,
	QuantityInBox		INTEGER ,
	TotalBoxes			INTEGER,
	TotalQuantity		INTEGER,
	UnitPrice			REAL NOT NULL,
	EntryDate		    TEXT NOT NULL,
	Remarks				Text,
	FOREIGN KEY (BillId) REFERENCES Bill(Id),
	FOREIGN KEY (ProductId) REFERENCES Product(Id)
)


INSERT INTO Product ( Name, Code, Color, Remarks) 
				VALUES ('Prod 101', 'PROD101', 'Red', 'Rem 101')

INSERT INTO Dealer (Name, Address, Email, Mobile, Remarks) 
			VALUES('Deal101', 'Delr Add 101', 'Dealr101@abc.com', '9874563210', 'Rem Delr 101')

INSERT INTO Bill (DealerId, BillDate, EntryDate, TotalAmount, Remarks)
			VALUES (1, '2020-03-25', '2020-03-28', 12.32, 'Rem bill 1')

INSERT INTO BillDetail (BillId, ProductId, TotalAmount, QuantityInBox, TotalBoxes, TotalQuantity, UnitPrice, EntryDate, Remarks)
			VALUES (1, 1, 12.32, 2, 3, 6, 6.16, '2020-03-30', 'Rem Bil Details 1')