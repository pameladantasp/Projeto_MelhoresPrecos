SET SQL_SAFE_UPDATES = 0;
SHOW VARIABLES LIKE 'sql_safe_updates';

use sql10527490;
CREATE TABLE address (
    idAddress INT PRIMARY KEY AUTO_INCREMENT,
    Street VARCHAR(90) NOT NULL,
    Number VARCHAR(90) NOT NULL,
    City VARCHAR(90) NOT NULL,
    State VARCHAR(90) NOT NULL,
    PostalCode VARCHAR(8) NOT NULL
);


CREATE TABLE costumer (
    idCostumer INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(90) NOT NULL,
    email VARCHAR(90) NOT NULL UNIQUE,
    password VARCHAR(90) NOT NULL,
    idAddress INT NOT NULL,
    FOREIGN KEY (idAddress) REFERENCES address (idAddress)
        ON UPDATE CASCADE
);


CREATE TABLE supermarket (
    idSupermarket INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(90) NOT NULL,
    idAddress INT NOT NULL,
    FOREIGN KEY (idaddress) REFERENCES address (idAddress)
        ON DELETE CASCADE
);


CREATE TABLE category (
    idCategory INT PRIMARY KEY AUTO_INCREMENT,
    Type VARCHAR(90) NOT NULL
);


CREATE TABLE product (
    idProduct INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(90) NOT NULL,
    Category INT NOT NULL,
    FOREIGN KEY (category) REFERENCES category (idCategory)
);


CREATE TABLE registerProduct (
    idRegister INT PRIMARY KEY AUTO_INCREMENT,
    idCostumer INT NOT NULL,
    FOREIGN KEY (idCostumer)
        REFERENCES costumer (idCostumer)
        ON DELETE RESTRICT,
    idSupermarket INT NOT NULL,
    FOREIGN KEY (idSupermarket)
        REFERENCES supermarket (idSupermarket)
        ON DELETE CASCADE,
	idProduct INT NOT NULL,
    FOREIGN KEY (idProduct)
        REFERENCES product (idProduct)
		ON DELETE CASCADE,    
    Price FLOAT NOT NULL,
    DateRegister DATE NOT NULL
);
