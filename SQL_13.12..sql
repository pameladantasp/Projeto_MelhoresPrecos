# Consultando o produto e sua respectiva categoria.
# ORDER BY category para facilitar a conferencia para ver se o produto é realmente daquela categoria

SELECT P.idProduct, P.name, C.type as category
FROM product AS P
	INNER JOIN
	category AS C ON P.category = C.idCategory
    ORDER BY category
;


# Consultando as informações de registros de produtos
SELECT
    cust.name AS customer,
    prod.name AS product,
    reg.price,
    sup.name AS supermarket,
    reg.dateRegister
FROM
    (((registerProduct AS reg
    INNER JOIN product AS prod ON prod.idProduct = reg.idProduct)
    INNER JOIN customer AS cust ON cust.idCustomer = reg.idCustomer)
    INNER JOIN supermarket AS sup ON sup.idSupermarket = reg.idSupermarket)
WHERE sup.name IN ('Tenda', 'dia')    # filtra por nomes de mercados
   
   # + opções de WHERE para usar:
# WHERE reg.idProduct LIKE 2           # filtra por produtos iguais
# WHERE prod.name LIKE 'shampoo%'        # filtra pelo produto que começa com a palavra 'Shampoo'
# WHERE prod.name IN ('Salame', 'Picanha', 'Guarana', 'Alcatra')

# WHERE cust.name IN ('Matheus Tosi')   # assim não funciona pq ele vai tentar buscar apenas por Matheus, ignorando o sobrenome Tosi na frente
# OU:
# WHERE cust.name LIKE 'Matheus%'


