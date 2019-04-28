CREATE TABLE DeviceType(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Code VARCHAR(10) NOT NULL UNIQUE,
	Description NVARCHAR(MAX),
	CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
	UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Device(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Code VARCHAR(20) NOT NULL UNIQUE,
	Type INT NOT NULL FOREIGN KEY REFERENCES DeviceType(Id),
	CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
	UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Account(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
	UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
)