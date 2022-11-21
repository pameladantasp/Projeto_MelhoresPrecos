SELECT 
    C.name 'Customer',
    S.name 'Supermarket',
    P.name 'Product',
    R.price 'Price',
    R.dateRegister 'Date Register'
FROM
    registerProduct R
        INNER JOIN
    supermarket S ON R.idSupermarket = S.idSupermarket
        INNER JOIN
    product P ON R.idProduct = P.idProduct
        INNER JOIN
    customer C ON R.idCustomer = C.idCustomer
WHERE
    C.idCustomer IN (SELECT idCustomer FROM
					(SELECT idCustomer FROM customer WHERE email = 'teste@gmail.com') 
					  AS CustomerIDRelatory)
ORDER BY R.dateRegister DESC

## Substituir o email = 'testeUser@gmail.com' para email = @email
