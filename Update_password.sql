
# ATUALIZAR SENHA (esqueci minha senha)

UPDATE customer SET password = MD5('abcd123')
WHERE idCustomer = (SELECT idCustomer FROM (SELECT idCustomer FROM customer
					WHERE email = 'teste@gmail.com') AS CustomerIDPassword)
;

# a query funciona, então para
# o código (eu acho que seria assim kkk mas vc analisa)
UPDATE customer SET password = MD5(@passowrd)
WHERE idCustomer = (SELECT idCustomer FROM (SELECT idCustomer FROM customer
					WHERE email = @email) AS CustomerIDPassword)