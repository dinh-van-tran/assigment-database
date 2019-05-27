CREATE TABLE Account(
	Username VARCHAR(100) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Password VARCHAR(100) NOT NULL,
	CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
	UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE DeviceType(
	Code VARCHAR(10) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Description NVARCHAR(MAX),
	CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
	UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Device(
	Code VARCHAR(20) PRIMARY KEY,
	Type VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES DeviceType(Code) ON UPDATE CASCADE ON DELETE NO ACTION,
	Value MONEY NOT NULL DEFAULT 0,
	Owner VARCHAR(100) FOREIGN KEY REFERENCES Account(Username) ON UPDATE CASCADE ON DELETE SET NULL,
	CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
	UpdatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);


INSERT INTO Account(Username, Name, Password) VALUES ('dinh', N'Định Trần', '123');
INSERT INTO Account(Username, Name, Password) VALUES ('hai', N'Hải Nguyễn', '123');
INSERT INTO Account(Username, Name, Password) VALUES ('khang', N'Khang', '123');

INSERT INTO DeviceType(Code, Name, Description) VALUES ('MT', N'Máy tính bàn', N'Máy tính để bàn');
INSERT INTO DeviceType(Code, Name, Description) VALUES ('LT', N'Laptop', N'Máy tính xách tay');
INSERT INTO DeviceType(Code, Name, Description) VALUES ('MC', N'Máy chiếu', N'Máy chiếu');

INSERT INTO Device(Code, Type, Value, Owner) VALUES ('MT01', 'MT', 5000000, 'dinh');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('MT02', 'MT', 6000000, 'hai');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('MT03', 'MT', 7000000, 'khang');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('LT01', 'LT', 5000000, 'dinh');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('LT02', 'LT', 6000000, 'hai');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('LT03', 'LT', 7000000, 'khang');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('MC01', 'MC', 5000000, 'dinh');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('MC02', 'MC', 6000000, 'hai');
INSERT INTO Device(Code, Type, Value, Owner) VALUES ('MC03', 'MC', 7000000, 'khang');