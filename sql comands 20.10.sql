Select * from sql10527490.Address as A
inner join sql10527490.Consumer as B
where B.idAddress = A.idAddress
ORDER BY B.idAddress DESC;

INSERT INTO `sql10527490`.`Supermarket` (`idSupermarket`, `nameSupermarket`, `idAddress`) VALUES ('30', 'Pao de Acucar', '1');

INSERT INTO `sql10527490`.`Supermarket` (`idSupermarket`, `nameSupermarket`, `idAddress`) VALUES ('99', 'Carrefour', '5');
INSERT INTO `sql10527490`.`Address` (`idAddress`, `street`, `number`, `city`, `state`, `postalCode`) VALUES ('5', 'Rodovia Dom Pedro', '224', 'Campinas', 'SP', '13084470');

# DELETE FROM `sql10527490`.`Consumer` WHERE (`idConsumer` = '4');
# DELETE FROM `sql10527490`.`Consumer` WHERE (`idConsumer` = '5');


insert into `sql10527490`.`Consumer` (`idConsumer`, `nameConsumer`, `emailConsumer`, `password`, `idAddress`) VALUES ('1', 'Matheus', 'matheusteste@hotmail.com', '', '3');
INSERT INTO `sql10527490`.`Address` (`idAddress`,`street`,`number`, `city`, `state`, `postalCode`) VALUES ('3', 'Alberto Custodio','986','Campinas', 'SP', '13568002') ;
# FIZ UPDATE PQ O ID =  3 ESTAVA INSERIDO MANUALMENTE
UPDATE `sql10527490`.`Address` SET `street` = 'Alberto Custodio', `number` = 986, `city` = 'Campinas', `state` = 'SP', `postalCode`= 13568002 WHERE (`idAddress` = '3');


INSERT INTO `sql10527490`.`Address` (`idAddress`,`street`,`number`, `city`, `state`, `postalCode`) VALUES ('6', 'Avenida Ayrton Senna','456','Campinas', 'SP','130965887');
insert into `sql10527490`.`Consumer` (`idConsumer`, `nameConsumer`, `emailConsumer`, `password`, `idAddress`) VALUES ('4', 'Ricardo', 'ricardo@outlook.com', '****', '6');


INSERT INTO `sql10527490`.`Address` (`idAddress`,`street`,`number`, `city`, `state`, `postalCode`) VALUES ('7', 'Avenida Santa Isabel','230', 'Campinas', 'SP','');
insert into `sql10527490`.`Consumer` (`idConsumer`, `nameConsumer`, `emailConsumer`, `password`, `idAddress`) VALUES ('5', 'Maria', 'mary@gmail.com', '***', '7');
# UPDATE POSTALCODE
UPDATE `sql10527490`.`Address` SET `postalCode` = 13987654  WHERE (idAddress = 7);


INSERT INTO `sql10527490`.`Address` (`idAddress`,`street`,`number`, `city`, `state`, `postalCode`) VALUES ('8', 'Dom Lino Deodato', '500', 'Campinas', 'SP','') ;
insert into `sql10527490`.`Consumer` (`idConsumer`, `nameConsumer`, `emailConsumer`, `password`, `idAddress`) VALUES ('9', 'Joao', 'joao@outlook.com', '****', '8');
# UPDATE POSTALCODE
UPDATE `sql10527490`.`Address` SET `postalCode` = 13456765  WHERE (idAddress = 8);

# ___________________________________________________________________________________________ #

insert into `sql10527490`.`Address` (`idAddress`,`street`,`number`, `city`, `state`, `postalCode`) VALUES ('9', 'Avenida Alan Turing', '754', 'Campinas', 'SP', '') ;
UPDATE `sql10527490`.`Address`  SET `postalCode` = 13456987 WHERE (`idAddress`= 9);
UPDATE `sql10527490`.`Consumer` SET `idAddress` = 9  WHERE (`idConsumer` = 3);


insert into `sql10527490`.`Address` (`idAddress`,`street`,`number`, `city`, `state`, `postalCode`) VALUES ('10', 'Paulo Gustavo', '79', 'Campinas', 'SP', '13321654') ;
UPDATE `sql10527490`.`Consumer` SET `idAddress` = 10  WHERE (idConsumer = 2);


insert into `sql10527490`.`Address` (`idAddress`,`street`,`number`, `city`, `state`, `postalCode`) VALUES ('11', 'Orozimbo Maia', '525', 'Campinas', 'SP', '13698569') ;
UPDATE `sql10527490`.`Consumer` SET `idAddress` = 11  WHERE (idConsumer = 6);


UPDATE `sql10527490`.`Consumer` SET `idAddress` = 10  WHERE (idConsumer = 7);


SELECT * FROM sql10527490.Address
order by idAddress
;

SELECT distinct * FROM  sql10527490.Address as A
inner join  sql10527490.Consumer as B
where B.idAddress = A.idAddress
order by B.idAddress
;


SELECT distinct * FROM  sql10527490.Address as A
inner join  sql10527490.Supermarket as B
where B.idAddress = A.idAddress
ORDER BY B.idAddress
;


