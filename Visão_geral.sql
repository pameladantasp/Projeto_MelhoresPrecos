SELECT 
    RG.dateRegister 'Date Register',
    cust.name 'Customer',
    category.type 'Category',
    P.name 'Product',
    RG.Price,
    sup.name 'Supermarket',
    CONCAT(AddSup.street, ', ', AddSup.number) 'Address Supermarket',
    CONCAT(AddSup.city, ' - ', AddSup.state) 'City - State'
FROM
    registerProduct RG
        INNER JOIN
    customer cust ON cust.idCustomer = RG.idCustomer
        INNER JOIN
    supermarket sup ON RG.idSupermarket = sup.idSupermarket
        INNER JOIN
    product P ON P.idProduct = RG.idProduct
        INNER JOIN
    address AddSup ON AddSup.idAddress = sup.idAddress
        INNER JOIN
    category ON category.idCategory = P.category
WHERE
    RG.idRegister IS NOT NULL
       # AND cust.name = 'Maria'
ORDER BY RG.dateRegister DESC