use sql10527490;

insert into product (name, category) values
    ('Vinho tinto', 1),
    ('Linguiça', 2),
    ('Pizza congelada', 3),
    ('Uva verde', 4),
    ('Picanha', 5),
    ('Requeijão Vida Veg.', 6),
    ('Sonho recheado com doce de leite', 7),
    ('Shampoo Cuide-se Bem - O Boticario', 8),
	('Condicionador Cuide-se Bem - O Boticario', 8),
    ('Sabão em pó - Omo', 9),
    ('Caderno espiral 200 folhas', 10),
    ('Páprica Doce', 11),
    ('Vassoura', 12),
    ('Leite integral UHT', 13),
    ('Soja', 14),
    ('Amendoin temperado', 15),
    ('Bacalhau', 16)
;

insert into address (idAddress, street, number, city, state, postalCode) values
    (13, 'Maria Monteiro', 1270, 'Campinas', 'SP', '13025-152'),
	(14, 'Av. Mirandópolis', 86, 'Campinas', 'SP', '13050-470'),
    (15, 'R. Olavo Bilac', 197, 'Campinas', 'SP', '13024-110'),
    (16, 'R. Dr. Viêira Bueno', 248, 'Campinas', 'SP', '13024-040')
;  # coloquei o id pois o auto_increment não ia pegar eles por antigamente ter dados ali (mas foram apagados)

insert into supermarket (name, idAddress) values
   ('Oba Hortifruti - Cambuí', 13),
   ('Mini supermercado Extra', 14),
   ('Dia - Cambuí', 15),
   ('Pague Menos', 16)
;

insert into registerProduct (idCustomer, idSupermarket, idProduct, price, dateRegister) values
	(1, 2, 22, 36.90, now()),
    (1, 2, 24, 24.99, now()),
    (1, 11, 28, 7.90, now()),
    (2, 3, 20, 1.65, now()),
    (2, 3, 30, 27.80, now()),
    (4, 6, 35, 5.70, now()),
    (4, 6, 7, 4.25, now()),
    (6, 4, 25, 9.55, now()),
    (6, 4, 37, 10.89, now()),
    (5, 8, 26, 79.90, now()),
    (5, 8, 17, 8.70, now()),
    (5, 9, 23, 24.46, now()),
    (2, 10, 23, 22.89, now()),
	(5, 11, 1, 6.97, now()),
    (5, 11, 3, 16.80, now()),
    (6, 7, 5, 24.99, now()),
    (6, 7, 6, 8.99, now()),
    (6, 7, 9, 6.99, now()),
    (4, 9, 10, 3.90, now()),
	(4, 9, 11, 4.75, now()),
    (4, 9, 12, 27.90, now())
;

