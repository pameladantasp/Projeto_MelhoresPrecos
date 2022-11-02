SELECT * FROM sql10527490.address;

use sql10527490;
insert into address(street, number, city, state, postalCode) VALUES
	('Avenida Albino Oliveira',	1340, 'Campinas','SP',	13084008),
    ('Rodovia Dom Pedro', 140, 'Campinas', 'SP', 13080395),
    ('Avenida Albino Oliveira', 511, 'Campinas', 'SP', 13084551),
    ('Rodovia Dom Pedro', 224, 'Campinas', 'SP', 13084470),
    ('Avenida Ayrton Senna', 456, 'Campinas', 'SP',	13096588),
    ('Avenida Santa Isabel', 230, 'Campinas', 'SP', 13987654),
    ('Dom Lino Deodato', 500, 'Campinas', 'SP',	13456765),
    ('Avenida Alan Turing', 754, 'Campinas', 'SP', 13456987),
    ('Paulo Gustavo', 79, 'Campinas', 'SP', 13321654),
    ('Orozimbo Maia', 525, 'Campinas', 'SP', 13698569),
    ('Ruberlei Boareto', 400, 'Campinas', 'SP', 13083710),
    ('Alberto Custodio', 986, 'Campinas', 'SP', 13568002)
;

insert into category(type) values
	('Bebidas'),
    ('Frios'),
	('Congelados'),
    ('Frutas'),
    ('Carnes'),
    ('Veganos'),
    ('Padaria'),
    ('Higiene pessoal'),
    ('Produtos de limpeza'),
    ('Papelaria'),
    ('Temperos'),
    ('Utilidades'),
    ('Laticínios'),
    ('Grãos'),
    ('Petiscos'),
    ('Peixes')
;

insert into costumer (name, email, password, idAddress) values
	('Matheus Tosi', 'matheusteste@hotmail.com', 12345, 3),
    ('Angelica','teste@gmail.com', 12345, 9),
    ('Angelica2', 'teste2@gmail.com', 54321, 9),
    ('Pamela', 'pamela@gmail.com', 12345, 6),
	('Maria', 'maria@hotmail.com', 12345, 7),
    ('Joao', 'joao@hotmail.com', 54321, 8)
;
        
insert into product (name, category) values 
	('Guarana', 1), ('Salame', 2), ('Lasanha congelada', 3), ('Manga palmer', 4), 
    ('Alcatra', 5), ('Bebida vegetal Not milk', 6), ('Pão frances', 7), ('Pasta de dente', 8), 
    ('Desinfetante', 9), ('Lapiseira', 10), ('Pimenta do reino', 11), ('Espeto Tridente Churrasco', 12), 
    ('Queijo minas', 13), ('Feijão', 14), ('Amendoin japones', 15), ('Salmão', 16), 
    ('Coca-cola', 1), ('Arroz', 14), ('Banana', 4), ('Sabonete', 8)
;
    
insert ignore into registerproduct (idCostumer, idProduct, idSupermarket, price, dateRegister) values
	(1, 4, 5, 5.29, now())
;
    
insert into registerproduct (idCostumer, idProduct, idSupermarket, price, dateRegister) values
	(2, 7, 5, 2.90, now()), 	
    (3, 2, 1, 12.99, now()),
    (3, 14, 1, 17.50, now()),
    (3, 2, 1, 11.30, now()),
    (6, 16, 7, 50.99, now()),
    (1, 2, 5, 10.98, now()),
    (6, 17, 1, 8.90, now()),
    (6, 13, 1, 30.68, now())
;

insert into supermarket(name, idaddress) values 
	('Tenda', 1), ('Atacadao', 2), ('Carrefour', 4), ('Dalben', 5), 
    ('Makro', 10), ('Dia', 11), ('Enxuto', 12)
;