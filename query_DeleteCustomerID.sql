DELETE FROM customer WHERE idCustomer = (SELECT idCustomer FROM (SELECT idCustomer FROM customer
									WHERE email = 'pamela@gmail.com') AS DeleteCustomerID)
;

# no código
DELETE FROM customer WHERE idCustomer = (SELECT idCustomer FROM (SELECT idCustomer FROM customer
									WHERE email = @email) AS DeleteCustomerID)
